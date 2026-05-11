using AppRRHH.Data;
using AppRRHH.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppRRHH.views.vistasAdmin
{
    public partial class UCConfiguracionAdmin : UserControl
    {
        public UCConfiguracionAdmin()
        {
            InitializeComponent();
            CargarEmpresa();


        }
        private void CargarEmpresa()
        {
            using (var db = new AppDbContext())
            {
                // Compruebo si existe una empresa en la bd
                var empresa = db.Empresas.FirstOrDefault();
                // Si existe, cargo sus datos en los campos de texto
                if (empresa != null)
                {
                    txtNombre.Text = empresa.Nombre;
                    txtCIF.Text = empresa.CIF;
                    txtDireccion.Text = empresa.Direccion;
                    txtMunicipio.Text = empresa.Municipio;
                    txtCodigoPostal.Text = empresa.CodigoPostal;
                    txtNumCuentaCotizacion.Text = empresa.NumCuentaCotizacion;
                }

                // cargo el cmbEmpleados con los empleados de la empresa
                var empleados = db.Empleados.ToList();
                cmbEmpleados.DataSource = empleados;
                cmbEmpleados.DisplayMember = "Nombre";

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // compruebo si los campos de nombre y cif estan vacíos 
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCIF.Text))
            {
                MessageBox.Show("El nombre y el CIF son obligatorios.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new AppDbContext())
            {
                var empresa = db.Empresas.FirstOrDefault();
                // si no existe una empresa, la creo, si ya existe, la edito con los nuevos datos
                if (empresa == null)
                {
                    // doy de alta la nueva empresa
                    empresa = new Empresa
                    {
                        Nombre = txtNombre.Text,
                        CIF = txtCIF.Text,
                        Direccion = txtDireccion.Text,
                        Municipio = txtMunicipio.Text,
                        CodigoPostal = txtCodigoPostal.Text,
                        NumCuentaCotizacion = txtNumCuentaCotizacion.Text
                    };
                    db.Empresas.Add(empresa);
                }
                else
                {
                    // Edito la empresa qeu ya existe
                    empresa.Nombre = txtNombre.Text;
                    empresa.CIF = txtCIF.Text;
                    empresa.Direccion = txtDireccion.Text;
                    empresa.Municipio = txtMunicipio.Text;
                    empresa.CodigoPostal = txtCodigoPostal.Text;
                    empresa.NumCuentaCotizacion = txtNumCuentaCotizacion.Text;
                }

                db.SaveChanges();
                MessageBox.Show("Datos de la empresa guardados correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnActualizarContrasena_Click(object sender, EventArgs e)
        {
            string nuevaContrasena = txtNuevaContrasena.Text.Trim();
            string nuevaContrasena2 = txtNuevaContrasena2.Text.Trim();

            // compruebo que las contraseñas no estén vacías
            if (string.IsNullOrEmpty(nuevaContrasena) || string.IsNullOrEmpty(nuevaContrasena2))
            {
                MessageBox.Show("Por favor, ingrese la nueva contraseña en ambos campos.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // compruebo que las contraseñas coincidan
            if (nuevaContrasena != nuevaContrasena2)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, inténtelo de nuevo.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // actualizo la contraseña del empleado seleccionado
            using (var db = new AppDbContext())
            {
                // obtengo el empleado seleccionado en el combo box
                var empleadoSeleccionado = cmbEmpleados.SelectedItem as Empleado;

                if (empleadoSeleccionado.Rol.Trim().ToLower() == "administrador")
                {
                    using (var ventanaSeguridad = new FormContrasenaSeguridad())
                    {
                        ventanaSeguridad.Text = "Confirmación necesaria.";

                        if (ventanaSeguridad.ShowDialog() != DialogResult.OK)
                        {
                            return;
                        }

                        // obtengo el usuario del empleado logueado para verificar su contraseña
                        var miUsuario = db.Usuarios.FirstOrDefault(u => u.EmpleadoId == Program.idEmpleadoLogueado);
                        if (miUsuario == null || !BCrypt.Net.BCrypt.Verify(ventanaSeguridad.contrasenaPrivada, miUsuario.Contrasena))
                        {
                            MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                // obtengo el usuario del empleado seleccionado para actualizar su contraseña
                var usuario = db.Usuarios.FirstOrDefault(u => u.EmpleadoId == empleadoSeleccionado.Id);
                if (usuario != null)
                {
                    // actualizo la contraseña del usuario con la nueva contraseña hasheada
                    usuario.Contrasena = BCrypt.Net.BCrypt.HashPassword(nuevaContrasena);
                    // marco que el usuario SI necesita cambiar la contraseña en el próximo inicio de sesión
                    usuario.CambiarContrasena = false;
                    // guardo los cambios en la base de datos
                    db.SaveChanges();

                    MessageBox.Show("Contraseña de " + empleadoSeleccionado.Nombre + " actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNuevaContrasena.Clear();
                    txtNuevaContrasena2.Clear();
                }

            }
        }
    }
}

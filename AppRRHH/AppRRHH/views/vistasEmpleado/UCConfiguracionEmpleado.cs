using AppRRHH.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppRRHH.views.vistasEmpleado
{
    public partial class UCConfiguracionEmpleado : UserControl
    {
        public UCConfiguracionEmpleado()
        {
            InitializeComponent();

            CargarDatos();
        }

        private void CargarDatos()
        {
            using (var db = new AppDbContext())
            {
                var idEmpleado = db.Empleados.Find(Program.idEmpleadoLogueado);

                if (idEmpleado != null)
                {
                    // pongo sus datos en los textbox
                    // lblNombre.Text = idEmpleado.Nombre;
                    txtEmail.Text = idEmpleado.Email;
                    txtTelefono.Text = idEmpleado.Telefono;
                }
            }
        }

        private void btnCambiarContrasena_Click(object sender, EventArgs e)
        {
            FormCambiarContrasena formCambiar = new FormCambiarContrasena();

            // el formulario tenga la x para cerrarlo, pero que no se pueda redimensionar ni minimizar ni maximzar
            formCambiar.FormBorderStyle = FormBorderStyle.FixedDialog;
            formCambiar.MaximizeBox = false;
            formCambiar.MinimizeBox = false;
            formCambiar.ControlBox = true;

            formCambiar.ShowDialog();
        }

        private void btnContactar_Click(object sender, EventArgs e)
        {
            // abre el correo del PC con el asunto ya escrito
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                // correo al admin
                FileName = "mailto:admin@rrhh.com?subject=Duda%20del%20empleado",
                UseShellExecute = true
            });
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // miro si el email o el telefono estan vacios
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("El email y el teléfono no pueden estar vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var db = new AppDbContext())
            {
                var idEmpleado = db.Empleados.Find(Program.idEmpleadoLogueado);
                if (idEmpleado != null)
                {
                    idEmpleado.Email = txtEmail.Text;
                    idEmpleado.Telefono = txtTelefono.Text;
                    db.SaveChanges();
                    MessageBox.Show("Datos actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

using AppRRHH.Data;
using AppRRHH.views.Empleado;
using AppRRHH.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppRRHH.views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            // Maximizo la ventana al abrirla
            this.WindowState = FormWindowState.Maximized;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Acceder a los controles directamente por sus campos generados por el diseñador
            var txtEmailControl = this.txtEmail; 
            var txtPasswordControl = this.txtPassword; 
            var lblErrorControl = this.lblError;

            // Validar que los controles existan
            string email = txtEmailControl.Text.Trim();
            string password = txtPasswordControl.Text.Trim();

            // Validar que no estén vacíos
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                lblErrorControl.Text = "Por favor, ingrese email y contraseña.";
                return;
            }

            
            using (var db = new AppDbContext())
            {
                // Buscar el usuario en la base de datos
                var usuario = db.Usuarios
                    .Include(u => u.Empleado)
                    .FirstOrDefault(u => u.Email == email && u.Contrasena == password);

                // Validar si se encontró el usuario
                if (usuario == null)
                {
                    lblErrorControl.Text = "Email o contraseña incorrectos.";
                    return;
                }

                // Redirigir según rol
                if (usuario.Rol == "Administrador")
                {
                    // Guardo el ID del empleado que ha iniciado sesión
                    Program.idEmpleadoLogueado = usuario.Empleado.Id;

                    // Abro FormPrincipalAdmin
                    FormAdmin formAdmin = new FormAdmin();
                    formAdmin.Show();
                    this.Hide();
                }
                else
                {
                    // Guardo el ID del empleado que ha iniciado sesión
                    Program.idEmpleadoLogueado = usuario.Empleado.Id;

                    // Abro FormPrincipalEmpleado
                    FormEmpleado formEmpleado = new FormEmpleado();
                    formEmpleado.Show();
                    this.Hide();
                }

                this.Hide();

            }
        }



    }
}

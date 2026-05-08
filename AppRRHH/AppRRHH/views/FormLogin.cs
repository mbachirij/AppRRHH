using AppRRHH.Data;
using AppRRHH.views.vistasAdmin;
using AppRRHH.views.vistasEmpleado;
using Microsoft.EntityFrameworkCore;

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
                // busco el usuario en la base de datos
                var usuario = db.Usuarios
                    .Include(u => u.Empleado)
                    .FirstOrDefault(u => u.Email == email);

                // verifico si se existe y la contraseña es correcta
                if (usuario == null || !BCrypt.Net.BCrypt.Verify(password, usuario.Contrasena))
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

                    // Compruebo si tiene que cambiar la contraseña
                    if (!usuario.CambiarContrasena)
                    {
                        MessageBox.Show("Por seguridad tienes que cambiar tu contraseña al entrar por primera vez.",
                            "Cambio de contraseña requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        FormCambiarContrasena frmCambio = new FormCambiarContrasena();
                        frmCambio.ShowDialog();
                    }
                }
                else
                {
                    // Guardo el ID del empleado que ha iniciado sesión
                    Program.idEmpleadoLogueado = usuario.Empleado.Id;

                    // Abro FormPrincipalEmpleado
                    FormEmpleado formEmpleado = new FormEmpleado();
                    formEmpleado.Show();
                    this.Hide();

                    // Compruebo si tiene que cambiar la contraseña
                    if (!usuario.CambiarContrasena)
                    {
                        MessageBox.Show("Por seguridad tienes que cambiar tu contraseña al entrar por primera vez.",
                            "Cambio de contraseña requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        FormCambiarContrasena frmCambio = new FormCambiarContrasena();
                        frmCambio.ShowDialog();
                    }
                }

                this.Hide();

            }
        }



    }
}

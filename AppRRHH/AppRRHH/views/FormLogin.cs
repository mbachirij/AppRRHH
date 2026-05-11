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
            this.AcceptButton = button1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // guardo en variables los controles para no tener que escribir this.txtEmail cada vez
            var txtEmailControl = this.txtEmail;
            var txtPasswordControl = this.txtPassword;
            var lblErrorControl = this.lblError;

            // para ver que existen y no son null
            string email = txtEmailControl.Text.Trim();
            string password = txtPasswordControl.Text.Trim();

            // miro que no estén vacíos
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

                // Redirijo a la vista correspondiente según el rol del usuario
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

        private void lblContrasenaOlvidada_Click(object sender, EventArgs e)
        {
            // abre el correo del PC con el asunto ya escrito
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                // correo al admin
                FileName = "mailto:admin@rrhh.com?subject=He%20olvidado%20mi%20contrasena",
                UseShellExecute = true
            });
        }
    }
}

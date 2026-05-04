using AppRRHH.views;
using AppRRHH.views.vistasAdmin;
using AppRRHH.views.vistasEmpleado;

namespace AppRRHH
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();

            panelSidebar.BackColor = Color.FromArgb(35, 35, 55);
            panelContenido.BackColor = Color.FromArgb(25, 25, 40);
            
            UCInicioAdmin home = new UCInicioAdmin();
            panelContenido.Controls.Add(home);
            home.Dock = DockStyle.Fill;

            // Maximizo la ventana al abrirla
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            // Borro lo que hay en el panel
            panelContenido.Controls.Clear();
            UCEmpleados vista = new UCEmpleados();
            panelContenido.Controls.Add(vista);
            vista.Dock = DockStyle.Fill;

        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();
            UCDepartamentosAdmin dep = new UCDepartamentosAdmin();
            panelContenido.Controls.Add(dep);
            dep.Dock = DockStyle.Fill;
        }

        private void btnNominas_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();
            UCNominasAdmin nom = new UCNominasAdmin();
            panelContenido.Controls.Add(nom);
            nom.Dock = DockStyle.Fill;
        }

        private void btnVacaciones_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();
            UCVacacionesAdmin vac = new UCVacacionesAdmin();
            panelContenido.Controls.Add(vac);
            vac.Dock = DockStyle.Fill;
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();
            UCConfiguracionAdmin config = new UCConfiguracionAdmin();
            panelContenido.Controls.Add(config);
            config.Dock = DockStyle.Fill;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();
            UCInicioAdmin home = new UCInicioAdmin();
            panelContenido.Controls.Add(home);
            home.Dock = DockStyle.Fill;
            
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Cierro la sesión y vuelvo al login
            this.Hide();
            FormLogin login = new FormLogin();
            login.ShowDialog();
        }
    }
}

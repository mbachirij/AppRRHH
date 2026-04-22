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
            panelTitulo.BackColor = Color.FromArgb(35, 35, 40);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "GESTIÓN DE EMPLEADOS";

            // Borro lo que hay en el panel
            panelContenido.Controls.Clear();

            UCEmpleados vista = new UCEmpleados();

            panelContenido.Controls.Add(vista);

            vista.Dock = DockStyle.Fill;

        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Gestión de Departamentos";

            panelContenido.Controls.Clear();
            UCDepartamentosAdmin dep = new UCDepartamentosAdmin();
            panelContenido.Controls.Add(dep);
            dep.Dock = DockStyle.Fill;
        }

        private void btnNominas_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "NÓMINAS Y PAGOS";
        }

        private void btnVacaciones_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Gestión de Vacaciones";
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Gestión de Informes";
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Configuración de la Aplicación";
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Bienvenido al Sistema de Gestión de Recursos Humanos";
            /*
            panelContenido.Controls.Clear();
            UCInicioEmpleado home = new UCInicioEmpleado();
            panelContenido.Controls.Add(home);
            home.Dock = DockStyle.Fill;
            */
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

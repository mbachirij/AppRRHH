using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AppRRHH.views.vistasEmpleado;

namespace AppRRHH.views.Empleado
{
    public partial class FormEmpleado : Form
    {
        public FormEmpleado()
        {
            InitializeComponent();

            panelSidebar.BackColor = Color.FromArgb(35, 35, 55);
            panelContenido.BackColor = Color.FromArgb(25, 25, 40);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            UCInicioEmpleado vista = new UCInicioEmpleado();

            panelContenido.Controls.Add(vista);

            vista.Dock = DockStyle.Fill;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Cierro la sesión y vuelvo al login
            this.Hide();
            FormLogin login = new FormLogin();
            login.ShowDialog();
        }

        private void btnYo_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            UCEmpleadoFichajes fichajes = new UCEmpleadoFichajes();

            panelContenido.Controls.Add(fichajes);

            fichajes.Dock = DockStyle.Fill;
        }
    }
}

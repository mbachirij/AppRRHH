using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppRRHH.views
{

    public partial class FormContrasenaSeguridad : Form
    {
        public string contrasenaPrivada = "";
        public FormContrasenaSeguridad()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // guardo lo que hay en el texto en la variable
            contrasenaPrivada = txtContrasena.Text;

            // cierro diciendo que todo ha ido bien
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

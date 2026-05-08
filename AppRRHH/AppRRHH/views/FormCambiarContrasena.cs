using AppRRHH.Data;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppRRHH.views
{
    public partial class FormCambiarContrasena : Form
    {
        public FormCambiarContrasena()
        {
            InitializeComponent();
            // al presionar Enter se pulsa el botón Cambiar
            this.AcceptButton = btnCambiar; 
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            string antigua = txtAntigua.Text.Trim();
            string nueva = txtNueva.Text.Trim();
            string nueva2 = txtNueva2.Text.Trim();

            if(string.IsNullOrEmpty(antigua) || string.IsNullOrEmpty(nueva) || string.IsNullOrEmpty(nueva2))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nueva != nueva2)
            {
                MessageBox.Show("Las nuevas contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nueva == antigua)
            {
                MessageBox.Show("La nueva contraseña no puede ser igual a la antigua.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using(var db = new AppDbContext())
            {
                var usuario = db.Usuarios.FirstOrDefault(u => u.EmpleadoId == Program.idEmpleadoLogueado);
    
                if (usuario == null)
                {
                    MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
    
                if (!BCrypt.Net.BCrypt.Verify(antigua, usuario.Contrasena))
                {
                    MessageBox.Show("La contraseña antigua es incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
    
                // Actualizo la contraseña del usuario
                usuario.Contrasena = BCrypt.Net.BCrypt.HashPassword(nueva);
                usuario.CambiarContrasena = true; // ya no necesita cambiar la contraseña al entrar
                db.SaveChanges();
    
                MessageBox.Show("Contraseña cambiada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private void txtAntigua_TrailingIconClick(object sender, EventArgs e)
        {
            // Esto alterna entre mostrar los puntos y mostrar las letras
            txtAntigua.UseSystemPasswordChar = !txtAntigua.UseSystemPasswordChar;
        }
        private void txtNueva_TrailingIconClick(object sender, EventArgs e)
        {
            // Esto alterna entre mostrar los puntos y mostrar las letras
            txtNueva.UseSystemPasswordChar = !txtNueva.UseSystemPasswordChar;
        }
        private void txtNueva2_TrailingIconClick(object sender, EventArgs e)
        {
            // Esto alterna entre mostrar los puntos y mostrar las letras
            txtNueva2.UseSystemPasswordChar = !txtNueva2.UseSystemPasswordChar;
        }
    }
}

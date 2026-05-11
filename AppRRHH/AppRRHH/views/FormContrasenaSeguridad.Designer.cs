namespace AppRRHH.views
{
    partial class FormContrasenaSeguridad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContrasenaSeguridad));
            txtContrasena = new MaterialSkin.Controls.MaterialTextBox2();
            label3 = new Label();
            label1 = new Label();
            lblAviso = new Label();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // txtContrasena
            // 
            txtContrasena.AnimateReadOnly = false;
            txtContrasena.BackgroundImageLayout = ImageLayout.None;
            txtContrasena.CharacterCasing = CharacterCasing.Normal;
            txtContrasena.Depth = 0;
            txtContrasena.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtContrasena.HideSelection = true;
            txtContrasena.LeadingIcon = null;
            txtContrasena.Location = new Point(12, 184);
            txtContrasena.MaxLength = 32767;
            txtContrasena.MouseState = MaterialSkin.MouseState.OUT;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '●';
            txtContrasena.PrefixSuffixText = null;
            txtContrasena.ReadOnly = false;
            txtContrasena.RightToLeft = RightToLeft.No;
            txtContrasena.SelectedText = "";
            txtContrasena.SelectionLength = 0;
            txtContrasena.SelectionStart = 0;
            txtContrasena.ShortcutsEnabled = true;
            txtContrasena.Size = new Size(346, 48);
            txtContrasena.TabIndex = 1;
            txtContrasena.TabStop = false;
            txtContrasena.TextAlign = HorizontalAlignment.Left;
            txtContrasena.TrailingIcon = (Image)resources.GetObject("txtContrasena.TrailingIcon");
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 166);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 8;
            label3.Text = "Tu Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(224, 30);
            label1.TabIndex = 10;
            label1.Text = "Confirmar Identidad";
            // 
            // lblAviso
            // 
            lblAviso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAviso.ForeColor = Color.Gray;
            lblAviso.Location = new Point(12, 70);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(346, 53);
            lblAviso.TabIndex = 9;
            lblAviso.Text = "Debes introducir contraseña de administrador para continuar.";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(212, 18, 142);
            btnConfirmar.Cursor = Cursors.Hand;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(73, 298);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(227, 47);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // FormContrasenaSeguridad
            // 
            AcceptButton = btnConfirmar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 389);
            Controls.Add(btnConfirmar);
            Controls.Add(label1);
            Controls.Add(lblAviso);
            Controls.Add(txtContrasena);
            Controls.Add(label3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormContrasenaSeguridad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Verificación Seguridad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtContrasena;
        private Label label3;
        private Label label1;
        private Label lblAviso;
        private Button btnConfirmar;
    }
}
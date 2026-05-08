namespace AppRRHH.views
{
    partial class FormCambiarContrasena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCambiarContrasena));
            lblAviso = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCambiar = new Button();
            txtAntigua = new MaterialSkin.Controls.MaterialTextBox2();
            txtNueva = new MaterialSkin.Controls.MaterialTextBox2();
            txtNueva2 = new MaterialSkin.Controls.MaterialTextBox2();
            SuspendLayout();
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAviso.ForeColor = Color.Gray;
            lblAviso.Location = new Point(21, 55);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(346, 21);
            lblAviso.TabIndex = 0;
            lblAviso.Text = "Debes cambiar tu contraseña antes de continuar.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(246, 30);
            label1.TabIndex = 4;
            label1.Text = "Cambia de Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 88);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 5;
            label2.Text = "Contraseña antigua:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 170);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 6;
            label3.Text = "Contraseña nueva:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 251);
            label4.Name = "label4";
            label4.Size = new Size(139, 15);
            label4.TabIndex = 7;
            label4.Text = "Repite contraseña nueva:";
            // 
            // btnCambiar
            // 
            btnCambiar.BackColor = Color.FromArgb(212, 18, 142);
            btnCambiar.Cursor = Cursors.Hand;
            btnCambiar.FlatAppearance.BorderSize = 0;
            btnCambiar.FlatStyle = FlatStyle.Flat;
            btnCambiar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCambiar.ForeColor = Color.White;
            btnCambiar.Location = new Point(78, 352);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(227, 47);
            btnCambiar.TabIndex = 4;
            btnCambiar.Text = "CAMBIAR CONTRASEÑA";
            btnCambiar.UseVisualStyleBackColor = false;
            btnCambiar.Click += btnCambiar_Click;
            // 
            // txtAntigua
            // 
            txtAntigua.AnimateReadOnly = false;
            txtAntigua.BackgroundImageLayout = ImageLayout.None;
            txtAntigua.CharacterCasing = CharacterCasing.Normal;
            txtAntigua.Depth = 0;
            txtAntigua.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAntigua.HideSelection = true;
            txtAntigua.LeadingIcon = null;
            txtAntigua.Location = new Point(21, 106);
            txtAntigua.MaxLength = 32767;
            txtAntigua.MouseState = MaterialSkin.MouseState.OUT;
            txtAntigua.Name = "txtAntigua";
            txtAntigua.PasswordChar = '●';
            txtAntigua.PrefixSuffixText = null;
            txtAntigua.ReadOnly = false;
            txtAntigua.RightToLeft = RightToLeft.No;
            txtAntigua.SelectedText = "";
            txtAntigua.SelectionLength = 0;
            txtAntigua.SelectionStart = 0;
            txtAntigua.ShortcutsEnabled = true;
            txtAntigua.Size = new Size(346, 48);
            txtAntigua.TabIndex = 1;
            txtAntigua.TabStop = false;
            txtAntigua.Text = "materialTextBox21";
            txtAntigua.TextAlign = HorizontalAlignment.Left;
            txtAntigua.TrailingIcon = (Image)resources.GetObject("txtAntigua.TrailingIcon");
            txtAntigua.UseSystemPasswordChar = true;
            txtAntigua.TrailingIconClick += txtAntigua_TrailingIconClick;
            // 
            // txtNueva
            // 
            txtNueva.AnimateReadOnly = false;
            txtNueva.BackgroundImageLayout = ImageLayout.None;
            txtNueva.CharacterCasing = CharacterCasing.Normal;
            txtNueva.Depth = 0;
            txtNueva.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNueva.HideSelection = true;
            txtNueva.LeadingIcon = null;
            txtNueva.Location = new Point(21, 188);
            txtNueva.MaxLength = 32767;
            txtNueva.MouseState = MaterialSkin.MouseState.OUT;
            txtNueva.Name = "txtNueva";
            txtNueva.PasswordChar = '●';
            txtNueva.PrefixSuffixText = null;
            txtNueva.ReadOnly = false;
            txtNueva.RightToLeft = RightToLeft.No;
            txtNueva.SelectedText = "";
            txtNueva.SelectionLength = 0;
            txtNueva.SelectionStart = 0;
            txtNueva.ShortcutsEnabled = true;
            txtNueva.Size = new Size(346, 48);
            txtNueva.TabIndex = 2;
            txtNueva.TabStop = false;
            txtNueva.Text = "materialTextBox22";
            txtNueva.TextAlign = HorizontalAlignment.Left;
            txtNueva.TrailingIcon = (Image)resources.GetObject("txtNueva.TrailingIcon");
            txtNueva.UseSystemPasswordChar = true;
            txtNueva.TrailingIconClick += txtNueva_TrailingIconClick;
            // 
            // txtNueva2
            // 
            txtNueva2.AnimateReadOnly = false;
            txtNueva2.BackgroundImageLayout = ImageLayout.None;
            txtNueva2.CharacterCasing = CharacterCasing.Normal;
            txtNueva2.Depth = 0;
            txtNueva2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNueva2.HideSelection = true;
            txtNueva2.LeadingIcon = null;
            txtNueva2.Location = new Point(21, 269);
            txtNueva2.MaxLength = 32767;
            txtNueva2.MouseState = MaterialSkin.MouseState.OUT;
            txtNueva2.Name = "txtNueva2";
            txtNueva2.PasswordChar = '●';
            txtNueva2.PrefixSuffixText = null;
            txtNueva2.ReadOnly = false;
            txtNueva2.RightToLeft = RightToLeft.No;
            txtNueva2.SelectedText = "";
            txtNueva2.SelectionLength = 0;
            txtNueva2.SelectionStart = 0;
            txtNueva2.ShortcutsEnabled = true;
            txtNueva2.Size = new Size(346, 48);
            txtNueva2.TabIndex = 3;
            txtNueva2.TabStop = false;
            txtNueva2.Text = "materialTextBox23";
            txtNueva2.TextAlign = HorizontalAlignment.Left;
            txtNueva2.TrailingIcon = (Image)resources.GetObject("txtNueva2.TrailingIcon");
            txtNueva2.UseSystemPasswordChar = true;
            txtNueva2.TrailingIconClick += txtNueva2_TrailingIconClick;
            // 
            // FormCambiarContrasena
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(404, 422);
            ControlBox = false;
            Controls.Add(txtNueva2);
            Controls.Add(txtNueva);
            Controls.Add(txtAntigua);
            Controls.Add(btnCambiar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblAviso);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCambiarContrasena";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAviso;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCambiar;
        private MaterialSkin.Controls.MaterialTextBox2 txtAntigua;
        private MaterialSkin.Controls.MaterialTextBox2 txtNueva;
        private MaterialSkin.Controls.MaterialTextBox2 txtNueva2;
    }
}
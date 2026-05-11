namespace AppRRHH.views
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            lblError = new Label();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            lblContrasenaOlvidada = new Label();
            pictureLogo = new PictureBox();
            button1 = new Button();
            lblSubTitulo = new Label();
            txtPassword = new MaterialSkin.Controls.MaterialTextBox2();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            panel1 = new Panel();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblError
            // 
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(40, 294);
            lblError.Name = "lblError";
            lblError.Size = new Size(351, 31);
            lblError.TabIndex = 2;
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(lblContrasenaOlvidada);
            materialCard1.Controls.Add(pictureLogo);
            materialCard1.Controls.Add(button1);
            materialCard1.Controls.Add(lblSubTitulo);
            materialCard1.Controls.Add(lblError);
            materialCard1.Controls.Add(txtPassword);
            materialCard1.Controls.Add(txtEmail);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(404, 81);
            materialCard1.Margin = new Padding(12, 10, 12, 10);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(12, 10, 12, 10);
            materialCard1.Size = new Size(431, 439);
            materialCard1.TabIndex = 1;
            // 
            // lblContrasenaOlvidada
            // 
            lblContrasenaOlvidada.ForeColor = Color.Blue;
            lblContrasenaOlvidada.Location = new Point(40, 391);
            lblContrasenaOlvidada.Name = "lblContrasenaOlvidada";
            lblContrasenaOlvidada.Size = new Size(351, 31);
            lblContrasenaOlvidada.TabIndex = 5;
            lblContrasenaOlvidada.Text = "He olvidado mi contraseña";
            lblContrasenaOlvidada.TextAlign = ContentAlignment.MiddleCenter;
            lblContrasenaOlvidada.Click += lblContrasenaOlvidada_Click;
            // 
            // pictureLogo
            // 
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(0, 0);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(431, 138);
            pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogo.TabIndex = 4;
            pictureLogo.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(212, 18, 142);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(40, 341);
            button1.Name = "button1";
            button1.Size = new Size(351, 47);
            button1.TabIndex = 3;
            button1.Text = "INICIAR SESIÓN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // lblSubTitulo
            // 
            lblSubTitulo.BackColor = Color.Transparent;
            lblSubTitulo.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubTitulo.ForeColor = Color.FromArgb(88, 101, 242);
            lblSubTitulo.Location = new Point(0, 123);
            lblSubTitulo.Name = "lblSubTitulo";
            lblSubTitulo.Size = new Size(431, 65);
            lblSubTitulo.TabIndex = 3;
            lblSubTitulo.Text = "INICIAR SESIÓN";
            lblSubTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.AnimateReadOnly = false;
            txtPassword.BackgroundImageLayout = ImageLayout.None;
            txtPassword.CharacterCasing = CharacterCasing.Normal;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.HideSelection = true;
            txtPassword.Hint = "Password";
            txtPassword.LeadingIcon = (Image)resources.GetObject("txtPassword.LeadingIcon");
            txtPassword.Location = new Point(40, 244);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.MaxLength = 32767;
            txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PrefixSuffixText = null;
            txtPassword.ReadOnly = false;
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.ShortcutsEnabled = true;
            txtPassword.Size = new Size(351, 48);
            txtPassword.TabIndex = 2;
            txtPassword.TabStop = false;
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.TrailingIcon = null;
            txtPassword.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F);
            txtEmail.Hint = "Email";
            txtEmail.LeadingIcon = (Image)resources.GetObject("txtEmail.LeadingIcon");
            txtEmail.Location = new Point(40, 190);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.MaxLength = 50;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(351, 50);
            txtEmail.TabIndex = 1;
            txtEmail.Text = "admin@rrhh.com";
            txtEmail.TrailingIcon = null;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(materialCard1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1242, 571);
            panel1.TabIndex = 2;
            // 
            // FormLogin
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1266, 595);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AppRRHH - Login";
            materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 txtPassword;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard card2;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private Panel panel1;
        private Label lblSubTitulo;
        private Button button1;
        private PictureBox pictureLogo;
        private Label lblContrasenaOlvidada;
    }
}
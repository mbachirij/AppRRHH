namespace AppRRHH.views.vistasEmpleado
{
    partial class UCConfiguracionEmpleado
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            label2 = new Label();
            btnCambiarContrasena = new Button();
            label1 = new Label();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            btnContactar = new Button();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            btnModificar = new Button();
            txtTelefono = new MaterialSkin.Controls.MaterialTextBox2();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox2();
            label7 = new Label();
            panelCentrado = new Panel();
            label4 = new Label();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard3.SuspendLayout();
            panelCentrado.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(label2);
            materialCard1.Controls.Add(btnCambiarContrasena);
            materialCard1.Controls.Add(label1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(457, 184);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(456, 141);
            materialCard1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 85);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 2;
            label2.Text = "* Cambiar contraseña";
            // 
            // btnCambiarContrasena
            // 
            btnCambiarContrasena.BackColor = Color.FromArgb(212, 18, 142);
            btnCambiarContrasena.FlatStyle = FlatStyle.Flat;
            btnCambiarContrasena.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCambiarContrasena.ForeColor = Color.White;
            btnCambiarContrasena.Location = new Point(280, 72);
            btnCambiarContrasena.Name = "btnCambiarContrasena";
            btnCambiarContrasena.Size = new Size(159, 41);
            btnCambiarContrasena.TabIndex = 1;
            btnCambiarContrasena.Text = "CAMBIAR";
            btnCambiarContrasena.UseVisualStyleBackColor = false;
            btnCambiarContrasena.Click += btnCambiarContrasena_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 14);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "Seguridad Y Acceso";
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(btnContactar);
            materialCard2.Controls.Add(label6);
            materialCard2.Controls.Add(label5);
            materialCard2.Controls.Add(label3);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(457, 353);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(456, 145);
            materialCard2.TabIndex = 1;
            // 
            // btnContactar
            // 
            btnContactar.BackColor = Color.FromArgb(212, 18, 142);
            btnContactar.FlatStyle = FlatStyle.Flat;
            btnContactar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContactar.ForeColor = Color.White;
            btnContactar.Location = new Point(280, 76);
            btnContactar.Name = "btnContactar";
            btnContactar.Size = new Size(159, 41);
            btnContactar.TabIndex = 2;
            btnContactar.Text = "CONTACTAR";
            btnContactar.UseVisualStyleBackColor = false;
            btnContactar.Click += btnContactar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 105);
            label6.Name = "label6";
            label6.Size = new Size(219, 15);
            label6.TabIndex = 3;
            label6.Text = "Contacta con el departamento de RRHH";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 61);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 2;
            label5.Text = "¿Tienes alguna duda?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 14);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 1;
            label3.Text = "Soporte";
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(btnModificar);
            materialCard3.Controls.Add(txtTelefono);
            materialCard3.Controls.Add(txtEmail);
            materialCard3.Controls.Add(label7);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(457, 526);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(456, 168);
            materialCard3.TabIndex = 2;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(212, 18, 142);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(280, 110);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(159, 41);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "GUARDAR CAMBIOS";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.AnimateReadOnly = false;
            txtTelefono.BackgroundImageLayout = ImageLayout.None;
            txtTelefono.CharacterCasing = CharacterCasing.Normal;
            txtTelefono.Depth = 0;
            txtTelefono.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefono.HideSelection = true;
            txtTelefono.Hint = "Teléfono";
            txtTelefono.LeadingIcon = null;
            txtTelefono.Location = new Point(35, 103);
            txtTelefono.MaxLength = 32767;
            txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PasswordChar = '\0';
            txtTelefono.PrefixSuffixText = null;
            txtTelefono.ReadOnly = false;
            txtTelefono.RightToLeft = RightToLeft.No;
            txtTelefono.SelectedText = "";
            txtTelefono.SelectionLength = 0;
            txtTelefono.SelectionStart = 0;
            txtTelefono.ShortcutsEnabled = true;
            txtTelefono.Size = new Size(228, 48);
            txtTelefono.TabIndex = 4;
            txtTelefono.TabStop = false;
            txtTelefono.TextAlign = HorizontalAlignment.Left;
            txtTelefono.TrailingIcon = null;
            txtTelefono.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.Hint = "Email";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(35, 49);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.ReadOnly = false;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(228, 48);
            txtEmail.TabIndex = 3;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 14);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 0;
            label7.Text = "Mis Datos";
            // 
            // panelCentrado
            // 
            panelCentrado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCentrado.AutoScroll = true;
            panelCentrado.BackColor = Color.Transparent;
            panelCentrado.Controls.Add(label4);
            panelCentrado.Controls.Add(materialCard1);
            panelCentrado.Controls.Add(materialCard3);
            panelCentrado.Controls.Add(materialCard2);
            panelCentrado.Location = new Point(0, 10);
            panelCentrado.Name = "panelCentrado";
            panelCentrado.Size = new Size(1411, 962);
            panelCentrado.TabIndex = 3;
            // 
            // label4
            // 
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(30, 41, 59);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(1411, 85);
            label4.TabIndex = 8;
            label4.Text = "Configuración";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UCConfiguracionEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(248, 250, 252);
            Controls.Add(panelCentrado);
            Name = "UCConfiguracionEmpleado";
            Padding = new Padding(20);
            Size = new Size(1411, 1008);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            panelCentrado.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Label label2;
        private Button btnCambiarContrasena;
        private Label label1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Button btnContactar;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialTextBox2 txtTelefono;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmail;
        private Label label7;
        private Button btnModificar;
        private Panel panelCentrado;
        private Label label4;
    }
}

namespace AppRRHH.views.vistasEmpleado
{
    partial class FormEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleado));
            panelSidebar = new Panel();
            pictureBox1 = new PictureBox();
            panelContenido = new Panel();
            btnInicio = new Button();
            this.btnFichar = new Button();
            btnNominas = new Button();
            btnVacaciones = new Button();
            btnConfiguracion = new Button();
            btnCerrarSesion = new Button();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(30, 41, 59);
            panelSidebar.Controls.Add(btnInicio);
            panelSidebar.Controls.Add(btnCerrarSesion);
            panelSidebar.Controls.Add(pictureBox1);
            panelSidebar.Controls.Add(btnConfiguracion);
            panelSidebar.Controls.Add(btnVacaciones);
            panelSidebar.Controls.Add(this.btnFichar);
            panelSidebar.Controls.Add(btnNominas);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(3, 2, 3, 2);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(208, 570);
            panelSidebar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.SeaShell;
            panelContenido.BackgroundImageLayout = ImageLayout.Stretch;
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(208, 0);
            panelContenido.Margin = new Padding(3, 2, 3, 2);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(845, 570);
            panelContenido.TabIndex = 1;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.Transparent;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.FromArgb(241, 245, 249);
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(11, 178);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(185, 36);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "MI PERFIL";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnFichar
            // 
            this.btnFichar.BackColor = Color.Transparent;
            this.btnFichar.FlatAppearance.BorderSize = 0;
            this.btnFichar.FlatStyle = FlatStyle.Flat;
            this.btnFichar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnFichar.ForeColor = Color.FromArgb(241, 245, 249);
            this.btnFichar.Image = (Image)resources.GetObject("btnFichar.Image");
            this.btnFichar.ImageAlign = ContentAlignment.MiddleLeft;
            this.btnFichar.Location = new Point(11, 220);
            this.btnFichar.Name = "btnFichar";
            this.btnFichar.Size = new Size(185, 36);
            this.btnFichar.TabIndex = 3;
            this.btnFichar.Text = "FICHAR";
            this.btnFichar.UseVisualStyleBackColor = false;
            this.btnFichar.Click += this.btnYo_Click;
            // 
            // btnNominas
            // 
            btnNominas.BackColor = Color.Transparent;
            btnNominas.FlatAppearance.BorderSize = 0;
            btnNominas.FlatStyle = FlatStyle.Flat;
            btnNominas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNominas.ForeColor = Color.FromArgb(241, 245, 249);
            btnNominas.Image = (Image)resources.GetObject("btnNominas.Image");
            btnNominas.ImageAlign = ContentAlignment.MiddleLeft;
            btnNominas.Location = new Point(11, 264);
            btnNominas.Name = "btnNominas";
            btnNominas.Size = new Size(185, 36);
            btnNominas.TabIndex = 5;
            btnNominas.Text = "NÓMINAS";
            btnNominas.UseVisualStyleBackColor = false;
            btnNominas.Click += btnNominas_Click;
            // 
            // btnVacaciones
            // 
            btnVacaciones.BackColor = Color.Transparent;
            btnVacaciones.FlatAppearance.BorderSize = 0;
            btnVacaciones.FlatStyle = FlatStyle.Flat;
            btnVacaciones.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVacaciones.ForeColor = Color.FromArgb(241, 245, 249);
            btnVacaciones.Image = (Image)resources.GetObject("btnVacaciones.Image");
            btnVacaciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnVacaciones.Location = new Point(11, 308);
            btnVacaciones.Name = "btnVacaciones";
            btnVacaciones.Size = new Size(185, 36);
            btnVacaciones.TabIndex = 6;
            btnVacaciones.Text = "VACACIONES";
            btnVacaciones.UseVisualStyleBackColor = false;
            btnVacaciones.Click += btnVacaciones_Click;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.BackColor = Color.Transparent;
            btnConfiguracion.FlatAppearance.BorderSize = 0;
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfiguracion.ForeColor = Color.FromArgb(241, 245, 249);
            btnConfiguracion.Image = (Image)resources.GetObject("btnConfiguracion.Image");
            btnConfiguracion.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfiguracion.Location = new Point(11, 352);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(185, 36);
            btnConfiguracion.TabIndex = 7;
            btnConfiguracion.Text = "CONFIGURACIÓN";
            btnConfiguracion.UseVisualStyleBackColor = false;
            btnConfiguracion.Click += this.btnConfiguracion_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Transparent;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.FromArgb(241, 245, 249);
            btnCerrarSesion.Image = (Image)resources.GetObject("btnCerrarSesion.Image");
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(11, 513);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(185, 36);
            btnCerrarSesion.TabIndex = 8;
            btnCerrarSesion.Text = "CERRAR SESIÓN";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += this.btnCerrarSesion_Click;
            // 
            // FormEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 570);
            Controls.Add(panelContenido);
            Controls.Add(panelSidebar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1000, 500);
            Name = "FormEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pantalla de Inicio - Empleado";
            panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Panel panelContenido;
        private PictureBox pictureBox1;
        private Button btnInicio;
        private Button btnFichar;
        private Button btnYo;
        private Button btnNominas;
        private Button btnConfiguracion;
        private Button btnCerrarSesion;
        private Button btnVacaciones;
    }
}
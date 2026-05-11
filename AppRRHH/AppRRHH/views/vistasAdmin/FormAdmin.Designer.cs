namespace AppRRHH.views.vistasAdmin
{
    partial class FormAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            panelSidebar = new Panel();
            btnCerrarSesion = new Button();
            pictureLogo = new PictureBox();
            btnConfiguracion = new Button();
            btnInicio = new Button();
            btnVacaciones = new Button();
            btnEmpleados = new Button();
            btnNominas = new Button();
            btnFichajes = new Button();
            btnDepartamentos = new Button();
            panelContenido = new Panel();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(30, 41, 59);
            panelSidebar.Controls.Add(btnCerrarSesion);
            panelSidebar.Controls.Add(pictureLogo);
            panelSidebar.Controls.Add(btnConfiguracion);
            panelSidebar.Controls.Add(btnInicio);
            panelSidebar.Controls.Add(btnVacaciones);
            panelSidebar.Controls.Add(btnEmpleados);
            panelSidebar.Controls.Add(btnNominas);
            panelSidebar.Controls.Add(btnFichajes);
            panelSidebar.Controls.Add(btnDepartamentos);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(3, 2, 3, 2);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(208, 570);
            panelSidebar.TabIndex = 0;
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
            btnCerrarSesion.Location = new Point(7, 512);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(185, 36);
            btnCerrarSesion.TabIndex = 7;
            btnCerrarSesion.Text = "CERRAR SESIÓN";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // pictureLogo
            // 
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(0, 0);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(208, 121);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 0;
            pictureLogo.TabStop = false;
            pictureLogo.Click += pictureBox1_Click;
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
            btnConfiguracion.Location = new Point(7, 420);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(185, 36);
            btnConfiguracion.TabIndex = 6;
            btnConfiguracion.Text = "CONFIGURACIÓN";
            btnConfiguracion.UseVisualStyleBackColor = false;
            btnConfiguracion.Click += btnConfiguracion_Click;
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
            btnInicio.Location = new Point(7, 160);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(185, 36);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "MI PERFIL";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
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
            btnVacaciones.Location = new Point(7, 376);
            btnVacaciones.Name = "btnVacaciones";
            btnVacaciones.Size = new Size(185, 36);
            btnVacaciones.TabIndex = 5;
            btnVacaciones.Text = "VACACIONES";
            btnVacaciones.UseVisualStyleBackColor = false;
            btnVacaciones.Click += btnVacaciones_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.Transparent;
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmpleados.ForeColor = Color.FromArgb(241, 245, 249);
            btnEmpleados.Image = (Image)resources.GetObject("btnEmpleados.Image");
            btnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Location = new Point(7, 202);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(185, 36);
            btnEmpleados.TabIndex = 1;
            btnEmpleados.Text = "EMPLEADOS";
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleados_Click;
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
            btnNominas.Location = new Point(7, 332);
            btnNominas.Name = "btnNominas";
            btnNominas.Size = new Size(185, 36);
            btnNominas.TabIndex = 4;
            btnNominas.Text = "NÓMINAS";
            btnNominas.UseVisualStyleBackColor = false;
            btnNominas.Click += btnNominas_Click;
            // 
            // btnFichajes
            // 
            btnFichajes.BackColor = Color.Transparent;
            btnFichajes.FlatAppearance.BorderSize = 0;
            btnFichajes.FlatStyle = FlatStyle.Flat;
            btnFichajes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFichajes.ForeColor = Color.FromArgb(241, 245, 249);
            btnFichajes.Image = (Image)resources.GetObject("btnFichajes.Image");
            btnFichajes.ImageAlign = ContentAlignment.MiddleLeft;
            btnFichajes.Location = new Point(7, 246);
            btnFichajes.Name = "btnFichajes";
            btnFichajes.Size = new Size(185, 36);
            btnFichajes.TabIndex = 2;
            btnFichajes.Text = "FICHAJES";
            btnFichajes.UseVisualStyleBackColor = false;
            btnFichajes.Click += btnFichajes_Click;
            // 
            // btnDepartamentos
            // 
            btnDepartamentos.BackColor = Color.Transparent;
            btnDepartamentos.FlatAppearance.BorderSize = 0;
            btnDepartamentos.FlatStyle = FlatStyle.Flat;
            btnDepartamentos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDepartamentos.ForeColor = Color.FromArgb(241, 245, 249);
            btnDepartamentos.Image = (Image)resources.GetObject("btnDepartamentos.Image");
            btnDepartamentos.ImageAlign = ContentAlignment.MiddleLeft;
            btnDepartamentos.Location = new Point(7, 288);
            btnDepartamentos.Name = "btnDepartamentos";
            btnDepartamentos.Size = new Size(185, 36);
            btnDepartamentos.TabIndex = 3;
            btnDepartamentos.Text = "DEPARTAMENTOS";
            btnDepartamentos.UseVisualStyleBackColor = false;
            btnDepartamentos.Click += btnDepartamentos_Click;
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.FromArgb(248, 250, 252);
            panelContenido.BackgroundImageLayout = ImageLayout.Stretch;
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(208, 0);
            panelContenido.Margin = new Padding(3, 2, 3, 2);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(845, 570);
            panelContenido.TabIndex = 1;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 570);
            Controls.Add(panelContenido);
            Controls.Add(panelSidebar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1000, 500);
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pantalla de Inicio - Admin";
            panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Panel panelContenido;
        private PictureBox pictureLogo;
        private Button btnConfiguracion;
        private Button btnCerrarSesion;
        private Button btnNominas;
        private Button btnVacaciones;
        private Button btnDepartamentos;
        private Button btnFichajes;
        private Button btnEmpleados;
        private Button btnInicio;
    }
}

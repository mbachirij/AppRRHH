namespace AppRRHH
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
            btnInicio = new MaterialSkin.Controls.MaterialButton();
            btnCerrarSesion = new MaterialSkin.Controls.MaterialButton();
            btnConfiguracion = new MaterialSkin.Controls.MaterialButton();
            btnInformes = new MaterialSkin.Controls.MaterialButton();
            btnVacaciones = new MaterialSkin.Controls.MaterialButton();
            btnNominas = new MaterialSkin.Controls.MaterialButton();
            btnDepartamentos = new MaterialSkin.Controls.MaterialButton();
            btnEmpleados = new MaterialSkin.Controls.MaterialButton();
            panelContenido = new Panel();
            panelTitulo = new Panel();
            lblTitulo = new Label();
            panelSidebar.SuspendLayout();
            panelContenido.SuspendLayout();
            panelTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.White;
            panelSidebar.Controls.Add(btnInicio);
            panelSidebar.Controls.Add(btnCerrarSesion);
            panelSidebar.Controls.Add(btnConfiguracion);
            panelSidebar.Controls.Add(btnInformes);
            panelSidebar.Controls.Add(btnVacaciones);
            panelSidebar.Controls.Add(btnNominas);
            panelSidebar.Controls.Add(btnDepartamentos);
            panelSidebar.Controls.Add(btnEmpleados);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(220, 633);
            panelSidebar.TabIndex = 0;
            // 
            // btnInicio
            // 
            btnInicio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnInicio.Depth = 0;
            btnInicio.HighEmphasis = false;
            btnInicio.Icon = (Image)resources.GetObject("btnInicio.Icon");
            btnInicio.Location = new Point(13, 25);
            btnInicio.Margin = new Padding(4, 6, 4, 6);
            btnInicio.MouseState = MaterialSkin.MouseState.HOVER;
            btnInicio.Name = "btnInicio";
            btnInicio.NoAccentTextColor = Color.Empty;
            btnInicio.Size = new Size(96, 36);
            btnInicio.TabIndex = 7;
            btnInicio.Text = "Admin";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnInicio.UseAccentColor = false;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCerrarSesion.Depth = 0;
            btnCerrarSesion.HighEmphasis = false;
            btnCerrarSesion.Icon = (Image)resources.GetObject("btnCerrarSesion.Icon");
            btnCerrarSesion.Location = new Point(13, 549);
            btnCerrarSesion.Margin = new Padding(4, 6, 4, 6);
            btnCerrarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.NoAccentTextColor = Color.Empty;
            btnCerrarSesion.Size = new Size(159, 36);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCerrarSesion.UseAccentColor = false;
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfiguracion.Cursor = Cursors.Hand;
            btnConfiguracion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnConfiguracion.Depth = 0;
            btnConfiguracion.HighEmphasis = false;
            btnConfiguracion.Icon = (Image)resources.GetObject("btnConfiguracion.Icon");
            btnConfiguracion.Location = new Point(13, 364);
            btnConfiguracion.Margin = new Padding(4, 6, 4, 6);
            btnConfiguracion.MouseState = MaterialSkin.MouseState.HOVER;
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.NoAccentTextColor = Color.Empty;
            btnConfiguracion.Size = new Size(165, 36);
            btnConfiguracion.TabIndex = 5;
            btnConfiguracion.Text = "Configuración";
            btnConfiguracion.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguracion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnConfiguracion.UseAccentColor = false;
            btnConfiguracion.UseVisualStyleBackColor = true;
            btnConfiguracion.Click += btnConfiguracion_Click;
            // 
            // btnInformes
            // 
            btnInformes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnInformes.Cursor = Cursors.Hand;
            btnInformes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnInformes.Depth = 0;
            btnInformes.HighEmphasis = false;
            btnInformes.Icon = (Image)resources.GetObject("btnInformes.Icon");
            btnInformes.Location = new Point(13, 316);
            btnInformes.Margin = new Padding(4, 6, 4, 6);
            btnInformes.MouseState = MaterialSkin.MouseState.HOVER;
            btnInformes.Name = "btnInformes";
            btnInformes.NoAccentTextColor = Color.Empty;
            btnInformes.Size = new Size(122, 36);
            btnInformes.TabIndex = 4;
            btnInformes.Text = "Informes";
            btnInformes.TextAlign = ContentAlignment.MiddleLeft;
            btnInformes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnInformes.UseAccentColor = false;
            btnInformes.UseVisualStyleBackColor = true;
            btnInformes.Click += btnInformes_Click;
            // 
            // btnVacaciones
            // 
            btnVacaciones.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVacaciones.Cursor = Cursors.Hand;
            btnVacaciones.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVacaciones.Depth = 0;
            btnVacaciones.HighEmphasis = false;
            btnVacaciones.Icon = (Image)resources.GetObject("btnVacaciones.Icon");
            btnVacaciones.Location = new Point(13, 268);
            btnVacaciones.Margin = new Padding(4, 6, 4, 6);
            btnVacaciones.MouseState = MaterialSkin.MouseState.HOVER;
            btnVacaciones.Name = "btnVacaciones";
            btnVacaciones.NoAccentTextColor = Color.Empty;
            btnVacaciones.Size = new Size(140, 36);
            btnVacaciones.TabIndex = 3;
            btnVacaciones.Text = "Vacaciones";
            btnVacaciones.TextAlign = ContentAlignment.MiddleLeft;
            btnVacaciones.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVacaciones.UseAccentColor = false;
            btnVacaciones.UseVisualStyleBackColor = true;
            btnVacaciones.Click += btnVacaciones_Click;
            // 
            // btnNominas
            // 
            btnNominas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNominas.Cursor = Cursors.Hand;
            btnNominas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNominas.Depth = 0;
            btnNominas.HighEmphasis = false;
            btnNominas.Icon = (Image)resources.GetObject("btnNominas.Icon");
            btnNominas.Location = new Point(13, 220);
            btnNominas.Margin = new Padding(4, 6, 4, 6);
            btnNominas.MouseState = MaterialSkin.MouseState.HOVER;
            btnNominas.Name = "btnNominas";
            btnNominas.NoAccentTextColor = Color.Empty;
            btnNominas.Size = new Size(116, 36);
            btnNominas.TabIndex = 2;
            btnNominas.Text = "Nominas";
            btnNominas.TextAlign = ContentAlignment.MiddleLeft;
            btnNominas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNominas.UseAccentColor = false;
            btnNominas.UseVisualStyleBackColor = true;
            btnNominas.Click += btnNominas_Click;
            // 
            // btnDepartamentos
            // 
            btnDepartamentos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDepartamentos.Cursor = Cursors.Hand;
            btnDepartamentos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDepartamentos.Depth = 0;
            btnDepartamentos.HighEmphasis = false;
            btnDepartamentos.Icon = (Image)resources.GetObject("btnDepartamentos.Icon");
            btnDepartamentos.Location = new Point(13, 172);
            btnDepartamentos.Margin = new Padding(4, 6, 4, 6);
            btnDepartamentos.MouseState = MaterialSkin.MouseState.HOVER;
            btnDepartamentos.Name = "btnDepartamentos";
            btnDepartamentos.NoAccentTextColor = Color.Empty;
            btnDepartamentos.Size = new Size(174, 36);
            btnDepartamentos.TabIndex = 1;
            btnDepartamentos.Text = "Departamentos";
            btnDepartamentos.TextAlign = ContentAlignment.MiddleLeft;
            btnDepartamentos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDepartamentos.UseAccentColor = false;
            btnDepartamentos.UseVisualStyleBackColor = true;
            btnDepartamentos.Click += btnDepartamentos_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEmpleados.Cursor = Cursors.Hand;
            btnEmpleados.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEmpleados.Depth = 0;
            btnEmpleados.HighEmphasis = false;
            btnEmpleados.Icon = (Image)resources.GetObject("btnEmpleados.Icon");
            btnEmpleados.Location = new Point(13, 124);
            btnEmpleados.Margin = new Padding(4, 6, 4, 6);
            btnEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.NoAccentTextColor = Color.Empty;
            btnEmpleados.Size = new Size(135, 36);
            btnEmpleados.TabIndex = 0;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.TextAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEmpleados.UseAccentColor = false;
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // panelContenido
            // 
            panelContenido.BackgroundImage = (Image)resources.GetObject("panelContenido.BackgroundImage");
            panelContenido.BackgroundImageLayout = ImageLayout.Zoom;
            panelContenido.Controls.Add(panelTitulo);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(220, 0);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(862, 633);
            panelContenido.TabIndex = 1;
            // 
            // panelTitulo
            // 
            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(862, 76);
            panelTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(30, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(504, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "PANEL DE CONTROL GENERAL";
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 633);
            Controls.Add(panelContenido);
            Controls.Add(panelSidebar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(900, 600);
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pantalla de Inicio - Admin";
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelContenido.ResumeLayout(false);
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Panel panelContenido;
        private MaterialSkin.Controls.MaterialButton btnEmpleados;
        private MaterialSkin.Controls.MaterialButton btnConfiguracion;
        private MaterialSkin.Controls.MaterialButton btnInformes;
        private MaterialSkin.Controls.MaterialButton btnVacaciones;
        private MaterialSkin.Controls.MaterialButton btnNominas;
        private MaterialSkin.Controls.MaterialButton btnDepartamentos;
        private Panel panelTitulo;
        private Label lblTitulo;
        private MaterialSkin.Controls.MaterialButton btnCerrarSesion;
        private MaterialSkin.Controls.MaterialButton btnInicio;
    }
}

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
            btnVacaciones = new MaterialSkin.Controls.MaterialButton();
            btnNominas = new MaterialSkin.Controls.MaterialButton();
            btnDepartamentos = new MaterialSkin.Controls.MaterialButton();
            btnEmpleados = new MaterialSkin.Controls.MaterialButton();
            panelContenido = new Panel();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.White;
            panelSidebar.Controls.Add(btnInicio);
            panelSidebar.Controls.Add(btnCerrarSesion);
            panelSidebar.Controls.Add(btnConfiguracion);
            panelSidebar.Controls.Add(btnVacaciones);
            panelSidebar.Controls.Add(btnNominas);
            panelSidebar.Controls.Add(btnDepartamentos);
            panelSidebar.Controls.Add(btnEmpleados);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(3, 2, 3, 2);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(192, 617);
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
            btnInicio.Location = new Point(11, 19);
            btnInicio.Margin = new Padding(4);
            btnInicio.MouseState = MaterialSkin.MouseState.HOVER;
            btnInicio.Name = "btnInicio";
            btnInicio.NoAccentTextColor = Color.Empty;
            btnInicio.Size = new Size(117, 36);
            btnInicio.TabIndex = 7;
            btnInicio.Text = "Mi Perfil";
            btnInicio.TextAlign = ContentAlignment.TopLeft;
            btnInicio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnInicio.UseAccentColor = false;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCerrarSesion.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCerrarSesion.Depth = 0;
            btnCerrarSesion.HighEmphasis = false;
            btnCerrarSesion.Icon = (Image)resources.GetObject("btnCerrarSesion.Icon");
            btnCerrarSesion.Location = new Point(17, 560);
            btnCerrarSesion.Margin = new Padding(4);
            btnCerrarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.NoAccentTextColor = Color.Empty;
            btnCerrarSesion.Size = new Size(159, 36);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.BottomLeft;
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
            btnConfiguracion.Location = new Point(13, 310);
            btnConfiguracion.Margin = new Padding(4);
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
            // btnVacaciones
            // 
            btnVacaciones.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVacaciones.Cursor = Cursors.Hand;
            btnVacaciones.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVacaciones.Depth = 0;
            btnVacaciones.HighEmphasis = false;
            btnVacaciones.Icon = (Image)resources.GetObject("btnVacaciones.Icon");
            btnVacaciones.Location = new Point(13, 266);
            btnVacaciones.Margin = new Padding(4);
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
            btnNominas.Location = new Point(13, 222);
            btnNominas.Margin = new Padding(4);
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
            btnDepartamentos.Location = new Point(13, 178);
            btnDepartamentos.Margin = new Padding(4);
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
            btnEmpleados.Location = new Point(13, 134);
            btnEmpleados.Margin = new Padding(4);
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
            panelContenido.BackgroundImageLayout = ImageLayout.Zoom;
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(192, 0);
            panelContenido.Margin = new Padding(3, 2, 3, 2);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(875, 617);
            panelContenido.TabIndex = 1;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 617);
            Controls.Add(panelContenido);
            Controls.Add(panelSidebar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1000, 500);
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pantalla de Inicio - Admin";
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Panel panelContenido;
        private MaterialSkin.Controls.MaterialButton btnEmpleados;
        private MaterialSkin.Controls.MaterialButton btnConfiguracion;
        private MaterialSkin.Controls.MaterialButton btnVacaciones;
        private MaterialSkin.Controls.MaterialButton btnNominas;
        private MaterialSkin.Controls.MaterialButton btnDepartamentos;
        private MaterialSkin.Controls.MaterialButton btnCerrarSesion;
        private MaterialSkin.Controls.MaterialButton btnInicio;
    }
}

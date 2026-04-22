namespace AppRRHH.views.Empleado
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
            btnInicio = new MaterialSkin.Controls.MaterialButton();
            btnCerrarSesion = new MaterialSkin.Controls.MaterialButton();
            btnConfiguracion = new MaterialSkin.Controls.MaterialButton();
            btnInformes = new MaterialSkin.Controls.MaterialButton();
            btnVacaciones = new MaterialSkin.Controls.MaterialButton();
            btnNominas = new MaterialSkin.Controls.MaterialButton();
            btnYo = new MaterialSkin.Controls.MaterialButton();
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
            panelSidebar.Controls.Add(btnInformes);
            panelSidebar.Controls.Add(btnVacaciones);
            panelSidebar.Controls.Add(btnNominas);
            panelSidebar.Controls.Add(btnYo);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(3, 2, 3, 2);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(192, 502);
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
            btnInicio.Size = new Size(127, 36);
            btnInicio.TabIndex = 7;
            btnInicio.Text = "Dashboad";
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
            btnCerrarSesion.Location = new Point(11, 432);
            btnCerrarSesion.Margin = new Padding(4);
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
            btnConfiguracion.Location = new Point(11, 273);
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
            // 
            // btnInformes
            // 
            btnInformes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnInformes.Cursor = Cursors.Hand;
            btnInformes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnInformes.Depth = 0;
            btnInformes.HighEmphasis = false;
            btnInformes.Icon = (Image)resources.GetObject("btnInformes.Icon");
            btnInformes.Location = new Point(11, 237);
            btnInformes.Margin = new Padding(4);
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
            // 
            // btnVacaciones
            // 
            btnVacaciones.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVacaciones.Cursor = Cursors.Hand;
            btnVacaciones.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVacaciones.Depth = 0;
            btnVacaciones.HighEmphasis = false;
            btnVacaciones.Icon = (Image)resources.GetObject("btnVacaciones.Icon");
            btnVacaciones.Location = new Point(11, 201);
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
            // 
            // btnNominas
            // 
            btnNominas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNominas.Cursor = Cursors.Hand;
            btnNominas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNominas.Depth = 0;
            btnNominas.HighEmphasis = false;
            btnNominas.Icon = (Image)resources.GetObject("btnNominas.Icon");
            btnNominas.Location = new Point(11, 165);
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
            // 
            // btnYo
            // 
            btnYo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnYo.Cursor = Cursors.Hand;
            btnYo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnYo.Depth = 0;
            btnYo.HighEmphasis = false;
            btnYo.Icon = (Image)resources.GetObject("btnYo.Icon");
            btnYo.Location = new Point(11, 129);
            btnYo.Margin = new Padding(4);
            btnYo.MouseState = MaterialSkin.MouseState.HOVER;
            btnYo.Name = "btnYo";
            btnYo.NoAccentTextColor = Color.Empty;
            btnYo.Size = new Size(68, 36);
            btnYo.TabIndex = 0;
            btnYo.Text = "FICHAR";
            btnYo.TextAlign = ContentAlignment.MiddleLeft;
            btnYo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnYo.UseAccentColor = false;
            btnYo.UseVisualStyleBackColor = true;
            btnYo.Click += btnYo_Click;
            // 
            // panelContenido
            // 
            panelContenido.BackgroundImageLayout = ImageLayout.Zoom;
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(192, 0);
            panelContenido.Margin = new Padding(3, 2, 3, 2);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(804, 502);
            panelContenido.TabIndex = 1;
            // 
            // FormEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 502);
            Controls.Add(panelContenido);
            Controls.Add(panelSidebar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(790, 460);
            Name = "FormEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pantalla de Inicio - Empleado";
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private MaterialSkin.Controls.MaterialButton btnInicio;
        private MaterialSkin.Controls.MaterialButton btnCerrarSesion;
        private MaterialSkin.Controls.MaterialButton btnConfiguracion;
        private MaterialSkin.Controls.MaterialButton btnInformes;
        private MaterialSkin.Controls.MaterialButton btnVacaciones;
        private MaterialSkin.Controls.MaterialButton btnNominas;
        private MaterialSkin.Controls.MaterialButton btnYo;
        private Panel panelContenido;
    }
}
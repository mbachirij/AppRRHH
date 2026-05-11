namespace AppRRHH.views.vistasEmpleado
{
    partial class UCInicioEmpleado
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
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCInicioEmpleado));
            LiveChartsCore.Drawing.Padding padding1 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding2 = new LiveChartsCore.Drawing.Padding();
            panelContenido = new Panel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            label3 = new Label();
            lblVacacionesPend = new Label();
            label1 = new Label();
            lblDiasVacaciones = new Label();
            label2 = new Label();
            label8 = new Label();
            label6 = new Label();
            materialCard5 = new MaterialSkin.Controls.MaterialCard();
            lblPuesto = new Label();
            lblNumSegSocial = new Label();
            lblRol = new Label();
            lblDepartamento = new Label();
            lblEmail = new Label();
            lblDNI = new Label();
            lblApellidos = new Label();
            lblNombre = new Label();
            label5 = new Label();
            panelContenido.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard5.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenido
            // 
            panelContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContenido.Controls.Add(materialCard2);
            panelContenido.Controls.Add(label6);
            panelContenido.Controls.Add(materialCard5);
            panelContenido.Location = new Point(0, 24);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1211, 690);
            panelContenido.TabIndex = 5;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(pieChart1);
            materialCard2.Controls.Add(label3);
            materialCard2.Controls.Add(lblVacacionesPend);
            materialCard2.Controls.Add(label1);
            materialCard2.Controls.Add(lblDiasVacaciones);
            materialCard2.Controls.Add(label2);
            materialCard2.Controls.Add(label8);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(559, 105);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(480, 550);
            materialCard2.TabIndex = 7;
            // 
            // pieChart1
            // 
            pieChart1.AutoUpdateEnabled = true;
            pieChart1.ChartTheme = null;
            skDefaultLegend1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultLegend1.Content = null;
            skDefaultLegend1.IsValid = false;
            skDefaultLegend1.Opacity = 1F;
            padding1.Bottom = 0F;
            padding1.Left = 0F;
            padding1.Right = 0F;
            padding1.Top = 0F;
            skDefaultLegend1.Padding = padding1;
            skDefaultLegend1.RemoveOnCompleted = false;
            skDefaultLegend1.RotateTransform = 0F;
            skDefaultLegend1.X = 0F;
            skDefaultLegend1.Y = 0F;
            pieChart1.Legend = skDefaultLegend1;
            pieChart1.Location = new Point(58, 293);
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(360, 240);
            pieChart1.TabIndex = 9;
            skDefaultTooltip1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultTooltip1.Content = null;
            skDefaultTooltip1.IsValid = false;
            skDefaultTooltip1.Opacity = 1F;
            padding2.Bottom = 0F;
            padding2.Left = 0F;
            padding2.Right = 0F;
            padding2.Top = 0F;
            skDefaultTooltip1.Padding = padding2;
            skDefaultTooltip1.RemoveOnCompleted = false;
            skDefaultTooltip1.RotateTransform = 0F;
            skDefaultTooltip1.Wedge = 10;
            skDefaultTooltip1.X = 0F;
            skDefaultTooltip1.Y = 0F;
            pieChart1.Tooltip = skDefaultTooltip1;
            pieChart1.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(17, 250);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 8;
            label3.Text = "Nóminas por mes:";
            // 
            // lblVacacionesPend
            // 
            lblVacacionesPend.AutoSize = true;
            lblVacacionesPend.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVacacionesPend.ForeColor = Color.FromArgb(88, 101, 242);
            lblVacacionesPend.Location = new Point(17, 185);
            lblVacacionesPend.Name = "lblVacacionesPend";
            lblVacacionesPend.Size = new Size(44, 51);
            lblVacacionesPend.TabIndex = 7;
            lblVacacionesPend.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(17, 160);
            label1.Name = "label1";
            label1.Size = new Size(166, 20);
            label1.TabIndex = 6;
            label1.Text = "Vacaciones pendientes";
            // 
            // lblDiasVacaciones
            // 
            lblDiasVacaciones.AutoSize = true;
            lblDiasVacaciones.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiasVacaciones.ForeColor = Color.FromArgb(88, 101, 242);
            lblDiasVacaciones.Location = new Point(17, 95);
            lblDiasVacaciones.Name = "lblDiasVacaciones";
            lblDiasVacaciones.Size = new Size(44, 51);
            lblDiasVacaciones.TabIndex = 5;
            lblDiasVacaciones.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(17, 70);
            label2.Name = "label2";
            label2.Size = new Size(222, 20);
            label2.TabIndex = 4;
            label2.Text = "Días de vacaciones disponibles";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(88, 101, 242);
            label8.Location = new Point(20, 15);
            label8.Name = "label8";
            label8.Size = new Size(123, 25);
            label8.TabIndex = 1;
            label8.Text = "Mi Actividad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(248, 250, 252);
            label6.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(30, 41, 59);
            label6.Location = new Point(49, 55);
            label6.Name = "label6";
            label6.Size = new Size(140, 41);
            label6.TabIndex = 6;
            label6.Text = "Mi Perfil";
            // 
            // materialCard5
            // 
            materialCard5.BackColor = Color.FromArgb(255, 255, 255);
            materialCard5.Controls.Add(lblPuesto);
            materialCard5.Controls.Add(lblNumSegSocial);
            materialCard5.Controls.Add(lblRol);
            materialCard5.Controls.Add(lblDepartamento);
            materialCard5.Controls.Add(lblEmail);
            materialCard5.Controls.Add(lblDNI);
            materialCard5.Controls.Add(lblApellidos);
            materialCard5.Controls.Add(lblNombre);
            materialCard5.Controls.Add(label5);
            materialCard5.Depth = 0;
            materialCard5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard5.Location = new Point(49, 105);
            materialCard5.Margin = new Padding(14);
            materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard5.Name = "materialCard5";
            materialCard5.Padding = new Padding(14);
            materialCard5.Size = new Size(480, 550);
            materialCard5.TabIndex = 5;
            // 
            // lblPuesto
            // 
            lblPuesto.AutoSize = true;
            lblPuesto.BackColor = Color.Transparent;
            lblPuesto.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblPuesto.ForeColor = Color.Gray;
            lblPuesto.Location = new Point(20, 360);
            lblPuesto.Name = "lblPuesto";
            lblPuesto.Size = new Size(61, 20);
            lblPuesto.TabIndex = 8;
            lblPuesto.Text = "Puesto:";
            // 
            // lblNumSegSocial
            // 
            lblNumSegSocial.AutoSize = true;
            lblNumSegSocial.BackColor = Color.Transparent;
            lblNumSegSocial.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblNumSegSocial.ForeColor = Color.Gray;
            lblNumSegSocial.Location = new Point(20, 410);
            lblNumSegSocial.Name = "lblNumSegSocial";
            lblNumSegSocial.Size = new Size(52, 20);
            lblNumSegSocial.TabIndex = 7;
            lblNumSegSocial.Text = "Nº SS:";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.BackColor = Color.Transparent;
            lblRol.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblRol.ForeColor = Color.Gray;
            lblRol.Location = new Point(20, 310);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(36, 20);
            lblRol.TabIndex = 6;
            lblRol.Text = "Rol:";
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.BackColor = Color.Transparent;
            lblDepartamento.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblDepartamento.ForeColor = Color.Gray;
            lblDepartamento.Location = new Point(20, 260);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(115, 20);
            lblDepartamento.TabIndex = 5;
            lblDepartamento.Text = "Departamento:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblEmail.ForeColor = Color.Gray;
            lblEmail.Location = new Point(20, 210);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.BackColor = Color.Transparent;
            lblDNI.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblDNI.ForeColor = Color.Gray;
            lblDNI.Location = new Point(20, 160);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(41, 20);
            lblDNI.TabIndex = 3;
            lblDNI.Text = "DNI:";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.BackColor = Color.Transparent;
            lblApellidos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblApellidos.ForeColor = Color.Gray;
            lblApellidos.Location = new Point(20, 110);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(78, 20);
            lblApellidos.TabIndex = 2;
            lblApellidos.Text = "Apellidos:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblNombre.ForeColor = Color.Gray;
            lblNombre.Location = new Point(20, 60);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(88, 101, 242);
            label5.Location = new Point(20, 15);
            label5.Name = "label5";
            label5.Size = new Size(162, 25);
            label5.TabIndex = 0;
            label5.Text = "Datos Personales";
            // 
            // UCInicioEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(248, 250, 252);
            Controls.Add(panelContenido);
            ForeColor = Color.White;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCInicioEmpleado";
            Size = new Size(1211, 736);
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCard5.ResumeLayout(false);
            materialCard5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelContenido;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private Label lblNumSegSocial;
        private Label lblRol;
        private Label lblDepartamento;
        private Label lblEmail;
        private Label lblDNI;
        private Label lblApellidos;
        private Label lblNombre;
        private Label label5;
        private Label label6;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Label lblVacacionesPend;
        private Label label1;
        private Label lblDiasVacaciones;
        private Label label2;
        private Label label8;
        private Label lblPuesto;
        private Label label3;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
    }
}

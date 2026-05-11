namespace AppRRHH.views.vistasAdmin
{
    partial class UCInicioAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCInicioAdmin));
            LiveChartsCore.Drawing.Padding padding1 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding2 = new LiveChartsCore.Drawing.Padding();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            lblNumSegSocial = new Label();
            lblRol = new Label();
            lblDepartamento = new Label();
            lblEmail = new Label();
            lblDNI = new Label();
            lblApellidos = new Label();
            lblNombre = new Label();
            label2 = new Label();
            label1 = new Label();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            lblTotalDeptos2 = new Label();
            label7 = new Label();
            label5 = new Label();
            lblNominasMes = new Label();
            label6 = new Label();
            lblTotalEmpleados = new Label();
            label4 = new Label();
            label3 = new Label();
            panelCentrado = new Panel();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            panelCentrado.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(lblNumSegSocial);
            materialCard1.Controls.Add(lblRol);
            materialCard1.Controls.Add(lblDepartamento);
            materialCard1.Controls.Add(lblEmail);
            materialCard1.Controls.Add(lblDNI);
            materialCard1.Controls.Add(lblApellidos);
            materialCard1.Controls.Add(lblNombre);
            materialCard1.Controls.Add(label2);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(54, 93);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(480, 550);
            materialCard1.TabIndex = 0;
            // 
            // lblNumSegSocial
            // 
            lblNumSegSocial.AutoSize = true;
            lblNumSegSocial.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblNumSegSocial.ForeColor = Color.DarkGray;
            lblNumSegSocial.Location = new Point(20, 360);
            lblNumSegSocial.Name = "lblNumSegSocial";
            lblNumSegSocial.Size = new Size(52, 20);
            lblNumSegSocial.TabIndex = 7;
            lblNumSegSocial.Text = "Nº SS:";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblRol.ForeColor = Color.DarkGray;
            lblRol.Location = new Point(20, 310);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(36, 20);
            lblRol.TabIndex = 6;
            lblRol.Text = "Rol:";
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblDepartamento.ForeColor = Color.DarkGray;
            lblDepartamento.Location = new Point(20, 260);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(115, 20);
            lblDepartamento.TabIndex = 5;
            lblDepartamento.Text = "Departamento:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblEmail.ForeColor = Color.DarkGray;
            lblEmail.Location = new Point(20, 210);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblDNI.ForeColor = Color.DarkGray;
            lblDNI.Location = new Point(20, 160);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(41, 20);
            lblDNI.TabIndex = 3;
            lblDNI.Text = "DNI:";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblApellidos.ForeColor = Color.DarkGray;
            lblApellidos.Location = new Point(20, 110);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(78, 20);
            lblApellidos.TabIndex = 2;
            lblApellidos.Text = "Apellidos:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblNombre.ForeColor = Color.DarkGray;
            lblNombre.Location = new Point(20, 60);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(88, 101, 242);
            label2.Location = new Point(20, 15);
            label2.Name = "label2";
            label2.Size = new Size(162, 25);
            label2.TabIndex = 0;
            label2.Text = "Datos Personales";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(15, 23, 42);
            label1.Location = new Point(49, 23);
            label1.Name = "label1";
            label1.Size = new Size(140, 41);
            label1.TabIndex = 1;
            label1.Text = "Mi Perfil";
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(pieChart1);
            materialCard2.Controls.Add(lblTotalDeptos2);
            materialCard2.Controls.Add(label7);
            materialCard2.Controls.Add(label5);
            materialCard2.Controls.Add(lblNominasMes);
            materialCard2.Controls.Add(label6);
            materialCard2.Controls.Add(lblTotalEmpleados);
            materialCard2.Controls.Add(label4);
            materialCard2.Controls.Add(label3);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(564, 93);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(480, 550);
            materialCard2.TabIndex = 2;
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
            pieChart1.Location = new Point(152, 383);
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(150, 150);
            pieChart1.TabIndex = 10;
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
            // lblTotalDeptos2
            // 
            lblTotalDeptos2.AutoSize = true;
            lblTotalDeptos2.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDeptos2.ForeColor = Color.FromArgb(88, 101, 242);
            lblTotalDeptos2.Location = new Point(20, 279);
            lblTotalDeptos2.Name = "lblTotalDeptos2";
            lblTotalDeptos2.Size = new Size(44, 51);
            lblTotalDeptos2.TabIndex = 9;
            lblTotalDeptos2.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label7.ForeColor = Color.DarkGray;
            label7.Location = new Point(20, 254);
            label7.Name = "label7";
            label7.Size = new Size(157, 20);
            label7.TabIndex = 8;
            label7.Text = "Total Departamentos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(20, 349);
            label5.Name = "label5";
            label5.Size = new Size(168, 20);
            label5.TabIndex = 6;
            label5.Text = "Vacaciones por estado:";
            // 
            // lblNominasMes
            // 
            lblNominasMes.AutoSize = true;
            lblNominasMes.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNominasMes.ForeColor = Color.FromArgb(88, 101, 242);
            lblNominasMes.Location = new Point(20, 185);
            lblNominasMes.Name = "lblNominasMes";
            lblNominasMes.Size = new Size(44, 51);
            lblNominasMes.TabIndex = 5;
            lblNominasMes.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.ForeColor = Color.DarkGray;
            label6.Location = new Point(20, 160);
            label6.Name = "label6";
            label6.Size = new Size(138, 20);
            label6.TabIndex = 4;
            label6.Text = "Nóminas este mes";
            // 
            // lblTotalEmpleados
            // 
            lblTotalEmpleados.AutoSize = true;
            lblTotalEmpleados.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalEmpleados.ForeColor = Color.FromArgb(88, 101, 242);
            lblTotalEmpleados.Location = new Point(20, 95);
            lblTotalEmpleados.Name = "lblTotalEmpleados";
            lblTotalEmpleados.Size = new Size(44, 51);
            lblTotalEmpleados.TabIndex = 3;
            lblTotalEmpleados.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(20, 70);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 2;
            label4.Text = "Total Empleados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(88, 101, 242);
            label3.Location = new Point(20, 15);
            label3.Name = "label3";
            label3.Size = new Size(198, 25);
            label3.TabIndex = 1;
            label3.Text = "Resumen del Sistema";
            // 
            // panelCentrado
            // 
            panelCentrado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCentrado.BackColor = Color.Transparent;
            panelCentrado.Controls.Add(materialCard2);
            panelCentrado.Controls.Add(label1);
            panelCentrado.Controls.Add(materialCard1);
            panelCentrado.Location = new Point(14, 24);
            panelCentrado.Name = "panelCentrado";
            panelCentrado.Size = new Size(1272, 736);
            panelCentrado.TabIndex = 0;
            // 
            // UCInicioAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            Controls.Add(panelCentrado);
            Name = "UCInicioAdmin";
            Size = new Size(1320, 794);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            panelCentrado.ResumeLayout(false);
            panelCentrado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Label lblNumSegSocial;
        private Label lblRol;
        private Label lblDepartamento;
        private Label lblEmail;
        private Label lblDNI;
        private Label lblApellidos;
        private Label lblNombre;
        private Label label2;
        private Label label1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Panel panelCentrado;
        private Label label3;
        private Label label5;
        private Label lblNominasMes;
        private Label label6;
        private Label lblTotalEmpleados;
        private Label label4;
        private Label lblTotalDeptos2;
        private Label label7;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
    }
}

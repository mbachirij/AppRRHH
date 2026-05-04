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
            panelContenido = new Panel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            lblNominasAnio = new Label();
            label7 = new Label();
            lblVacacionesPend = new Label();
            label1 = new Label();
            lblDiasVacaciones = new Label();
            label2 = new Label();
            lblHorasMes = new Label();
            label3 = new Label();
            label8 = new Label();
            label6 = new Label();
            materialCard5 = new MaterialSkin.Controls.MaterialCard();
            lblNumSegSocial = new Label();
            lblRol = new Label();
            lblDepartamento = new Label();
            lblEmail = new Label();
            lblDNI = new Label();
            lblApellidos = new Label();
            lblNombre = new Label();
            label5 = new Label();
            lblPuesto = new Label();
            panelContenido.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard5.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenido
            // 
            panelContenido.Anchor = AnchorStyles.None;
            panelContenido.Controls.Add(materialCard2);
            panelContenido.Controls.Add(label6);
            panelContenido.Controls.Add(materialCard5);
            panelContenido.Location = new Point(25, 24);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1170, 690);
            panelContenido.TabIndex = 5;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(lblNominasAnio);
            materialCard2.Controls.Add(label7);
            materialCard2.Controls.Add(lblVacacionesPend);
            materialCard2.Controls.Add(label1);
            materialCard2.Controls.Add(lblDiasVacaciones);
            materialCard2.Controls.Add(label2);
            materialCard2.Controls.Add(lblHorasMes);
            materialCard2.Controls.Add(label3);
            materialCard2.Controls.Add(label8);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(540, 70);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(480, 550);
            materialCard2.TabIndex = 7;
            // 
            // lblNominasAnio
            // 
            lblNominasAnio.AutoSize = true;
            lblNominasAnio.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNominasAnio.ForeColor = Color.FromArgb(88, 101, 242);
            lblNominasAnio.Location = new Point(20, 365);
            lblNominasAnio.Name = "lblNominasAnio";
            lblNominasAnio.Size = new Size(44, 51);
            lblNominasAnio.TabIndex = 9;
            lblNominasAnio.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(200, 200, 220);
            label7.Location = new Point(20, 340);
            label7.Name = "label7";
            label7.Size = new Size(176, 19);
            label7.TabIndex = 8;
            label7.Text = "Nóminas recibidas este año";
            // 
            // lblVacacionesPend
            // 
            lblVacacionesPend.AutoSize = true;
            lblVacacionesPend.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVacacionesPend.ForeColor = Color.FromArgb(88, 101, 242);
            lblVacacionesPend.Location = new Point(20, 275);
            lblVacacionesPend.Name = "lblVacacionesPend";
            lblVacacionesPend.Size = new Size(44, 51);
            lblVacacionesPend.TabIndex = 7;
            lblVacacionesPend.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(200, 200, 220);
            label1.Location = new Point(20, 250);
            label1.Name = "label1";
            label1.Size = new Size(146, 19);
            label1.TabIndex = 6;
            label1.Text = "Vacaciones pendientes";
            // 
            // lblDiasVacaciones
            // 
            lblDiasVacaciones.AutoSize = true;
            lblDiasVacaciones.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiasVacaciones.ForeColor = Color.FromArgb(88, 101, 242);
            lblDiasVacaciones.Location = new Point(20, 185);
            lblDiasVacaciones.Name = "lblDiasVacaciones";
            lblDiasVacaciones.Size = new Size(44, 51);
            lblDiasVacaciones.TabIndex = 5;
            lblDiasVacaciones.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(200, 200, 220);
            label2.Location = new Point(20, 160);
            label2.Name = "label2";
            label2.Size = new Size(195, 19);
            label2.TabIndex = 4;
            label2.Text = "Días de vacaciones disponibles";
            // 
            // lblHorasMes
            // 
            lblHorasMes.AutoSize = true;
            lblHorasMes.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHorasMes.ForeColor = Color.FromArgb(88, 101, 242);
            lblHorasMes.Location = new Point(20, 95);
            lblHorasMes.Name = "lblHorasMes";
            lblHorasMes.Size = new Size(44, 51);
            lblHorasMes.TabIndex = 3;
            lblHorasMes.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(200, 200, 220);
            label3.Location = new Point(20, 70);
            label3.Name = "label3";
            label3.Size = new Size(187, 19);
            label3.TabIndex = 2;
            label3.Text = "Total horas fichadas este mes";
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
            label6.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(30, 20);
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
            materialCard5.Location = new Point(30, 70);
            materialCard5.Margin = new Padding(14);
            materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard5.Name = "materialCard5";
            materialCard5.Padding = new Padding(14);
            materialCard5.Size = new Size(480, 550);
            materialCard5.TabIndex = 5;
            // 
            // lblNumSegSocial
            // 
            lblNumSegSocial.AutoSize = true;
            lblNumSegSocial.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumSegSocial.ForeColor = Color.FromArgb(200, 200, 220);
            lblNumSegSocial.Location = new Point(20, 410);
            lblNumSegSocial.Name = "lblNumSegSocial";
            lblNumSegSocial.Size = new Size(46, 19);
            lblNumSegSocial.TabIndex = 7;
            lblNumSegSocial.Text = "Nº SS:";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRol.ForeColor = Color.FromArgb(200, 200, 220);
            lblRol.Location = new Point(20, 310);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(31, 19);
            lblRol.TabIndex = 6;
            lblRol.Text = "Rol:";
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDepartamento.ForeColor = Color.FromArgb(200, 200, 220);
            lblDepartamento.Location = new Point(20, 260);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(101, 19);
            lblDepartamento.TabIndex = 5;
            lblDepartamento.Text = "Departamento:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(200, 200, 220);
            lblEmail.Location = new Point(20, 210);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 19);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDNI.ForeColor = Color.FromArgb(200, 200, 220);
            lblDNI.Location = new Point(20, 160);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(36, 19);
            lblDNI.TabIndex = 3;
            lblDNI.Text = "DNI:";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidos.ForeColor = Color.FromArgb(200, 200, 220);
            lblApellidos.Location = new Point(20, 110);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(67, 19);
            lblApellidos.TabIndex = 2;
            lblApellidos.Text = "Apellidos:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.FromArgb(200, 200, 220);
            lblNombre.Location = new Point(20, 60);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(62, 19);
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
            // lblPuesto
            // 
            lblPuesto.AutoSize = true;
            lblPuesto.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPuesto.ForeColor = Color.FromArgb(200, 200, 220);
            lblPuesto.Location = new Point(20, 360);
            lblPuesto.Name = "lblPuesto";
            lblPuesto.Size = new Size(54, 19);
            lblPuesto.TabIndex = 8;
            lblPuesto.Text = "Puesto:";
            // 
            // UCInicioEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
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
        private Label lblNominasAnio;
        private Label label7;
        private Label lblVacacionesPend;
        private Label label1;
        private Label lblDiasVacaciones;
        private Label label2;
        private Label lblHorasMes;
        private Label label3;
        private Label label8;
        private Label lblPuesto;
    }
}

namespace AppRRHH.views.vistasAdmin
{
    partial class UCNominasAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCNominasAdmin));
            panelCentrado = new Panel();
            label2 = new Label();
            materialCard7 = new MaterialSkin.Controls.MaterialCard();
            btnBuscar = new Button();
            cmbFiltroAno = new ComboBox();
            cmbFiltroMes = new ComboBox();
            cmbFiltroNombre = new ComboBox();
            btnGuardar = new Button();
            btnImprimir = new Button();
            dgvNominas = new DataGridView();
            lblHistorial = new Label();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            label3 = new Label();
            nudIRPF = new NumericUpDown();
            label1 = new Label();
            btnCalcular = new Button();
            lblPlusTrans = new Label();
            nudPlusTransporte = new NumericUpDown();
            lblPlusFest = new Label();
            nudPlusFestivo = new NumericUpDown();
            lblPlusNoct = new Label();
            nudPlusNocturnidad = new NumericUpDown();
            lblHorasExtra = new Label();
            nudHorasExtra = new NumericUpDown();
            lblHoras = new Label();
            nudHoras = new NumericUpDown();
            lblAnio = new Label();
            cmbAnio = new ComboBox();
            lblMes = new Label();
            cmbMes = new ComboBox();
            lblEmpleado = new Label();
            cmbEmpleado = new ComboBox();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            lblResumen = new Label();
            panelCentrado.SuspendLayout();
            materialCard7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNominas).BeginInit();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudIRPF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPlusTransporte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPlusFestivo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPlusNocturnidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHorasExtra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHoras).BeginInit();
            materialCard2.SuspendLayout();
            SuspendLayout();
            // 
            // panelCentrado
            // 
            panelCentrado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCentrado.AutoScroll = true;
            panelCentrado.BackColor = Color.Transparent;
            panelCentrado.Controls.Add(label2);
            panelCentrado.Controls.Add(materialCard7);
            panelCentrado.Controls.Add(materialCard1);
            panelCentrado.Controls.Add(materialCard2);
            panelCentrado.Location = new Point(0, 10);
            panelCentrado.Name = "panelCentrado";
            panelCentrado.Size = new Size(1411, 1016);
            panelCentrado.TabIndex = 0;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(30, 41, 59);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(1411, 80);
            label2.TabIndex = 3;
            label2.Text = "Gestión de Nóminas";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialCard7
            // 
            materialCard7.BackColor = Color.FromArgb(255, 255, 255);
            materialCard7.Controls.Add(btnBuscar);
            materialCard7.Controls.Add(cmbFiltroAno);
            materialCard7.Controls.Add(cmbFiltroMes);
            materialCard7.Controls.Add(cmbFiltroNombre);
            materialCard7.Controls.Add(btnGuardar);
            materialCard7.Controls.Add(btnImprimir);
            materialCard7.Controls.Add(dgvNominas);
            materialCard7.Controls.Add(lblHistorial);
            materialCard7.Depth = 0;
            materialCard7.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard7.Location = new Point(575, 348);
            materialCard7.Margin = new Padding(14);
            materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard7.Name = "materialCard7";
            materialCard7.Padding = new Padding(14);
            materialCard7.Size = new Size(626, 600);
            materialCard7.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(212, 18, 142);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(429, 71);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(180, 55);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cmbFiltroAno
            // 
            cmbFiltroAno.FormattingEnabled = true;
            cmbFiltroAno.Location = new Point(291, 88);
            cmbFiltroAno.Name = "cmbFiltroAno";
            cmbFiltroAno.Size = new Size(121, 23);
            cmbFiltroAno.TabIndex = 13;
            // 
            // cmbFiltroMes
            // 
            cmbFiltroMes.FormattingEnabled = true;
            cmbFiltroMes.Location = new Point(151, 88);
            cmbFiltroMes.Name = "cmbFiltroMes";
            cmbFiltroMes.Size = new Size(121, 23);
            cmbFiltroMes.TabIndex = 12;
            // 
            // cmbFiltroNombre
            // 
            cmbFiltroNombre.FormattingEnabled = true;
            cmbFiltroNombre.Location = new Point(17, 88);
            cmbFiltroNombre.Name = "cmbFiltroNombre";
            cmbFiltroNombre.Size = new Size(121, 23);
            cmbFiltroNombre.TabIndex = 11;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(212, 18, 142);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(17, 528);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(180, 55);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(212, 18, 142);
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.Image = (Image)resources.GetObject("btnImprimir.Image");
            btnImprimir.ImageAlign = ContentAlignment.MiddleLeft;
            btnImprimir.Location = new Point(429, 528);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(180, 55);
            btnImprimir.TabIndex = 16;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // dgvNominas
            // 
            dgvNominas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNominas.Location = new Point(17, 140);
            dgvNominas.Name = "dgvNominas";
            dgvNominas.Size = new Size(592, 382);
            dgvNominas.TabIndex = 1;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistorial.ForeColor = Color.FromArgb(180, 180, 200);
            lblHistorial.Location = new Point(17, 14);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(255, 32);
            lblHistorial.TabIndex = 0;
            lblHistorial.Text = "Historial de Nóminas";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(label3);
            materialCard1.Controls.Add(nudIRPF);
            materialCard1.Controls.Add(label1);
            materialCard1.Controls.Add(btnCalcular);
            materialCard1.Controls.Add(lblPlusTrans);
            materialCard1.Controls.Add(nudPlusTransporte);
            materialCard1.Controls.Add(lblPlusFest);
            materialCard1.Controls.Add(nudPlusFestivo);
            materialCard1.Controls.Add(lblPlusNoct);
            materialCard1.Controls.Add(nudPlusNocturnidad);
            materialCard1.Controls.Add(lblHorasExtra);
            materialCard1.Controls.Add(nudHorasExtra);
            materialCard1.Controls.Add(lblHoras);
            materialCard1.Controls.Add(nudHoras);
            materialCard1.Controls.Add(lblAnio);
            materialCard1.Controls.Add(cmbAnio);
            materialCard1.Controls.Add(lblMes);
            materialCard1.Controls.Add(cmbMes);
            materialCard1.Controls.Add(lblEmpleado);
            materialCard1.Controls.Add(cmbEmpleado);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(115, 104);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1086, 216);
            materialCard1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(829, 99);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 19;
            label3.Text = "% IRPF";
            // 
            // nudIRPF
            // 
            nudIRPF.DecimalPlaces = 2;
            nudIRPF.Location = new Point(889, 97);
            nudIRPF.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nudIRPF.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudIRPF.Name = "nudIRPF";
            nudIRPF.Size = new Size(79, 23);
            nudIRPF.TabIndex = 5;
            nudIRPF.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(180, 180, 200);
            label1.Location = new Point(21, 24);
            label1.Name = "label1";
            label1.Size = new Size(203, 32);
            label1.TabIndex = 17;
            label1.Text = "Generar Nómina";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(212, 18, 142);
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(889, 134);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(180, 55);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblPlusTrans
            // 
            lblPlusTrans.AutoSize = true;
            lblPlusTrans.Location = new Point(666, 154);
            lblPlusTrans.Name = "lblPlusTrans";
            lblPlusTrans.Size = new Size(88, 15);
            lblPlusTrans.TabIndex = 15;
            lblPlusTrans.Text = "Plus Transporte";
            // 
            // nudPlusTransporte
            // 
            nudPlusTransporte.Location = new Point(766, 152);
            nudPlusTransporte.Name = "nudPlusTransporte";
            nudPlusTransporte.Size = new Size(79, 23);
            nudPlusTransporte.TabIndex = 9;
            // 
            // lblPlusFest
            // 
            lblPlusFest.AutoSize = true;
            lblPlusFest.Location = new Point(472, 154);
            lblPlusFest.Name = "lblPlusFest";
            lblPlusFest.Size = new Size(69, 15);
            lblPlusFest.TabIndex = 13;
            lblPlusFest.Text = "Plus Festivo";
            // 
            // nudPlusFestivo
            // 
            nudPlusFestivo.Location = new Point(563, 152);
            nudPlusFestivo.Name = "nudPlusFestivo";
            nudPlusFestivo.Size = new Size(79, 23);
            nudPlusFestivo.TabIndex = 8;
            // 
            // lblPlusNoct
            // 
            lblPlusNoct.AutoSize = true;
            lblPlusNoct.Location = new Point(241, 154);
            lblPlusNoct.Name = "lblPlusNoct";
            lblPlusNoct.Size = new Size(99, 15);
            lblPlusNoct.TabIndex = 11;
            lblPlusNoct.Text = "Plus Nocturnidad";
            // 
            // nudPlusNocturnidad
            // 
            nudPlusNocturnidad.Location = new Point(351, 152);
            nudPlusNocturnidad.Name = "nudPlusNocturnidad";
            nudPlusNocturnidad.Size = new Size(94, 23);
            nudPlusNocturnidad.TabIndex = 7;
            // 
            // lblHorasExtra
            // 
            lblHorasExtra.AutoSize = true;
            lblHorasExtra.Location = new Point(21, 154);
            lblHorasExtra.Name = "lblHorasExtra";
            lblHorasExtra.Size = new Size(66, 15);
            lblHorasExtra.TabIndex = 9;
            lblHorasExtra.Text = "Horas Extra";
            // 
            // nudHorasExtra
            // 
            nudHorasExtra.Location = new Point(99, 152);
            nudHorasExtra.Name = "nudHorasExtra";
            nudHorasExtra.Size = new Size(115, 23);
            nudHorasExtra.TabIndex = 6;
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Location = new Point(638, 99);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(38, 15);
            lblHoras.TabIndex = 7;
            lblHoras.Text = "Horas";
            // 
            // nudHoras
            // 
            nudHoras.Location = new Point(703, 96);
            nudHoras.Maximum = new decimal(new int[] { 160, 0, 0, 0 });
            nudHoras.Name = "nudHoras";
            nudHoras.Size = new Size(105, 23);
            nudHoras.TabIndex = 4;
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(441, 99);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(29, 15);
            lblAnio.TabIndex = 5;
            lblAnio.Text = "Año";
            // 
            // cmbAnio
            // 
            cmbAnio.FormattingEnabled = true;
            cmbAnio.Location = new Point(487, 96);
            cmbAnio.Name = "cmbAnio";
            cmbAnio.Size = new Size(121, 23);
            cmbAnio.TabIndex = 3;
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Location = new Point(241, 99);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(29, 15);
            lblMes.TabIndex = 3;
            lblMes.Text = "Mes";
            // 
            // cmbMes
            // 
            cmbMes.FormattingEnabled = true;
            cmbMes.Location = new Point(287, 96);
            cmbMes.Name = "cmbMes";
            cmbMes.Size = new Size(121, 23);
            cmbMes.TabIndex = 2;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Location = new Point(21, 99);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(60, 15);
            lblEmpleado.TabIndex = 1;
            lblEmpleado.Text = "Empleado";
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location = new Point(93, 96);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new Size(121, 23);
            cmbEmpleado.TabIndex = 0;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(lblResumen);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(115, 348);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(445, 600);
            materialCard2.TabIndex = 1;
            // 
            // lblResumen
            // 
            lblResumen.Dock = DockStyle.Fill;
            lblResumen.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResumen.Location = new Point(14, 14);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(417, 572);
            lblResumen.TabIndex = 0;
            lblResumen.Text = "Resumen";
            // 
            // UCNominasAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(248, 250, 252);
            Controls.Add(panelCentrado);
            Name = "UCNominasAdmin";
            Padding = new Padding(20);
            Size = new Size(1411, 1026);
            panelCentrado.ResumeLayout(false);
            materialCard7.ResumeLayout(false);
            materialCard7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNominas).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudIRPF).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPlusTransporte).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPlusFestivo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPlusNocturnidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHorasExtra).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHoras).EndInit();
            materialCard2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCentrado;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Label lblAnio;
        private ComboBox cmbAnio;
        private Label lblMes;
        private ComboBox cmbMes;
        private Label lblEmpleado;
        private ComboBox cmbEmpleado;
        private Label lblHoras;
        private NumericUpDown nudHoras;
        private Label lblPlusTrans;
        private NumericUpDown nudPlusTransporte;
        private Label lblPlusFest;
        private NumericUpDown nudPlusFestivo;
        private Label lblPlusNoct;
        private NumericUpDown nudPlusNocturnidad;
        private Label lblHorasExtra;
        private NumericUpDown nudHorasExtra;
        private Button btnCalcular;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private DataGridView dgvNominas;
        private Label lblHistorial;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Button btnGuardar;
        private Label lblResumen;
        private Button btnImprimir;
        private Label label1;
        private Label label2;
        private Button btnBuscar;
        private ComboBox cmbFiltroAno;
        private ComboBox cmbFiltroMes;
        private ComboBox cmbFiltroNombre;
        private Label label3;
        private NumericUpDown nudIRPF;
    }
}

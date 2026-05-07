namespace AppRRHH.views.vistasEmpleado
{
    partial class UCNominasEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCNominasEmpleado));
            panel1 = new Panel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            dgvHistorial = new DataGridView();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            label2 = new Label();
            label1 = new Label();
            btnBuscar = new Button();
            cmbFiltroAno = new ComboBox();
            cmbFiltroMes = new ComboBox();
            lblHistorial = new Label();
            mcEstadisticas = new MaterialSkin.Controls.MaterialCard();
            lblTotalAno = new Label();
            lbl3 = new Label();
            lblNominasAno = new Label();
            lbl2 = new Label();
            lblNetoMes = new Label();
            lbl1 = new Label();
            btnImprimir = new Button();
            lblTitulo = new Label();
            panel1.SuspendLayout();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            mcEstadisticas.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(materialCard1);
            panel1.Controls.Add(mcEstadisticas);
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1396, 962);
            panel1.TabIndex = 0;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(dgvHistorial);
            materialCard1.Controls.Add(materialDivider1);
            materialCard1.Controls.Add(btnImprimir);
            materialCard1.Controls.Add(label2);
            materialCard1.Controls.Add(label1);
            materialCard1.Controls.Add(btnBuscar);
            materialCard1.Controls.Add(cmbFiltroAno);
            materialCard1.Controls.Add(cmbFiltroMes);
            materialCard1.Controls.Add(lblHistorial);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(204, 386);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1017, 458);
            materialCard1.TabIndex = 9;
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(31, 119);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.Size = new Size(937, 313);
            dgvHistorial.TabIndex = 26;
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(31, 80);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(937, 10);
            materialDivider1.TabIndex = 25;
            materialDivider1.Text = "materialDivider1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(489, 42);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 24;
            label2.Text = "Año";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(295, 42);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 23;
            label1.Text = "Mes";
            // 
            // btnBuscar
            // 
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(696, 19);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(146, 46);
            btnBuscar.TabIndex = 22;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cmbFiltroAno
            // 
            cmbFiltroAno.FormattingEnabled = true;
            cmbFiltroAno.Location = new Point(526, 39);
            cmbFiltroAno.Name = "cmbFiltroAno";
            cmbFiltroAno.Size = new Size(129, 23);
            cmbFiltroAno.TabIndex = 21;
            // 
            // cmbFiltroMes
            // 
            cmbFiltroMes.FormattingEnabled = true;
            cmbFiltroMes.Items.AddRange(new object[] { "Todos los Meses", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Nomviembre", "Diciembre" });
            cmbFiltroMes.Location = new Point(340, 40);
            cmbFiltroMes.Name = "cmbFiltroMes";
            cmbFiltroMes.Size = new Size(129, 23);
            cmbFiltroMes.TabIndex = 20;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistorial.ForeColor = Color.FromArgb(180, 180, 200);
            lblHistorial.Location = new Point(31, 31);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(116, 32);
            lblHistorial.TabIndex = 18;
            lblHistorial.Text = "Nóminas";
            // 
            // mcEstadisticas
            // 
            mcEstadisticas.BackColor = Color.FromArgb(255, 255, 255);
            mcEstadisticas.Controls.Add(lblTotalAno);
            mcEstadisticas.Controls.Add(lbl3);
            mcEstadisticas.Controls.Add(lblNominasAno);
            mcEstadisticas.Controls.Add(lbl2);
            mcEstadisticas.Controls.Add(lblNetoMes);
            mcEstadisticas.Controls.Add(lbl1);
            mcEstadisticas.Depth = 0;
            mcEstadisticas.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcEstadisticas.Location = new Point(204, 123);
            mcEstadisticas.Margin = new Padding(14);
            mcEstadisticas.MouseState = MaterialSkin.MouseState.HOVER;
            mcEstadisticas.Name = "mcEstadisticas";
            mcEstadisticas.Padding = new Padding(14);
            mcEstadisticas.Size = new Size(1017, 221);
            mcEstadisticas.TabIndex = 8;
            // 
            // lblTotalAno
            // 
            lblTotalAno.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAno.ForeColor = Color.FromArgb(88, 101, 242);
            lblTotalAno.Location = new Point(683, 80);
            lblTotalAno.Name = "lblTotalAno";
            lblTotalAno.Size = new Size(293, 80);
            lblTotalAno.TabIndex = 8;
            lblTotalAno.Text = "label2";
            lblTotalAno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            lbl3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl3.ForeColor = Color.FromArgb(200, 200, 220);
            lbl3.Location = new Point(683, 31);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(293, 30);
            lbl3.TabIndex = 7;
            lbl3.Text = "Total año";
            lbl3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNominasAno
            // 
            lblNominasAno.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNominasAno.ForeColor = Color.FromArgb(88, 101, 242);
            lblNominasAno.Location = new Point(362, 80);
            lblNominasAno.Name = "lblNominasAno";
            lblNominasAno.Size = new Size(293, 80);
            lblNominasAno.TabIndex = 6;
            lblNominasAno.Text = "label1";
            lblNominasAno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            lbl2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl2.ForeColor = Color.FromArgb(200, 200, 220);
            lbl2.Location = new Point(362, 31);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(293, 30);
            lbl2.TabIndex = 5;
            lbl2.Text = "Nóminas año";
            lbl2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNetoMes
            // 
            lblNetoMes.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNetoMes.ForeColor = Color.FromArgb(88, 101, 242);
            lblNetoMes.Location = new Point(31, 80);
            lblNetoMes.Name = "lblNetoMes";
            lblNetoMes.Size = new Size(293, 80);
            lblNetoMes.TabIndex = 4;
            lblNetoMes.Text = "label1";
            lblNetoMes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            lbl1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1.ForeColor = Color.FromArgb(150, 150, 170);
            lbl1.Location = new Point(31, 31);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(293, 30);
            lbl1.TabIndex = 3;
            lbl1.Text = "Neto último es";
            lbl1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnImprimir
            // 
            btnImprimir.Cursor = Cursors.Hand;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Image = (Image)resources.GetObject("btnImprimir.Image");
            btnImprimir.ImageAlign = ContentAlignment.MiddleLeft;
            btnImprimir.Location = new Point(856, 19);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Padding = new Padding(10, 0, 0, 0);
            btnImprimir.Size = new Size(144, 46);
            btnImprimir.TabIndex = 7;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.BorderStyle = BorderStyle.Fixed3D;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(88, 101, 242);
            lblTitulo.Location = new Point(14, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1364, 68);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Mis Nóminas";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UCNominasEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UCNominasEmpleado";
            Padding = new Padding(20);
            Size = new Size(1411, 1008);
            panel1.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            mcEstadisticas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private Button btnImprimir;
        private MaterialSkin.Controls.MaterialCard mcEstadisticas;
        private Label lblTotalAno;
        private Label lbl3;
        private Label lblNominasAno;
        private Label lbl2;
        private Label lblNetoMes;
        private Label lbl1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Button btnBuscar;
        private ComboBox cmbFiltroAno;
        private ComboBox cmbFiltroMes;
        private Label lblHistorial;
        private DataGridView dgvHistorial;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private Label label2;
        private Label label1;
    }
}

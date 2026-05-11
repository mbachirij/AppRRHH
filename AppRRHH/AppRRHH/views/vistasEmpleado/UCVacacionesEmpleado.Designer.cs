namespace AppRRHH.views.vistasEmpleado
{
    partial class UCVacacionesEmpleado
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
            panelCentrado = new Panel();
            label2 = new Label();
            label1 = new Label();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            dgvHistorial = new DataGridView();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            btnSolicitar = new Button();
            dtpFin = new DateTimePicker();
            lblFin = new Label();
            dtpInicio = new DateTimePicker();
            lblInicio = new Label();
            lblTitulo = new Label();
            lblDiasDisponibles = new Label();
            panelCentrado.SuspendLayout();
            materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // panelCentrado
            // 
            panelCentrado.BackColor = Color.FromArgb(248, 250, 252);
            panelCentrado.Controls.Add(label2);
            panelCentrado.Controls.Add(label1);
            panelCentrado.Controls.Add(materialCard2);
            panelCentrado.Controls.Add(materialCard1);
            panelCentrado.Controls.Add(lblDiasDisponibles);
            panelCentrado.Location = new Point(0, 10);
            panelCentrado.Name = "panelCentrado";
            panelCentrado.Size = new Size(1411, 962);
            panelCentrado.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(30, 41, 59);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(1411, 94);
            label2.TabIndex = 9;
            label2.Text = "Gestión de Vacaciones";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(30, 41, 59);
            label1.Location = new Point(169, 165);
            label1.Name = "label1";
            label1.Size = new Size(229, 41);
            label1.TabIndex = 8;
            label1.Text = "Mis Vacaciones";
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(dgvHistorial);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(679, 275);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(500, 320);
            materialCard2.TabIndex = 7;
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Dock = DockStyle.Fill;
            dgvHistorial.Location = new Point(14, 14);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.Size = new Size(472, 292);
            dgvHistorial.TabIndex = 6;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(btnSolicitar);
            materialCard1.Controls.Add(dtpFin);
            materialCard1.Controls.Add(lblFin);
            materialCard1.Controls.Add(dtpInicio);
            materialCard1.Controls.Add(lblInicio);
            materialCard1.Controls.Add(lblTitulo);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(169, 275);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(480, 320);
            materialCard1.TabIndex = 1;
            // 
            // btnSolicitar
            // 
            btnSolicitar.Location = new Point(130, 230);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(200, 42);
            btnSolicitar.TabIndex = 5;
            btnSolicitar.Text = "Solicitar Vacaciones";
            btnSolicitar.UseVisualStyleBackColor = true;
            btnSolicitar.Click += btnSolicitar_Click;
            // 
            // dtpFin
            // 
            dtpFin.Location = new Point(126, 106);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(219, 23);
            dtpFin.TabIndex = 4;
            // 
            // lblFin
            // 
            lblFin.AutoSize = true;
            lblFin.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFin.ForeColor = Color.FromArgb(100, 100, 120);
            lblFin.Location = new Point(20, 106);
            lblFin.Name = "lblFin";
            lblFin.Size = new Size(69, 19);
            lblFin.TabIndex = 3;
            lblFin.Text = "Fecha Fin:";
            // 
            // dtpInicio
            // 
            dtpInicio.Location = new Point(126, 65);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(219, 23);
            dtpInicio.TabIndex = 2;
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInicio.ForeColor = Color.FromArgb(100, 100, 120);
            lblInicio.Location = new Point(20, 68);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(83, 19);
            lblInicio.TabIndex = 1;
            lblInicio.Text = "Fecha Inicio:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(88, 101, 242);
            lblTitulo.Location = new Point(17, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(216, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Solicitar Vacaciones";
            // 
            // lblDiasDisponibles
            // 
            lblDiasDisponibles.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiasDisponibles.ForeColor = Color.FromArgb(30, 41, 59);
            lblDiasDisponibles.Location = new Point(369, 215);
            lblDiasDisponibles.Name = "lblDiasDisponibles";
            lblDiasDisponibles.Size = new Size(600, 40);
            lblDiasDisponibles.TabIndex = 0;
            lblDiasDisponibles.Text = "label1";
            lblDiasDisponibles.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UCVacacionesEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            Controls.Add(panelCentrado);
            Name = "UCVacacionesEmpleado";
            Size = new Size(1411, 1008);
            panelCentrado.ResumeLayout(false);
            panelCentrado.PerformLayout();
            materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCentrado;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Label lblDiasDisponibles;
        private Label lblFin;
        private DateTimePicker dtpInicio;
        private Label lblInicio;
        private Label lblTitulo;
        private DataGridView dgvHistorial;
        private Button btnSolicitar;
        private DateTimePicker dtpFin;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Label label1;
        private Label label2;
    }
}

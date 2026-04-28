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
            panelCentrado.Controls.Add(materialCard2);
            panelCentrado.Controls.Add(materialCard1);
            panelCentrado.Controls.Add(lblDiasDisponibles);
            panelCentrado.Location = new Point(14, 16);
            panelCentrado.Name = "panelCentrado";
            panelCentrado.Size = new Size(1054, 551);
            panelCentrado.TabIndex = 0;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(dgvHistorial);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(507, 92);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(509, 248);
            materialCard2.TabIndex = 7;
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(17, 17);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.Size = new Size(464, 214);
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
            materialCard1.Location = new Point(24, 92);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(455, 248);
            materialCard1.TabIndex = 1;
            // 
            // btnSolicitar
            // 
            btnSolicitar.Location = new Point(166, 171);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(179, 45);
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
            lblFin.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFin.Location = new Point(17, 103);
            lblFin.Name = "lblFin";
            lblFin.Size = new Size(86, 28);
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
            lblInicio.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInicio.Location = new Point(17, 60);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(103, 28);
            lblInicio.TabIndex = 1;
            lblInicio.Text = "Fecha Inicio:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(17, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(154, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Solicitar Vacaciones";
            // 
            // lblDiasDisponibles
            // 
            lblDiasDisponibles.AutoSize = true;
            lblDiasDisponibles.Font = new Font("Sitka Banner", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiasDisponibles.Location = new Point(454, 19);
            lblDiasDisponibles.Name = "lblDiasDisponibles";
            lblDiasDisponibles.Size = new Size(82, 43);
            lblDiasDisponibles.TabIndex = 0;
            lblDiasDisponibles.Text = "label1";
            // 
            // UCVacacionesEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelCentrado);
            Name = "UCVacacionesEmpleado";
            Size = new Size(1091, 583);
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
    }
}

namespace AppRRHH.views.vistasEmpleado
{
    partial class UCEmpleadoFichajes
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            lblContadorHoras = new Label();
            lblReloj = new Label();
            lblFecha = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnFichar = new Button();
            dgvHistorial = new DataGridView();
            panelCentrado = new Panel();
            lblTitulo = new Label();
            label1 = new Label();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            panelCentrado.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(lblContadorHoras);
            materialCard1.Controls.Add(lblReloj);
            materialCard1.Controls.Add(btnFichar);
            materialCard1.Controls.Add(lblFecha);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(30, 70);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(500, 350);
            materialCard1.TabIndex = 0;
            // 
            // lblContadorHoras
            // 
            lblContadorHoras.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContadorHoras.ForeColor = Color.FromArgb(200, 200, 220);
            lblContadorHoras.Location = new Point(20, 150);
            lblContadorHoras.Name = "lblContadorHoras";
            lblContadorHoras.Size = new Size(460, 30);
            lblContadorHoras.TabIndex = 2;
            lblContadorHoras.Text = "label1";
            lblContadorHoras.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblReloj
            // 
            lblReloj.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReloj.ForeColor = Color.FromArgb(88, 101, 242);
            lblReloj.Location = new Point(20, 60);
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(460, 80);
            lblReloj.TabIndex = 1;
            lblReloj.Text = "label1";
            lblReloj.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            lblFecha.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = Color.FromArgb(150, 150, 170);
            lblFecha.Location = new Point(20, 20);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(460, 30);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "label1";
            lblFecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btnFichar
            // 
            btnFichar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFichar.ForeColor = SystemColors.Control;
            btnFichar.Location = new Point(23, 273);
            btnFichar.Name = "btnFichar";
            btnFichar.Size = new Size(460, 60);
            btnFichar.TabIndex = 2;
            btnFichar.Text = "Fichar Entrada";
            btnFichar.UseVisualStyleBackColor = true;
            btnFichar.Click += btnFichar_Click;
            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.BackgroundColor = Color.White;
            dgvHistorial.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHistorial.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHistorial.EnableHeadersVisualStyles = false;
            dgvHistorial.GridColor = Color.LightGray;
            dgvHistorial.Location = new Point(560, 100);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dgvHistorial.RowHeadersVisible = false;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dgvHistorial.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.Size = new Size(500, 320);
            dgvHistorial.TabIndex = 0;
            // 
            // panelCentrado
            // 
            panelCentrado.Anchor = AnchorStyles.None;
            panelCentrado.Controls.Add(label1);
            panelCentrado.Controls.Add(lblTitulo);
            panelCentrado.Controls.Add(dgvHistorial);
            panelCentrado.Controls.Add(materialCard1);
            panelCentrado.Location = new Point(17, 26);
            panelCentrado.Name = "panelCentrado";
            panelCentrado.Size = new Size(1076, 543);
            panelCentrado.TabIndex = 5;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(88, 101, 242);
            lblTitulo.Location = new Point(30, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(337, 45);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Control de Asistencia";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(88, 101, 242);
            label1.Location = new Point(560, 30);
            label1.Name = "label1";
            label1.Size = new Size(320, 45);
            label1.TabIndex = 4;
            label1.Text = "Historial de Fichajes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UCEmpleadoFichajes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.Control;
            Controls.Add(panelCentrado);
            ForeColor = SystemColors.ControlText;
            Name = "UCEmpleadoFichajes";
            Size = new Size(1109, 586);
            Load += UCEmpleadoFichajes_Load;
            materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            panelCentrado.ResumeLayout(false);
            panelCentrado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Label lblContadorHoras;
        private Label lblReloj;
        private Label lblFecha;
        private System.Windows.Forms.Timer timer1;
        private Button btnFichar;
        private DataGridView dgvHistorial;
        private Panel panelCentrado;
        private Label lblTitulo;
        private Label label1;
    }
}

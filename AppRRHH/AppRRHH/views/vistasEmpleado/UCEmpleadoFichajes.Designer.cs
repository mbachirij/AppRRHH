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
            txtNotas = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            btnFichar = new Button();
            dgvHistorial = new DataGridView();
            panelCentrado = new Panel();
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
            materialCard1.Controls.Add(lblFecha);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(46, 37);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(426, 201);
            materialCard1.TabIndex = 0;
            // 
            // lblContadorHoras
            // 
            lblContadorHoras.AutoSize = true;
            lblContadorHoras.Location = new Point(193, 135);
            lblContadorHoras.Name = "lblContadorHoras";
            lblContadorHoras.Size = new Size(38, 15);
            lblContadorHoras.TabIndex = 2;
            lblContadorHoras.Text = "label1";
            lblContadorHoras.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblReloj
            // 
            lblReloj.AutoSize = true;
            lblReloj.Location = new Point(191, 73);
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(38, 15);
            lblReloj.TabIndex = 1;
            lblReloj.Text = "label1";
            lblReloj.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(191, 14);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "label1";
            lblFecha.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtNotas
            // 
            txtNotas.Location = new Point(46, 285);
            txtNotas.Name = "txtNotas";
            txtNotas.Size = new Size(426, 23);
            txtNotas.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btnFichar
            // 
            btnFichar.Location = new Point(46, 358);
            btnFichar.Name = "btnFichar";
            btnFichar.Size = new Size(426, 74);
            btnFichar.TabIndex = 2;
            btnFichar.Text = "Fichar Entrada";
            btnFichar.UseVisualStyleBackColor = true;
            btnFichar.Click += btnFichar_Click;
            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
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
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHistorial.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHistorial.EnableHeadersVisualStyles = false;
            dgvHistorial.GridColor = Color.LightGray;
            dgvHistorial.Location = new Point(547, 37);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dgvHistorial.RowHeadersVisible = false;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dgvHistorial.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.Size = new Size(426, 395);
            dgvHistorial.TabIndex = 0;
            // 
            // panelCentrado
            // 
            panelCentrado.Anchor = AnchorStyles.None;
            panelCentrado.Controls.Add(dgvHistorial);
            panelCentrado.Controls.Add(btnFichar);
            panelCentrado.Controls.Add(materialCard1);
            panelCentrado.Controls.Add(txtNotas);
            panelCentrado.Location = new Point(17, 26);
            panelCentrado.Name = "panelCentrado";
            panelCentrado.Size = new Size(1040, 543);
            panelCentrado.TabIndex = 5;
            // 
            // UCEmpleadoFichajes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = SystemColors.Control;
            Controls.Add(panelCentrado);
            ForeColor = Color.White;
            Name = "UCEmpleadoFichajes";
            Size = new Size(1109, 586);
            Load += UCEmpleadoFichajes_Load;
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
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
        private TextBox txtNotas;
        private System.Windows.Forms.Timer timer1;
        private Button btnFichar;
        private DataGridView dgvHistorial;
        private Panel panelCentrado;
    }
}

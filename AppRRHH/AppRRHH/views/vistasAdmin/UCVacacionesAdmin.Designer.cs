namespace AppRRHH.views.vistasAdmin
{
    partial class UCVacacionesAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCVacacionesAdmin));
            panelContenido = new Panel();
            label2 = new Label();
            lblHistorial = new Label();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            dgvHistorial = new DataGridView();
            label1 = new Label();
            lblTitulo = new Label();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            btnRechazar = new Button();
            btnAprobar = new Button();
            dgvPendientes = new DataGridView();
            lblSoliciPend = new Label();
            panelContenido.SuspendLayout();
            materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendientes).BeginInit();
            SuspendLayout();
            // 
            // panelContenido
            // 
            panelContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContenido.AutoScroll = true;
            panelContenido.BackColor = Color.Transparent;
            panelContenido.Controls.Add(label2);
            panelContenido.Controls.Add(lblHistorial);
            panelContenido.Controls.Add(materialCard2);
            panelContenido.Controls.Add(lblTitulo);
            panelContenido.Controls.Add(materialCard1);
            panelContenido.Location = new Point(0, 10);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1411, 962);
            panelContenido.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(30, 41, 59);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(1411, 80);
            label2.TabIndex = 4;
            label2.Text = "Gestión de Vacaciones";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold);
            lblHistorial.ForeColor = Color.FromArgb(30, 41, 59);
            lblHistorial.Location = new Point(736, 156);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(160, 47);
            lblHistorial.TabIndex = 3;
            lblHistorial.Text = "Historial";
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(dgvHistorial);
            materialCard2.Controls.Add(label1);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(736, 238);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(434, 398);
            materialCard2.TabIndex = 2;
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(17, 60);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.Size = new Size(400, 260);
            dgvHistorial.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(180, 180, 200);
            label1.Location = new Point(17, 23);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 1;
            label1.Text = "Historial Completo";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 41, 59);
            lblTitulo.Location = new Point(144, 156);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(387, 47);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Solicitudes Vacaciones";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(btnRechazar);
            materialCard1.Controls.Add(btnAprobar);
            materialCard1.Controls.Add(dgvPendientes);
            materialCard1.Controls.Add(lblSoliciPend);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(144, 238);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(434, 398);
            materialCard1.TabIndex = 0;
            // 
            // btnRechazar
            // 
            btnRechazar.Image = (Image)resources.GetObject("btnRechazar.Image");
            btnRechazar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRechazar.Location = new Point(17, 340);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(146, 41);
            btnRechazar.TabIndex = 3;
            btnRechazar.Text = "Rechazar";
            btnRechazar.UseVisualStyleBackColor = true;
            btnRechazar.Click += btnRechazar_Click;
            // 
            // btnAprobar
            // 
            btnAprobar.Image = (Image)resources.GetObject("btnAprobar.Image");
            btnAprobar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAprobar.Location = new Point(271, 340);
            btnAprobar.Name = "btnAprobar";
            btnAprobar.Size = new Size(146, 41);
            btnAprobar.TabIndex = 2;
            btnAprobar.Text = "Aprobar";
            btnAprobar.UseVisualStyleBackColor = true;
            btnAprobar.Click += btnAprobar_Click;
            // 
            // dgvPendientes
            // 
            dgvPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPendientes.Location = new Point(17, 60);
            dgvPendientes.Name = "dgvPendientes";
            dgvPendientes.Size = new Size(400, 260);
            dgvPendientes.TabIndex = 1;
            // 
            // lblSoliciPend
            // 
            lblSoliciPend.AutoSize = true;
            lblSoliciPend.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoliciPend.ForeColor = Color.FromArgb(180, 180, 200);
            lblSoliciPend.Location = new Point(17, 23);
            lblSoliciPend.Name = "lblSoliciPend";
            lblSoliciPend.Size = new Size(165, 20);
            lblSoliciPend.TabIndex = 0;
            lblSoliciPend.Text = "Solicitudes Pendientes";
            // 
            // UCVacacionesAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(248, 250, 252);
            Controls.Add(panelContenido);
            Name = "UCVacacionesAdmin";
            Size = new Size(1411, 1008);
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenido;
        private Label lblTitulo;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Button btnRechazar;
        private Button btnAprobar;
        private DataGridView dgvPendientes;
        private Label lblSoliciPend;
        private Label lblHistorial;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private DataGridView dgvHistorial;
        private Label label1;
        private Label label2;
    }
}

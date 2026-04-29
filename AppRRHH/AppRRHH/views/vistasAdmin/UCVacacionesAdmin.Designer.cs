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
            panelContenido.Anchor = AnchorStyles.None;
            panelContenido.Controls.Add(lblHistorial);
            panelContenido.Controls.Add(materialCard2);
            panelContenido.Controls.Add(lblTitulo);
            panelContenido.Controls.Add(materialCard1);
            panelContenido.Location = new Point(14, 17);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1119, 546);
            panelContenido.TabIndex = 0;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Sitka Banner", 25.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHistorial.Location = new Point(633, 39);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(136, 50);
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
            materialCard2.Location = new Point(633, 121);
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
            label1.Location = new Point(17, 23);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 1;
            label1.Text = "Historial Completo";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Sitka Banner", 25.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(41, 39);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(314, 50);
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
            materialCard1.Location = new Point(41, 121);
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
            btnRechazar.Size = new Size(125, 37);
            btnRechazar.TabIndex = 3;
            btnRechazar.Text = "Rechazar";
            btnRechazar.UseVisualStyleBackColor = true;
            btnRechazar.Click += btnRechazar_Click;
            // 
            // btnAprobar
            // 
            btnAprobar.Image = (Image)resources.GetObject("btnAprobar.Image");
            btnAprobar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAprobar.Location = new Point(292, 340);
            btnAprobar.Name = "btnAprobar";
            btnAprobar.Size = new Size(125, 37);
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
            lblSoliciPend.Location = new Point(17, 23);
            lblSoliciPend.Name = "lblSoliciPend";
            lblSoliciPend.Size = new Size(125, 15);
            lblSoliciPend.TabIndex = 0;
            lblSoliciPend.Text = "Solicitudes Pendientes";
            // 
            // UCVacacionesAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContenido);
            Name = "UCVacacionesAdmin";
            Size = new Size(1149, 578);
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
    }
}

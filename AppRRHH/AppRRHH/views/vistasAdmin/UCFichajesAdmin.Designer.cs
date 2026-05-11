namespace AppRRHH.views.vistasAdmin
{
    partial class UCFichajesAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCFichajesAdmin));
            panel1 = new Panel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            dgvDiaria = new DataGridView();
            dtpDia = new DateTimePicker();
            btnBuscarDia = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDiaria).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(materialCard1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1411, 962);
            panel1.TabIndex = 0;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(dgvDiaria);
            materialCard1.Controls.Add(dtpDia);
            materialCard1.Controls.Add(btnBuscarDia);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(208, 197);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1010, 555);
            materialCard1.TabIndex = 17;
            // 
            // dgvDiaria
            // 
            dgvDiaria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiaria.Location = new Point(63, 192);
            dgvDiaria.Name = "dgvDiaria";
            dgvDiaria.Size = new Size(880, 335);
            dgvDiaria.TabIndex = 16;
            // 
            // dtpDia
            // 
            dtpDia.Location = new Point(246, 97);
            dtpDia.Name = "dtpDia";
            dtpDia.Size = new Size(244, 23);
            dtpDia.TabIndex = 0;
            // 
            // btnBuscarDia
            // 
            btnBuscarDia.BackColor = Color.FromArgb(212, 18, 142);
            btnBuscarDia.FlatStyle = FlatStyle.Flat;
            btnBuscarDia.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarDia.ForeColor = Color.White;
            btnBuscarDia.Image = (Image)resources.GetObject("btnBuscarDia.Image");
            btnBuscarDia.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarDia.Location = new Point(569, 82);
            btnBuscarDia.Name = "btnBuscarDia";
            btnBuscarDia.Size = new Size(180, 55);
            btnBuscarDia.TabIndex = 15;
            btnBuscarDia.Text = "BUSCAR";
            btnBuscarDia.UseVisualStyleBackColor = false;
            btnBuscarDia.Click += btnBuscarDia_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(30, 41, 59);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(1411, 98);
            label2.TabIndex = 4;
            label2.Text = "Gestión de Fichajes";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UCFichajesAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(248, 250, 252);
            Controls.Add(panel1);
            Name = "UCFichajesAdmin";
            Size = new Size(1411, 1008);
            panel1.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDiaria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private DataGridView dgvDiaria;
        private DateTimePicker dtpDia;
        private Button btnBuscarDia;
    }
}

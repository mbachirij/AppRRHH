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
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            lblContadorHoras = new Label();
            lblReloj = new Label();
            lblFecha = new Label();
            txtNotas = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            btnFichar = new Button();
            materialCard1.SuspendLayout();
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
            materialCard1.Location = new Point(338, 51);
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
            txtNotas.Location = new Point(338, 278);
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
            btnFichar.Location = new Point(338, 330);
            btnFichar.Name = "btnFichar";
            btnFichar.Size = new Size(426, 74);
            btnFichar.TabIndex = 2;
            btnFichar.Text = "Fichar Entrada";
            btnFichar.UseVisualStyleBackColor = true;
            btnFichar.Click += btnFichar_Click;
            // 
            // UCEmpleadoFichajes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = SystemColors.Control;
            Controls.Add(btnFichar);
            Controls.Add(txtNotas);
            Controls.Add(materialCard1);
            ForeColor = Color.White;
            Name = "UCEmpleadoFichajes";
            Size = new Size(1109, 586);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Label lblContadorHoras;
        private Label lblReloj;
        private Label lblFecha;
        private TextBox txtNotas;
        private System.Windows.Forms.Timer timer1;
        private Button btnFichar;
    }
}

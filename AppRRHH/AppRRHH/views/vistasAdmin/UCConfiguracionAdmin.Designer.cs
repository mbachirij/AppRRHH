namespace AppRRHH.views.vistasAdmin
{
    partial class UCConfiguracionAdmin
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
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            btnGuardar = new Button();
            txtNumCuentaCotizacion = new TextBox();
            lblNumSS = new Label();
            txtCodigoPostal = new TextBox();
            lblCP = new Label();
            txtMunicipio = new TextBox();
            lblMunicipio = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            txtCIF = new TextBox();
            lblCIF = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            lblTitulo = new Label();
            panelCentrado.SuspendLayout();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // panelCentrado
            // 
            panelCentrado.Controls.Add(label2);
            panelCentrado.Controls.Add(materialCard1);
            panelCentrado.Location = new Point(10, 10);
            panelCentrado.Name = "panelCentrado";
            panelCentrado.Size = new Size(1396, 962);
            panelCentrado.TabIndex = 0;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(88, 101, 242);
            label2.Location = new Point(14, 12);
            label2.Name = "label2";
            label2.Size = new Size(1339, 68);
            label2.TabIndex = 3;
            label2.Text = "Gestión de Datos Empresa";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(btnGuardar);
            materialCard1.Controls.Add(txtNumCuentaCotizacion);
            materialCard1.Controls.Add(lblNumSS);
            materialCard1.Controls.Add(txtCodigoPostal);
            materialCard1.Controls.Add(lblCP);
            materialCard1.Controls.Add(txtMunicipio);
            materialCard1.Controls.Add(lblMunicipio);
            materialCard1.Controls.Add(txtDireccion);
            materialCard1.Controls.Add(lblDireccion);
            materialCard1.Controls.Add(txtCIF);
            materialCard1.Controls.Add(lblCIF);
            materialCard1.Controls.Add(txtNombre);
            materialCard1.Controls.Add(label1);
            materialCard1.Controls.Add(lblTitulo);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(191, 173);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(908, 520);
            materialCard1.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(352, 291);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(211, 101);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNumCuentaCotizacion
            // 
            txtNumCuentaCotizacion.Location = new Point(632, 157);
            txtNumCuentaCotizacion.Name = "txtNumCuentaCotizacion";
            txtNumCuentaCotizacion.Size = new Size(191, 23);
            txtNumCuentaCotizacion.TabIndex = 12;
            // 
            // lblNumSS
            // 
            lblNumSS.AutoSize = true;
            lblNumSS.Location = new Point(490, 160);
            lblNumSS.Name = "lblNumSS";
            lblNumSS.Size = new Size(136, 15);
            lblNumSS.TabIndex = 11;
            lblNumSS.Text = "Nº Cuenta Cotización SS";
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Location = new Point(364, 157);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(104, 23);
            txtCodigoPostal.TabIndex = 10;
            // 
            // lblCP
            // 
            lblCP.AutoSize = true;
            lblCP.Location = new Point(277, 160);
            lblCP.Name = "lblCP";
            lblCP.Size = new Size(81, 15);
            lblCP.TabIndex = 9;
            lblCP.Text = "Código Postal";
            // 
            // txtMunicipio
            // 
            txtMunicipio.Location = new Point(127, 157);
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.Size = new Size(122, 23);
            txtMunicipio.TabIndex = 8;
            // 
            // lblMunicipio
            // 
            lblMunicipio.AutoSize = true;
            lblMunicipio.Location = new Point(60, 160);
            lblMunicipio.Name = "lblMunicipio";
            lblMunicipio.Size = new Size(61, 15);
            lblMunicipio.TabIndex = 7;
            lblMunicipio.Text = "Municipio";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(675, 98);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(191, 23);
            txtDireccion.TabIndex = 6;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(612, 104);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 5;
            lblDireccion.Text = "Dirección";
            // 
            // txtCIF
            // 
            txtCIF.Location = new Point(412, 98);
            txtCIF.Name = "txtCIF";
            txtCIF.Size = new Size(176, 23);
            txtCIF.TabIndex = 4;
            // 
            // lblCIF
            // 
            lblCIF.AutoSize = true;
            lblCIF.Location = new Point(382, 104);
            lblCIF.Name = "lblCIF";
            lblCIF.Size = new Size(24, 15);
            lblCIF.TabIndex = 3;
            lblCIF.Text = "CIF";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(165, 98);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(191, 23);
            txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 101);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre Empresa";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(310, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(310, 39);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Datos de la Empresa";
            // 
            // UCConfiguracionAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelCentrado);
            Name = "UCConfiguracionAdmin";
            Size = new Size(1411, 1008);
            panelCentrado.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCentrado;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Label lblTitulo;
        private TextBox txtNumCuentaCotizacion;
        private Label lblNumSS;
        private TextBox txtCodigoPostal;
        private Label lblCP;
        private TextBox txtMunicipio;
        private Label lblMunicipio;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private TextBox txtCIF;
        private Label lblCIF;
        private TextBox txtNombre;
        private Label label1;
        private Button btnGuardar;
        private Label label2;
    }
}

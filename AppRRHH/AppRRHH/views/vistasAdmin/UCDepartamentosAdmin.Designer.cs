namespace AppRRHH.views.vistasAdmin
{
    partial class UCDepartamentosAdmin
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
            Card1 = new MaterialSkin.Controls.MaterialCard();
            label3 = new Label();
            lblTotalDeptos = new Label();
            label1 = new Label();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            lblPromedio = new Label();
            lblPr = new Label();
            label2 = new Label();
            lstDepartamentos = new MaterialSkin.Controls.MaterialListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            lstEmpleadosDepto = new MaterialSkin.Controls.MaterialListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            txtNuevoDepto = new MaterialSkin.Controls.MaterialTextBox();
            btnGuardar = new MaterialSkin.Controls.MaterialButton();
            panelContenido = new Panel();
            label7 = new Label();
            label6 = new Label();
            btnEliminar = new MaterialSkin.Controls.MaterialButton();
            label5 = new Label();
            label4 = new Label();
            Card1.SuspendLayout();
            materialCard1.SuspendLayout();
            panelContenido.SuspendLayout();
            SuspendLayout();
            // 
            // Card1
            // 
            Card1.BackColor = Color.FromArgb(255, 255, 255);
            Card1.Controls.Add(label3);
            Card1.Controls.Add(lblTotalDeptos);
            Card1.Controls.Add(label1);
            Card1.Depth = 0;
            Card1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            Card1.Location = new Point(607, 114);
            Card1.Margin = new Padding(14);
            Card1.MouseState = MaterialSkin.MouseState.HOVER;
            Card1.Name = "Card1";
            Card1.Padding = new Padding(14);
            Card1.Size = new Size(275, 167);
            Card1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(150, 150, 170);
            label3.Location = new Point(0, 129);
            label3.Name = "label3";
            label3.Size = new Size(275, 38);
            label3.TabIndex = 7;
            label3.Text = "\"registrados\"";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalDeptos
            // 
            lblTotalDeptos.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDeptos.ForeColor = Color.FromArgb(88, 101, 242);
            lblTotalDeptos.Location = new Point(0, 55);
            lblTotalDeptos.Name = "lblTotalDeptos";
            lblTotalDeptos.Size = new Size(275, 75);
            lblTotalDeptos.TabIndex = 4;
            lblTotalDeptos.Text = "label4";
            lblTotalDeptos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(150, 150, 170);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(275, 55);
            label1.TabIndex = 2;
            label1.Text = "Total Departamentos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(lblPromedio);
            materialCard1.Controls.Add(lblPr);
            materialCard1.Controls.Add(label2);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(52, 114);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(268, 167);
            materialCard1.TabIndex = 1;
            // 
            // lblPromedio
            // 
            lblPromedio.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPromedio.ForeColor = Color.FromArgb(88, 101, 242);
            lblPromedio.Location = new Point(0, 55);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(268, 75);
            lblPromedio.TabIndex = 4;
            lblPromedio.Text = "label3";
            lblPromedio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPr
            // 
            lblPr.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPr.ForeColor = Color.FromArgb(150, 150, 170);
            lblPr.Location = new Point(0, 130);
            lblPr.Name = "lblPr";
            lblPr.Size = new Size(268, 38);
            lblPr.TabIndex = 6;
            lblPr.Text = "\"por departamento\"";
            lblPr.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(150, 150, 170);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(268, 55);
            label2.TabIndex = 3;
            label2.Text = "Promedio de Empleados";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lstDepartamentos.AutoSizeTable = false;
            lstDepartamentos.BackColor = Color.FromArgb(255, 255, 255);
            lstDepartamentos.BorderStyle = BorderStyle.None;
            lstDepartamentos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lstDepartamentos.Depth = 0;
            lstDepartamentos.FullRowSelect = true;
            lstDepartamentos.Location = new Point(52, 424);
            lstDepartamentos.MinimumSize = new Size(200, 100);
            lstDepartamentos.MouseLocation = new Point(-1, -1);
            lstDepartamentos.MouseState = MaterialSkin.MouseState.OUT;
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.OwnerDraw = true;
            lstDepartamentos.Size = new Size(277, 292);
            lstDepartamentos.TabIndex = 2;
            lstDepartamentos.UseCompatibleStateImageBehavior = false;
            lstDepartamentos.View = View.Details;
            lstDepartamentos.SelectedIndexChanged += lstDepartamentos_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nombre Dept";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nº Empleados";
            columnHeader2.Width = 150;
            // 
            // lstEmpleadosDepto
            // 
            lstEmpleadosDepto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstEmpleadosDepto.AutoSizeTable = false;
            lstEmpleadosDepto.BackColor = Color.FromArgb(255, 255, 255);
            lstEmpleadosDepto.BorderStyle = BorderStyle.None;
            lstEmpleadosDepto.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4, columnHeader5 });
            lstEmpleadosDepto.Depth = 0;
            lstEmpleadosDepto.FullRowSelect = true;
            lstEmpleadosDepto.Location = new Point(579, 424);
            lstEmpleadosDepto.MinimumSize = new Size(200, 100);
            lstEmpleadosDepto.MouseLocation = new Point(-1, -1);
            lstEmpleadosDepto.MouseState = MaterialSkin.MouseState.OUT;
            lstEmpleadosDepto.Name = "lstEmpleadosDepto";
            lstEmpleadosDepto.OwnerDraw = true;
            lstEmpleadosDepto.Size = new Size(350, 292);
            lstEmpleadosDepto.TabIndex = 3;
            lstEmpleadosDepto.UseCompatibleStateImageBehavior = false;
            lstEmpleadosDepto.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Nombre";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Apellidos";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Rol";
            columnHeader5.Width = 100;
            // 
            // txtNuevoDepto
            // 
            txtNuevoDepto.AnimateReadOnly = false;
            txtNuevoDepto.BorderStyle = BorderStyle.None;
            txtNuevoDepto.Depth = 0;
            txtNuevoDepto.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNuevoDepto.LeadingIcon = null;
            txtNuevoDepto.Location = new Point(300, 303);
            txtNuevoDepto.MaxLength = 50;
            txtNuevoDepto.MouseState = MaterialSkin.MouseState.OUT;
            txtNuevoDepto.Multiline = false;
            txtNuevoDepto.Name = "txtNuevoDepto";
            txtNuevoDepto.Size = new Size(253, 50);
            txtNuevoDepto.TabIndex = 4;
            txtNuevoDepto.Text = "";
            txtNuevoDepto.TrailingIcon = null;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGuardar.Depth = 0;
            btnGuardar.HighEmphasis = true;
            btnGuardar.Icon = null;
            btnGuardar.Location = new Point(593, 312);
            btnGuardar.Margin = new Padding(4, 6, 4, 6);
            btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.NoAccentTextColor = Color.Empty;
            btnGuardar.Size = new Size(88, 36);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardar.UseAccentColor = false;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panelContenido
            // 
            panelContenido.Anchor = AnchorStyles.None;
            panelContenido.BackColor = Color.Transparent;
            panelContenido.Controls.Add(label7);
            panelContenido.Controls.Add(label6);
            panelContenido.Controls.Add(btnEliminar);
            panelContenido.Controls.Add(label5);
            panelContenido.Controls.Add(label4);
            panelContenido.Controls.Add(materialCard1);
            panelContenido.Controls.Add(lstEmpleadosDepto);
            panelContenido.Controls.Add(txtNuevoDepto);
            panelContenido.Controls.Add(lstDepartamentos);
            panelContenido.Controls.Add(btnGuardar);
            panelContenido.Controls.Add(Card1);
            panelContenido.Location = new Point(15, 11);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1045, 738);
            panelContenido.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(200, 210, 255);
            label7.Location = new Point(657, 385);
            label7.Name = "label7";
            label7.Size = new Size(104, 25);
            label7.TabIndex = 10;
            label7.Text = "Empleados";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(200, 210, 255);
            label6.Location = new Point(98, 385);
            label6.Name = "label6";
            label6.Size = new Size(141, 25);
            label6.TabIndex = 9;
            label6.Text = "Departamentos";
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEliminar.Depth = 0;
            btnEliminar.HighEmphasis = true;
            btnEliminar.Icon = null;
            btnEliminar.Location = new Point(401, 424);
            btnEliminar.Margin = new Padding(4, 6, 4, 6);
            btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.NoAccentTextColor = Color.Empty;
            btnEliminar.Size = new Size(88, 36);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "eliminar";
            btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEliminar.UseAccentColor = false;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(200, 210, 255);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(1042, 113);
            label5.TabIndex = 7;
            label5.Text = "Gestión de Departamentos";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(200, 210, 255);
            label4.Location = new Point(64, 323);
            label4.Name = "label4";
            label4.Size = new Size(202, 25);
            label4.TabIndex = 6;
            label4.Text = "Nuevo Departamento: ";
            // 
            // UCDepartamentosAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContenido);
            Location = new Point(17, 11);
            Name = "UCDepartamentosAdmin";
            Padding = new Padding(20);
            Size = new Size(1197, 772);
            Card1.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard Card1;
        private Label label1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Label label2;
        private MaterialSkin.Controls.MaterialListView lstDepartamentos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private MaterialSkin.Controls.MaterialListView lstEmpleadosDepto;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label lblTotalDeptos;
        private Label lblPromedio;
        private MaterialSkin.Controls.MaterialTextBox txtNuevoDepto;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private Panel panelContenido;
        private Label label3;
        private Label lblPr;
        private Label label4;
        private Label label5;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private Label label7;
        private Label label6;
    }
}

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
            lblTotalDeptos = new Label();
            label1 = new Label();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            lblPromedio = new Label();
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
            Card1.SuspendLayout();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // Card1
            // 
            Card1.BackColor = Color.FromArgb(255, 255, 255);
            Card1.Controls.Add(lblTotalDeptos);
            Card1.Controls.Add(label1);
            Card1.Depth = 0;
            Card1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            Card1.Location = new Point(81, 53);
            Card1.Margin = new Padding(14);
            Card1.MouseState = MaterialSkin.MouseState.HOVER;
            Card1.Name = "Card1";
            Card1.Padding = new Padding(14);
            Card1.Size = new Size(212, 138);
            Card1.TabIndex = 0;
            // 
            // lblTotalDeptos
            // 
            lblTotalDeptos.AutoSize = true;
            lblTotalDeptos.Location = new Point(74, 80);
            lblTotalDeptos.Name = "lblTotalDeptos";
            lblTotalDeptos.Size = new Size(38, 15);
            lblTotalDeptos.TabIndex = 4;
            lblTotalDeptos.Text = "label4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 26);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 2;
            label1.Text = "Total Departamentos";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(lblPromedio);
            materialCard1.Controls.Add(label2);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(450, 53);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(212, 138);
            materialCard1.TabIndex = 1;
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(72, 80);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(38, 15);
            lblPromedio.TabIndex = 4;
            lblPromedio.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 26);
            label2.Name = "label2";
            label2.Size = new Size(169, 15);
            label2.TabIndex = 3;
            label2.Text = "Promedio Empleados por dpto";
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
            lstDepartamentos.Location = new Point(101, 342);
            lstDepartamentos.MinimumSize = new Size(200, 100);
            lstDepartamentos.MouseLocation = new Point(-1, -1);
            lstDepartamentos.MouseState = MaterialSkin.MouseState.OUT;
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.OwnerDraw = true;
            lstDepartamentos.Size = new Size(325, 255);
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
            lstEmpleadosDepto.Location = new Point(470, 342);
            lstEmpleadosDepto.MinimumSize = new Size(200, 100);
            lstEmpleadosDepto.MouseLocation = new Point(-1, -1);
            lstEmpleadosDepto.MouseState = MaterialSkin.MouseState.OUT;
            lstEmpleadosDepto.Name = "lstEmpleadosDepto";
            lstEmpleadosDepto.OwnerDraw = true;
            lstEmpleadosDepto.Size = new Size(390, 255);
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
            txtNuevoDepto.Location = new Point(155, 233);
            txtNuevoDepto.MaxLength = 50;
            txtNuevoDepto.MouseState = MaterialSkin.MouseState.OUT;
            txtNuevoDepto.Multiline = false;
            txtNuevoDepto.Name = "txtNuevoDepto";
            txtNuevoDepto.Size = new Size(198, 50);
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
            btnGuardar.Location = new Point(394, 267);
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
            // UCDepartamentosAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnGuardar);
            Controls.Add(txtNuevoDepto);
            Controls.Add(lstEmpleadosDepto);
            Controls.Add(lstDepartamentos);
            Controls.Add(materialCard1);
            Controls.Add(Card1);
            Name = "UCDepartamentosAdmin";
            Padding = new Padding(20);
            Size = new Size(927, 658);
            Card1.ResumeLayout(false);
            Card1.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}

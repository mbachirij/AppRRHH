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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDepartamentosAdmin));
            Card1 = new MaterialSkin.Controls.MaterialCard();
            label3 = new Label();
            lblTotalDeptos = new Label();
            label1 = new Label();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            lblPromedio = new Label();
            lblPr = new Label();
            label2 = new Label();
            txtNuevoDepto = new MaterialSkin.Controls.MaterialTextBox();
            panelContenido = new Panel();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            label10 = new Label();
            btnAnadir = new Button();
            cmbEmpleados = new MaterialSkin.Controls.MaterialComboBox();
            lstEmpleadosDepto = new DataGridView();
            lstDepartamentos = new DataGridView();
            btnEliminar = new Button();
            label9 = new Label();
            btnEliminar2 = new Button();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            btnGuardar = new Button();
            label4 = new Label();
            label5 = new Label();
            Card1.SuspendLayout();
            materialCard1.SuspendLayout();
            panelContenido.SuspendLayout();
            materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lstEmpleadosDepto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lstDepartamentos).BeginInit();
            materialCard2.SuspendLayout();
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
            Card1.Location = new Point(44, 56);
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
            lblTotalDeptos.Location = new Point(0, 54);
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
            materialCard1.Location = new Point(808, 19);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(268, 204);
            materialCard1.TabIndex = 1;
            // 
            // lblPromedio
            // 
            lblPromedio.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPromedio.ForeColor = Color.FromArgb(88, 101, 242);
            lblPromedio.Location = new Point(0, 55);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(268, 111);
            lblPromedio.TabIndex = 7;
            lblPromedio.Text = "label4";
            lblPromedio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPr
            // 
            lblPr.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPr.ForeColor = Color.FromArgb(150, 150, 170);
            lblPr.Location = new Point(0, 166);
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
            // txtNuevoDepto
            // 
            txtNuevoDepto.AnimateReadOnly = false;
            txtNuevoDepto.BorderStyle = BorderStyle.None;
            txtNuevoDepto.Depth = 0;
            txtNuevoDepto.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNuevoDepto.Hint = "Nombre departamento...";
            txtNuevoDepto.LeadingIcon = null;
            txtNuevoDepto.Location = new Point(386, 99);
            txtNuevoDepto.MaxLength = 50;
            txtNuevoDepto.MouseState = MaterialSkin.MouseState.OUT;
            txtNuevoDepto.Multiline = false;
            txtNuevoDepto.Name = "txtNuevoDepto";
            txtNuevoDepto.Size = new Size(202, 50);
            txtNuevoDepto.TabIndex = 4;
            txtNuevoDepto.Text = "";
            txtNuevoDepto.TrailingIcon = null;
            // 
            // panelContenido
            // 
            panelContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContenido.AutoScroll = true;
            panelContenido.BackColor = Color.FromArgb(248, 250, 252);
            panelContenido.Controls.Add(materialCard3);
            panelContenido.Controls.Add(materialCard2);
            panelContenido.Controls.Add(label5);
            panelContenido.Location = new Point(0, 10);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1411, 962);
            panelContenido.TabIndex = 6;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(label10);
            materialCard3.Controls.Add(btnAnadir);
            materialCard3.Controls.Add(cmbEmpleados);
            materialCard3.Controls.Add(lstEmpleadosDepto);
            materialCard3.Controls.Add(lstDepartamentos);
            materialCard3.Controls.Add(btnEliminar);
            materialCard3.Controls.Add(label9);
            materialCard3.Controls.Add(btnEliminar2);
            materialCard3.Controls.Add(label8);
            materialCard3.Controls.Add(label6);
            materialCard3.Controls.Add(label7);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(69, 429);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(1226, 390);
            materialCard3.TabIndex = 12;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(150, 150, 170);
            label10.Location = new Point(379, 34);
            label10.Name = "label10";
            label10.Size = new Size(170, 38);
            label10.TabIndex = 19;
            label10.Text = "\"Selecciona un Departamento y un Empleado para reasignarlo\"";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAnadir
            // 
            btnAnadir.BackColor = Color.FromArgb(212, 18, 142);
            btnAnadir.Cursor = Cursors.Hand;
            btnAnadir.FlatAppearance.BorderSize = 0;
            btnAnadir.FlatStyle = FlatStyle.Flat;
            btnAnadir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnadir.ForeColor = Color.White;
            btnAnadir.Location = new Point(343, 167);
            btnAnadir.Name = "btnAnadir";
            btnAnadir.Size = new Size(238, 47);
            btnAnadir.TabIndex = 18;
            btnAnadir.Text = "AÑADIR EMPLEADO";
            btnAnadir.UseVisualStyleBackColor = false;
            btnAnadir.Click += btnAnadir_Click;
            // 
            // cmbEmpleados
            // 
            cmbEmpleados.AutoResize = false;
            cmbEmpleados.BackColor = Color.FromArgb(255, 255, 255);
            cmbEmpleados.Depth = 0;
            cmbEmpleados.DrawMode = DrawMode.OwnerDrawVariable;
            cmbEmpleados.DropDownHeight = 174;
            cmbEmpleados.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmpleados.DropDownWidth = 121;
            cmbEmpleados.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbEmpleados.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbEmpleados.FormattingEnabled = true;
            cmbEmpleados.IntegralHeight = false;
            cmbEmpleados.ItemHeight = 43;
            cmbEmpleados.Location = new Point(343, 86);
            cmbEmpleados.MaxDropDownItems = 4;
            cmbEmpleados.MouseState = MaterialSkin.MouseState.OUT;
            cmbEmpleados.Name = "cmbEmpleados";
            cmbEmpleados.Size = new Size(238, 49);
            cmbEmpleados.StartIndex = 0;
            cmbEmpleados.TabIndex = 17;
            // 
            // lstEmpleadosDepto
            // 
            lstEmpleadosDepto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lstEmpleadosDepto.Location = new Point(602, 57);
            lstEmpleadosDepto.Name = "lstEmpleadosDepto";
            lstEmpleadosDepto.Size = new Size(420, 304);
            lstEmpleadosDepto.TabIndex = 16;
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lstDepartamentos.Location = new Point(44, 57);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(275, 304);
            lstDepartamentos.TabIndex = 15;
            lstDepartamentos.SelectionChanged += lstDepartamentos_SelectionChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(212, 18, 142);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(343, 308);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(238, 53);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(150, 150, 170);
            label9.Location = new Point(1028, 254);
            label9.Name = "label9";
            label9.Size = new Size(170, 38);
            label9.TabIndex = 13;
            label9.Text = "\"Selecciona un Empleado para eliminarlo\"";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEliminar2
            // 
            btnEliminar2.BackColor = Color.FromArgb(212, 18, 142);
            btnEliminar2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar2.ForeColor = Color.White;
            btnEliminar2.Location = new Point(1028, 308);
            btnEliminar2.Name = "btnEliminar2";
            btnEliminar2.Size = new Size(181, 53);
            btnEliminar2.TabIndex = 12;
            btnEliminar2.Text = "ELIMINAR";
            btnEliminar2.UseVisualStyleBackColor = false;
            btnEliminar2.Click += btnEliminar2_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(150, 150, 170);
            label8.Location = new Point(379, 254);
            label8.Name = "label8";
            label8.Size = new Size(170, 38);
            label8.TabIndex = 11;
            label8.Text = "\"Selecciona un Departamento para eliminarlo\"";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(200, 210, 255);
            label6.Location = new Point(44, 14);
            label6.Name = "label6";
            label6.Size = new Size(141, 25);
            label6.TabIndex = 9;
            label6.Text = "Departamentos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(200, 210, 255);
            label7.Location = new Point(602, 14);
            label7.Name = "label7";
            label7.Size = new Size(104, 25);
            label7.TabIndex = 10;
            label7.Text = "Empleados";
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(btnGuardar);
            materialCard2.Controls.Add(Card1);
            materialCard2.Controls.Add(materialCard1);
            materialCard2.Controls.Add(label4);
            materialCard2.Controls.Add(txtNuevoDepto);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(125, 130);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(1104, 271);
            materialCard2.TabIndex = 11;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(212, 18, 142);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(631, 99);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(160, 53);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(200, 210, 255);
            label4.Location = new Point(386, 42);
            label4.Name = "label4";
            label4.Size = new Size(202, 25);
            label4.TabIndex = 6;
            label4.Text = "Nuevo Departamento: ";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(30, 41, 59);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(1408, 83);
            label5.TabIndex = 7;
            label5.Text = "Gestión de Departamentos";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UCDepartamentosAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            Controls.Add(panelContenido);
            Name = "UCDepartamentosAdmin";
            Padding = new Padding(20);
            Size = new Size(1411, 1008);
            Card1.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            panelContenido.ResumeLayout(false);
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lstEmpleadosDepto).EndInit();
            ((System.ComponentModel.ISupportInitialize)lstDepartamentos).EndInit();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard Card1;
        private Label label1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Label label2;
        private Label lblTotalDeptos;
        private MaterialSkin.Controls.MaterialTextBox txtNuevoDepto;
        private Panel panelContenido;
        private Label label3;
        private Label lblPr;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label6;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private Label label9;
        private Button btnEliminar2;
        private Label label8;
        private Button btnEliminar;
        private Button btnGuardar;
        private DataGridView lstEmpleadosDepto;
        private DataGridView lstDepartamentos;
        private MaterialSkin.Controls.MaterialComboBox cmbEmpleados;
        private Button btnAnadir;
        private Label label10;
        private Label lblPromedio;
    }
}

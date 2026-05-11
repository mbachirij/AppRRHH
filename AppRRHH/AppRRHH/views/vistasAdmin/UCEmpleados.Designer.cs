namespace AppRRHH.views.vistasAdmin
{
    partial class UCEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCEmpleados));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            btnEliminar = new Button();
            txtBuscar = new MaterialSkin.Controls.MaterialTextBox();
            lblTitulo = new Label();
            dgvEmpleados = new DataGridView();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            btnAdd = new Button();
            label2 = new Label();
            cmbTipoContrato = new ComboBox();
            cmbCatProfesional = new ComboBox();
            cmbDepartamento = new ComboBox();
            comboBoxRol = new ComboBox();
            txtSalario = new TextBox();
            txtEmail = new TextBox();
            txtApellidos = new TextBox();
            txtNumSS = new TextBox();
            txtDni = new TextBox();
            txtNombre = new TextBox();
            lblCatProfesional = new Label();
            lblTipoContrato = new Label();
            lblNSS = new Label();
            dateFechaNacimiento = new DateTimePicker();
            txtTelefono = new MaterialSkin.Controls.MaterialMaskedTextBox();
            lblSalario = new Label();
            lblEmail = new Label();
            lblTelefono = new Label();
            lblRol = new Label();
            lblDepartamento = new Label();
            lblFechaNac = new Label();
            lblDni = new Label();
            lblApellidos = new Label();
            lblNombre = new Label();
            panel1.SuspendLayout();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            materialCard2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(materialCard1);
            panel1.Controls.Add(materialCard2);
            panel1.Location = new Point(0, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1411, 962);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(30, 41, 59);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1411, 80);
            label1.TabIndex = 2;
            label1.Text = "Gestión de Empleados";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(btnEliminar);
            materialCard1.Controls.Add(txtBuscar);
            materialCard1.Controls.Add(lblTitulo);
            materialCard1.Controls.Add(dgvEmpleados);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(40, 116);
            materialCard1.Margin = new Padding(12, 10, 12, 10);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(12, 10, 12, 10);
            materialCard1.Size = new Size(1339, 368);
            materialCard1.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(212, 18, 142);
            btnEliminar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(1080, 39);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(215, 50);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "ELIMINAR EMPLEADO";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.AnimateReadOnly = false;
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.Depth = 0;
            txtBuscar.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBuscar.Hint = "Buscar por nombre, apellidos o DNI...";
            txtBuscar.LeadingIcon = (Image)resources.GetObject("txtBuscar.LeadingIcon");
            txtBuscar.Location = new Point(513, 39);
            txtBuscar.MaxLength = 50;
            txtBuscar.MouseState = MaterialSkin.MouseState.OUT;
            txtBuscar.Multiline = false;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(324, 50);
            txtBuscar.TabIndex = 1;
            txtBuscar.Text = "";
            txtBuscar.TrailingIcon = null;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(180, 180, 200);
            lblTitulo.Location = new Point(22, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(258, 37);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Listado Empleados";
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleados.BackgroundColor = Color.White;
            dgvEmpleados.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.EnableHeadersVisualStyles = false;
            dgvEmpleados.Location = new Point(15, 121);
            dgvEmpleados.Margin = new Padding(3, 2, 3, 2);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(1280, 235);
            dgvEmpleados.TabIndex = 0;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(btnAdd);
            materialCard2.Controls.Add(label2);
            materialCard2.Controls.Add(cmbTipoContrato);
            materialCard2.Controls.Add(cmbCatProfesional);
            materialCard2.Controls.Add(cmbDepartamento);
            materialCard2.Controls.Add(comboBoxRol);
            materialCard2.Controls.Add(txtSalario);
            materialCard2.Controls.Add(txtEmail);
            materialCard2.Controls.Add(txtApellidos);
            materialCard2.Controls.Add(txtNumSS);
            materialCard2.Controls.Add(txtDni);
            materialCard2.Controls.Add(txtNombre);
            materialCard2.Controls.Add(lblCatProfesional);
            materialCard2.Controls.Add(lblTipoContrato);
            materialCard2.Controls.Add(lblNSS);
            materialCard2.Controls.Add(dateFechaNacimiento);
            materialCard2.Controls.Add(txtTelefono);
            materialCard2.Controls.Add(lblSalario);
            materialCard2.Controls.Add(lblEmail);
            materialCard2.Controls.Add(lblTelefono);
            materialCard2.Controls.Add(lblRol);
            materialCard2.Controls.Add(lblDepartamento);
            materialCard2.Controls.Add(lblFechaNac);
            materialCard2.Controls.Add(lblDni);
            materialCard2.Controls.Add(lblApellidos);
            materialCard2.Controls.Add(lblNombre);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(40, 504);
            materialCard2.Margin = new Padding(12, 10, 12, 10);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(12, 10, 12, 10);
            materialCard2.Size = new Size(1339, 357);
            materialCard2.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(212, 18, 142);
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(1046, 284);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(215, 50);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "AÑADIR EMPLEADO";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(180, 180, 200);
            label2.Location = new Point(22, 21);
            label2.Name = "label2";
            label2.Size = new Size(324, 37);
            label2.TabIndex = 39;
            label2.Text = "Añadir nuevo Empleado";
            // 
            // cmbTipoContrato
            // 
            cmbTipoContrato.FormattingEnabled = true;
            cmbTipoContrato.Items.AddRange(new object[] { "Contrato Indefinido", "Contrato Fijo-Discontinuo", "Contrato Temporal", "Contrato de Prácticas" });
            cmbTipoContrato.Location = new Point(1116, 98);
            cmbTipoContrato.Name = "cmbTipoContrato";
            cmbTipoContrato.Size = new Size(199, 23);
            cmbTipoContrato.TabIndex = 12;
            // 
            // cmbCatProfesional
            // 
            cmbCatProfesional.FormattingEnabled = true;
            cmbCatProfesional.Items.AddRange(new object[] { "Técnico", "Administrativo", "Operario", "Directivo", "Comercial" });
            cmbCatProfesional.Location = new Point(1116, 151);
            cmbCatProfesional.Name = "cmbCatProfesional";
            cmbCatProfesional.Size = new Size(199, 23);
            cmbCatProfesional.TabIndex = 13;
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Location = new Point(755, 151);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(199, 23);
            cmbDepartamento.TabIndex = 10;
            // 
            // comboBoxRol
            // 
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Items.AddRange(new object[] { "Empleado", "Administrador" });
            comboBoxRol.Location = new Point(755, 224);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(199, 23);
            comboBoxRol.TabIndex = 11;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(394, 229);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(199, 23);
            txtSalario.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(394, 154);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(199, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(81, 154);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(199, 23);
            txtApellidos.TabIndex = 4;
            // 
            // txtNumSS
            // 
            txtNumSS.Location = new Point(1116, 224);
            txtNumSS.Name = "txtNumSS";
            txtNumSS.Size = new Size(199, 23);
            txtNumSS.TabIndex = 14;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(81, 229);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(199, 23);
            txtDni.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(81, 94);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(199, 23);
            txtNombre.TabIndex = 3;
            // 
            // lblCatProfesional
            // 
            lblCatProfesional.AutoSize = true;
            lblCatProfesional.Location = new Point(975, 154);
            lblCatProfesional.Name = "lblCatProfesional";
            lblCatProfesional.Size = new Size(120, 15);
            lblCatProfesional.TabIndex = 23;
            lblCatProfesional.Text = "Categoría Profesional";
            // 
            // lblTipoContrato
            // 
            lblTipoContrato.AutoSize = true;
            lblTipoContrato.Location = new Point(975, 102);
            lblTipoContrato.Name = "lblTipoContrato";
            lblTipoContrato.Size = new Size(81, 15);
            lblTipoContrato.TabIndex = 21;
            lblTipoContrato.Text = "Tipo Contrato";
            // 
            // lblNSS
            // 
            lblNSS.AutoSize = true;
            lblNSS.Location = new Point(975, 227);
            lblNSS.Name = "lblNSS";
            lblNSS.Size = new Size(36, 15);
            lblNSS.TabIndex = 19;
            lblNSS.Text = "Nº SS";
            // 
            // dateFechaNacimiento
            // 
            dateFechaNacimiento.Format = DateTimePickerFormat.Short;
            dateFechaNacimiento.Location = new Point(755, 97);
            dateFechaNacimiento.Margin = new Padding(3, 2, 3, 2);
            dateFechaNacimiento.Name = "dateFechaNacimiento";
            dateFechaNacimiento.Size = new Size(199, 23);
            dateFechaNacimiento.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.AllowPromptAsInput = true;
            txtTelefono.AnimateReadOnly = false;
            txtTelefono.AsciiOnly = false;
            txtTelefono.BackgroundImageLayout = ImageLayout.None;
            txtTelefono.BeepOnError = false;
            txtTelefono.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtTelefono.Depth = 0;
            txtTelefono.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefono.HidePromptOnLeave = false;
            txtTelefono.HideSelection = true;
            txtTelefono.InsertKeyMode = InsertKeyMode.Default;
            txtTelefono.LeadingIcon = null;
            txtTelefono.Location = new Point(394, 84);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Mask = "000-000-000";
            txtTelefono.MaxLength = 32767;
            txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PasswordChar = '\0';
            txtTelefono.PrefixSuffixText = null;
            txtTelefono.PromptChar = '_';
            txtTelefono.ReadOnly = false;
            txtTelefono.RejectInputOnFirstFailure = false;
            txtTelefono.ResetOnPrompt = true;
            txtTelefono.ResetOnSpace = true;
            txtTelefono.RightToLeft = RightToLeft.No;
            txtTelefono.SelectedText = "";
            txtTelefono.SelectionLength = 0;
            txtTelefono.SelectionStart = 0;
            txtTelefono.ShortcutsEnabled = true;
            txtTelefono.Size = new Size(199, 48);
            txtTelefono.SkipLiterals = true;
            txtTelefono.TabIndex = 6;
            txtTelefono.TabStop = false;
            txtTelefono.Text = "   -   -";
            txtTelefono.TextAlign = HorizontalAlignment.Left;
            txtTelefono.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtTelefono.TrailingIcon = null;
            txtTelefono.UseSystemPasswordChar = false;
            txtTelefono.ValidatingType = null;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(324, 233);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(42, 15);
            lblSalario.TabIndex = 8;
            lblSalario.Text = "Salario";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(324, 154);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(324, 101);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(53, 15);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Teléfono";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(628, 232);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(24, 15);
            lblRol.TabIndex = 5;
            lblRol.Text = "Rol";
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Location = new Point(628, 154);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(83, 15);
            lblDepartamento.TabIndex = 4;
            lblDepartamento.Text = "Departamento";
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(628, 102);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(103, 15);
            lblFechaNac.TabIndex = 3;
            lblFechaNac.Text = "Fecha Nacimiento";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(15, 232);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(15, 160);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(56, 15);
            lblApellidos.TabIndex = 1;
            lblApellidos.Text = "Apellidos";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(15, 96);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // UCEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(248, 250, 252);
            Controls.Add(panel1);
            Name = "UCEmpleados";
            Padding = new Padding(20);
            Size = new Size(1411, 1008);
            panel1.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Label lblTitulo;
        private DataGridView dgvEmpleados;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private ComboBox cmbTipoContrato;
        private ComboBox cmbCatProfesional;
        private ComboBox cmbDepartamento;
        private ComboBox comboBoxRol;
        private TextBox txtSalario;
        private TextBox txtEmail;
        private TextBox txtApellidos;
        private TextBox txtNumSS;
        private TextBox txtDni;
        private TextBox txtNombre;
        private Label lblCatProfesional;
        private Label lblTipoContrato;
        private Label lblNSS;
        private DateTimePicker dateFechaNacimiento;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtTelefono;
        private Label lblSalario;
        private Label lblEmail;
        private Label lblTelefono;
        private Label lblRol;
        private Label lblDepartamento;
        private Label lblFechaNac;
        private Label lblDni;
        private Label lblApellidos;
        private Label lblNombre;
        private Label label1;
        private MaterialSkin.Controls.MaterialTextBox txtBuscar;
        private Label label2;
        private Button btnEliminar;
        private Button btnAdd;
    }
}

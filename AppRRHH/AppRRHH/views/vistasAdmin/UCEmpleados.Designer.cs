namespace AppRRHH.views
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCEmpleados));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            label1 = new Label();
            btnEliminar = new MaterialSkin.Controls.MaterialButton();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departamentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rolDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empleadoBindingSource = new BindingSource(components);
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            comboBoxRol = new MaterialSkin.Controls.MaterialComboBox();
            txtDepartamento = new MaterialSkin.Controls.MaterialComboBox();
            dateFechaNacimiento = new DateTimePicker();
            txtSalario = new MaterialSkin.Controls.MaterialTextBox2();
            txtTelefono = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox2();
            txtDni = new MaterialSkin.Controls.MaterialTextBox2();
            txtApellidos = new MaterialSkin.Controls.MaterialTextBox2();
            txtNombre = new MaterialSkin.Controls.MaterialTextBox2();
            lblSalario = new Label();
            lblEmail = new Label();
            lblTelefono = new Label();
            lblRol = new Label();
            lblDepartamento = new Label();
            lblFechaNac = new Label();
            lblDni = new Label();
            lblApellidos = new Label();
            lblNombre = new Label();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource).BeginInit();
            materialCard2.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(label1);
            materialCard1.Controls.Add(btnEliminar);
            materialCard1.Controls.Add(dataGridView1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(55, 35);
            materialCard1.Margin = new Padding(12, 10, 12, 10);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(12, 10, 12, 10);
            materialCard1.Size = new Size(643, 450);
            materialCard1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 46);
            label1.Name = "label1";
            label1.Size = new Size(246, 26);
            label1.TabIndex = 3;
            label1.Text = "Listado Empleados";
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEliminar.Depth = 0;
            btnEliminar.HighEmphasis = true;
            btnEliminar.Icon = (Image)resources.GetObject("btnEliminar.Icon");
            btnEliminar.Location = new Point(421, 40);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.NoAccentTextColor = Color.Empty;
            btnEliminar.Size = new Size(197, 36);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar Empleado";
            btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEliminar.UseAccentColor = false;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidosDataGridViewTextBoxColumn, departamentoDataGridViewTextBoxColumn, rolDataGridViewTextBoxColumn });
            dataGridView1.DataSource = empleadoBindingSource;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(24, 108);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(594, 316);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            apellidosDataGridViewTextBoxColumn.MinimumWidth = 6;
            apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            // 
            // departamentoDataGridViewTextBoxColumn
            // 
            departamentoDataGridViewTextBoxColumn.DataPropertyName = "Departamento";
            departamentoDataGridViewTextBoxColumn.HeaderText = "Departamento";
            departamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            departamentoDataGridViewTextBoxColumn.Name = "departamentoDataGridViewTextBoxColumn";
            // 
            // rolDataGridViewTextBoxColumn
            // 
            rolDataGridViewTextBoxColumn.DataPropertyName = "Rol";
            rolDataGridViewTextBoxColumn.HeaderText = "Rol";
            rolDataGridViewTextBoxColumn.MinimumWidth = 6;
            rolDataGridViewTextBoxColumn.Name = "rolDataGridViewTextBoxColumn";
            // 
            // empleadoBindingSource
            // 
            empleadoBindingSource.DataSource = typeof(models.Empleado);
            // 
            // btnAdd
            // 
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = (Image)resources.GetObject("btnAdd.Icon");
            btnAdd.Location = new Point(130, 460);
            btnAdd.Margin = new Padding(4);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(183, 36);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Añadir Empleado";
            btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(btnAdd);
            materialCard2.Controls.Add(comboBoxRol);
            materialCard2.Controls.Add(txtDepartamento);
            materialCard2.Controls.Add(dateFechaNacimiento);
            materialCard2.Controls.Add(txtSalario);
            materialCard2.Controls.Add(txtTelefono);
            materialCard2.Controls.Add(txtEmail);
            materialCard2.Controls.Add(txtDni);
            materialCard2.Controls.Add(txtApellidos);
            materialCard2.Controls.Add(txtNombre);
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
            materialCard2.Location = new Point(738, 35);
            materialCard2.Margin = new Padding(12, 10, 12, 10);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(12, 10, 12, 10);
            materialCard2.Size = new Size(418, 521);
            materialCard2.TabIndex = 1;
            // 
            // comboBoxRol
            // 
            comboBoxRol.AutoResize = false;
            comboBoxRol.BackColor = Color.FromArgb(255, 255, 255);
            comboBoxRol.Depth = 0;
            comboBoxRol.DrawMode = DrawMode.OwnerDrawVariable;
            comboBoxRol.DropDownHeight = 174;
            comboBoxRol.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRol.DropDownWidth = 121;
            comboBoxRol.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboBoxRol.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.IntegralHeight = false;
            comboBoxRol.ItemHeight = 43;
            comboBoxRol.Items.AddRange(new object[] { "Administrador", "Empleado" });
            comboBoxRol.Location = new Point(175, 244);
            comboBoxRol.Margin = new Padding(3, 2, 3, 2);
            comboBoxRol.MaxDropDownItems = 4;
            comboBoxRol.MouseState = MaterialSkin.MouseState.OUT;
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(199, 49);
            comboBoxRol.StartIndex = 0;
            comboBoxRol.TabIndex = 18;
            // 
            // txtDepartamento
            // 
            txtDepartamento.AutoResize = false;
            txtDepartamento.BackColor = Color.FromArgb(255, 255, 255);
            txtDepartamento.Depth = 0;
            txtDepartamento.DrawMode = DrawMode.OwnerDrawVariable;
            txtDepartamento.DropDownHeight = 174;
            txtDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            txtDepartamento.DropDownWidth = 121;
            txtDepartamento.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtDepartamento.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtDepartamento.FormattingEnabled = true;
            txtDepartamento.IntegralHeight = false;
            txtDepartamento.ItemHeight = 43;
            txtDepartamento.Location = new Point(175, 202);
            txtDepartamento.Margin = new Padding(3, 2, 3, 2);
            txtDepartamento.MaxDropDownItems = 4;
            txtDepartamento.MouseState = MaterialSkin.MouseState.OUT;
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(199, 49);
            txtDepartamento.StartIndex = 0;
            txtDepartamento.TabIndex = 17;
            // 
            // dateFechaNacimiento
            // 
            dateFechaNacimiento.Format = DateTimePickerFormat.Short;
            dateFechaNacimiento.Location = new Point(175, 174);
            dateFechaNacimiento.Margin = new Padding(3, 2, 3, 2);
            dateFechaNacimiento.Name = "dateFechaNacimiento";
            dateFechaNacimiento.Size = new Size(199, 23);
            dateFechaNacimiento.TabIndex = 16;
            // 
            // txtSalario
            // 
            txtSalario.AnimateReadOnly = false;
            txtSalario.BackgroundImageLayout = ImageLayout.None;
            txtSalario.CharacterCasing = CharacterCasing.Normal;
            txtSalario.Depth = 0;
            txtSalario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSalario.HideSelection = true;
            txtSalario.LeadingIcon = null;
            txtSalario.Location = new Point(175, 388);
            txtSalario.Margin = new Padding(3, 2, 3, 2);
            txtSalario.MaxLength = 32767;
            txtSalario.MouseState = MaterialSkin.MouseState.OUT;
            txtSalario.Name = "txtSalario";
            txtSalario.PasswordChar = '\0';
            txtSalario.PrefixSuffixText = "€";
            txtSalario.ReadOnly = false;
            txtSalario.RightToLeft = RightToLeft.No;
            txtSalario.SelectedText = "";
            txtSalario.SelectionLength = 0;
            txtSalario.SelectionStart = 0;
            txtSalario.ShortcutsEnabled = true;
            txtSalario.Size = new Size(199, 48);
            txtSalario.TabIndex = 15;
            txtSalario.TabStop = false;
            txtSalario.TextAlign = HorizontalAlignment.Left;
            txtSalario.TrailingIcon = null;
            txtSalario.UseSystemPasswordChar = false;
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
            txtTelefono.Location = new Point(175, 292);
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
            txtTelefono.TabIndex = 14;
            txtTelefono.TabStop = false;
            txtTelefono.Text = "   -   -";
            txtTelefono.TextAlign = HorizontalAlignment.Left;
            txtTelefono.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtTelefono.TrailingIcon = null;
            txtTelefono.UseSystemPasswordChar = false;
            txtTelefono.ValidatingType = null;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(175, 343);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.ReadOnly = false;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(199, 48);
            txtEmail.TabIndex = 12;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // txtDni
            // 
            txtDni.AnimateReadOnly = false;
            txtDni.BackgroundImageLayout = ImageLayout.None;
            txtDni.CharacterCasing = CharacterCasing.Normal;
            txtDni.Depth = 0;
            txtDni.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDni.HideSelection = true;
            txtDni.LeadingIcon = null;
            txtDni.Location = new Point(175, 113);
            txtDni.Margin = new Padding(3, 2, 3, 2);
            txtDni.MaxLength = 32767;
            txtDni.MouseState = MaterialSkin.MouseState.OUT;
            txtDni.Name = "txtDni";
            txtDni.PasswordChar = '\0';
            txtDni.PrefixSuffixText = null;
            txtDni.ReadOnly = false;
            txtDni.RightToLeft = RightToLeft.No;
            txtDni.SelectedText = "";
            txtDni.SelectionLength = 0;
            txtDni.SelectionStart = 0;
            txtDni.ShortcutsEnabled = true;
            txtDni.Size = new Size(199, 48);
            txtDni.TabIndex = 11;
            txtDni.TabStop = false;
            txtDni.TextAlign = HorizontalAlignment.Left;
            txtDni.TrailingIcon = null;
            txtDni.UseSystemPasswordChar = false;
            // 
            // txtApellidos
            // 
            txtApellidos.AnimateReadOnly = false;
            txtApellidos.BackgroundImageLayout = ImageLayout.None;
            txtApellidos.CharacterCasing = CharacterCasing.Normal;
            txtApellidos.Depth = 0;
            txtApellidos.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtApellidos.HideSelection = true;
            txtApellidos.LeadingIcon = null;
            txtApellidos.Location = new Point(175, 74);
            txtApellidos.Margin = new Padding(3, 2, 3, 2);
            txtApellidos.MaxLength = 32767;
            txtApellidos.MouseState = MaterialSkin.MouseState.OUT;
            txtApellidos.Name = "txtApellidos";
            txtApellidos.PasswordChar = '\0';
            txtApellidos.PrefixSuffixText = null;
            txtApellidos.ReadOnly = false;
            txtApellidos.RightToLeft = RightToLeft.No;
            txtApellidos.SelectedText = "";
            txtApellidos.SelectionLength = 0;
            txtApellidos.SelectionStart = 0;
            txtApellidos.ShortcutsEnabled = true;
            txtApellidos.Size = new Size(199, 48);
            txtApellidos.TabIndex = 10;
            txtApellidos.TabStop = false;
            txtApellidos.TextAlign = HorizontalAlignment.Left;
            txtApellidos.TrailingIcon = null;
            txtApellidos.UseSystemPasswordChar = false;
            // 
            // txtNombre
            // 
            txtNombre.AnimateReadOnly = false;
            txtNombre.BackgroundImageLayout = ImageLayout.None;
            txtNombre.CharacterCasing = CharacterCasing.Normal;
            txtNombre.Depth = 0;
            txtNombre.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombre.HideSelection = true;
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(175, 33);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.MaxLength = 32767;
            txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            txtNombre.Name = "txtNombre";
            txtNombre.PasswordChar = '\0';
            txtNombre.PrefixSuffixText = null;
            txtNombre.ReadOnly = false;
            txtNombre.RightToLeft = RightToLeft.No;
            txtNombre.SelectedText = "";
            txtNombre.SelectionLength = 0;
            txtNombre.SelectionStart = 0;
            txtNombre.ShortcutsEnabled = true;
            txtNombre.Size = new Size(199, 48);
            txtNombre.TabIndex = 9;
            txtNombre.TabStop = false;
            txtNombre.TextAlign = HorizontalAlignment.Left;
            txtNombre.TrailingIcon = null;
            txtNombre.UseSystemPasswordChar = false;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(45, 398);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(42, 15);
            lblSalario.TabIndex = 8;
            lblSalario.Text = "Salario";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(45, 352);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(45, 304);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(53, 15);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Teléfono";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(45, 258);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(24, 15);
            lblRol.TabIndex = 5;
            lblRol.Text = "Rol";
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Location = new Point(45, 214);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(83, 15);
            lblDepartamento.TabIndex = 4;
            lblDepartamento.Text = "Departamento";
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(45, 174);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(103, 15);
            lblFechaNac.TabIndex = 3;
            lblFechaNac.Text = "Fecha Nacimiento";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(45, 120);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(45, 79);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(56, 15);
            lblApellidos.TabIndex = 1;
            lblApellidos.Text = "Apellidos";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(45, 40);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // UCEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            Controls.Add(materialCard2);
            Controls.Add(materialCard1);
            ForeColor = Color.White;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1000, 650);
            Name = "UCEmpleados";
            Padding = new Padding(20);
            Size = new Size(1211, 650);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource).EndInit();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private DataGridView dataGridView1;
        private BindingSource empleadoBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rolDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Label lblTelefono;
        private Label lblRol;
        private Label lblDepartamento;
        private Label lblFechaNac;
        private Label lblDni;
        private Label lblApellidos;
        private Label lblNombre;
        private Label lblSalario;
        private Label lblEmail;
        private DateTimePicker dateFechaNacimiento;
        private MaterialSkin.Controls.MaterialTextBox2 txtSalario;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtTelefono;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmail;
        private MaterialSkin.Controls.MaterialTextBox2 txtDni;
        private MaterialSkin.Controls.MaterialTextBox2 txtApellidos;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombre;
        private MaterialSkin.Controls.MaterialComboBox comboBoxRol;
        private MaterialSkin.Controls.MaterialComboBox txtDepartamento;
        private Label label1;
    }
}

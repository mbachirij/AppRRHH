using AppRRHH.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AppRRHH.models;

namespace AppRRHH.views.vistasAdmin
{
    public partial class UCEmpleados : UserControl
    {
        public UCEmpleados()
        {
            InitializeComponent();

            CargarDatos();
            EditarDataGridView();

            this.AutoScroll = true;
        }
        public void CargarDatos()
        {
            using (var db = new AppDbContext())
            {
                // Traigo la lista de empleados de la DB
                var listaEmpleados = db.Empleados.ToList();
                dgvEmpleados.DataSource = listaEmpleados;

                // oculto las que no son necesarias
                dgvEmpleados.Columns["NumSegSocial"].Visible = false;
                dgvEmpleados.Columns["TipoContrato"].Visible = false;
                dgvEmpleados.Columns["CategoriaProfesional"].Visible = false;
                dgvEmpleados.Columns["Antiguedad"].Visible = false;
                dgvEmpleados.Columns["FechaNacimiento"].Visible = false;
                dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            RellenarDatos();
        }

        public void RellenarDatos()
        {
            using (var db = new AppDbContext())
            {
                // Traigo la lista de departamentos de la DB y la asigno al ComboBox
                var listaDeptos = db.Departamentos.Select(d => d.Nombre).ToList();
                // si la lista no es nula ni vacía, asigno la lista al ComboBox
                if (listaDeptos != null && listaDeptos.Count > 0)
                {
                    cmbDepartamento.DataSource = listaDeptos;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            using (var db = new AppDbContext())
            {
                // compruebo si ya existe un empleado con el mismo DNI o email para evitar duplicados
                bool yaExiste = db.Empleados.Any(emp => emp.DNI == txtDni.Text || emp.Email == txtEmail.Text);

                // si ya existe un empleado con el mismo DNI, muestro un mensaje de error y no agrego el nuevo empleado
                if (yaExiste)
                {
                    // muestro un mensaje de error
                    MessageBox.Show("Error: Ya existe un empleado registrado con el DNI o Email proporcionado.",
                            "Empleado Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                // creo un empleado nuevo con los datos de los controles
                Empleado nuevoEmpleado = new Empleado
                {
                    Nombre = txtNombre.Text,
                    Apellidos = txtApellidos.Text,
                    DNI = txtDni.Text,
                    FechaNacimiento = dateFechaNacimiento.Value,
                    Departamento = cmbDepartamento.Text,
                    Email = txtEmail.Text,
                    Salario = decimal.TryParse(txtSalario.Text, out decimal salario) ? salario : 0,
                    NumSegSocial = txtNumSS.Text,
                    TipoContrato = cmbTipoContrato.Text,
                    CategoriaProfesional = cmbCatProfesional.Text,
                    Antiguedad = 0, // pongo antiguedad a 0 por defecto
                    Rol = comboBoxRol.Text,
                    Telefono = txtTelefono.Text.Replace("-", "").Replace("_", "").Replace(" ", "")
                };

                // Guardo el nuevo empleado en la base de datos
                db.Empleados.Add(nuevoEmpleado);
                db.SaveChanges();


                // creo el usuario para el nuevo empleado
                Usuario nuevoUsuario = new Usuario
                {
                    EmpleadoId = nuevoEmpleado.Id,
                    Email = nuevoEmpleado.Email.ToLower(),
                    Contrasena = BCrypt.Net.BCrypt.HashPassword("1234"), // le asigno una contraseña temporal hasheada
                    Rol = nuevoEmpleado.Rol,
                    Empleado = nuevoEmpleado
                };

                // Guardo el nuevo usuario en la base de datos
                db.Usuarios.Add(nuevoUsuario);
                db.SaveChanges();

                // limpiar los campos de texto después de agregar el empleado
                txtNombre.Text = "";
                txtApellidos.Text = "";
                txtDni.Text = "";
                txtEmail.Text = "";
                txtSalario.Text = "";
                txtTelefono.Text = "";
                comboBoxRol.SelectedIndex = -1;
                cmbTipoContrato.SelectedIndex = -1;
                cmbCatProfesional.SelectedIndex = -1;
                dateFechaNacimiento.Value = DateTime.Now;


                // recargo la lista de empleados para que se vea el nuevo empleado agregado
                CargarDatos();

            }

        }

        private void EditarDataGridView()
        {
            // Verifico que el DataGridView no sea nulo antes de aplicar los estilos
            if (dgvEmpleados == null) return;

            // Estilo del DataGridView
            dgvEmpleados.BackgroundColor = Color.White;
            dgvEmpleados.BorderStyle = BorderStyle.None;
            dgvEmpleados.RowHeadersVisible = false;
            dgvEmpleados.GridColor = Color.FromArgb(230, 230, 230);
            dgvEmpleados.RowsDefaultCellStyle.BackColor = Color.White;
            dgvEmpleados.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 255);
            dgvEmpleados.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(88, 101, 242);
            dgvEmpleados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvEmpleados.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvEmpleados.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgvEmpleados.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvEmpleados.ColumnHeadersHeight = 35;
            dgvEmpleados.RowTemplate.Height = 30;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.EnableHeadersVisualStyles = false;
            // dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.ToLower().Trim();

            using (var db = new AppDbContext())
            {
                // busco dentro de la tabla empleados
                var empleados = db.Empleados
                    // donde nombre contenga busqueda
                    .Where(e => e.Nombre.ToLower().Contains(busqueda)
                    // apellidos contegna busqueda
                        || e.Apellidos.ToLower().Contains(busqueda)
                        // o dni contenga busqueda
                        || e.DNI.ToLower().Contains(busqueda))
                    .ToList();
                // y lo muestro
                dgvEmpleados.DataSource = empleados;
                // y oculto datos innecesarios
                dgvEmpleados.Columns["NumSegSocial"].Visible = false;
                dgvEmpleados.Columns["TipoContrato"].Visible = false;
                dgvEmpleados.Columns["CategoriaProfesional"].Visible = false;
                dgvEmpleados.Columns["Antiguedad"].Visible = false;
                dgvEmpleados.Columns["FechaNacimiento"].Visible = false;
                dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // compruebo que haya seleccionado un empleado
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un empleado primero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var empleadoSeleccionado = dgvEmpleados.SelectedRows[0].DataBoundItem as Empleado;

            if (empleadoSeleccionado == null) return;

            using (var db = new AppDbContext())
            {
                var empleadoEnDb = db.Empleados.Find(empleadoSeleccionado.Id);
                if (empleadoEnDb != null)
                {
                    db.Empleados.Remove(empleadoEnDb);
                    var usuarioEnDb = db.Usuarios.FirstOrDefault(u => u.EmpleadoId == empleadoEnDb.Id);
                    if (usuarioEnDb != null)
                        db.Usuarios.Remove(usuarioEnDb);
                    db.SaveChanges();
                    CargarDatos();
                }
            }
        }
    }
}


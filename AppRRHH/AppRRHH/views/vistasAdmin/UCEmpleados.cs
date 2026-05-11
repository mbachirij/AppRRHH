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

                if (!ComprobarCampos())
                {
                    return; // salgo del botón no se ejecuta nada más.
                }

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
                    Empleado = nuevoEmpleado,
                    CambiarContrasena = false
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
                txtNumSS.Text = "";


                // recargo la lista de empleados para que se vea el nuevo empleado agregado
                CargarDatos();
            }
        }
          
        private bool ComprobarCampos()
        {
            // compruebo que ninguno de los campos quede vacío
            // 1. Comprobación de campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(txtDni.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtSalario.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtNumSS.Text) ||
                comboBoxRol.SelectedIndex == -1 ||
                cmbTipoContrato.SelectedIndex == -1 ||
                cmbCatProfesional.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Campos Incompletos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // compruebo que la edad del empleado sea mayor de 18 años
            int edad = DateTime.Today.Year - dateFechaNacimiento.Value.Year;
            if (dateFechaNacimiento.Value.Date > DateTime.Today.AddYears(-edad))
            {
                edad--;
            }
            if (edad < 18 || edad >= 100)
            {
                MessageBox.Show("El empleado debe tener entre 18 y 99 años.", "Edad inválida",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // compruebo el Formato del Email sea el correcto
            string emailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text.Trim(), emailRegex))
            {
                MessageBox.Show("El formato del correo electrónico no es válido.\nEjemplo: usuario@empresa.com", "Email inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // compruebo que el número de la ssocial tenga exactamente 12 dígitos numéricos
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNumSS.Text.Trim(), @"^\d{12}$"))
            {
                MessageBox.Show("El Número de la Seguridad Social debe tener exactamente 12 dígitos numéricos.", "Nº SS inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // compruebo que el dni tenga 9 caracteres y termine en una letra
            string dni = txtDni.Text.Trim();
            if (dni.Length != 9 || !char.IsLetter(dni[dni.Length - 1]))
            {
                MessageBox.Show("El DNI debe tener 9 caracteres y terminar en una letra.", "DNI inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // compruebo que el salario sea número y mayor que 0
            if (!decimal.TryParse(txtSalario.Text.Trim(), out decimal salarioValido) || salarioValido <= 0)
            {
                MessageBox.Show("El salario debe ser un número válido mayor que 0.", "Salario inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
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
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un empleado primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // obtengo el empleado seleccionado en el DataGridView
            var empleadoSeleccionado = dgvEmpleados.SelectedRows[0].DataBoundItem as Empleado;
            // si no se pudo obtener el empleado seleccionado, salgo del método
            if (empleadoSeleccionado == null)
            {
                return;
            }

            using (var db = new AppDbContext())
            {
                bool esSeleccionadoAdmin = empleadoSeleccionado.Rol.Trim().ToUpper() == "ADMINISTRADOR";

                // validación extra si se intenta borrar a un administrador
                if (esSeleccionadoAdmin)
                {
                    var todosLosEmpleados = db.Empleados.ToList();
                    int totalAdmins = todosLosEmpleados.Count(emp => emp.Rol.Trim().ToUpper() == "ADMINISTRADOR");

                    // evitar quedarse sin administradores en el sistema
                    if (totalAdmins <= 1)
                    {
                        MessageBox.Show("No puedes eliminar a este usuario porque es el ÚNICO administrador del sistema.",
                            "Alerta Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    // confirmar identidad antes de borrar a un compañero admin
                    var ventanaSeguridad = new FormContrasenaSeguridad();
                    if(ventanaSeguridad.ShowDialog() != DialogResult.OK)
                    {
                        // si se cancela, no pasa nada
                        return;
                    }

                    string contrasenaIngresada = ventanaSeguridad.contrasenaPrivada;

                    var miUsuario = db.Usuarios.FirstOrDefault(u => u.EmpleadoId == Program.idEmpleadoLogueado);
                    // verifico que la contraseña ingresada sea correcta y el usuario exista, si no es así, muestro un mensaje de error y no se elimina al usuario seleccionado
                    if (miUsuario == null || !BCrypt.Net.BCrypt.Verify(contrasenaIngresada, miUsuario.Contrasena))
                    {
                        MessageBox.Show("Contraseña incorrecta. No se eliminará al usuario.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // flujo normal de eliminación
                string mensaje = $"¿Estás seguro de que quieres eliminar a {empleadoSeleccionado.Nombre} {empleadoSeleccionado.Apellidos}?";
                DialogResult resultado = MessageBox.Show(mensaje, "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    var empleadoEnDb = db.Empleados.Find(empleadoSeleccionado.Id);
                    if (empleadoEnDb != null)
                    {
                        var usuarioEnDb = db.Usuarios.FirstOrDefault(u => u.EmpleadoId == empleadoEnDb.Id);
                        if (usuarioEnDb != null) db.Usuarios.Remove(usuarioEnDb);

                        db.Empleados.Remove(empleadoEnDb);
                        db.SaveChanges();

                        MessageBox.Show("Empleado eliminado con éxito.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                    }
                }
            }
        }
    }
}


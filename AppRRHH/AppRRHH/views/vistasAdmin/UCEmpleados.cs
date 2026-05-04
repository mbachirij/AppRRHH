using AppRRHH.Data;
using AppRRHH.models;
using AppRRHH.views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AppRRHH.views
{
    public partial class UCEmpleados : UserControl
    {
        public UCEmpleados()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(25, 25, 40);

            CargarDatos();
            RellenarDepartamentos();
            EditarDataGridView();
        }
        public void CargarDatos()
        {
            using (var db = new AppDbContext())
            {
                // Traigo la lista de empleados de la DB
                var listaEmpleados = db.Empleados.ToList();

                // La asigno al BindingSource que he creado en el diseño
                empleadoBindingSource.DataSource = listaEmpleados;
            }
        }

        public void RellenarDepartamentos()
        {
            using (var db = new AppDbContext())
            {
                // Cojo los nombres de la tabla Departamentos
                var listaDeptos = db.Departamentos.Select(d => d.Nombre).ToList();

                // Los meto en el ComboBox que lo he llamado txtDepartamento
                txtDepartamento.DataSource = listaDeptos;
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
                AppRRHH.models.Empleado nuevoEmpleado = new AppRRHH.models.Empleado
                {
                    Nombre = txtNombre.Text,
                    Apellidos = txtApellidos.Text,
                    DNI = txtDni.Text,
                    FechaNacimiento = dateFechaNacimiento.Value,
                    Departamento = txtDepartamento.Text,
                    Email = txtEmail.Text,
                    Salario = decimal.TryParse(txtSalario.Text, out decimal salario) ? salario : 0,
                    NumSegSocial = txtNumSS.Text,
                    TipoContrato = cmbTipoContrato.Text,
                    CategoriaProfesional = cmbCatProfesional.Text,
                    Antiguedad = (int)nudAntiguedad.Value, // convierto el valor del NumericUpDown a int
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
                    Contrasena = "1234",
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
                nudAntiguedad.Value = 0;
                dateFechaNacimiento.Value = DateTime.Now;


                // recargo la lista de empleados para que se vea el nuevo empleado agregado
                CargarDatos();

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verifico que haya un empleado seleccionado
            if (empleadoBindingSource.Current is AppRRHH.models.Empleado empleadoSeleccionado)
            {
                using (var db = new AppDbContext())
                {
                    // Busco el empleado en la base de datos
                    var empleadoEnDb = db.Empleados.Find(empleadoSeleccionado.Id);
                    if (empleadoEnDb != null)
                    {
                        // Elimino el empleado
                        db.Empleados.Remove(empleadoEnDb);
                        // Elimino el usuario asociado al empleado
                        var usuarioEnDb = db.Usuarios.FirstOrDefault(u => u.EmpleadoId == empleadoEnDb.Id);
                        if (usuarioEnDb != null)
                        {
                            db.Usuarios.Remove(usuarioEnDb);
                        }
                        // Guardo los cambios en la base de datos
                        db.SaveChanges();
                        // Recargo la lista de empleados para reflejar los cambios
                        CargarDatos();
                    }
                }
            }
        }

        private void EditarDataGridView()
        {
            // Estilo del DataGridView
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.GridColor = Color.FromArgb(230, 230, 230);
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 255);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(88, 101, 242);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }
    }
}

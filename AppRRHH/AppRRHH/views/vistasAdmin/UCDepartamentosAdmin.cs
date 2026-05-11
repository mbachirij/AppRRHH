using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppRRHH.views.vistasAdmin
{
    public partial class UCDepartamentosAdmin : UserControl
    {
        public UCDepartamentosAdmin()
        {
            InitializeComponent();

            CargarDepartamentos();

            EstiloListas();

            this.AutoScroll = true;
        }

        private void lstDepartamentos_SelectionChanged(object sender, EventArgs e)
        {
            // si no hay ninguna fila seleccionada salgo
            if (lstDepartamentos.SelectedRows.Count == 0) return;
            // cojo el nombre del departamento de la primera fila seleccionada
            string nombreDepto = lstDepartamentos.SelectedRows[0].Cells["Nombre"].Value?.ToString();

            using (var db = new Data.AppDbContext())
            {
                // busco los empleados que pertenecen a ese departamento
                var empleados = db.Empleados
                    .Where(emp => emp.Departamento == nombreDepto)
                    .Select(emp => new { emp.Nombre, emp.Apellidos, emp.Rol })
                    .ToList();

                // y los muestro en la otra lista
                lstEmpleadosDepto.DataSource = empleados;
                lstEmpleadosDepto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        public void CargarDepartamentos()
        {
            using (var db = new Data.AppDbContext())
            {
                var lista = db.Departamentos.Select(d => new
                {
                    Nombre = d.Nombre,
                    Empleados = db.Empleados.Count(e => e.Departamento == d.Nombre)
                }).ToList();

                lstDepartamentos.DataSource = lista;
                lstDepartamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // cargo el comb con empleados para asignar a departamentos
                var empleados = db.Empleados.Select(e => e.Nombre + " " + e.Apellidos).ToList();
                cmbEmpleados.DataSource = empleados;

            }
            ActualizarCards();
        }
        private void ActualizarCards()
        {
            using (var db = new Data.AppDbContext())
            {
                int totalD = db.Departamentos.Count();
                int totalE = db.Empleados.Count();

                lblTotalDeptos.Text = totalD.ToString();

                if (totalD > 0)
                    lblPromedio.Text = ((double)totalE / totalD).ToString("N1") + " %";
                else
                    lblPromedio.Text = "0 %";
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNuevoDepto.Text)) return;

            using (var db = new Data.AppDbContext())
            {
                // Creo el departamento
                var nuevo = new models.Departamento { Nombre = txtNuevoDepto.Text };
                db.Departamentos.Add(nuevo);
                db.SaveChanges();
            }

            txtNuevoDepto.Clear();

            //actualizo Lista y Tarjetas
            CargarDepartamentos();
            MessageBox.Show("Departamento creado con éxito");
        }

        private void EstiloListas()
        {
            // miro que el dgv no sea nulo antes de aplicar los estilos
            if (lstDepartamentos == null)
            {
                return;
            }

            // Estilo del DataGridView
            lstDepartamentos.BackgroundColor = Color.White;
            lstDepartamentos.BorderStyle = BorderStyle.None;
            lstDepartamentos.RowHeadersVisible = false;
            lstDepartamentos.GridColor = Color.FromArgb(230, 230, 230);
            lstDepartamentos.RowsDefaultCellStyle.BackColor = Color.White;
            lstDepartamentos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 255);
            lstDepartamentos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(88, 101, 242);
            lstDepartamentos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            lstDepartamentos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lstDepartamentos.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            lstDepartamentos.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            lstDepartamentos.ColumnHeadersHeight = 35;
            lstDepartamentos.RowTemplate.Height = 30;
            lstDepartamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lstDepartamentos.EnableHeadersVisualStyles = false;
            lstDepartamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Verifico que el DataGridView no sea nulo antes de aplicar los estilos
            if (lstDepartamentos == null) return;

            // Estilo del DataGridView
            lstEmpleadosDepto.BackgroundColor = Color.White;
            lstEmpleadosDepto.BorderStyle = BorderStyle.None;
            lstEmpleadosDepto.RowHeadersVisible = false;
            lstEmpleadosDepto.GridColor = Color.FromArgb(230, 230, 230);
            lstEmpleadosDepto.RowsDefaultCellStyle.BackColor = Color.White;
            lstEmpleadosDepto.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 255);
            lstEmpleadosDepto.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(88, 101, 242);
            lstEmpleadosDepto.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            lstEmpleadosDepto.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lstEmpleadosDepto.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            lstEmpleadosDepto.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            lstEmpleadosDepto.ColumnHeadersHeight = 35;
            lstEmpleadosDepto.RowTemplate.Height = 30;
            lstEmpleadosDepto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lstEmpleadosDepto.EnableHeadersVisualStyles = false;
            lstEmpleadosDepto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstDepartamentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un departamento para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // cojo el nombre del departamento de la primera fila seleccionada
            string nombreDepto = lstDepartamentos.SelectedRows[0].Cells["Nombre"].Value?.ToString();
            if (string.IsNullOrEmpty(nombreDepto))
            {
                return;
            }

            using (var db = new Data.AppDbContext())
            {
                bool tieneEmpleados = db.Empleados.Any(e => e.Departamento == nombreDepto);
                if (tieneEmpleados)
                {
                    MessageBox.Show("No puedes eliminar un departamento con empleados asignados.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Pregunta de confirmación antes de eliminar
                var result = MessageBox.Show($"¿Estás seguro de que quieres eliminar el departamento '{nombreDepto}'?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // busco y borro el departamento
                    var depto = db.Departamentos.FirstOrDefault(d => d.Nombre == nombreDepto);
                    if (depto != null)
                    {
                        db.Departamentos.Remove(depto);
                        db.SaveChanges();
                        CargarDepartamentos();
                        MessageBox.Show("Departamento eliminado correctamente.");
                    }
                }
                else
                {
                    MessageBox.Show("El departamento no ha sido eliminado.");
                }
            }
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            if (lstEmpleadosDepto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un empleado primero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombreEmp = lstEmpleadosDepto.SelectedRows[0].Cells["Nombre"].Value?.ToString();
            string apellidosEmp = lstEmpleadosDepto.SelectedRows[0].Cells["Apellidos"].Value?.ToString();

            using (var db = new Data.AppDbContext())
            {
                // Busco el empleado por nombre y apellidos
                var emp = db.Empleados.FirstOrDefault(e => e.Nombre == nombreEmp && e.Apellidos == apellidosEmp);

                if (emp != null)
                {
                    // Le quito el departamento
                    emp.Departamento = null;
                    db.SaveChanges();
                    CargarDepartamentos();
                    MessageBox.Show("Empleado eliminado del departamento correctamente.");
                }
            }
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            // compruebo que haya un departamento y un empleado seleccionado
            if (lstDepartamentos.SelectedRows.Count == 0 || cmbEmpleados.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un departamento y un empleado para asignar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // cojo el nombre del departamento de la primera fila seleccionada
            string nombreDepto = lstDepartamentos.SelectedRows[0].Cells["Nombre"].Value?.ToString();
            string nombreEmp = cmbEmpleados.SelectedItem.ToString().Split(' ')[0];
            string apellidosEmp = cmbEmpleados.SelectedItem.ToString().Split(' ')[1];

            // Busco el empleado por nombre y apellido
            using (var db = new Data.AppDbContext())
            {
                var emp = db.Empleados.FirstOrDefault(e => e.Nombre == nombreEmp && e.Apellidos == apellidosEmp);
                if (emp != null)
                {
                    // Asigno el departamento al empleado
                    emp.Departamento = nombreDepto;
                    db.SaveChanges();
                    CargarDepartamentos();
                    MessageBox.Show("Empleado asignado al departamento correctamente.");
                }
            }
        }
    }
}

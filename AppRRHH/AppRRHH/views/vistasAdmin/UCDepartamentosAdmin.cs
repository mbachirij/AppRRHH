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
        }

        private void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDepartamentos.SelectedItems.Count > 0)
            {
                // Cojo el nombre del departamento de la primera columna
                string nombreDepto = lstDepartamentos.SelectedItems[0].Text;

                using (var db = new Data.AppDbContext())
                {
                    lstEmpleadosDepto.Items.Clear();

                    // Busco empleados y Filtro por el nombre del depto
                    var empleados = db.Empleados
                        .Where(emp => emp.Departamento == nombreDepto)
                        .ToList();

                    foreach (var emp in empleados)
                    {
                        // El primer campo es el nombre
                        ListViewItem item = new ListViewItem(emp.Nombre);

                        // Añado los sub-elementos (Apellidos y Rol)
                        item.SubItems.Add(emp.Apellidos);
                        item.SubItems.Add(emp.Rol);

                        lstEmpleadosDepto.Items.Add(item);
                    }
                }
            }
        }
        public void CargarDepartamentos()
        {
            using (var db = new Data.AppDbContext())
            {
                lstDepartamentos.Items.Clear();
                var lista = db.Departamentos.ToList();

                foreach (var d in lista)
                {
                    ListViewItem item = new ListViewItem(d.Nombre);

                    // Cuento cuántos empleados hay en este depto
                    int total = db.Empleados.Count(e => e.Departamento == d.Nombre);
                    item.SubItems.Add(total.ToString());

                    lstDepartamentos.Items.Add(item);
                }
            }
            // para que se actualice cada vez que cargue departamentos
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
                    lblPromedio.Text = ((double)totalE / totalD).ToString("N1");
                else
                    lblPromedio.Text = "0";
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
            // lstDepartamentos
            lstDepartamentos.BackColor = Color.White;
            lstDepartamentos.ForeColor = Color.FromArgb(50, 50, 50);
            lstDepartamentos.Font = new Font("Segoe UI", 10);
            lstDepartamentos.FullRowSelect = true;
            lstDepartamentos.GridLines = true;
            lstDepartamentos.BorderStyle = BorderStyle.None;

            // lstEmpleadosDepto
            lstEmpleadosDepto.BackColor = Color.White;
            lstEmpleadosDepto.ForeColor = Color.FromArgb(50, 50, 50);
            lstEmpleadosDepto.Font = new Font("Segoe UI", 10);
            lstEmpleadosDepto.FullRowSelect = true;
            lstEmpleadosDepto.GridLines = true;
            lstEmpleadosDepto.BorderStyle = BorderStyle.None;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstDepartamentos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona un departamento para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombreDepto = lstDepartamentos.SelectedItems[0].Text;

            using (var db = new Data.AppDbContext())
            {
                bool tieneEmpleados = db.Empleados.Any(e => e.Departamento == nombreDepto);
                if (tieneEmpleados)
                {
                    MessageBox.Show("No puedes eliminar un departamento con empleados asignados.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var depto = db.Departamentos.FirstOrDefault(d => d.Nombre == nombreDepto);
                if (depto != null)
                {
                    db.Departamentos.Remove(depto);
                    db.SaveChanges();
                    CargarDepartamentos();
                    MessageBox.Show("Departamento eliminado correctamente.");
                }
            }
        }
    }
}

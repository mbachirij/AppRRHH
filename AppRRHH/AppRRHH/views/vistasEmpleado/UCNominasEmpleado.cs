using AppRRHH.Data;
using AppRRHH.models;
using AppRRHH.reports;
using AppRRHH.views.vistasEmpleado;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace AppRRHH.views.vistasEmpleado
{
    public partial class UCNominasEmpleado : UserControl
    {
        private int empleadoId = Program.idEmpleadoLogueado;
        public UCNominasEmpleado()
        {
            InitializeComponent();
            CargarFiltros();
            CargarDatos();
            EstiloGrid();

            this.AutoScroll = true;
        }

        private void CargarFiltros()
        {
            // ComboBox de Meses están añadidos manualmente desde propiedades
            
            // Añado los años al ComboBox de año
            cmbFiltroAno.Items.Add("Todos los años");
            cmbFiltroAno.Items.Add(DateTime.Now.Year - 2);
            cmbFiltroAno.Items.Add(DateTime.Now.Year - 1);
            cmbFiltroAno.Items.Add(DateTime.Now.Year);
            cmbFiltroAno.SelectedIndex = 0;
        }

        private void CargarDatos()
        {

            using(var db = new AppDbContext())
            {
                // lista de nominas generadas al empleado en el año actual
                var nominasAno = db.Nominas
                    .Where(n => n.EmpleadoId == empleadoId && n.Anio == DateTime.Now.Year)
                    .ToList();

                int totalNominas = nominasAno.Count();
                lblNominasAno.Text = totalNominas.ToString();

                // el total cobrado este año es la suma de todos los LiquidosAPercibir
                decimal totalAno = nominasAno.Sum(n => n.LiquidoAPercibir);
                lblTotalAno.Text = totalAno.ToString()+"€";

                var ultima = db.Nominas
                    .Where(n => n.EmpleadoId == empleadoId)
                    .OrderByDescending(n => n.Anio)
                    .ThenByDescending(n => n.FechaPago)
                    .FirstOrDefault();

                if(ultima != null)
                {
                    lblNetoMes.Text = ultima.LiquidoAPercibir.ToString("C")+"€";
                } else
                {
                    lblNetoMes.Text = "0,00 €";
                }
                
                // para mostrar historial le paso al método Mostrar el listado de nominas del usuario
                var nominas = db.Nominas.Where(n => n.EmpleadoId == empleadoId).ToList();
                MostrarHistorial(nominas);
            }

        }
        private void MostrarHistorial(List<Nomina> nominas)
        {
            dgvHistorial.DataSource = nominas.Select(n => new
            {
                Mes = n.Mes,
                Año = n.Anio,
                SalarioBase = n.SalarioBase.ToString("C"),
                Bruto = n.TotalDevengado.ToString("C"),
                Deducciones = n.TotalDeducciones.ToString("C"),
                Neto = n.LiquidoAPercibir.ToString("C"),
                Id = n.Id
            }).ToList();

            if (dgvHistorial.Columns.Contains("Id"))
            {
                dgvHistorial.Columns["Id"].Visible = false;
                dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvHistorial.DefaultCellStyle.ForeColor = Color.Black;
            }
        }
        private void EstiloGrid()
        {
            dgvHistorial.BackgroundColor = Color.White;
            dgvHistorial.BorderStyle = BorderStyle.None;
            dgvHistorial.RowHeadersVisible = false;
            dgvHistorial.GridColor = Color.FromArgb(230, 230, 230);
            dgvHistorial.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(88, 101, 242);
            dgvHistorial.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHistorial.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvHistorial.EnableHeadersVisualStyles = false;
            dgvHistorial.RowTemplate.Height = 32;
            dgvHistorial.ColumnHeadersHeight = 38;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 255);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var query = db.Nominas
                    .Where(n => n.EmpleadoId == empleadoId)
                    .ToList();

                // Filtro mes
                if (cmbFiltroMes.SelectedIndex > 0)
                {
                    query = query.Where(n => n.Mes == cmbFiltroMes.SelectedItem.ToString()).ToList();
                }
                // Filtro año
                if (cmbFiltroAno.SelectedIndex > 0)
                {
                    query = query.Where(n => n.Anio == (int)cmbFiltroAno.SelectedItem).ToList();

                }
                MostrarHistorial(query);
            }
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dgvHistorial.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una nómina primero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // cojo el id de la nómina seleccionada
            var id = (int) dgvHistorial.SelectedRows[0].Cells["Id"].Value;

            using (var db = new AppDbContext())
            {
                var nomina = db.Nominas.FirstOrDefault(n => n.Id == id);
                var empleado = db.Empleados.FirstOrDefault(e => e.Id == empleadoId);
                var empresa = db.Empresas.FirstOrDefault();

                if (nomina != null && empleado != null && empresa != null)
                {
                    NominaReport.Generar(nomina, empleado, empresa);
                }
                else
                {
                    MessageBox.Show("Faltan datos para generar la nómina.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}


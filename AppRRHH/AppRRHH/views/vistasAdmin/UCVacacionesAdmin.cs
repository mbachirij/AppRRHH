using AppRRHH.Data;
using AppRRHH.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace AppRRHH.views.vistasAdmin
{
    public partial class UCVacacionesAdmin : UserControl
    {
        public UCVacacionesAdmin()
        {
            InitializeComponent();
            CargarDatos();

            EstiloDataGridView();
        }

        private void CargarDatos()
        {
            using (var db = new AppDbContext())
            {
                // Paso a una lista todos los empleados de la bd
                var empleados = db.Empleados.ToList();

                // paso a otra lista las solicitudes de vacaciones pendientes
                var pendientesVista = db.Vacaciones
                    .Where(v => v.Estado == "Pendiente")
                    // las ordeno por fecha de inicio
                    .OrderBy(v => v.FechaInicio)
                    .ToList()
                    // y las transformo a una vista que muestre el nombre completo del empleado en lugar de su ID
                    .Select(v => new
                    {
                        Id = v.Id,
                        Empleado = empleados.FirstOrDefault(e => e.Id == v.EmpleadoId)?.NombreCompleto() ?? "Desconocido",
                        FechaInicio = v.FechaInicio.ToShortDateString(),
                        FechaFin = v.FechaFin.ToShortDateString(),
                        Estado = v.Estado
                    }).ToList();

                dgvPendientes.DataSource = pendientesVista;
                dgvPendientes.Columns["Id"].Visible = false;
                dgvPendientes.DefaultCellStyle.ForeColor = Color.Black;
                dgvPendientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                var historialVista = db.Vacaciones
                    .OrderByDescending(v => v.FechaInicio)
                    .ToList()
                    .Select(v => new
                    {
                        Id = v.Id,
                        Empleado = empleados.FirstOrDefault(e => e.Id == v.EmpleadoId)?.NombreCompleto() ?? "Desconocido",
                        FechaInicio = v.FechaInicio.ToShortDateString(),
                        FechaFin = v.FechaFin.ToShortDateString(),
                        Estado = v.Estado
                    }).ToList();

                dgvHistorial.DataSource = historialVista;
                dgvHistorial.Columns["Id"].Visible = false;
                dgvHistorial.DefaultCellStyle.ForeColor = Color.Black;
                dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            CambiarEstado("Aprobada");
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            CambiarEstado("Rechazada");
        }

        private void CambiarEstado(string nuevoEstado)
        {
            // Compruebo que se ha seleccionado una fila
            if (dgvPendientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una solicitud primero.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cojo el ID de la solicitud seleccionada
            var id = (int)dgvPendientes.SelectedRows[0].Cells["Id"].Value;

            // Entro a la base de datos
            using (var db = new AppDbContext())
            {
                // Busco la solicitud por su ID
                var vac = db.Vacaciones.FirstOrDefault(v => v.Id == id);
                if (vac != null)
                {
                    // Cambio el estado de la solicitud por el nuevo estado
                    vac.Estado = nuevoEstado;
                    db.SaveChanges();
                    MessageBox.Show($"Solicitud {nuevoEstado.ToLower()} correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                }
            }
        }

        private void EstiloDataGridView() 
        {
            // Estilo del DataGridView
            dgvPendientes.BackgroundColor = Color.White;
            dgvPendientes.BorderStyle = BorderStyle.None;
            dgvPendientes.RowHeadersVisible = false;
            dgvPendientes.GridColor = Color.FromArgb(230, 230, 230);
            dgvPendientes.RowsDefaultCellStyle.BackColor = Color.White;
            dgvPendientes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 255);
            dgvPendientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(88, 101, 242);
            dgvPendientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPendientes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvPendientes.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgvPendientes.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvPendientes.ColumnHeadersHeight = 35;
            dgvPendientes.RowTemplate.Height = 30;
            dgvPendientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPendientes.EnableHeadersVisualStyles = false;
            dgvPendientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Estilo del DataGridView
            dgvHistorial.BackgroundColor = Color.White;
            dgvHistorial.BorderStyle = BorderStyle.None;
            dgvHistorial.RowHeadersVisible = false;
            dgvHistorial.GridColor = Color.FromArgb(230, 230, 230);
            dgvHistorial.RowsDefaultCellStyle.BackColor = Color.White;
            dgvHistorial.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 255);
            dgvHistorial.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(88, 101, 242);
            dgvHistorial.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHistorial.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvHistorial.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgvHistorial.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvHistorial.ColumnHeadersHeight = 35;
            dgvHistorial.RowTemplate.Height = 30;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.EnableHeadersVisualStyles = false;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }
    }
}

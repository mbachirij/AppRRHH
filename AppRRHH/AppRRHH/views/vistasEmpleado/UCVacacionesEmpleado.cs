using AppRRHH.Data;
using AppRRHH.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppRRHH.views.vistasEmpleado
{
    public partial class UCVacacionesEmpleado : UserControl
    {
        public UCVacacionesEmpleado()
        {
            InitializeComponent();

            CargarDatos();
        }

        private void CargarDatos()
        {
            var empleadoId = Program.idEmpleadoLogueado;

            using (var db = new AppDbContext())
            {
                // Calcular días usados en vacaciones aprobadas este año
                int diasUsados = db.Vacaciones
                    .Where(v => v.EmpleadoId == empleadoId
                        && v.Estado == "Aprobada"
                        && v.FechaInicio.Year == DateTime.Today.Year)
                    .ToList()
                    .Sum(v => (int)(v.FechaFin - v.FechaInicio).TotalDays);

                // Calcular días disponibles
                int diasDisponibles = 30 - diasUsados;
                lblDiasDisponibles.Text = $"{diasDisponibles} días disponibles de 30";

                // Historial de solicitudes de vacaciones
                var solicitudes = db.Vacaciones
                    .Where(v => v.EmpleadoId == empleadoId)
                    .OrderByDescending(v => v.FechaInicio)
                    .ToList();

                dgvHistorial.DataSource = solicitudes;
                dgvHistorial.Columns["EmpleadoId"].Visible = false;
                dgvHistorial.Columns["Empleado"].Visible = false;
                dgvHistorial.Columns["Id"].Visible = false;
                dgvHistorial.Columns["FechaInicio"].HeaderText = "Fecha Inicio";
                dgvHistorial.Columns["FechaFin"].HeaderText = "Fecha Fin";
                dgvHistorial.Columns["Estado"].HeaderText = "Estado";
                dgvHistorial.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            DateTime inicio = dtpInicio.Value.Date;
            DateTime fin = dtpFin.Value.Date;

            if (fin <= inicio)
            {
                MessageBox.Show("La fecha de fin debe ser posterior a la de inicio.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int diasSolicitados = (int)(fin - inicio).TotalDays;

            using (var db = new AppDbContext())
            {
                // Calcular días disponibles
                int diasUsados = db.Vacaciones
                    .Where(v => v.EmpleadoId == Program.idEmpleadoLogueado
                        && v.Estado == "Aprobada"
                        && v.FechaInicio.Year == DateTime.Today.Year)
                    .ToList()
                    .Sum(v => (int)(v.FechaFin - v.FechaInicio).TotalDays);

                int diasDisponibles = 30 - diasUsados;

                if (diasSolicitados > diasDisponibles)
                {
                    MessageBox.Show($"No tienes suficientes días. Te quedan {diasDisponibles} días.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var solicitud = new Vacaciones
                {
                    FechaInicio = inicio,
                    FechaFin = fin,
                    Estado = "Pendiente",
                    EmpleadoId = Program.idEmpleadoLogueado,
                    DiasDisponibles = diasDisponibles - diasSolicitados
                };

                db.Vacaciones.Add(solicitud);
                db.SaveChanges();

                MessageBox.Show("Solicitud enviada. Estado: Pendiente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarDatos();
            }
        }
    }
}

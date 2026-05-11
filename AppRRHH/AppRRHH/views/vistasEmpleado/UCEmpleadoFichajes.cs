using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppRRHH.views.vistasEmpleado
{
    public partial class UCEmpleadoFichajes : UserControl
    {
        private DateTime? horaEntradaHoy = null;
        private bool trabajando = false;
        // variable para contar las horas acumuladas del día
        // timespan.zero es un valor inicial de tiempo que representa 0 horas, 0 minutos y 0 segundos
        private TimeSpan horasAcumuladasHoy = TimeSpan.Zero;

        public UCEmpleadoFichajes()
        {
            InitializeComponent();

            EditarDataGridView();

            // Enciendo el reloj a la fuerza
            timer1.Enabled = true;
            // obligamo a leer tu código cada segundo
            timer1.Tick += timer1_Tick;

            // Muestro la hora al cargar la vista
            lblReloj.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // para que el reloj se actualice cada segundo
            lblReloj.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            // Empiezo con las horas que ya trajimos de la base de datos
            TimeSpan tiempoTotalHoy = horasAcumuladasHoy;

            // Si está trabajando AHORA MISMO, le sumo los segundos que van pasando
            if (trabajando == true && horaEntradaHoy != null)
            {
                tiempoTotalHoy += (DateTime.Now - horaEntradaHoy.Value);
            }

            // Mostramos el total
            lblContadorHoras.Text = "Horas totales hoy: " + tiempoTotalHoy.ToString(@"hh\:mm\:ss");
        }

        private void btnFichar_Click(object sender, EventArgs e)
        {
            using (var db = new Data.AppDbContext())
            {
                int idEmp = Program.idEmpleadoLogueado;
                DateTime hoy = DateTime.Today;

                if (!trabajando) // REGISTRAR ENTRADA
                {
                    var nuevoFichaje = new models.Asistencia
                    {
                        EmpleadoId = idEmp,
                        Fecha = hoy,
                        HoraEntrada = DateTime.Now
                        // Aquí podría guardar txtNotas.Text si añado el campo a la DB
                    };

                    db.Asistencias.Add(nuevoFichaje);
                    db.SaveChanges();
                    // Al registrar la entrada, recalculo las horas para que el contador se actualice correctamente
                    // (en caso de que haya turnos anteriores)
                    CalcularHoras();

                    horaEntradaHoy = nuevoFichaje.HoraEntrada;
                    trabajando = true;
                    ConfigurarInterfaz(true);
                    MessageBox.Show("Entrada registrada a las " + horaEntradaHoy?.ToShortTimeString());
                }
                else // REGISTRAR SALIDA
                {
                    var fichaje = db.Asistencias.FirstOrDefault(a => a.EmpleadoId == idEmp && a.Fecha == hoy && a.HoraSalida == null);

                    if (fichaje != null)
                    {
                        fichaje.HoraSalida = DateTime.Now;
                        db.SaveChanges();
                        // Al registrar la salida, recalculo las horas para que el contador se actualice correctamente
                        CalcularHoras();

                        trabajando = false;
                        horaEntradaHoy = null;
                        ConfigurarInterfaz(false);
                        MessageBox.Show("Salida registrada. ¡Buen trabajo!");

                        CargarHistorial(); // Actualizo el historial para mostrar la salida registrada
                    }
                }
            }
        }

        private void ConfigurarInterfaz(bool estaTrabajando)
        {
            if (estaTrabajando)
            {
                btnFichar.Text = "REGISTRAR SALIDA";
                btnFichar.BackColor = Color.Firebrick; // Rojo oscuro
                btnFichar.BackColor = Color.Firebrick; // Rojo para salida
            }
            else
            {
                btnFichar.Text = "REGISTRAR ENTRADA";
                btnFichar.BackColor = Color.ForestGreen; // Verde
                btnFichar.BackColor = Color.ForestGreen; // Verde para entrada
            }
        }

        private void CargarHistorial()
        {
            using (var db = new Data.AppDbContext())
            {
                int idEmp = Program.idEmpleadoLogueado;

                var historial = db.Asistencias
                    .Where(a => a.EmpleadoId == idEmp)
                    .OrderByDescending(a => a.Fecha) // Los más recientes primero
                    .Select(a => new {
                        Fecha = a.Fecha.ToString("dd/MM/yyyy"),
                        Entrada = a.HoraEntrada.HasValue ? a.HoraEntrada.Value.ToString("HH:mm:ss") : "--:--",
                        Salida = a.HoraSalida.HasValue ? a.HoraSalida.Value.ToString("HH:mm:ss") : "Trabajando..."
                    })
                    .ToList();

                dgvHistorial.DataSource = historial;
            }
        }

        private void UCEmpleadoFichajes_Load(object sender, EventArgs e)
        {
            using (var db = new Data.AppDbContext())
            {
                int idEmp = Program.idEmpleadoLogueado;
                DateTime hoy = DateTime.Today;

                // Busco si el empleado YA ha fichado hoy y no ha salido todavía
                var fichajeHoy = db.Asistencias
                    .FirstOrDefault(a => a.EmpleadoId == idEmp && a.Fecha == hoy && a.HoraSalida == null);

                if (fichajeHoy != null)
                {
                    // Si ya está trabajando, configuro el botón en ROJO
                    trabajando = true;
                    horaEntradaHoy = fichajeHoy.HoraEntrada;
                    ConfigurarInterfaz(true);
                }
                else
                {
                    // Si no está trabajando, configuro el botón en VERDE
                    trabajando = false;
                    ConfigurarInterfaz(false);
                }
            }

            // Cargo el historial de fichajes del empleado
            CargarHistorial();
            // Y calculo las horas acumuladas del día para mostrar el contador correcto
            CalcularHoras();
        }
        // Método para calcular las horas acumuladas del día sumando los turnos anteriores
        private void CalcularHoras()
        {
            using (var db = new Data.AppDbContext())
            {
                int idEmp = Program.idEmpleadoLogueado;
                DateTime hoy = DateTime.Today;

                // Buscos los turnos de hoy que YA ESTÁN TERMINADOS (los que tienen HoraSalida)
                var turnosTerminados = db.Asistencias
                    .Where(a => a.EmpleadoId == idEmp && a.Fecha == hoy && a.HoraSalida != null)
                    .ToList();

                horasAcumuladasHoy = TimeSpan.Zero; // Empiezo a contar desde cero

                foreach (var turno in turnosTerminados)
                {
                    if (turno.HoraEntrada.HasValue && turno.HoraSalida.HasValue)
                    {
                        // Sumo la duración de cada turno antiguo
                        horasAcumuladasHoy += (turno.HoraSalida.Value - turno.HoraEntrada.Value);
                    }
                }
            }
        }

        private void EditarDataGridView()
        {
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

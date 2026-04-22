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

        public UCEmpleadoFichajes()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            // Si el usuario ya fichó entrada, calculo el tiempo transcurrido
            if (trabajando && horaEntradaHoy.HasValue)
            {
                TimeSpan tiempo = DateTime.Now - horaEntradaHoy.Value;
                lblContadorHoras.Text = string.Format("Tiempo trabajado: {0:h\\:mm\\:ss}", tiempo);
            }

        }

        private void btnFichar_Click(object sender, EventArgs e)
        {
            using (var db = new Data.AppDbContext())
            {
                int idEmp = Program.idEmpleadoLogueado;
                DateTime hoy = DateTime.Today;

                if (!trabajando) // VAMOS A REGISTRAR ENTRADA
                {
                    var nuevoFichaje = new models.Asistencia
                    {
                        EmpleadoId = idEmp,
                        Fecha = hoy,
                        HoraEntrada = DateTime.Now
                        // Aquí podrías guardar txtNotas.Text si añadiste el campo a la DB
                    };

                    db.Asistencias.Add(nuevoFichaje);
                    db.SaveChanges();

                    horaEntradaHoy = nuevoFichaje.HoraEntrada;
                    trabajando = true;
                    ConfigurarInterfaz(true);
                    MessageBox.Show("Entrada registrada a las " + horaEntradaHoy?.ToShortTimeString());
                }
                else // VAMOS A REGISTRAR SALIDA
                {
                    var fichaje = db.Asistencias.FirstOrDefault(a => a.EmpleadoId == idEmp && a.Fecha == hoy && a.HoraSalida == null);

                    if (fichaje != null)
                    {
                        fichaje.HoraSalida = DateTime.Now;
                        db.SaveChanges();

                        trabajando = false;
                        horaEntradaHoy = null;
                        ConfigurarInterfaz(false);
                        MessageBox.Show("Salida registrada. ¡Buen trabajo!");
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
    }
}

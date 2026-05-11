using AppRRHH.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppRRHH.views.vistasAdmin
{
    public partial class UCFichajesAdmin : UserControl
    {
        public UCFichajesAdmin()
        {
            InitializeComponent();
            CargarEstilo();

            // por defecto muestro los fichajes del día actual
            dtpDia.Value = DateTime.Now;
            btnBuscarDia_Click(null, null);
        }

        private void CargarEstilo()
        {
            // estilo del datagridview
            dgvDiaria.BackgroundColor = Color.White;
            dgvDiaria.BorderStyle = BorderStyle.None;
            dgvDiaria.RowHeadersVisible = false;
            dgvDiaria.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(88, 101, 242);
            dgvDiaria.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDiaria.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvDiaria.EnableHeadersVisualStyles = false;
            dgvDiaria.RowTemplate.Height = 32;
            dgvDiaria.ColumnHeadersHeight = 38;
            dgvDiaria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDiaria.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 255);
        }
        private void btnBuscarDia_Click(object sender, EventArgs e)
        {
            DateTime diaSeleccionado = dtpDia.Value.Date;

            using (var db = new AppDbContext())
            {
                // traigo todos los empleados de la base de datos
                var empleados = db.Empleados.ToList();

                // traigo los fichajes del día seleccionado
                var fichajes = db.Asistencias
                    .Where(a => a.Fecha == diaSeleccionado)
                    .ToList();

                // creo la lista donde voy a guardar los resultados
                var resultado = new List<dynamic>();

                foreach (var emp in empleados)
                {
                    // busco si este empleado tiene fichaje ese día
                    var fichaje = fichajes.FirstOrDefault(f => f.EmpleadoId == emp.Id);

                    string entrada = "---";
                    string salida = "---";
                    string horas = "No fichado";

                    if (fichaje != null)
                    {
                        // si tiene hora de entrada la muestro
                        if (fichaje.HoraEntrada.HasValue)
                        {
                            entrada = fichaje.HoraEntrada.Value.ToString("HH:mm");
                        }

                        // si tiene hora de salida la muestro
                        if (fichaje.HoraSalida.HasValue)
                        {
                            salida = fichaje.HoraSalida.Value.ToString("HH:mm");
                        }

                        // si tiene entrada y salida calculo las horas trabajadas
                        if (fichaje.HoraEntrada.HasValue && fichaje.HoraSalida.HasValue)
                        {
                            horas = $"{(fichaje.HoraSalida.Value - fichaje.HoraEntrada.Value).TotalHours:N1}h";
                        }
                        else if (fichaje.HoraEntrada.HasValue)
                        {
                            // si solo tiene entrada significa que aún está trabajando
                            horas = "En curso";
                        }
                    }

                    resultado.Add(new
                    {
                        Empleado = emp.NombreCompletoTexto,
                        Entrada = entrada,
                        Salida = salida,
                        Horas = horas
                    });
                }

                // ordeno los resultados: primero en curso, luego completados, luego no fichados
                resultado = resultado
                    .OrderBy(r => r.Horas == "En curso" ? 0 : r.Horas == "No fichado" ? 2 : 1)
                    .ToList();

                dgvDiaria.DataSource = resultado;
                dgvDiaria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDiaria.DefaultCellStyle.ForeColor = Color.Black;

            }

        }

        
       
    }
    
}

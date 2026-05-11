using AppRRHH.Data;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.SKCharts;
using LiveChartsCore.SkiaSharpView.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace AppRRHH.views.vistasAdmin
{
    public partial class UCInicioAdmin : UserControl
    {
        public UCInicioAdmin()
        {
            InitializeComponent();
            CargarDatos();
        }
        private void CargarDatos()
        {
            using (var db = new AppDbContext())
            {
                // Datos personales
                var empleado = db.Empleados
                    .FirstOrDefault(e => e.Id == Program.idEmpleadoLogueado);

                if (empleado != null)
                {
                    lblNombre.Text = $"Nombre: {empleado.Nombre}";
                    lblApellidos.Text = $"Apellidos: {empleado.Apellidos}";
                    lblDNI.Text = $"DNI: {empleado.DNI}";
                    lblEmail.Text = $"Email: {empleado.Email}";
                    lblDepartamento.Text = $"Departamento: {empleado.Departamento}";
                    lblRol.Text = $"Rol: {empleado.Rol}";
                    lblNumSegSocial.Text = $"Nº SS: {empleado.NumSegSocial}";
                }

                // Resumen del sistema
                lblTotalEmpleados.Text = db.Empleados.Count().ToString();

                string mesActual = DateTime.Now.ToString("MMMM", new System.Globalization.CultureInfo("es-ES"));
                int anioActual = DateTime.Now.Year;
                // Contar nóminas del mes actual
                lblNominasMes.Text = db.Nominas.Count(n => n.Mes == mesActual && n.Anio == anioActual).ToString();

                lblTotalDeptos2.Text = db.Departamentos.Count().ToString();

                // creo el gráfico de vacaciones por estado
                var series = new List<ISeries>();

                int pendientes = db.Vacaciones.Count(v => v.Estado == "Pendiente");
                int aprobadas = db.Vacaciones.Count(v => v.Estado == "Aprobada");
                int rechazadas = db.Vacaciones.Count(v => v.Estado == "Rechazada");

                series.Add(new PieSeries<int> { Values = new[] { pendientes }, Name = "Pendientes", DataLabelsSize = 12 });
                series.Add(new PieSeries<int> { Values = new[] { aprobadas }, Name = "Aprobadas", DataLabelsSize = 12 });
                series.Add(new PieSeries<int> { Values = new[] { rechazadas }, Name = "Rechazadas", DataLabelsSize = 12 });

                pieChart1.Series = series.ToArray();
            }
        }
    }
}

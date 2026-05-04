using AppRRHH.Data;
using AppRRHH.models;
using AppRRHH.reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppRRHH.views.vistasAdmin
{

    public partial class UCNominasAdmin : UserControl
    {
        private Nomina nominaCalculada = null; // Variable para almacenar la nómina calculada antes de guardarla en la base de datos
        public UCNominasAdmin()
        {
            InitializeComponent();
            CargarMeses();
            CargarEmpleados();
            CargarAnios();
            CargarHistorial();

            EstiloDataGridView();
        }
        private void CargarEmpleados()
        {
            using (var db = new AppDbContext())
            {
                var empleados = db.Empleados.ToList();
                cmbEmpleado.DataSource = empleados;
                cmbEmpleado.DisplayMember = "NombreCompletoTexto";
                cmbEmpleado.ValueMember = "Id";
            }
        }
        // Este método carga el combo de meses con los nombres de los meses en español y selecciona el mes actual
        private void CargarMeses()
        {
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            cmbMes.DataSource = meses;
            cmbMes.SelectedItem = DateTime.Now.ToString("MMMM", new System.Globalization.CultureInfo("es-ES"));
        }
        private void CargarAnios()
        {
            var anios = new List<int>();
            // Cargo un rango de años desde 2 años antes del actual
            // hasta 1 año después del actual para poder generar nóminas de meses anteriores y futuros
            for (int i = DateTime.Now.Year - 2; i <= DateTime.Now.Year + 1; i++)
                anios.Add(i);
            cmbAnio.DataSource = anios;
            cmbAnio.SelectedItem = DateTime.Now.Year;
        }
        private void CargarHistorial()
        {
            using (var db = new AppDbContext())
            {
                var empleados = db.Empleados.ToList();

                var historial = db.Nominas
                    .OrderByDescending(n => n.Anio)
                    .ThenBy(n => n.Mes)
                    .ToList()
                    .Select(n => new
                    {
                        n.Id,
                        Empleado = empleados.FirstOrDefault(e => e.Id == n.EmpleadoId)?.NombreCompleto() ?? "Desconocido",
                        n.Mes,
                        n.Anio,
                        SalarioBase = n.SalarioBase.ToString("C"),
                        TotalDevengado = n.TotalDevengado.ToString("C"),
                        Deducciones = n.TotalDeducciones.ToString("C"),
                        LiquidoAPercibir = n.LiquidoAPercibir.ToString("C"),
                        n.FechaPago
                    }).ToList();

                dgvNominas.DataSource = historial;
                if (dgvNominas.Columns.Contains("Id"))
                    dgvNominas.Columns["Id"].Visible = false;
                dgvNominas.DefaultCellStyle.ForeColor = Color.Black;
                dgvNominas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbEmpleado.SelectedValue == null)
            {
                MessageBox.Show("Selecciona un empleado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int empleadoId = (int)cmbEmpleado.SelectedValue;

            using (var db = new AppDbContext())
            {
                var empleado = db.Empleados.FirstOrDefault(emp => emp.Id == empleadoId);
                var empresa = db.Empresas.FirstOrDefault();

                if (empleado == null)
                {
                    MessageBox.Show("Empleado no encontrado.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cálculo
                int horas = (int)nudHoras.Value;
                int horasExtra = (int)nudHorasExtra.Value;
                decimal plusNocturnidad = nudPlusNocturnidad.Value;
                decimal plusFestivo = nudPlusFestivo.Value;
                decimal plusTransporte = nudPlusTransporte.Value;

                decimal precioHora = empleado.Salario / 160;
                decimal salarioBase = precioHora * horas;
                decimal horasExtraImporte = (precioHora * 1.75m) * horasExtra;

                decimal totalDevengado = salarioBase + horasExtraImporte
                    + plusNocturnidad + plusFestivo + plusTransporte;

                // Deducciones reales
                decimal irpf = totalDevengado * 0.15m;          // 15% IRPF
                decimal contingencias = totalDevengado * 0.047m; // 4.7% SS
                decimal desempleo = totalDevengado * 0.0155m;    // 1.55%
                decimal fp = totalDevengado * 0.001m;            // 0.1% FP
                decimal totalDeducciones = irpf + contingencias + desempleo + fp;

                decimal liquidoAPercibir = totalDevengado - totalDeducciones;

                // Guardar en variable temporal
                nominaCalculada = new Nomina
                {
                    EmpleadoId = empleadoId,
                    EmpresaId = empresa?.Id ?? 1,
                    Mes = cmbMes.SelectedItem.ToString(),
                    Anio = (int)cmbAnio.SelectedItem,
                    HorasTrabajadas = horas,
                    HorasExtra = horasExtra,
                    SalarioBase = salarioBase,
                    HorasExtraImporte = horasExtraImporte,
                    PlusNocturnidad = plusNocturnidad,
                    PlusFestivo = plusFestivo,
                    PlusTransporte = plusTransporte,
                    TotalDevengado = totalDevengado,
                    PorcentajeIRPF = 15,
                    ImporteIRPF = irpf,
                    ContingenciasComunes = contingencias,
                    Desempleo = desempleo,
                    FormacionProfesional = fp,
                    TotalDeducciones = totalDeducciones,
                    LiquidoAPercibir = liquidoAPercibir,
                    FechaPago = DateTime.Now
                };

                // Mostrar resumen
                lblResumen.Text =
                    $"Empleado: {empleado.NombreCompleto()}\n" +
                    $"Periodo: {cmbMes.SelectedItem} {cmbAnio.SelectedItem}\n" +
                    $"─────────────────────────\n" +
                    $"Salario base:          {salarioBase:C}\n" +
                    $"Horas extra ({horasExtra}h):   {horasExtraImporte:C}\n" +
                    $"Plus nocturnidad:      {plusNocturnidad:C}\n" +
                    $"Plus festivo:          {plusFestivo:C}\n" +
                    $"Plus transporte:       {plusTransporte:C}\n" +
                    $"─────────────────────────\n" +
                    $"Total devengado:       {totalDevengado:C}\n" +
                    $"IRPF (15%):           -{irpf:C}\n" +
                    $"Cont. comunes (4.7%): -{contingencias:C}\n" +
                    $"Desempleo (1.55%):    -{desempleo:C}\n" +
                    $"Form. prof. (0.1%):   -{fp:C}\n" +
                    $"─────────────────────────\n" +
                    $"LÍQUIDO A PERCIBIR:    {liquidoAPercibir:C}";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // si aun no ha calculado la nómina, no se puede guardar
            if (nominaCalculada == null)
            {
                MessageBox.Show("Primero calcula la nómina.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new AppDbContext())
            {
                // compruebo si ya existe nómina para ese empleado y mes
                bool yaExiste = db.Nominas.Any(n =>
                    n.EmpleadoId == nominaCalculada.EmpleadoId &&
                    n.Mes == nominaCalculada.Mes &&
                    n.Anio == nominaCalculada.Anio);

                if (yaExiste)
                {
                    var confirmar = MessageBox.Show(
                        "Ya existe una nómina para este empleado en ese mes. ¿Sobreescribir?",
                        "Nómina duplicada", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmar == DialogResult.No) return;

                    var existente = db.Nominas.FirstOrDefault(n =>
                        n.EmpleadoId == nominaCalculada.EmpleadoId &&
                        n.Mes == nominaCalculada.Mes &&
                        n.Anio == nominaCalculada.Anio);

                    db.Nominas.Remove(existente);
                    db.SaveChanges();
                }

                db.Nominas.Add(nominaCalculada);
                db.SaveChanges();

                MessageBox.Show("Nómina guardada correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nominaCalculada = null;
                lblResumen.Text = "";
                CargarHistorial();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // si no ha seleccionado una nómina del historial, no se puede imprimir
            if (dgvNominas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una nómina del historial primero.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // obtengo el id de la nómina seleccionada para luego cargarla y generar el PDF
            var id = (int)dgvNominas.SelectedRows[0].Cells["Id"].Value;

            using (var db = new AppDbContext())
            {
                // cargo la nómina, el empleado y la empresa para generar el PDF
                var nomina = db.Nominas.FirstOrDefault(n => n.Id == id);
                var empleado = db.Empleados.FirstOrDefault(e => e.Id == nomina.EmpleadoId);
                var empresa = db.Empresas.FirstOrDefault();

                // si todo está correcto, genero el PDF, sino muestro un error
                if (nomina != null && empleado != null && empresa != null)
                    NominaReport.Generar(nomina, empleado, empresa);
                else
                    MessageBox.Show("Faltan datos para generar la nómina.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EstiloDataGridView() 
        {
            // Estilo del DataGridView
            dgvNominas.BackgroundColor = Color.White;
            dgvNominas.BorderStyle = BorderStyle.None;
            dgvNominas.RowHeadersVisible = false;
            dgvNominas.GridColor = Color.FromArgb(230, 230, 230);
            dgvNominas.RowsDefaultCellStyle.BackColor = Color.White;
            dgvNominas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 255);
            dgvNominas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(88, 101, 242);
            dgvNominas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNominas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvNominas.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgvNominas.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvNominas.ColumnHeadersHeight = 35;
            dgvNominas.RowTemplate.Height = 30;
            dgvNominas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNominas.EnableHeadersVisualStyles = false;
            dgvNominas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            
        }
    }
}

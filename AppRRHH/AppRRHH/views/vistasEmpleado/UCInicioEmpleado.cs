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
    public partial class UCInicioEmpleado : UserControl
    {
        private int empleadoId = Program.idEmpleadoLogueado;

        public UCInicioEmpleado()
        {
            InitializeComponent();

            cargarDatos();
        }

        // en éste método cargaré los datos del empleado que ha iniciado sesión, para mostrarlos en la vista de inicio
        public void cargarDatos() 
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
                    lblPuesto.Text = $"Puesto: {empleado.CategoriaProfesional}";
                }

                lblVacacionesPend.Text = db.Vacaciones.Count(v => v.EmpleadoId == empleadoId && v.Estado == "Pendiente").ToString();

                // días de vacaciones totales que quedan para el empleado en el año actual 
                // Primero traer a memoria, luego calcular
                var vacacionesAprobadas = db.Vacaciones
                    .Where(v => v.EmpleadoId == Program.idEmpleadoLogueado &&
                                v.Estado == "Aprobada" &&
                                v.FechaInicio.Year == DateTime.Now.Year)
                    .ToList() // ← traer a memoria primero
                    .Sum(v => (v.FechaFin - v.FechaInicio).Days + 1);

                vacacionesAprobadas = Math.Min(vacacionesAprobadas, 30);
                lblDiasVacaciones.Text = (30 - vacacionesAprobadas).ToString();

                lblNominasAnio.Text = db.Nominas
                .Count(n => n.EmpleadoId == empleadoId && n.Anio == DateTime.Now.Year)
                .ToString();

                lblHorasMes.Text = db.Asistencias
                .Count(a => a.EmpleadoId == empleadoId && a.Fecha.Month == DateTime.Now.Month)
                .ToString() + " días";


            }
        }
    }




}

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
        public UCInicioEmpleado()
        {
            InitializeComponent();

            cargarDatos();
        }

        // en éste método cargaré los datos del empleado que ha iniciado sesión, para mostrarlos en la vista de inicio
        public void cargarDatos() 
        {
            using (var db = new Data.AppDbContext())
            { 
                // cojo el id del empleado que ha iniciado sesión
                var usuarioActual = db.Empleados.Find(Program.idEmpleadoLogueado);

                if (usuarioActual == null)
                {
                    MessageBox.Show("Error al cargar los datos del empleado.");
                    return;
                } else
                {

                    // muestro los datos del empleado en los labels correspondientes
                    lblNombreUser.Text = usuarioActual.NombreCompleto();
                    
                    if (string.IsNullOrWhiteSpace(usuarioActual.Departamento))
                    {
                        lblDepartamento.Text = "Sin departamento";
                    }
                    else
                    {
                        lblDepartamento.Text = usuarioActual.Departamento;
                    }

                    // muestro los días de vacaciones disponibles
                    var vacaciones = db.Vacaciones.FirstOrDefault(v => v.EmpleadoId == Program.idEmpleadoLogueado);
                    lblDias.Text = vacaciones != null ? vacaciones.DiasDisponibles.ToString() : "0";

                    lblBienvenida.Text = $"¡Bienvenido, {usuarioActual.Nombre}!";

                }
            }
        }
    }




}

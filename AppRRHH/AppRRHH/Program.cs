using AppRRHH.Data;
using AppRRHH.views;
using AppRRHH.models;
using System.Diagnostics.CodeAnalysis;

namespace AppRRHH
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        // variable global para almacenar el ID del empleado que ha iniciado sesión
        public static int idEmpleadoLogueado; 

        [STAThread]
        static void Main()
        {
            // Crear la base de datos si no existe
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();

                // Crear un usuario por defecto si no existe
                if(!db.Usuarios.Any())
                {
                    // Crear un empleado administrador
                    var empleadoAdmin = new Empleado
                    {
                        Nombre = "Admin",
                        Apellidos = "User",
                        DNI = "00000000R",
                        FechaNacimiento = new DateTime(1999, 12, 10),
                        Departamento = "RRHH",
                        Email = "admin@rrhh.com",
                        Rol = "Administrador",
                        Telefono = "662000000"
                    };

                    db.Empleados.Add(empleadoAdmin);
                    db.SaveChanges();

                    // Crear el usuario administrador asociado al empleado
                    db.Usuarios.Add(new Usuario
                    {
                        EmpleadoId = empleadoAdmin.Id,
                        Email = "admin@rrhh.com",
                        Contrasena = "admin123", // En un entorno real, la contraseña debería estar hasheada
                        Rol = "Administrador",
                        Empleado = empleadoAdmin
                    });

                    db.SaveChanges();
                }
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new FormLogin());
        }
    }
}
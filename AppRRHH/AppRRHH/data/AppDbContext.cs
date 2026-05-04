using AppRRHH.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppRRHH.Data
{
    // Esta clase conecta todas las entidades (modelos) con la base de datos SQL Server
    public class AppDbContext : DbContext
    {
        // Cada DbSet representa una tabla en SQL Server
        // Sin ellos Entity Framework no crea las tablas 
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Vacaciones> Vacaciones { get; set; }
        public DbSet<Nomina> Nominas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Asistencia> Asistencias { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=DESKTOP-95UPOKJ\SQLEXPRESS01;Database=AppRRHH;Trusted_Connection=True;TrustServerCertificate=True;");
        } 
    } 
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppRRHH.models
{
    public class Asistencia
    {
        [Key] // Clave primaria
        public int Id { get; set; }
        [Required]
        public int EmpleadoId { get; set; } // Para saber quién es
        public DateTime Fecha { get; set; } // Día del fichaje
        public DateTime? HoraEntrada { get; set; } // Uso ? por si aún no ha fichado
        public DateTime? HoraSalida { get; set; }

        // Propiedad de navegación para Entity Framework
        [ForeignKey("EmpleadoId")] // para decirle a la base de datos que EmpleadoId es la llave foránea
        public virtual Empleado Empleado { get; set; }
    }
}

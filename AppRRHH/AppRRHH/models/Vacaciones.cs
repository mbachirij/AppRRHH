using System.ComponentModel.DataAnnotations;

namespace AppRRHH.models
{
    public class Vacaciones
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime FechaInicio { get; set; }
        [Required]
        public DateTime FechaFin { get; set; }
        [Required]
        [MaxLength(40)]
        public string Estado { get; set; } // Pendiente, Aprobada, Rechazada
        public int DiasDisponibles { get; set; }
        public int EmpleadoId { get; set; }
        // Navegación hacia Empleado
        public Empleado Empleado { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppRRHH.models
{
    public class Nomina
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime FechaPago { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal SalarioBase { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Deducciones { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal SalarioNeto { get; set; }
        public int EmpleadoId { get; set; }
        // Navegación hacia Empleado
        public Empleado Empleado { get; set; }
    }
}

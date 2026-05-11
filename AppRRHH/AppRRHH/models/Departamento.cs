using System.ComponentModel.DataAnnotations;

namespace AppRRHH.models
{
    public class Departamento
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(120)]
        public string Nombre { get; set; }

        // un departamento puede tener muchos empleados
        public List<Empleado> Empleados { get; set; } = new List<Empleado>();
    }
}

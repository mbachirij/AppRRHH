using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppRRHH.models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Email { get; set; }

        [Required]
        [MaxLength(255)]
        public string Contrasena { get; set; }

        [Required]
        [MaxLength(20)]
        public string Rol { get; set; }

        public bool CambiarContrasena { get; set; }

        public int EmpleadoId { get; set; }

        [ForeignKey("EmpleadoId")]
        public Empleado Empleado { get; set; }
    }
}

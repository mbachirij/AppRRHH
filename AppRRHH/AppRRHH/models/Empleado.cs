using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppRRHH.models
{
    public class Empleado
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(255)]
        public string Apellidos { get; set; }

        [Required]
        [MaxLength(20)]
        public string DNI { get; set; }

        public DateTime FechaNacimiento { get; set; }

        [MaxLength(100)]
        public string? Departamento { get; set; }

        [MaxLength(100)]
        public string Rol { get; set; }

        [MaxLength(9)]
        public string Telefono { get; set; }

        [MaxLength(150)]
        public string Email { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Salario { get; set; }

        [MaxLength(12)]
        public string? NumSegSocial { get; set; }

        [MaxLength(50)]
        public string? TipoContrato { get; set; }  // "Indefinido", "Temporal", etc.

        [MaxLength(100)]
        public string? CategoriaProfesional { get; set; }  // "Técnico", "Administrativo", etc.

        public int Antiguedad { get; set; }  // años de antigüedad

        public string NombreCompleto() => $"{Nombre} {Apellidos}";
        public string NombreCompletoTexto => $"{Nombre} {Apellidos}";
    }
}



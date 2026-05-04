using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppRRHH.models
{
    public class Nomina
    {
        [Key]
        public int Id { get; set; }

        // Periodo
        [Required]
        [MaxLength(20)]
        public string Mes { get; set; }
        public int Anio { get; set; }
        public int DiasTrabajados { get; set; }

        // Devengos
        [Column(TypeName = "decimal(10,2)")]
        public decimal SalarioBase { get; set; }

        public int HorasTrabajadas { get; set; }

        public int HorasExtra { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal HorasExtraImporte { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal PlusNocturnidad { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal PlusFestivo { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal PlusTransporte { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Antiguedad { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal TotalDevengado { get; set; }  // bruto

        // Deducciones
        [Column(TypeName = "decimal(10,2)")]
        public decimal PorcentajeIRPF { get; set; }  // % IRPF

        [Column(TypeName = "decimal(10,2)")]
        public decimal ImporteIRPF { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal ContingenciasComunes { get; set; }  // 4.70%

        [Column(TypeName = "decimal(10,2)")]
        public decimal Desempleo { get; set; }  // 1.55%

        [Column(TypeName = "decimal(10,2)")]
        public decimal FormacionProfesional { get; set; }  // 0.10%

        [Column(TypeName = "decimal(10,2)")]
        public decimal TotalDeducciones { get; set; }

        // Líquido
        [Column(TypeName = "decimal(10,2)")]
        public decimal LiquidoAPercibir { get; set; }

        // Fecha
        public DateTime FechaPago { get; set; }

        // Relaciones
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }

        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
    }
}

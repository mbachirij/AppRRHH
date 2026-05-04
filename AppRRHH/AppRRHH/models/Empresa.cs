using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AppRRHH.models
{
    public class Empresa
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(20)]
        public string CIF { get; set; }

        [MaxLength(300)]
        public string Direccion { get; set; }

        [MaxLength(20)]
        public string NumCuentaCotizacion { get; set; }

        [MaxLength(100)]
        public string Municipio { get; set; }

        [MaxLength(10)]
        public string CodigoPostal { get; set; }
    }
}

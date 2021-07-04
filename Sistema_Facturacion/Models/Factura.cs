using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_Facturacion.Models
{
    public class Factura
    {
        [Key]
        [Display(Name = "Numero Factura")]
        public int Numero_Factura { get; set; }

        
        [Required(ErrorMessage = "El campo FECHA no puede ir vacío")]
        [Display(Name = "Fecha")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El campo TOTAL no puede ir vacío")]
        [Display(Name = "Total Factura")]
        public double Total_Factura { get; set; }

        [Required(ErrorMessage = "El campo ANULADA no puede ir vacío")]
        [Display(Name = "Anulada")]
        public string Anulada { get; set; }

        [Required(ErrorMessage = "El campo CODIGO_CLIENTE no puede ir vacío")]
        [Display(Name = "Cliente")]
        public int? Codigo_Clientefk { get; set; }
        [ForeignKey("Codigo_Clientefk")]
        public virtual Cliente Cliente { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_Facturacion.Models
{
    public class Factura_Productos
    {

        [Required(ErrorMessage = "El campo Cantidad no puede ir vacío")]
        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "El campo Precio_Unitario no puede ir vacío")]
        [Display(Name = "Precio Unitario")]
        public double Precio_Unitario { get; set; }
        

        [Required(ErrorMessage = "El campo NUMERO FACTURA no puede ir vacío")]
        [Display(Name = "Numero Factura")]
        [Key, Column(Order = 0)]
        [ForeignKey("Numero_Facturafk")]
        public int? Numero_Facturafk { get; set; }
        
        public virtual Factura Factura { get; set; }



        [Required(ErrorMessage = "El campo CODIGO PRODUCTO no puede ir vacío")]    
        [Display(Name = "Producto")]
        [Key, Column(Order = 1)]
        [ForeignKey("Codigo_Productofk")]
        public int? Codigo_Productofk { get; set; }
        
        public virtual Producto Productos { get; set; }
    }
}

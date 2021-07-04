using System.ComponentModel.DataAnnotations;


namespace Sistema_Facturacion.Models
{
    public class Producto
    {
        [Key]
        [Display(Name = "Codigo Producto")]
        public int Codigo_Producto { get; set; }

        [Required(ErrorMessage = "El campo NOMBRE no puede ir vacío")]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El campo DESCRIPCION no puede ir vacío")]
        [Display(Name = "Descripcion")]
        public string descripcion { get; set; }

        [Required(ErrorMessage = "El campo PRECIO no puede ir vacío")]
        [Display(Name = "Precio")]
        public double Precio { get; set; }

        [Required(ErrorMessage = "El campo COSTO no puede ir vacío")]
        [Display(Name = "Costo")]
        public double Costo{ get; set; }

        [Required(ErrorMessage = "El campo EXISTENCIA no puede ir vacío")]
        [Display(Name = "Existencia")]
        public int Existencia { get; set; }

        [Required(ErrorMessage = "El campo ACTIVO no puede ir vacío")]
        [Display(Name = "Activo")]
        public string Activo { get; set; }

    }
}

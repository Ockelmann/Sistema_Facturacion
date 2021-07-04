using System.ComponentModel.DataAnnotations;

namespace Sistema_Facturacion.Models
{
    
    public class Cliente
    {
        [Key]
        [Display(Name = "Codigo Cliente")]
        public int Codigo_Cliente { get; set; }

        [Required(ErrorMessage = "El campo NOMBRE no puede ir vacío")]
        [Display(Name = "Nombre")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El campo APELLIDOS no puede ir vacío")]
        [Display(Name = "Apellidos")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El campo NIT no puede ir vacío")]
        [Display(Name = "Nit")]
        public string Nit { get; set; }

        [Required(ErrorMessage = "El campo TELEFONOS no puede ir vacío")]
        [Display(Name = "Telefonos")]
        public string Telefonos { get; set; }

        [Required(ErrorMessage = "El campo ACTIVO no puede ir vacío")]
        [Display(Name = "Activo")]
        public string Activo { get; set; }
    }
}

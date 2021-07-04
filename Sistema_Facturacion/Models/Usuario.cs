using System.ComponentModel.DataAnnotations;


namespace Sistema_Facturacion.Models
{
    public class Usuario
    {
        [Key]
        public int id_usuario { get; set; }

        [Required(ErrorMessage = "El campo USER no puede ir vacío")]
        [Display(Name = "Usuario")]
        public string User { get; set; }

        [Required(ErrorMessage = "El campo Nombre no puede ir vacío")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
       

        [Required(ErrorMessage = "El campo Password no puede ir vacío")]
        [Display(Name = "Contraseña")]
        public string password { get; set; }

    }
}

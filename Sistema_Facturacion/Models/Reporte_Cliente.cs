using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Facturacion.Models
{
    public class Reporte_Cliente
    {
        public string Dia { get; set; }
        public DateTime Fecha { get; set; }
        public string  Nombres { get; set; }
        public string Apellido { get; set; }

        [Key, Column(Order = 1)]
        [Display(Name = "Total Vendido")]
        public double Total { get; set; }
    }
}

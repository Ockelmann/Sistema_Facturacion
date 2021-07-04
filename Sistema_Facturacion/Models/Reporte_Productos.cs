using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Facturacion.Models
{
    public class Reporte_Productos
    {
        public string Dia { get; set; }
        public DateTime Fecha { get; set; }
        public int Codigo_Producto { get; set; }
        public string nombre { get; set; }

        [Key,Column(Order = 1)]
        [Display(Name = "Total Vendido")]
        public double Total { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Facturacion.Models
{
    public class Reporte_Estadistica
    {
        public string Dia { get; set; }
        public DateTime Fecha { get; set; }
        [Display(Name = "Facturas Emitidas")]
        public int Facturas_Emitidas { get; set; }
        [Key, Column(Order = 1)]
        [Display(Name = "Total")]
        public double Total { get; set; }
        [Display(Name = "Cantidad Productos")]
        public int Cantidad_Productos { get; set; }
    }
}

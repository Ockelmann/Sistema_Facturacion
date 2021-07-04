using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Sistema_Facturacion.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Facturacion.Controllers
{
    [Authorize]
    public class Reportes_ProductosFechaController : Controller
    {
        private readonly AplicationDbContext _context;

        public Reportes_ProductosFechaController(AplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ReporteVentasProducto(int? Codigo_Producto)
        {
            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.Productos)
            {
                listItems.Add(new SelectListItem() { Text = $"{item.nombre} - {item.descripcion} ", Value = $"{item.Codigo_Producto}" });
            }

            ViewData["Codigo_Producto"] = new SelectList(listItems, "Value", "Text");
            

            var list = await _context.Reporte_Productos.FromSqlRaw("Reporte_ProductosNombre @Codigo_Producto", new SqlParameter("@Codigo_Producto", Codigo_Producto)).ToListAsync();
                

            return View(list);
            

            
        }

        public async Task<IActionResult> ReporteVentasProductoFecha(string FechaInicio, string FechaFinal)
        {
           
            List<SqlParameter> parameters = new List<SqlParameter>
                    {
                       new SqlParameter("@FechaInicio", Convert.ToDateTime( FechaInicio)),
                       new SqlParameter("@FechaFinal", Convert.ToDateTime(FechaFinal))
                    };

                var list = await _context.Reporte_Productos.FromSqlRaw("Reporte_ProductosFecha @FechaInicio, @FechaFinal", parameters.ToArray()).ToListAsync();

              
                return View(list);
        }


        public async Task<IActionResult> ReporteVentasCliente(int? Codigo_Cliente)
        {

            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.Clientes)
            {
                listItems.Add(new SelectListItem() { Text = $"{item.Nombres} - {item.Apellido} ", Value = $"{item.Codigo_Cliente}" });
            }

            ViewData["Codigo_Cliente"] = new SelectList(listItems, "Value", "Text");


            var list = await _context.Reporte_Clientes.FromSqlRaw("Reporte_ClienteNombre @Codigo_Cliente", new SqlParameter("@Codigo_Cliente", Codigo_Cliente)).ToListAsync();


            return View(list);
        }


        public async Task<IActionResult> ReporteVentasClienteFecha(string FechaInicio, string FechaFinal)
        {

            List<SqlParameter> parameters = new List<SqlParameter>
                    {
                       new SqlParameter("@FechaInicio", Convert.ToDateTime( FechaInicio)),
                       new SqlParameter("@FechaFinal", Convert.ToDateTime(FechaFinal))
                    };

            var list = await _context.Reporte_Clientes.FromSqlRaw("Reporte_ClienteFecha @FechaInicio, @FechaFinal", parameters.ToArray()).ToListAsync();


            return View(list);
        }


        public async Task<IActionResult> ReporteEstadisticaFacturacion(string FechaInicio, string FechaFinal)
        {

            List<SqlParameter> parameters = new List<SqlParameter>
                    {
                       new SqlParameter("@FechaInicio", Convert.ToDateTime( FechaInicio)),
                       new SqlParameter("@FechaFinal", Convert.ToDateTime(FechaFinal))
                    };

            var list = await _context.Reporte_Estadistica.FromSqlRaw("Reporte_EstadisticaFacturacion @FechaInicio, @FechaFinal", parameters.ToArray()).ToListAsync();


            return View(list);
        }



    }
}

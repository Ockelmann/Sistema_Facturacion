using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sistema_Facturacion.DB;
using Sistema_Facturacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Facturacion.Controllers
{
    [Authorize]
    public class Factura_ProductosController : Controller
    {
        private readonly AplicationDbContext _context;

        public Factura_ProductosController(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            var aplicationDbContext = _context.Factura_Productos.Where(p => p.Numero_Facturafk == id).Include(p => p.Productos);
            var factura = _context.Facturas.Find(id);
            ViewBag.Anulada = Convert.ToString(factura.Anulada);
            TempData["Numero_Factura"] = id;
            return View(await aplicationDbContext.ToListAsync());
        }

        public IActionResult Create(int? id)
        {
            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.Productos)
            {
                listItems.Add(new SelectListItem() { Text = $"{item.nombre} - {item.descripcion} Precio: Q{item.Precio}", Value = $"{item.Codigo_Producto}" });
            }

            TempData["Numero_Factura"] = Convert.ToString(id);
            ViewData["Codigo_Producto"] = new SelectList(listItems, "Value", "Text");

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Factura_Productos factura_Productos)
        {
            if (ModelState.IsValid)
            {
                Producto producto = _context.Productos.Find(factura_Productos.Codigo_Productofk);
                factura_Productos.Precio_Unitario = producto.Precio;

                ViewData["Precio_Unitario"] = factura_Productos.Precio_Unitario;

                if (factura_Productos.Cantidad <= producto.Existencia)
                {
                    _context.Factura_Productos.Add(factura_Productos);
                    _context.SaveChanges();

                    producto.Existencia = producto.Existencia - factura_Productos.Cantidad;
                    _context.Productos.Update(producto);
                    _context.SaveChanges();

                    Factura factura = _context.Facturas.Find(factura_Productos.Numero_Facturafk);
                    factura.Total_Factura = (factura_Productos.Precio_Unitario * factura_Productos.Cantidad) + factura.Total_Factura;
                    _context.Facturas.Update(factura);
                    _context.SaveChanges();

                    return RedirectToAction("Index", "Factura_Productos", new { id = factura_Productos.Numero_Facturafk });
                }
                else
                {
                    Console.WriteLine("No hay existencias suficientes Disponibles");
                    ViewBag.Message = String.Format($"No hay existencias suficientes Disponibles: {producto.Existencia}");
                }
                
            }

            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.Productos)
            {
                listItems.Add(new SelectListItem() { Text = $"{item.nombre} - {item.descripcion} Precio: Q{item.Precio}", Value = $"{item.Codigo_Producto}" });
            }
            TempData["Numero_Factura"] = Convert.ToString(factura_Productos.Numero_Facturafk);
            ViewData["Codigo_Producto"] = new SelectList(listItems, "Value", "Text");

            return View();
        }


        public async Task<IActionResult> Edit(int? numero_Factura, int? codigo_Producto)
        {
            if (numero_Factura == null || codigo_Producto == null)
            {
                return NotFound();
            }

            var factura_producto = await _context.Factura_Productos.FindAsync(numero_Factura, codigo_Producto);

            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.Productos)
            {
                listItems.Add(new SelectListItem() { Text = $"{item.nombre} - {item.descripcion} Precio: Q{item.Precio}", Value = $"{item.Codigo_Producto}" });
            }

            TempData["Numero_Factura"] = numero_Factura;
            ViewData["Codigo_Producto"] = new SelectList(listItems, "Value", "Text");

            return View(factura_producto);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Factura_Productos factura_Productos)
        {
            TempData["Numero_Factura"] = factura_Productos.Numero_Facturafk;
            if (ModelState.IsValid)
            {
                _context.Update(factura_Productos);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Factura_Productos", new { id = factura_Productos.Numero_Facturafk });
            }

            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.Productos)
            {
                listItems.Add(new SelectListItem() { Text = $"{item.nombre} - {item.descripcion} Precio: Q{item.Precio}", Value = $"{item.Codigo_Producto}" });
            }

            ViewData["Codigo_Producto"] = new SelectList(listItems, "Value", "Text");

            return View();
        }


        public IActionResult Delete(int? numero_Factura, int? codigo_Producto)
        {
            if (numero_Factura == null || codigo_Producto == null)
            {
                return NotFound();
            }
            TempData["Numero_Factura"] = Convert.ToString(numero_Factura);

            var factura_Productos = _context.Factura_Productos.Find(numero_Factura, codigo_Producto);

            return View(factura_Productos);
        }


        public async Task<IActionResult> ConfirmacionEliminar(int? numero_Factura, int? codigo_Producto)
        {
            TempData["Numero_Factura"] = Convert.ToString(numero_Factura);
            try
            {
                var producto = _context.Productos.Find(codigo_Producto);
                var factura = _context.Facturas.Find(numero_Factura);
                var factura_Productos = _context.Factura_Productos.Find(numero_Factura, codigo_Producto);

                factura.Total_Factura = factura.Total_Factura - (factura_Productos.Cantidad * producto.Precio);
                _context.Facturas.Update(factura);
                _context.SaveChanges();

                producto.Existencia = producto.Existencia + factura_Productos.Cantidad;
                _context.Productos.Update(producto);
                _context.SaveChanges();

                _context.Factura_Productos.Remove(factura_Productos);

                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Factura_Productos", new { id = factura_Productos.Numero_Facturafk });
            }
            catch (Exception e)
            {
                return RedirectToAction("HttpError404", new { erro = e });
            }
        }

    }
}

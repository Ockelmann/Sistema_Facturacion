using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sistema_Facturacion.DB;
using Sistema_Facturacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Facturacion.Controllers
{
    [Authorize]
    public class ProductosController : Controller
    {
        private readonly AplicationDbContext _context;

        public ProductosController(AplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Producto> listaProductos = _context.Productos;
            return View(listaProductos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Producto producto)
        {
            if (ModelState.IsValid)
            {
                _context.Productos.Add(producto);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var producto = _context.Productos.Find(id);
            if (id.HasValue == false)
            {
                return NotFound();
            }
            else
            {
                return View(producto);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Producto producto)
        {
            if (ModelState.IsValid)
            {
                _context.Update(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Delete(int? id)
        {
            var producto = _context.Productos.Find(id);
            if (id.HasValue == false)
            {
                return RedirectToAction("HttpError404");
            }
            else
            {
                return View(producto);
            }
        }

        public async Task<IActionResult> ConfirmacionEliminar(int? id)
        {
            try
            {
                var producto = _context.Productos.Find(id);
                _context.Productos.Remove(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return RedirectToAction("HttpError404", new { erro = e });
            }


        }

        public ActionResult HttpError404(Exception erro)
        {
            TempData["Error"] = erro.Message;
            return View();
        }

    }
}

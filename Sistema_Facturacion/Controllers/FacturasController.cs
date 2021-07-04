using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sistema_Facturacion.DB;
using Sistema_Facturacion.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sistema_Facturacion.Controllers
{
    [Authorize]
    public class FacturasController : Controller
    {
        private readonly AplicationDbContext _context;
        

        public FacturasController(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var aplicationDbContext = _context.Facturas.Include(p => p.Cliente);
            return View(await aplicationDbContext.ToListAsync());
        }

        public IActionResult Create()
        {
            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.Clientes)
            {
                listItems.Add(new SelectListItem() { Text = $"{item.Nombres} {item.Apellido}", Value = $"{item.Codigo_Cliente}" });
            }

            ViewData["Codigo_Cliente"] = new SelectList(listItems, "Value", "Text");

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Numero_Factura,Fecha,Total_Factura,Anulada,Codigo_Clientefk")] Factura factura)
        {
            if (ModelState.IsValid)
            {
                _context.Add(factura);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create", "Factura_Productos", new { id = factura.Numero_Factura });

            }

            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.Clientes)
            {
                listItems.Add(new SelectListItem() { Text = $"{item.Nombres} {item.Apellido}", Value = $"{item.Codigo_Cliente}" });
            }

    
            ViewData["Codigo_Cliente"] = new SelectList(listItems, "Value", "Text");
            return View();
        }

       public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factura = await _context.Facturas.FindAsync(id);


            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.Clientes)
            {
                listItems.Add(new SelectListItem() { Text = $"{item.Nombres} {item.Apellido}", Value = $"{item.Codigo_Cliente}" });
            }

            ViewData["Codigo_Cliente"] = new SelectList(listItems, "Value", "Text");

            return View(factura);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Factura factura)
        {
            if (ModelState.IsValid)
            {
                _context.Update(factura);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.Clientes)
            {
                listItems.Add(new SelectListItem() { Text = $"{item.Nombres} {item.Apellido}", Value = $"{item.Codigo_Cliente}" });
            }

            ViewData["Codigo_Cliente"] = new SelectList(listItems, "Value", "Text");

            return View();
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factura = await _context.Facturas.FindAsync(id);
            var cliente = await _context.Clientes.FindAsync(factura.Codigo_Clientefk);

            ViewBag.Cliente = cliente.Nombres;
            return View(factura);
        }


        public async Task<IActionResult> ConfirmacionEliminar(int? id)
        {
            try
            {
                var persona = _context.Facturas.Find(id);
                _context.Facturas.Remove(persona);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return RedirectToAction("HttpError404", new { erro = e });
            }
        }


        public async Task<IActionResult> DetalleFactura(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factura = await _context.Facturas.FindAsync(id);

            return RedirectToAction("Index", "Factura_Productos", new { id = factura.Numero_Factura });
        }



    }
}



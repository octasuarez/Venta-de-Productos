using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcVentas.Data;
using VentaDeProductos.Models;

namespace VentaDeProductos.Controllers
{
    public class SubCategoriaController : Controller
    {
        private readonly MvcVentasContext _context;

        public SubCategoriaController(MvcVentasContext context)
        {
            _context = context;
        }

        // GET: SubCategoria
        public async Task<IActionResult> Index()
        {
            var mvcVentasContext = _context.SubCategorias.Include(s => s.Categoria);
            return View(await mvcVentasContext.ToListAsync());
        }

        // GET: SubCategoria/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SubCategorias == null)
            {
                return NotFound();
            }

            var subCategoria = await _context.SubCategorias
                .Include(s => s.Categoria)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subCategoria == null)
            {
                return NotFound();
            }

            return View(subCategoria);
        }

        // GET: SubCategoria/Create
        public IActionResult Create()
        {
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "Id", "Nombre");
            return View();
        }

        // POST: SubCategoria/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,CategoriaId")] SubCategoria subCategoria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subCategoria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "Id", "Nombre", subCategoria.CategoriaId);
            return View(subCategoria);
        }

        // GET: SubCategoria/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SubCategorias == null)
            {
                return NotFound();
            }

            var subCategoria = await _context.SubCategorias.FindAsync(id);
            if (subCategoria == null)
            {
                return NotFound();
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "Id", "Nombre", subCategoria.CategoriaId);
            return View(subCategoria);
        }

        // POST: SubCategoria/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,CategoriaId")] SubCategoria subCategoria)
        {
            if (id != subCategoria.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subCategoria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubCategoriaExists(subCategoria.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "Id", "Nombre", subCategoria.CategoriaId);
            return View(subCategoria);
        }

        // GET: SubCategoria/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SubCategorias == null)
            {
                return NotFound();
            }

            var subCategoria = await _context.SubCategorias
                .Include(s => s.Categoria)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subCategoria == null)
            {
                return NotFound();
            }

            return View(subCategoria);
        }

        // POST: SubCategoria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SubCategorias == null)
            {
                return Problem("Entity set 'MvcVentasContext.SubCategorias'  is null.");
            }
            var subCategoria = await _context.SubCategorias.FindAsync(id);
            if (subCategoria != null)
            {
                _context.SubCategorias.Remove(subCategoria);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubCategoriaExists(int id)
        {
          return (_context.SubCategorias?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

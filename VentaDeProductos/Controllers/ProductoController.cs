using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcVentas.Data;
using VentaDeProductos.Models;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace VentaDeProductos.Controllers
{
    public class ProductoController : Controller
    {
        private readonly MvcVentasContext _context;
        private IWebHostEnvironment _WebHostEnviroment;

        public ProductoController(MvcVentasContext context, IWebHostEnvironment env)
        {
            _context = context;
            this._WebHostEnviroment = env;
        }

        // GET: Producto
        public async Task<IActionResult> Index()
        {
            var mvcVentasContext = _context.Productos.Include(p => p.SubCategoria);
            return View(await mvcVentasContext.ToListAsync());
        }

        // GET: Producto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Productos == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos
                .Include(p => p.SubCategoria)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // GET: Producto/Create
        public IActionResult Create()
        {
            ViewData["SubCategoriaId"] = new SelectList(_context.SubCategorias, "Id", "Nombre");
            return View();
        }

        // POST: Producto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NombreProducto,SubCategoriaId,Precio,Descripcion,Descuento")] Producto producto, IFormFileCollection Imagenes)
        {
            if (ModelState.IsValid)
            {
                if(Imagenes != null) {

                    producto.Imagenes = new List<ProductoImagen>();

                    foreach (var i in Imagenes)
                    {
                        string imagePath = await SubirImagen(i);

                        if (imagePath != null)
                           producto.Imagenes.Add(new ProductoImagen { ImagePath=imagePath});
                    }
                }


                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SubCategoriaId"] = new SelectList(_context.SubCategorias, "Id", "Nombre", producto.SubCategoriaId);
            return View(producto);
        }

        //COPIAR IMAGEN A CARPETA Y DEVOLVER SU PATH
        private async Task<string> SubirImagen (IFormFile imagen) {

            var FileDic = "ImagenesProductos";
            string FilePath = Path.Combine(_WebHostEnviroment.WebRootPath, FileDic);
            if (!Directory.Exists(FilePath))
                Directory.CreateDirectory(FilePath);

            var imageName = Guid.NewGuid().ToString() + "_" + imagen.FileName;
            var filePath = Path.Combine(FilePath, imageName);

            using(FileStream fs = System.IO.File.Create(filePath)) {
               await imagen.CopyToAsync(fs);
            }


            return imageName;
        }

        // GET: Producto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Productos == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            ViewData["SubCategoriaId"] = new SelectList(_context.SubCategorias, "Id", "Nombre", producto.SubCategoriaId);
            return View(producto);
        }

        // POST: Producto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NombreProducto,SubCategoriaId,Precio,Descripcion,Descuento,ImagenPortada")] Producto producto)
        {
            if (id != producto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExists(producto.Id))
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
            ViewData["SubCategoriaId"] = new SelectList(_context.SubCategorias, "Id", "Nombre", producto.SubCategoriaId);
            return View(producto);
        }

        // GET: Producto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Productos == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos
                .Include(p => p.SubCategoria)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // POST: Producto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Productos == null)
            {
                return Problem("Entity set 'MvcVentasContext.Productos'  is null.");
            }
            var producto = await _context.Productos.Include(p=> p.Imagenes).FirstOrDefaultAsync(p=> p.Id == id);
            if (producto != null)
            {
                if (producto.Imagenes != null)
                    _context.ProductoImagenes.RemoveRange(producto.Imagenes);
                _context.Productos.Remove(producto);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductoExists(int id)
        {
          return (_context.Productos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

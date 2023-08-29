using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcVentas.Data;
using VentaDeProductos.Controllers;
using VentaDeProductos.Models;

namespace VentaDeProductos.ViewComponents
{
	public class MenuViewComponent : ViewComponent
	{
        private readonly MvcVentasContext _context;

        public MenuViewComponent(MvcVentasContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke() {

            List<Categoria> categorias = _context.Categorias.Include(c => c.SubCategorias).ToList();
            return View(categorias);
		}
	}
}


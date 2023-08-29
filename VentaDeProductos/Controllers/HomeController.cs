using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcVentas.Data;
using VentaDeProductos.Models;

namespace VentaDeProductos.Controllers;

public class HomeController : Controller
{
    private readonly MvcVentasContext _context;

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, MvcVentasContext context)
    {
        _context = context;
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Producto> productos = new List<Producto>();

        productos = _context.Productos.Include(p => p.Imagenes).ToList();

        List<Categoria> categorias = _context.Categorias.Include(c => c.SubCategorias).ToList();

        ViewBag.Categorias = categorias;

        return View(productos.ToList());
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}


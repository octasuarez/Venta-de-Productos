using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VentaDeProductos.Models;

namespace MvcVentas.Data
{
    public class MvcVentasContext : DbContext
    {
        public MvcVentasContext (DbContextOptions<MvcVentasContext> options)
            : base(options)
        {
        }

        public DbSet<VentaDeProductos.Models.Pais> Pais { get; set; } = default!;
        public DbSet<VentaDeProductos.Models.Producto> Productos { get; set; } = default!;
        public DbSet<VentaDeProductos.Models.Categoria> Categorias { get; set; } = default!;
        public DbSet<VentaDeProductos.Models.SubCategoria> SubCategorias { get; set; } = default!;
    }
}

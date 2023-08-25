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
        public MvcVentasContext(DbContextOptions<MvcVentasContext> options)
            : base(options)
        {
        }

        public DbSet<VentaDeProductos.Models.Pais> Pais { get; set; } = default!;
        public DbSet<VentaDeProductos.Models.Producto> Productos { get; set; } = default!;
        public DbSet<VentaDeProductos.Models.Categoria> Categorias { get; set; } = default!;
        public DbSet<VentaDeProductos.Models.SubCategoria> SubCategorias { get; set; } = default!;
        public DbSet<VentaDeProductos.Models.ProductoImagen> ProductoImagenes { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria { Id = 1, Nombre = "Comida" },
                new Categoria { Id = 2, Nombre = "Tecnologia" },
                new Categoria { Id = 3, Nombre = "Ferreteria" }
            );

            modelBuilder.Entity<SubCategoria>().HasData(
                new SubCategoria { Id = 1, Nombre = "Carnes", CategoriaId = 1 },
                new SubCategoria { Id = 2, Nombre = "Postres", CategoriaId = 1 },
                new SubCategoria { Id = 3, Nombre = "Computadoras", CategoriaId = 2 },
                new SubCategoria { Id = 4, Nombre = "Celulares", CategoriaId = 2 },
                new SubCategoria { Id = 5, Nombre = "Herramientas", CategoriaId = 3 },
                new SubCategoria { Id = 6, Nombre = "Pinturas", CategoriaId = 3 }
            );
            modelBuilder.Entity<Producto>().HasData(
                new Producto { Id = 1, NombreProducto = "Carne Picada Kg", Descripcion = "Carne roja de vacuno picada especial.", Precio = 349, SubCategoriaId = 1 },
                new Producto { Id = 2, NombreProducto = "Pollo Kg", Descripcion = "Carne de pollo de la pechuga por kilo", Precio = 309, SubCategoriaId = 1 },
                new Producto { Id = 3, NombreProducto = "Torta de chocolate", Descripcion = "Torta manjar \nchocolate por fuera con capas de dulce de leche por dentro", Precio = 796, SubCategoriaId = 2 },
                new Producto { Id = 4, NombreProducto = "Macbook Air m2", Descripcion = "CPU de 8 núcleos con 4 núcleos de rendimiento y 4 de eficiencia\nGPU de 8 núcleos\nNeural Engine de 16 núcleos\n100 GB/s de ancho de banda de memoria", Precio = 644663, SubCategoriaId = 3 },
                new Producto { Id = 5, NombreProducto = "Iphone 13", Descripcion = "Pantalla super Retina xdr \n128gb\nChip de ultima generacion", Precio = 39775, SubCategoriaId = 4 },
                new Producto { Id = 6, NombreProducto = "Xiaomi Redmi 10", Descripcion = "Pantalla LCD de 6.5\n4 camaras traseras\nProcesador Mediatek\nBateria de 5000mAh", Precio = 5730, SubCategoriaId = 4 },
                new Producto { Id = 7, NombreProducto = "Taladro Atornillador", Descripcion = "Voltaje: DC-20V\nTorque Maximo: 30N.m\nMandril: 10mm\nAuto bloqueo", Precio = 1200, SubCategoriaId = 5 },
                new Producto { Id = 8, NombreProducto = "Martillo", Descripcion = "Martillo de uña 250g", Precio = 279, SubCategoriaId = 5 },
                new Producto { Id = 9, NombreProducto = "Brocha Polinylon", Descripcion = "profesional 3", Precio = 209, SubCategoriaId = 6 },
                new Producto { Id = 10, NombreProducto = "Rodillo", Descripcion = "para pintar mas fluidamente", Precio = 169, SubCategoriaId = 6 }
            );
            modelBuilder.Entity<ProductoImagen>().HasData(
                new ProductoImagen { Id = 1, ProductoId = 1, ImagePath = "carnepicada.jpg" },
                new ProductoImagen { Id = 2, ProductoId = 2, ImagePath = "pollo.jpg" },
                new ProductoImagen { Id = 3, ProductoId = 3, ImagePath = "torta.jpg" },
                new ProductoImagen { Id = 4, ProductoId = 4, ImagePath = "macbook1.jpg" },
                new ProductoImagen { Id = 5, ProductoId = 4, ImagePath = "macbook2.jpg" },
                new ProductoImagen { Id = 6, ProductoId = 5, ImagePath = "iphone1.jpg" },
                new ProductoImagen { Id = 7, ProductoId = 5, ImagePath = "iphone2.jpg" },
                new ProductoImagen { Id = 8, ProductoId = 5, ImagePath = "iphone3.jpg" },
                new ProductoImagen { Id = 9, ProductoId = 6, ImagePath = "xiaomi1.jpg" },
                new ProductoImagen { Id = 10, ProductoId = 6, ImagePath = "xiaomi2.jpg" },
                new ProductoImagen { Id = 11, ProductoId = 7, ImagePath = "taladro.jpg" },
                new ProductoImagen { Id = 12, ProductoId = 8, ImagePath = "martillo.jpg" },
                new ProductoImagen { Id = 13, ProductoId = 9, ImagePath = "brocha.jpg" },
                new ProductoImagen { Id = 14, ProductoId = 10, ImagePath = "rodillo.jpg" }
            );

        }
    }
}

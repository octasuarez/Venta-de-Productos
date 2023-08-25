﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcVentas.Data;

#nullable disable

namespace VentaDeProductos.Migrations
{
    [DbContext(typeof(MvcVentasContext))]
    [Migration("20230825154501_PrecargaDeDatos")]
    partial class PrecargaDeDatos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("VentaDeProductos.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Comida"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Tecnologia"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Ferreteria"
                        });
                });

            modelBuilder.Entity("VentaDeProductos.Models.Pais", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PaisNombre")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Pais");
                });

            modelBuilder.Entity("VentaDeProductos.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreProducto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Precio")
                        .HasColumnType("TEXT");

                    b.Property<int>("SubCategoriaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SubCategoriaId");

                    b.ToTable("Producto");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "Carne roja de vacuno picada especial.",
                            NombreProducto = "Carne Picada Kg",
                            Precio = 349m,
                            SubCategoriaId = 1
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "Carne de pollo de la pechuga por kilo",
                            NombreProducto = "Pollo Kg",
                            Precio = 309m,
                            SubCategoriaId = 1
                        },
                        new
                        {
                            Id = 3,
                            Descripcion = "Torta manjar \nchocolate por fuera con capas de dulce de leche por dentro",
                            NombreProducto = "Torta de chocolate",
                            Precio = 796m,
                            SubCategoriaId = 2
                        },
                        new
                        {
                            Id = 4,
                            Descripcion = "CPU de 8 núcleos con 4 núcleos de rendimiento y 4 de eficiencia\nGPU de 8 núcleos\nNeural Engine de 16 núcleos\n100 GB/s de ancho de banda de memoria",
                            NombreProducto = "Macbook Air m2",
                            Precio = 644663m,
                            SubCategoriaId = 3
                        },
                        new
                        {
                            Id = 5,
                            Descripcion = "Pantalla super Retina xdr \n128gb\nChip de ultima generacion",
                            NombreProducto = "Iphone 13",
                            Precio = 39775m,
                            SubCategoriaId = 4
                        },
                        new
                        {
                            Id = 6,
                            Descripcion = "Pantalla LCD de 6.5\n4 camaras traseras\nProcesador Mediatek\nBateria de 5000mAh",
                            NombreProducto = "Xiaomi Redmi 10",
                            Precio = 5730m,
                            SubCategoriaId = 4
                        },
                        new
                        {
                            Id = 7,
                            Descripcion = "Voltaje: DC-20V\nTorque Maximo: 30N.m\nMandril: 10mm\nAuto bloqueo",
                            NombreProducto = "Taladro Atornillador",
                            Precio = 1200m,
                            SubCategoriaId = 5
                        },
                        new
                        {
                            Id = 8,
                            Descripcion = "Martillo de uña 250g",
                            NombreProducto = "Martillo",
                            Precio = 279m,
                            SubCategoriaId = 5
                        },
                        new
                        {
                            Id = 9,
                            Descripcion = "profesional 3",
                            NombreProducto = "Brocha Polinylon",
                            Precio = 209m,
                            SubCategoriaId = 6
                        },
                        new
                        {
                            Id = 10,
                            Descripcion = "para pintar mas fluidamente",
                            NombreProducto = "Rodillo",
                            Precio = 169m,
                            SubCategoriaId = 6
                        });
                });

            modelBuilder.Entity("VentaDeProductos.Models.ProductoImagen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImagePath")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProductoId");

                    b.ToTable("ProductoImagenes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImagePath = "carnepicada.jpg",
                            ProductoId = 1
                        },
                        new
                        {
                            Id = 2,
                            ImagePath = "pollo.jpg",
                            ProductoId = 2
                        },
                        new
                        {
                            Id = 3,
                            ImagePath = "torta.jpg",
                            ProductoId = 3
                        },
                        new
                        {
                            Id = 4,
                            ImagePath = "macbook1.jpg",
                            ProductoId = 4
                        },
                        new
                        {
                            Id = 5,
                            ImagePath = "macbook2.jpg",
                            ProductoId = 4
                        },
                        new
                        {
                            Id = 6,
                            ImagePath = "iphone1.jpg",
                            ProductoId = 5
                        },
                        new
                        {
                            Id = 7,
                            ImagePath = "iphone2.jpg",
                            ProductoId = 5
                        },
                        new
                        {
                            Id = 8,
                            ImagePath = "iphone3.jpg",
                            ProductoId = 5
                        },
                        new
                        {
                            Id = 9,
                            ImagePath = "xiaomi1.jpg",
                            ProductoId = 6
                        },
                        new
                        {
                            Id = 10,
                            ImagePath = "xiaomi2.jpg",
                            ProductoId = 6
                        },
                        new
                        {
                            Id = 11,
                            ImagePath = "taladro.jpg",
                            ProductoId = 7
                        },
                        new
                        {
                            Id = 12,
                            ImagePath = "martillo.jpg",
                            ProductoId = 8
                        },
                        new
                        {
                            Id = 13,
                            ImagePath = "brocha.jpg",
                            ProductoId = 9
                        },
                        new
                        {
                            Id = 14,
                            ImagePath = "rodillo.jpg",
                            ProductoId = 10
                        });
                });

            modelBuilder.Entity("VentaDeProductos.Models.SubCategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("SubCategorias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoriaId = 1,
                            Nombre = "Carnes"
                        },
                        new
                        {
                            Id = 2,
                            CategoriaId = 1,
                            Nombre = "Postres"
                        },
                        new
                        {
                            Id = 3,
                            CategoriaId = 2,
                            Nombre = "Computadoras"
                        },
                        new
                        {
                            Id = 4,
                            CategoriaId = 2,
                            Nombre = "Celulares"
                        },
                        new
                        {
                            Id = 5,
                            CategoriaId = 3,
                            Nombre = "Herramientas"
                        },
                        new
                        {
                            Id = 6,
                            CategoriaId = 3,
                            Nombre = "Pinturas"
                        });
                });

            modelBuilder.Entity("VentaDeProductos.Models.Producto", b =>
                {
                    b.HasOne("VentaDeProductos.Models.SubCategoria", "SubCategoria")
                        .WithMany("Productos")
                        .HasForeignKey("SubCategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubCategoria");
                });

            modelBuilder.Entity("VentaDeProductos.Models.ProductoImagen", b =>
                {
                    b.HasOne("VentaDeProductos.Models.Producto", "Producto")
                        .WithMany("Imagenes")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("VentaDeProductos.Models.SubCategoria", b =>
                {
                    b.HasOne("VentaDeProductos.Models.Categoria", "Categoria")
                        .WithMany("SubCategorias")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("VentaDeProductos.Models.Categoria", b =>
                {
                    b.Navigation("SubCategorias");
                });

            modelBuilder.Entity("VentaDeProductos.Models.Producto", b =>
                {
                    b.Navigation("Imagenes");
                });

            modelBuilder.Entity("VentaDeProductos.Models.SubCategoria", b =>
                {
                    b.Navigation("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}

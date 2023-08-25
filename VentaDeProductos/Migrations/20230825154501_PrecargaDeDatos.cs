using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VentaDeProductos.Migrations
{
    /// <inheritdoc />
    public partial class PrecargaDeDatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductoImagenes_Producto_ProductoId",
                table: "ProductoImagenes");

            migrationBuilder.AlterColumn<int>(
                name: "ProductoId",
                table: "ProductoImagenes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Comida" },
                    { 2, "Tecnologia" },
                    { 3, "Ferreteria" }
                });

            migrationBuilder.InsertData(
                table: "SubCategorias",
                columns: new[] { "Id", "CategoriaId", "Nombre" },
                values: new object[,]
                {
                    { 1, 1, "Carnes" },
                    { 2, 1, "Postres" },
                    { 3, 2, "Computadoras" },
                    { 4, 2, "Celulares" },
                    { 5, 3, "Herramientas" },
                    { 6, 3, "Pinturas" }
                });

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "Id", "Descripcion", "NombreProducto", "Precio", "SubCategoriaId" },
                values: new object[,]
                {
                    { 1, "Carne roja de vacuno picada especial.", "Carne Picada Kg", 349m, 1 },
                    { 2, "Carne de pollo de la pechuga por kilo", "Pollo Kg", 309m, 1 },
                    { 3, "Torta manjar \nchocolate por fuera con capas de dulce de leche por dentro", "Torta de chocolate", 796m, 2 },
                    { 4, "CPU de 8 núcleos con 4 núcleos de rendimiento y 4 de eficiencia\nGPU de 8 núcleos\nNeural Engine de 16 núcleos\n100 GB/s de ancho de banda de memoria", "Macbook Air m2", 644663m, 3 },
                    { 5, "Pantalla super Retina xdr \n128gb\nChip de ultima generacion", "Iphone 13", 39775m, 4 },
                    { 6, "Pantalla LCD de 6.5\n4 camaras traseras\nProcesador Mediatek\nBateria de 5000mAh", "Xiaomi Redmi 10", 5730m, 4 },
                    { 7, "Voltaje: DC-20V\nTorque Maximo: 30N.m\nMandril: 10mm\nAuto bloqueo", "Taladro Atornillador", 1200m, 5 },
                    { 8, "Martillo de uña 250g", "Martillo", 279m, 5 },
                    { 9, "profesional 3", "Brocha Polinylon", 209m, 6 },
                    { 10, "para pintar mas fluidamente", "Rodillo", 169m, 6 }
                });

            migrationBuilder.InsertData(
                table: "ProductoImagenes",
                columns: new[] { "Id", "ImagePath", "ProductoId" },
                values: new object[,]
                {
                    { 1, "carnepicada.jpg", 1 },
                    { 2, "pollo.jpg", 2 },
                    { 3, "torta.jpg", 3 },
                    { 4, "macbook1.jpg", 4 },
                    { 5, "macbook2.jpg", 4 },
                    { 6, "iphone1.jpg", 5 },
                    { 7, "iphone2.jpg", 5 },
                    { 8, "iphone3.jpg", 5 },
                    { 9, "xiaomi1.jpg", 6 },
                    { 10, "xiaomi2.jpg", 6 },
                    { 11, "taladro.jpg", 7 },
                    { 12, "martillo.jpg", 8 },
                    { 13, "brocha.jpg", 9 },
                    { 14, "rodillo.jpg", 10 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoImagenes_Producto_ProductoId",
                table: "ProductoImagenes",
                column: "ProductoId",
                principalTable: "Producto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductoImagenes_Producto_ProductoId",
                table: "ProductoImagenes");

            migrationBuilder.DeleteData(
                table: "ProductoImagenes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductoImagenes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductoImagenes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductoImagenes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductoImagenes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductoImagenes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductoImagenes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductoImagenes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductoImagenes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductoImagenes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductoImagenes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductoImagenes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductoImagenes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductoImagenes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SubCategorias",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubCategorias",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SubCategorias",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubCategorias",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SubCategorias",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SubCategorias",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "ProductoId",
                table: "ProductoImagenes",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoImagenes_Producto_ProductoId",
                table: "ProductoImagenes",
                column: "ProductoId",
                principalTable: "Producto",
                principalColumn: "Id");
        }
    }
}

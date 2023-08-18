using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VentaDeProductos.Migrations
{
    /// <inheritdoc />
    public partial class ImagenPortadaProducto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Producto");

            migrationBuilder.AddColumn<string>(
                name: "ImagenPortada",
                table: "Producto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagenPortada",
                table: "Producto");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Producto",
                type: "TEXT",
                nullable: true);
        }
    }
}

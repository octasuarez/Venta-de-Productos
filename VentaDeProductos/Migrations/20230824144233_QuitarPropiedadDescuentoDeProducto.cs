using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VentaDeProductos.Migrations
{
    /// <inheritdoc />
    public partial class QuitarPropiedadDescuentoDeProducto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descuento",
                table: "Producto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Descuento",
                table: "Producto",
                type: "INTEGER",
                nullable: true);
        }
    }
}

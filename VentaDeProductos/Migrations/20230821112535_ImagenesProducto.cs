using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VentaDeProductos.Migrations
{
    /// <inheritdoc />
    public partial class ImagenesProducto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagenPortada",
                table: "Producto");

            migrationBuilder.CreateTable(
                name: "ProductoImagen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: true),
                    ImagePath = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoImagen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductoImagen_Producto_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Producto",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductoImagen_ProductoId",
                table: "ProductoImagen",
                column: "ProductoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductoImagen");

            migrationBuilder.AddColumn<string>(
                name: "ImagenPortada",
                table: "Producto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}

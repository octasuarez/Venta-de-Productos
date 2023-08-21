using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VentaDeProductos.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTablaImgsProd_UpdateListEnProducto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductoImagen_Producto_ProductoId",
                table: "ProductoImagen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductoImagen",
                table: "ProductoImagen");

            migrationBuilder.RenameTable(
                name: "ProductoImagen",
                newName: "ProductoImagenes");

            migrationBuilder.RenameIndex(
                name: "IX_ProductoImagen_ProductoId",
                table: "ProductoImagenes",
                newName: "IX_ProductoImagenes_ProductoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductoImagenes",
                table: "ProductoImagenes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoImagenes_Producto_ProductoId",
                table: "ProductoImagenes",
                column: "ProductoId",
                principalTable: "Producto",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductoImagenes_Producto_ProductoId",
                table: "ProductoImagenes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductoImagenes",
                table: "ProductoImagenes");

            migrationBuilder.RenameTable(
                name: "ProductoImagenes",
                newName: "ProductoImagen");

            migrationBuilder.RenameIndex(
                name: "IX_ProductoImagenes_ProductoId",
                table: "ProductoImagen",
                newName: "IX_ProductoImagen_ProductoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductoImagen",
                table: "ProductoImagen",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoImagen_Producto_ProductoId",
                table: "ProductoImagen",
                column: "ProductoId",
                principalTable: "Producto",
                principalColumn: "Id");
        }
    }
}

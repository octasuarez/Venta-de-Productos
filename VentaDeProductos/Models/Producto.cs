using System;
using System.ComponentModel.DataAnnotations;

namespace VentaDeProductos.Models
{
	[System.ComponentModel.DataAnnotations.Schema.Table("Producto")]
	public class Producto
	{
		public int Id { get; set; }
		[Required]
		public string? NombreProducto { get; set; }

		public int SubCategoriaId { get; set; }
		public virtual SubCategoria? SubCategoria { get; set; }

		[Required]
		public decimal Precio { get; set; }
		[Required]
		public string? Descripcion { get; set; }

		public virtual ICollection<ProductoImagen>? Imagenes {get;set;}
	}
}


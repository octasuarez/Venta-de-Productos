using System;
namespace VentaDeProductos.Models
{
	public class ProductoImagen
	{
		public int Id { get; set; }
		public virtual Producto? Producto { get; set; }
		public string? ImagePath { get; set; }

	}
}


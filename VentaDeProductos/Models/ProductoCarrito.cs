using System;
namespace VentaDeProductos.Models
{
	public class ProductoCarrito
	{
		public int CarritoId { get; set; }
		public int ProductoId { get; set; }
		public int Cantidad { get; set; }

		public virtual Producto? Producto { get; set; }
	}
}


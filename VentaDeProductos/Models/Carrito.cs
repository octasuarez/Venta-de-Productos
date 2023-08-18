using System;
namespace VentaDeProductos.Models
{
	public class Carrito
	{
		public int Id { get; set; }
		public virtual Usuario? Usuario { get; set; }


		public virtual ICollection<ProductoCarrito>? Productos { get; set; }

	}
}


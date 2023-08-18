using System;
namespace VentaDeProductos.Models
{
	public class Marca
	{
		public int Id { get; set; }
		public string? Nombre { get; set; }
		public string? Descripcion { get; set; }
		public string? ImagePath { get; set; }


		public virtual ICollection<Producto>? Productos { get; set; }
	}
}


using System;
namespace VentaDeProductos.Models
{
	public class Usuario
	{
		public int Id { get; set; }
		public string? NombreUsuario { get; set; }
		public string? Email { get; set; }
		public int Telefono { get; set; }
		public string? Direccion { get; set; }


		public virtual Rol? Rol { get; set; }
		public virtual ICollection<Factura>? Facturas { get; set; }

	}
}


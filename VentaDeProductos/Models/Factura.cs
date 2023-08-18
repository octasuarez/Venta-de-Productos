using System;
namespace VentaDeProductos.Models
{
	public class Factura
	{
		public int Id { get; set; }
		public int UsuarioId { get; set; }
		public decimal Total { get; set; }
		public DateTime FechaCompra { get; set; }
		public virtual ICollection<LineaFactura>? LineaFacturas { get; set; }
	}
}


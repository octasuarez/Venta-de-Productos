using System;
namespace VentaDeProductos.Models
{
	public class LineaFactura
	{
		public int FacturaId { get; set; }
		public int ProductoId { get; set; }
		public int Cantidad { get; set; }

		public virtual Producto? Producto { get; set; }
	}
}


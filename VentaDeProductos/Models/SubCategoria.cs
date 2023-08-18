using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VentaDeProductos.Models
{
	public class SubCategoria
	{
		public int Id { get; set; }
		[Required]
		public string? Nombre { get; set; }
		
		public int CategoriaId { get; set; }
		public virtual Categoria? Categoria { get; set; }

		public virtual ICollection<Producto>? Productos { get; set; }
	}
}


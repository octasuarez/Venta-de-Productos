using System;
using System.ComponentModel.DataAnnotations;

namespace VentaDeProductos.Models
{
	public class Categoria
	{
		public int Id { get; set; }
		[Required]
		public string? Nombre { get; set; }

		public virtual ICollection<SubCategoria>? SubCategorias { get; set; }

	}
}


using System;

namespace Desktop.Mercado.Models
{
	public class TipoUsuario
	{
		public int Codigo { get; set; }
		public string Nome { get; set; }
		public DateTime DataHoraCadastro { get; set; }
		public bool Ativo { get; set; }

		public override string ToString()
		{
			return Nome;
		}
	}
}

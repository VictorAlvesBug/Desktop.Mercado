using System;

namespace Desktop.Mercado.Models
{
	public class Produto
	{
        public int Codigo { get; set; }
		public string Nome { get; set; }
		public decimal Preco { get; set; }
		public string Foto { get; set; }
		public int CodigoCategoria { get; set; }
		public Categoria Categoria { get; set; }
		public DateTime DataHoraCadastro { get; set; }
		public bool Ativo { get; set; }
	}
}

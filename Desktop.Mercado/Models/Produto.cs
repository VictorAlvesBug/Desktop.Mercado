using System;
using System.Drawing;
using System.Windows.Forms;

namespace Desktop.Mercado.Models
{
	public class Produto
	{
		public int Codigo { get; set; }
		public string Nome { get; set; }
		public decimal Preco { get; set; }
		public string NomeFoto { get; set; }
		public Image ArquivoFoto
		{
			get
			{
				try
				{
					string caminhoFoto = $"{Application.StartupPath}\\Fotos\\{NomeFoto}";
					return new Bitmap(caminhoFoto);
				}
				catch (Exception)
				{
					return null;
				}
			}
		}
		public int CodigoCategoria { get; set; }
		public Categoria Categoria { get; set; }
		public DateTime DataHoraCadastro { get; set; }
		public bool Ativo { get; set; }
	}
}

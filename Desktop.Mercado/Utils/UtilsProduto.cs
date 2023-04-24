using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Desktop.Mercado.Utils
{
	public static class UtilsProduto
	{
		public static bool NomeEhValido(string nome, out string mensagem)
		{
			bool quantidadeCaracteresValida = VerificarQuantidadeCaracteres(nome, 3, 100);

			mensagem = string.Empty;

			if (!quantidadeCaracteresValida)
			{ 
				mensagem = "O nome do produto deve ter de 3 a 100 caracteres\n";
				return false;
			}

			return true;
		}

		public static bool PrecoEhValido(decimal preco, out string mensagem)
		{
			bool faixaValoresValida = VerificarFaixaValores(preco, 0.01m, 999_999.99m);

			mensagem = string.Empty;

			if (!faixaValoresValida)
			{
				mensagem = "O preço do produto deve ser de R$ 0,01 até R$ 999.999,99\n";
				return false;
			}

			return true;
		}

		public static string AjustarPreco(string precoFormatado)
		{
			decimal precoDecimal = RetornarPrecoDecimal(precoFormatado);
			return RetornarPrecoFormatado(precoDecimal);
		}

		public static decimal RetornarPrecoDecimal(string precoFormatado)
		{
			string digitos = string.Concat(precoFormatado.Where(Char.IsDigit));

			if (!Decimal.TryParse(digitos, out decimal precoDecimal))
				precoDecimal = 0;

			precoDecimal /= 100;
			return precoDecimal;
		}

		public static string RetornarPrecoFormatado(decimal precoDecimal)
		{
			return precoDecimal.ToString("c2");
		}

		public static string SalvarFoto(Image arquivoFoto)
		{
			string nomeFoto = $"{Guid.NewGuid()}.jpg";
			string caminhoFoto = $"{Application.StartupPath}\\Fotos\\{nomeFoto}";

			using (MemoryStream memory = new MemoryStream())
			{
				using (FileStream fs = new FileStream(caminhoFoto, FileMode.Create, FileAccess.ReadWrite))
				{
					arquivoFoto.Save(memory, ImageFormat.Jpeg);
					byte[] bytes = memory.ToArray();
					fs.Write(bytes, 0, bytes.Length);
				}
			}
			return nomeFoto;
		}

		private static bool VerificarQuantidadeCaracteres(string texto, int min, int max)
		{
			texto = texto ?? "";
			return texto.Length >= min && texto.Length <= max;
		}

		private static bool VerificarFaixaValores(decimal valor, decimal min, decimal max)
		{
			return valor >= min && valor <= max;
		}
	}
}

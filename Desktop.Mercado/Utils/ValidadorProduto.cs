using System;
using System.Linq;

namespace Desktop.Mercado.Utils
{
	public static class ValidadorProduto
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

		public static string AjustarPreco(string preco, out decimal precoDecimal)
		{
			string digitos = string.Concat(preco.Where(Char.IsDigit));

			if (!Decimal.TryParse(digitos, out precoDecimal))
				precoDecimal = 0;

			precoDecimal = precoDecimal / 100;
			return precoDecimal.ToString("c2");
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

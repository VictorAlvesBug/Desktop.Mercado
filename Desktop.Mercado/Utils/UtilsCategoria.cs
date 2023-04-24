using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Desktop.Mercado.Utils
{
	public static class UtilsCategoria
	{
		public static bool NomeEhValido(string nome, out string mensagem)
		{
			bool quantidadeCaracteresValida = VerificarQuantidadeCaracteres(nome, 3, 100);

			mensagem = string.Empty;

			if (!quantidadeCaracteresValida)
			{ 
				mensagem = "O nome da categoria deve ter de 3 a 100 caracteres\n";
				return false;
			}

			return true;
		}

		private static bool VerificarQuantidadeCaracteres(string texto, int min, int max)
		{
			texto = texto ?? "";
			return texto.Length >= min && texto.Length <= max;
		}
	}
}

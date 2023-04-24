using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Desktop.Mercado.Utils
{
	public static class UtilsUsuario
	{
		public static bool NomeEhValido(string nome, out string mensagem)
		{
			bool quantidadeCaracteresValida = VerificarQuantidadeCaracteres(nome, 3, 100);

			mensagem = string.Empty;

			if (!quantidadeCaracteresValida)
				mensagem += "O nome deve ter de 3 a 100 caracteres\n";

			return mensagem.Length == 0;
		}

		public static bool EmailEhValido(string email, out string mensagem)
		{
			bool quantidadeCaracteresValida = VerificarQuantidadeCaracteres(email, 5, 100);

			mensagem = string.Empty;

			if (!quantidadeCaracteresValida)
			{ 
				mensagem += "O e-mail deve ter de 5 a 100 caracteres\n";
				return false;
			}

			Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
			Match match = regex.Match(email);
			mensagem = match.Success ? "E-mail válido\n" : "E-mail inválido\n";
			return match.Success;
		}

		public static bool SenhaEhValida(string senha, out string mensagem)
		{
			List<char> caracteres = senha.ToCharArray().ToList();

			mensagem = string.Empty;

			bool quantidadeCaracteresValida = VerificarQuantidadeCaracteres(senha, min: 8, max: 20);
			if (!quantidadeCaracteresValida)
				mensagem += "A senha deve ter de 8 a 20 caracteres\n";

			bool temNumero = caracteres.Any(c => EhNumero(c));
			if (!temNumero)
				mensagem += "A senha deve ter ao menos um número\n";

			bool temLetraMaiuscula = caracteres.Any(c => EhLetraMaiuscula(c));
			if (!temLetraMaiuscula)
				mensagem += "A senha deve ter ao menos uma letra maiúscula\n";

			bool temLetraMinuscula = caracteres.Any(c => EhLetraMinuscula(c));
			if (!temLetraMinuscula)
				mensagem += "A senha deve ter ao menos uma letra minúscula\n";

			bool temCaracterEspecial = caracteres.Any(c => EhCaracterEspecial(c));
			if (!temCaracterEspecial)
				mensagem += "A senha deve ter ao menos um caracter especial\n";

			return mensagem.Length == 0;
		}

		private static bool EhNumero(char caracter)
		{
			int ascii = (int)caracter;
			int ascii_0 = 48;
			int ascii_9 = 57;
			return ascii >= ascii_0 && ascii <= ascii_9;
		}

		private static bool EhLetraMaiuscula(char caracter)
		{
			int ascii = (int)caracter;
			int ascii_A = 65;
			int ascii_Z = 90;
			return ascii >= ascii_A && ascii <= ascii_Z;
		}

		private static bool EhLetraMinuscula(char caracter)
		{
			int ascii = (int)caracter;
			int ascii_a = 97;
			int ascii_z = 122;
			return ascii >= ascii_a && ascii <= ascii_z;
		}

		private static bool EhCaracterEspecial(char caracter)
		{
			if (EhNumero(caracter)) return false;

			if (EhLetraMaiuscula(caracter)) return false;


			if (EhLetraMinuscula(caracter)) return false;
			
			return true;
		}

		private static bool VerificarQuantidadeCaracteres(string texto, int min, int max)
		{
			texto = texto ?? "";
			return texto.Length >= min && texto.Length <= max;
		}
	}
}

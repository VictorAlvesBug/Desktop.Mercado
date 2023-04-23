using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Desktop.Mercado.Business.Services
{
	public static class ValidadorUsuario
	{
		public static bool NomeEhValido(string nome, out string mensagem)
		{
			bool quantidadeCaracteresValida = VerificarQuantidadeCaracteres(nome, 3, 50);

			mensagem = string.Empty;

			if (!quantidadeCaracteresValida)
				mensagem += "O nome deve ter de 3 a 50 caracteres\n";

			return mensagem.Length == 0;
		}

		public static bool EmailEhValido(string email, out string mensagem)
		{
			Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
			Match match = regex.Match(email);
			mensagem = match.Success ? "E-mail válido\n" : "E-mail inválido\n";
			return match.Success;
		}

		public static bool SenhaEhValida(string senha, out string mensagem)
		{
			byte[] asciiBytes = Encoding.ASCII.GetBytes(senha);

			bool quantidadeCaracteresValida = VerificarQuantidadeCaracteres(senha, min: 8, max: 20);
			bool temNumero = asciiBytes.Any(c => EhNumero(c));
			bool temLetraMaiuscula = asciiBytes.Any(c => EhLetraMaiuscula(c));
			bool temLetraMinuscula = asciiBytes.Any(c => EhLetraMinuscula(c));
			bool temCaracterEspecial = asciiBytes.Any(c => EhCaracterEspecial(c));

			mensagem = string.Empty;

			if (!quantidadeCaracteresValida)
				mensagem += "A senha deve ter de 8 a 20 caracteres\n";

			if (!temNumero)
				mensagem += "A senha deve ter ao menos um número\n";

			if (!temLetraMaiuscula)
				mensagem += "A senha deve ter ao menos uma letra maiúscula\n";

			if (!temLetraMinuscula)
				mensagem += "A senha deve ter ao menos uma letra minúscula\n";

			if (!temCaracterEspecial)
				mensagem += "A senha deve ter ao menos um caracter especial\n";

			return mensagem.Length == 0;
		}

		private static bool EhNumero(byte asciiByte)
		{
			byte caracter_0 = 48;
			byte caracter_9 = 57;
			return asciiByte >= caracter_0 && asciiByte <= caracter_9;
		}

		private static bool EhLetraMaiuscula(byte asciiByte)
		{
			byte caracter_A = 65;
			byte caracter_Z = 90;
			return asciiByte >= caracter_A && asciiByte <= caracter_Z;
		}

		private static bool EhLetraMinuscula(byte asciiByte)
		{
			byte caracter_a = 97;
			byte caracter_z = 122;
			return asciiByte >= caracter_a && asciiByte <= caracter_z;
		}

		private static bool EhCaracterEspecial(byte asciiByte)
		{
			if (EhNumero(asciiByte)) return false;

			if (EhLetraMaiuscula(asciiByte)) return false;

			if (EhCaracterEspecial(asciiByte)) return false;
			
			return true;
		}

		private static bool VerificarQuantidadeCaracteres(string texto, int min, int max)
		{
			texto = texto ?? "";
			return texto.Length >= min && texto.Length <= max;
		}
	}
}

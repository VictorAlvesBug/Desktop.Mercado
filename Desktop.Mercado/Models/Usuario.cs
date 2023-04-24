using System;

namespace Desktop.Mercado.Models
{
	public class Usuario
	{
		public int Codigo { get; set; }
		public string Nome { get; set; }
		public string Email { get; set; }
		public string HashSenha { get; set; }
		public int CodigoTipoUsuario { get; set; }
		public TipoUsuario TipoUsuario { get; set; }
		public DateTime DataHoraCadastro { get; set; }
		public bool Ativo { get; set; }

		public bool EhAdministrador()
		{
			return TipoUsuario?.Nome == "Administrador";
		}
	}
}

﻿using Desktop.Mercado.DataAccess;
using Desktop.Mercado.Models;
using Desktop.Mercado.Utils;
using System.Collections.Generic;
using System.Linq;

namespace Desktop.Mercado.Business
{
	public class UsuarioBusiness
	{
		private readonly UsuarioDataAccess _usuarioDataAccess;

        public UsuarioBusiness()
        {
			_usuarioDataAccess = new UsuarioDataAccess();
		}

		public bool Cadastrar(Usuario usuario)
		{
			return _usuarioDataAccess.Cadastrar(usuario);
		}

		public List<Usuario> Listar()
		{
			return _usuarioDataAccess.Listar();
		}

		public Usuario Logar(string email, string senha)
		{
			string hashSenha = UtilsCriptografia.RetornarHash(senha);

			return _usuarioDataAccess.Logar(email, hashSenha);
		}

		public bool VerificarEmailJaCadastrado(string email)
		{
			return _usuarioDataAccess.Listar().Any(usuario => usuario.Email == email);
		}

		public Usuario Retornar(int codigo)
		{
			return _usuarioDataAccess.Retornar(codigo);
		}
	}
}

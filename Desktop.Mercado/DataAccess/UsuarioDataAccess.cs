using Dapper;
using Desktop.Mercado.ConnectionFactories;
using Desktop.Mercado.Models;
using System.Collections.Generic;
using System.Linq;

namespace Desktop.Mercado.DataAccess
{
	public class UsuarioDataAccess
	{
		public bool Cadastrar(Usuario usuario)
		{
			using (var connection = ConnectionFactory.AbrirConexao("Mercado"))
			{
				string query = @"
							INSERT INTO Usuario
								(Nome, 
								Email, 
								HashSenha)
							VALUES
								(@Nome, 
								@Email, 
								@HashSenha)
						";

				return connection.Execute(query, usuario) > 0;
			}
		}

		public bool Editar(Usuario usuario)
		{
			using (var connection = ConnectionFactory.AbrirConexao("Mercado"))
			{
				string query = @"
							UPDATE
								Usuario
							SET
								Nome = @Nome, 
								Email = @Email, 
								HashSenha = @HashSenha
							WHERE
								Codigo = @Codigo
						";

				return connection.Execute(query, usuario) > 0;
			}
		}

		public List<Usuario> Listar()
		{
			using (var connection = ConnectionFactory.AbrirConexao("Mercado"))
			{
				string query = @"
							SELECT
								Usuario.Codigo,
								Usuario.Nome,
								Usuario.Email,
								Usuario.HashSenha,
								Usuario.CodigoTipoUsuario,
								Usuario.DataHoraCadastro,
								Usuario.Ativo,
								TipoUsuario.Codigo,
								TipoUsuario.Nome,
								TipoUsuario.DataHoraCadastro,
								TipoUsuario.Ativo
							FROM
								Usuario
								INNER JOIN TipoUsuario
									ON Usuario.CodigoTipoUsuario = TipoUsuario.Codigo
							WHERE
								Usuario.Ativo = 1
								AND TipoUsuario.Ativo = 1
						";

				return connection.Query<Usuario, TipoUsuario, Usuario>(query,
					(usuario, tipoUsuario) =>
					{
						usuario.TipoUsuario = tipoUsuario;
						return usuario;
					}, splitOn: "Codigo").ToList();
			}
		}

		public Usuario Retornar(int codigo)
		{
			using (var connection = ConnectionFactory.AbrirConexao("Mercado"))
			{
				string query = @"
							SELECT
								Usuario.Codigo,
								Usuario.Nome,
								Usuario.Email,
								Usuario.HashSenha,
								Usuario.CodigoTipoUsuario,
								Usuario.DataHoraCadastro,
								Usuario.Ativo,
								TipoUsuario.Codigo,
								TipoUsuario.Nome,
								TipoUsuario.DataHoraCadastro,
								TipoUsuario.Ativo
							FROM
								Usuario
								INNER JOIN TipoUsuario
									ON Usuario.CodigoTipoUsuario = TipoUsuario.Codigo
							WHERE
								Usuario.Codigo = @codigo
						";

				return connection.Query<Usuario, TipoUsuario, Usuario>(query,
					(usuario, tipoUsuario) =>
					{
						usuario.TipoUsuario = tipoUsuario;
						return usuario;
					}, new
					{
						codigo
					}, splitOn: "Codigo")
					.FirstOrDefault();
			}
		}

		public Usuario Logar(string email, string hashSenha)
		{
			using (var connection = ConnectionFactory.AbrirConexao("Mercado"))
			{
				string query = @"
							SELECT
								Usuario.Codigo,
								Usuario.Nome,
								Usuario.Email,
								Usuario.HashSenha,
								Usuario.CodigoTipoUsuario,
								Usuario.DataHoraCadastro,
								Usuario.Ativo,
								TipoUsuario.Codigo,
								TipoUsuario.Nome,
								TipoUsuario.DataHoraCadastro,
								TipoUsuario.Ativo
							FROM
								Usuario
								INNER JOIN TipoUsuario
									ON Usuario.CodigoTipoUsuario = TipoUsuario.Codigo
							WHERE
								Usuario.Ativo = 1
								AND Usuario.Email = @email
								AND Usuario.HashSenha =@hashSenha
						";


				return connection.Query<Usuario, TipoUsuario, Usuario>(query,
					(usuario, tipoUsuario) =>
					{
						usuario.TipoUsuario = tipoUsuario;
						return usuario;
					},
					new
					{
						email,
						hashSenha
					}, splitOn: "Codigo")
					.FirstOrDefault();
			}
		}
	}
}

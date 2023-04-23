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

		public List<Usuario> Listar()
		{
			using (var connection = ConnectionFactory.AbrirConexao("Mercado"))
			{
				string query = @"
							SELECT
								*
							FROM
								Usuario
							WHERE
								Ativo = 1
						";

				return connection.Query<Usuario>(query).ToList();
			}
		}

		public Usuario Logar(string email, string hashSenha)
		{
			using(var connection = ConnectionFactory.AbrirConexao("Mercado"))
			{
				string query = @"
							SELECT
								*
							FROM
								Usuario
							WHERE
								Ativo = 1
								AND Email = @email
								AND HashSenha =@hashSenha
						";


				return connection.QueryFirstOrDefault<Usuario>(query, new
				{
					email,
					hashSenha
				});
			}
		}
	}
}

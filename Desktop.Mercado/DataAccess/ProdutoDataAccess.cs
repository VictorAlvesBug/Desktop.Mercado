using Dapper;
using Desktop.Mercado.ConnectionFactories;
using Desktop.Mercado.Models;
using System.Collections.Generic;
using System.Linq;

namespace Desktop.Mercado.DataAccess
{
	public class ProdutoDataAccess
	{
		public List<Produto> Listar()
		{
			using (var connection = ConnectionFactory.AbrirConexao("Mercado"))
			{
				string query = @"
							SELECT
								*
							FROM
								Produto
							WHERE
								Ativo = 1
						";

				return connection.Query<Produto>(query).ToList();
			}
		}

		public bool Cadastrar(Produto produto)
		{
			using (var connection = ConnectionFactory.AbrirConexao("Mercado"))
			{
				string query = @"
							INSERT INTO Produto
								(Nome, 
								Preco, 
								NomeFoto, 
								CodigoCategoria)
							VALUES
								(@Nome, 
								@Preco, 
								@NomeFoto, 
								@CodigoCategoria)
						";

				return connection.Execute(query, produto) > 0;
			}
		}

		public bool Editar(Produto produto)
		{
			using (var connection = ConnectionFactory.AbrirConexao("Mercado"))
			{
				string query = @"
							UPDATE 
								Produto
							SET
								Nome = @Nome, 
								Preco = @Preco, 
								NomeFoto = @NomeFoto, 
								CodigoCategoria = @CodigoCategoria
							WHERE
								Codigo = @Codigo
						";

				return connection.Execute(query, produto) > 0;
			}
		}

		public Produto Retornar(int codigo)
		{
			using (var connection = ConnectionFactory.AbrirConexao("Mercado"))
			{
				string query = @"
							SELECT
								*
							FROM
								Produto
							WHERE
								Codigo = @codigo
						";

				return connection.QueryFirstOrDefault<Produto>(query, new { codigo });
			}
		}

		public bool Desativar(int codigo)
		{
			using (var connection = ConnectionFactory.AbrirConexao("Mercado"))
			{
				string query = @"
							UPDATE 
								Produto
							SET
								Ativo = 0
							WHERE
								Codigo = @codigo
						";

				return connection.Execute(query, new { codigo }) > 0;
			}
		}
	}
}

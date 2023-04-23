using Dapper;
using Desktop.Mercado.ConnectionFactories;
using Desktop.Mercado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Mercado.DataAccess
{
	public class CategoriaDataAccess
	{
		public List<Categoria> Listar()
		{
			using (var connection = ConnectionFactory.AbrirConexao("Mercado"))
			{
				string query = @"
							SELECT
								*
							FROM
								Categoria
							WHERE
								Ativo = 1
						";

				return connection.Query<Categoria>(query).ToList();
			}
		}

		public bool Cadastrar(Categoria categoria)
		{
			using (var connection = ConnectionFactory.AbrirConexao("Mercado"))
			{
				string query = @"
							INSERT INTO Categoria
								(Nome)
							VALUES
								(@Nome)
						";

				return connection.Execute(query, categoria) > 0;
			}
		}

		public bool Editar(Categoria categoria)
		{
			using (var connection = ConnectionFactory.AbrirConexao("Mercado"))
			{
				string query = @"
							UPDATE 
								Categoria
							SET
								Nome = @Nome
							WHERE
								Codigo = @Codigo
						";

				return connection.Execute(query, categoria) > 0;
			}
		}

		public Categoria Retornar(int codigo)
		{
			using (var connection = ConnectionFactory.AbrirConexao("Mercado"))
			{
				string query = @"
							SELECT
								*
							FROM
								Categoria
							WHERE
								Codigo = @codigo
						";

				return connection.QueryFirstOrDefault<Categoria>(query, new { codigo });
			}
		}

		public bool Desativar(int codigo)
		{
			using (var connection = ConnectionFactory.AbrirConexao("Mercado"))
			{
				string query = @"
							UPDATE 
								Categoria
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

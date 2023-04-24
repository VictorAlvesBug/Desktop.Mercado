using Desktop.Mercado.DataAccess;
using Desktop.Mercado.Models;
using Desktop.Mercado.Utils;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Windows.Forms;

namespace Desktop.Mercado.Business
{
	public class ProdutoBusiness
	{
		private readonly ProdutoDataAccess _produtoDataAccess;
		private readonly CategoriaDataAccess _categoriaDataAccess;

		public ProdutoBusiness()
		{
			_produtoDataAccess = new ProdutoDataAccess();
			_categoriaDataAccess = new CategoriaDataAccess();
		}

		public List<Produto> Listar()
		{
			try
			{
				return _produtoDataAccess.Listar()
					.Select(produto =>
					{
						produto.Categoria = _categoriaDataAccess.Retornar(produto.CodigoCategoria);
						return produto;
					})
					.ToList();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro");
				return new List<Produto>();
			}
		}

		public bool Salvar(Produto produto)
		{
			if (produto.Codigo == 0)
				return _produtoDataAccess.Cadastrar(produto);

			return _produtoDataAccess.Editar(produto);
		}

		public Produto Retornar(int codigo)
		{
			try
			{
				var produto = _produtoDataAccess.Retornar(codigo);
				produto.Categoria = _categoriaDataAccess.Retornar(produto.CodigoCategoria);
				return produto;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro");
				return null;
			}
		}

		public bool Desativar(int codigo)
		{
			return _produtoDataAccess.Desativar(codigo);
		}
	}
}

using Desktop.Mercado.DataAccess;
using Desktop.Mercado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Mercado.Business
{
	public class ProdutoBusiness
	{
		private readonly ProdutoDataAccess _produtoDataAccess;

        public ProdutoBusiness()
        {
			_produtoDataAccess = new ProdutoDataAccess();
		}

		public List<Produto> Listar()
		{
			return _produtoDataAccess.Listar();
		}

		public bool Salvar(Produto produto)
		{
			if(produto.Codigo == 0)
				return _produtoDataAccess.Cadastrar(produto);

			return _produtoDataAccess.Editar(produto);
		}

		public Produto Retornar(int codigo)
		{
			return _produtoDataAccess.Retornar(codigo);
		}

		public bool Desativar(int codigo)
		{
			return _produtoDataAccess.Desativar(codigo);
		}
	}
}

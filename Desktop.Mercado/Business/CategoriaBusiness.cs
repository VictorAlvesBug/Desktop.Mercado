using Desktop.Mercado.DataAccess;
using Desktop.Mercado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Mercado.Business
{
	public class CategoriaBusiness
	{
		private readonly CategoriaDataAccess _categoriaDataAccess;

        public CategoriaBusiness()
        {
			_categoriaDataAccess = new CategoriaDataAccess();
		}

		public List<Categoria> Listar()
		{
			return _categoriaDataAccess.Listar();
		}

		public bool Cadastrar(Categoria categoria)
		{
			return _categoriaDataAccess.Cadastrar(categoria);
		}

		public bool Editar(Categoria categoria)
		{
			return _categoriaDataAccess.Editar(categoria);
		}

		public Categoria Retornar(int codigo)
		{
			return _categoriaDataAccess.Retornar(codigo);
		}

		public bool Desativar(int codigo)
		{
			return _categoriaDataAccess.Desativar(codigo);
		}
	}
}

using Desktop.Mercado.Business;
using Desktop.Mercado.Models;
using Desktop.Mercado.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Customization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Mercado
{
	public partial class frmCategoria : DevExpress.XtraEditors.XtraForm
	{
		private readonly CategoriaBusiness _categoriaBusiness;
		private int _indiceSelecionadoAnterior;
		private Categoria _categoria;

		public frmCategoria()
		{
			InitializeComponent();
			_categoriaBusiness = new CategoriaBusiness();
			PopularCategorias();
		}

		private void lstCategoria_SelectedIndexChanged(object sender, EventArgs e)
		{
			_indiceSelecionadoAnterior = lstCategoria.SelectedIndex;

			if (_indiceSelecionadoAnterior != -1)
			{
				_categoria = (Categoria)lstCategoria.SelectedItem;
				txtNome.Text = _categoria.Nome;
				btnExcluir.Enabled = true;
			}
		}

		private void lstCategoria_Click(object sender, EventArgs e)
		{
			if (_indiceSelecionadoAnterior == lstCategoria.SelectedIndex)
			{
				lstCategoria.ClearSelected();
				_categoria = new Categoria();
				txtNome.Text = string.Empty;
				btnExcluir.Enabled = false;
			}
		}

		private void PopularCategorias()
		{
			var listaCategorias = _categoriaBusiness.Listar();

			lstCategoria.Items.Clear();

			listaCategorias.ForEach(categoria =>
			{
				lstCategoria.Items.Add(categoria);
			});

			_indiceSelecionadoAnterior = -1;
			_categoria = new Categoria();
			txtNome.Text = string.Empty;
			btnExcluir.Enabled = false;
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			string nome = txtNome.Text;

			if(!UtilsCategoria.NomeEhValido(nome, out string mensagem))
			{
				MessageBox.Show(mensagem, "Erro");
				return;
			}

			_categoria.Nome = nome;

			if (!_categoriaBusiness.Salvar(_categoria))
			{
				MessageBox.Show("Erro ao salvar a categoria", "Erro");
				return;
			}

			PopularCategorias();
			MessageBox.Show("Categoria salva com sucesso", "Sucesso");
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			if(_categoria.Codigo == 0)
			{
				MessageBox.Show("Selecione uma categoria", "Erro");
				return;
			}

			var result = MessageBox.Show($"Deseja excluir a categoria \"{_categoria.Nome}\"?", "Confirmação", MessageBoxButtons.YesNo);

			if(result != DialogResult.Yes)
			{
				return;
			}

			if (_categoriaBusiness.CategoriaTemProdutos(_categoria.Codigo))
			{
				MessageBox.Show("Um ou mais produto estão vinculados a esta categoria.\nExclusão cancelada.", "Erro");
				return;
			}

			if (!_categoriaBusiness.Desativar(_categoria.Codigo))
			{
				MessageBox.Show("Erro ao excluir a categoria", "Erro");
				return;
			}

			PopularCategorias();
			MessageBox.Show("Categoria excluída com sucesso", "Sucesso");
		}
	}
}
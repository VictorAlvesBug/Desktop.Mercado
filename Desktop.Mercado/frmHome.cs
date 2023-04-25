using Desktop.Mercado.Business;
using Desktop.Mercado.Models;
using Desktop.Mercado.Utils;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Desktop.Mercado
{
	public partial class frmHome : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
	{
		private readonly frmLogin _formLogin;
		private readonly ProdutoBusiness _produtoBusiness;
		private readonly CategoriaBusiness _categoriaBusiness;

		public frmHome(frmLogin formLogin)
		{
			InitializeComponent();

			_formLogin = formLogin;
			_produtoBusiness = new ProdutoBusiness();
			_categoriaBusiness = new CategoriaBusiness();

			PopularProdutos();
			ExibirFuncionalidadesConformePermissoes();
		}

		private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
		{
			_formLogin.Close();
		}

		private void btnCadastrar_Click(object sender, System.EventArgs e)
		{
			var formProduto = new frmProduto();
			formProduto.codigoProduto = 0;
			formProduto.nomeFoto = null;
			var result = formProduto.ShowDialog();

			if (result == DialogResult.OK)
			{ 
				PopularProdutos();
			}
		}

		private void btnEditar_Click(object sender, System.EventArgs e)
		{
			var formProduto = new frmProduto();
			int codigoProduto = Convert.ToInt32(dgvProduto.SelectedRows?[0].Cells["Codigo"].Value);
			var produto = _produtoBusiness.Retornar(codigoProduto);

			if (produto == null)
			{
				MessageBox.Show("Produto não encontrado", "Erro");
				return;
			}

			formProduto.codigoProduto = codigoProduto;
			formProduto.nomeFoto = produto.NomeFoto;
			formProduto.txtNome.Text = produto.Nome;
			formProduto.txtPreco.Text = UtilsProduto.RetornarPrecoFormatado(produto.Preco);
			formProduto.ptbFoto.Image = produto.ArquivoFoto;
			formProduto.cmbCategoria.SelectedIndex = formProduto.cmbCategoria.FindStringExact(produto.Categoria.Nome);

			var result = formProduto.ShowDialog();

			if (result == DialogResult.OK)
			{
				PopularProdutos();
			}
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			int codigoProduto = Convert.ToInt32(dgvProduto.SelectedRows?[0].Cells["Codigo"].Value);
			var produto = _produtoBusiness.Retornar(codigoProduto);

			if (produto == null)
			{
				MessageBox.Show("Produto não encontrado", "Erro");
				return;
			}

			var result = MessageBox.Show(
				$"Deseja excluir o produto \"{produto.Nome}\"?", 
				"Confirmação", 
				MessageBoxButtons.YesNo);

			if (result == DialogResult.Yes)
			{
				try
				{
					if (_produtoBusiness.Desativar(codigoProduto))
					{
						PopularProdutos();
						MessageBox.Show("Produto excluído com sucesso", "Sucesso");
						return;
					}

					MessageBox.Show($"Erro ao excluir produto", "Erro");

				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Erro");
				}
			}
		}

		private void PopularProdutos()
		{
			var listaProdutos = _produtoBusiness.Listar();

			dgvProduto.Rows.Clear();

			listaProdutos.ForEach(produto =>
			{
				DataGridViewRow linha = new DataGridViewRow();

				linha.CreateCells(dgvProduto);
				linha.Cells[0].Value = produto.Codigo;
				linha.Cells[1].Value = produto.ArquivoFoto;
				linha.Cells[2].Value = produto.Nome;
				linha.Cells[3].Value = UtilsProduto.RetornarPrecoFormatado(produto.Preco);
				linha.Cells[4].Value = produto.Categoria.Nome;
				linha.Cells[5].Value = produto.DataHoraCadastro.ToString("dd/MM/yyyy - HH:mm");
				linha.Height = 80;

				dgvProduto.Rows.Add(linha);
			});

			dgvProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

			if (listaProdutos.Any())
			{
				btnEditar.Enabled = true;
				btnExcluir.Enabled = true;
				return;
			}

			btnEditar.Enabled = false;
			btnExcluir.Enabled = false;
		}

		private void ExibirFuncionalidadesConformePermissoes()
		{
			if (Properties.Settings.Default.usuarioLogado != null 
				&& Properties.Settings.Default.usuarioLogado.EhAdministrador())
			{
				btnCadastrar.Visible = true;
				btnEditar.Visible = true;
				btnExcluir.Visible = true;
				return;
			}

			btnCadastrar.Visible = false;
			btnEditar.Visible = false;
			btnExcluir.Visible = false;
		}

		private void btnSair_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Properties.Settings.Default.usuarioLogado = null;

			_formLogin.txtEmail.Text = string.Empty;
			_formLogin.txtSenha.Text = string.Empty;
			_formLogin.Show();
			this.Hide();
		}

		private void formContainer_Click(object sender, EventArgs e)
		{
			accControl.CollapseAll();
		}

		private void btnAtualizar_Click(object sender, EventArgs e)
		{
			PopularProdutos();
		}

		private void accCategorias_Click(object sender, EventArgs e)
		{
			new frmCategoria().ShowDialog();

			PopularProdutos();
		}

		private void accMinhaConta_Click(object sender, EventArgs e)
		{
			if(Properties.Settings.Default.usuarioLogado == null)
			{
				MessageBox.Show("Usuário não está logado", "Erro");
				return;
			}

			var usuario = Properties.Settings.Default.usuarioLogado;

			var formEdicaoConta = new frmEdicaoConta();
			formEdicaoConta.codigoUsuario = usuario.Codigo;
			formEdicaoConta.txtNome.Text = usuario.Nome;
			formEdicaoConta.txtEmail.Text = usuario.Email;
			formEdicaoConta.txtSenha.Text = string.Empty;
			formEdicaoConta.txtConfirmacaoSenha.Text = string.Empty;
			formEdicaoConta.ShowDialog();
		}
	}
}

using Desktop.Mercado.Business;
using Desktop.Mercado.Models;
using Desktop.Mercado.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Design.RemoteDocumentSourceDesign;
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
	public partial class frmProduto : DevExpress.XtraEditors.XtraForm
	{
		public int codigoProduto;
		private readonly ProdutoBusiness _produtoBusiness;
		private readonly CategoriaBusiness _categoriaBusiness;

		public frmProduto()
		{
			InitializeComponent();

			_produtoBusiness = new ProdutoBusiness();
			_categoriaBusiness = new CategoriaBusiness();

			cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;

			_categoriaBusiness.Listar().ForEach(categoria =>
			{
				cmbCategoria.Items.Add(categoria);
			});
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			string nome = txtNome.Text;
			ValidadorProduto.AjustarPreco(txtPreco.Text, out decimal preco);
			string foto = imgFoto.Text;
			Categoria categoria = (Categoria)cmbCategoria.SelectedItem;

			if(Salvar(nome, preco, foto, categoria, out string mensagem))
			{
				MessageBox.Show("Produto salvo com sucesso", "Sucesso", MessageBoxButtons.OK);

				this.DialogResult = DialogResult.OK;
				this.Close();
				return;
			}


			MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK);
			return;
		}

		private bool Salvar(string nome, decimal preco, string foto, Categoria categoria, out string mensagem)
		{
			mensagem = string.Empty;

			try
			{
				if (!ValidadorProduto.NomeEhValido(nome, out string mensagemNome))
					mensagem += mensagemNome;

				if (!ValidadorProduto.PrecoEhValido(preco, out string mensagemPreco))
					mensagem += mensagemPreco;

				if (categoria == null)
					mensagem += "Selecione uma categoria válida\n";

				if (mensagem.Length > 0)
					return false;

				var produto = new Produto
				{
					Codigo = codigoProduto,
					Nome = nome,
					Preco = preco,
					Categoria = categoria,
					CodigoCategoria = categoria.Codigo,
					Foto = foto
				};

				if (_produtoBusiness.Salvar(produto))
					return true;

				mensagem += "Ocorreu um erro ao salvar o produto\n";
				return false;
			}
			catch (Exception ex)
			{
				mensagem += ex.Message;
				return false;
			}
		}

		private void txtPreco_KeyUp(object sender, KeyEventArgs e)
		{
			txtPreco.Text = ValidadorProduto.AjustarPreco(txtPreco.Text, out decimal _);
		}
	}
}
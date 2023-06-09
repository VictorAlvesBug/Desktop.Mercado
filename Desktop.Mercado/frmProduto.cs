﻿using Desktop.Mercado.Business;
using Desktop.Mercado.Models;
using Desktop.Mercado.Utils;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Desktop.Mercado
{
	public partial class frmProduto : DevExpress.XtraEditors.XtraForm
	{
		private readonly ProdutoBusiness _produtoBusiness;
		private readonly CategoriaBusiness _categoriaBusiness;
		public int codigoProduto;
		public string nomeFoto;
		private bool _alterouFoto;

		public frmProduto()
		{
			InitializeComponent();

			_produtoBusiness = new ProdutoBusiness();
			_categoriaBusiness = new CategoriaBusiness();

			this.MinimumSize = this.Size;
			this.MaximumSize = this.Size;

			cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;

			_categoriaBusiness.Listar().ForEach(categoria =>
			{
				cmbCategoria.Items.Add(categoria);
			});

			_alterouFoto = false;
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			string nome = txtNome.Text;
			decimal preco = UtilsProduto.RetornarPrecoDecimal(txtPreco.Text);
			Categoria categoria = (Categoria)cmbCategoria.SelectedItem;

			if (ptbFoto.Image != null && _alterouFoto)
			{
				nomeFoto = UtilsProduto.SalvarFoto(ptbFoto.Image);
			}

			if(Salvar(nome, preco, nomeFoto, categoria, out string mensagem))
			{
				MessageBox.Show("Produto salvo com sucesso", "Sucesso", MessageBoxButtons.OK);

				this.DialogResult = DialogResult.OK;
				this.Close();
				return;
			}


			MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK);
			return;
		}

		private bool Salvar(string nome, decimal preco, string nomeFoto, Categoria categoria, out string mensagem)
		{
			mensagem = string.Empty;

			try
			{
				if (!UtilsProduto.NomeEhValido(nome, out string mensagemNome))
					mensagem += mensagemNome;

				if (!UtilsProduto.PrecoEhValido(preco, out string mensagemPreco))
					mensagem += mensagemPreco;

				if (string.IsNullOrEmpty(nomeFoto))
					mensagem += "Selecione uma foto válida\n";

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
					NomeFoto = nomeFoto
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

		private void txtPreco_Click(object sender, EventArgs e)
		{
			txtPreco.Select(txtPreco.Text.Length, 0);
		}

		private void txtPreco_KeyUp(object sender, KeyEventArgs e)
		{
			txtPreco.Text = UtilsProduto.AjustarPreco(txtPreco.Text);
		}

		private void txtPreco_KeyDown(object sender, KeyEventArgs e)
		{
			txtPreco.Select(txtPreco.Text.Length, 0);
		}

		private void btnUploadFoto_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files (*.jpg;*.jpeg)|*.jpg;*.jpeg";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				ptbFoto.Image = new Bitmap(openFileDialog.FileName);
				_alterouFoto = true;
			}
		}
	}
}
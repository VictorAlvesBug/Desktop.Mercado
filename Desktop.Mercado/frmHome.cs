using Desktop.Mercado.Business;
using Desktop.Mercado.Models;
using System.ComponentModel;
using System.Windows.Forms;

namespace Desktop.Mercado
{
	public partial class frmHome : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
	{
		private readonly frmLogin _formLogin;
		private readonly ProdutoBusiness _produtoBusiness;

		public frmHome(frmLogin formLogin)
		{
			InitializeComponent();

			_formLogin = formLogin;
			_produtoBusiness = new ProdutoBusiness();

			PopularProdutos();
		}

		private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
		{
			_formLogin.Close();
		}

		private void btnCadastrar_Click(object sender, System.EventArgs e)
		{
			var formProduto = new frmProduto();
			formProduto.codigoProduto = 0;
			var result = formProduto.ShowDialog();

			if (result == DialogResult.OK)
			{ 
				PopularProdutos();
			}
		}

		private void PopularProdutos()
		{
			var listaProdutos = _produtoBusiness.Listar();
			var bindingListProdutos = new BindingList<Produto>(listaProdutos);
			dgvProduto.DataSource = bindingListProdutos;
		}

		private void btnSair_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Properties.Settings.Default.usuarioLogado = null;

			_formLogin.txtEmail.Text = string.Empty;
			_formLogin.txtSenha.Text = string.Empty;
			_formLogin.Show();
			this.Hide();
		}
	}
}

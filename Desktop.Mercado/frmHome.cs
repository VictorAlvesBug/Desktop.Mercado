using Desktop.Mercado.Business;
using Desktop.Mercado.Models;
using System.ComponentModel;
using System.Windows.Forms;

namespace Desktop.Mercado
{
	public partial class frmHome : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
	{
		private readonly frmLogin formLogin;
		private readonly ProdutoBusiness _produtoBusiness;

		public frmHome(frmLogin _formLogin)
		{
			InitializeComponent();

			formLogin = _formLogin;
			_produtoBusiness = new ProdutoBusiness();

			PopularProdutos();
		}

		private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
		{
			formLogin.Close();
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
	}
}

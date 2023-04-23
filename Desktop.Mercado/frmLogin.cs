using Desktop.Mercado.Business;
using Desktop.Mercado.Utils;
using System;
using System.Windows.Forms;

namespace Desktop.Mercado
{
	public partial class frmLogin : DevExpress.XtraEditors.XtraForm
	{
		private readonly UsuarioBusiness _usuarioBusiness;
		public frmLogin()
		{
			InitializeComponent();

			_usuarioBusiness = new UsuarioBusiness();
		}

		private void btnEntrar_Click(object sender, EventArgs e)
		{
			btnEntrar.Enabled = false;
			string textoAnterior = btnEntrar.Text;
			btnEntrar.Text = "ENTRANDO...";
			btnEntrar.Update();

			string email = txtEmail.Text;
			string senha = txtSenha.Text;

			if (RealizarLogin(email, senha, out string mensagem))
			{
				var formHome = new frmHome(this);
				formHome.Show();
				this.Hide();
				return;
			}

			btnEntrar.Enabled = true;
			btnEntrar.Text = textoAnterior;
			btnEntrar.Update();
			MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK);
		}

		private bool RealizarLogin(string email, string senha, out string mensagem)
		{
			mensagem = string.Empty;

			if (!ValidadorUsuario.EmailEhValido(email, out string mensagemEmail))
				mensagem += mensagemEmail;

			if (!ValidadorUsuario.SenhaEhValida(senha, out string mensagemSenha))
				mensagem += mensagemSenha;

			if(mensagem.Length > 0)
				return false;

			var usuario = _usuarioBusiness.Logar(email, senha);

			if (usuario == null)
			{
				mensagem = "E-mail ou senha inválidos.";
				return false;
			}

			Properties.Settings.Default.usuarioLogado = usuario;

			mensagem = "Usuário encontrado.";
			return true;
		}

		private void linkCriarConta_Click(object sender, EventArgs e)
		{
			var formCadastro = new frmCadastro(this);
			formCadastro.txtEmail.Text = txtEmail.Text;
			formCadastro.txtSenha.Text = txtSenha.Text;
			formCadastro.Show();
			this.Hide();
		}
	}
}
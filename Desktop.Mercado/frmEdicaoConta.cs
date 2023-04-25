using Desktop.Mercado.Business;
using Desktop.Mercado.Models;
using Desktop.Mercado.Utils;
using System;
using System.Windows.Forms;

namespace Desktop.Mercado
{
	public partial class frmEdicaoConta : DevExpress.XtraEditors.XtraForm
	{
		private readonly frmLogin _formLogin;
		private readonly UsuarioBusiness _usuarioBusiness;
		public int codigoUsuario;

		public frmEdicaoConta(frmLogin formLogin = null)
		{
			InitializeComponent();

			_formLogin = formLogin;
			_usuarioBusiness = new UsuarioBusiness();

			this.MinimumSize = this.Size;
			this.MaximumSize = this.Size;
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			var loadingSalvar = new Loading(btnSalvar);
			loadingSalvar.Habilitar("SALVANDO...");

			string nome = txtNome.Text;
			string email = txtEmail.Text.ToLower();
			string senha = txtSenha.Text;
			string confirmacaoSenha = txtConfirmacaoSenha.Text;

			if (AlterarConta(nome, email, senha, confirmacaoSenha, out string mensagem))
			{
				MessageBox.Show($"Usuário alterado com sucesso", "Sucesso", MessageBoxButtons.OK);
				loadingSalvar.Desabilitar();
				Properties.Settings.Default.usuarioLogado = _usuarioBusiness.Logar(email, senha);
				this.Hide();
				return;
			}

			loadingSalvar.Desabilitar();
			MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK);
		}

		private bool AlterarConta(string nome, string email, string senha, string confirmacaoSenha, out string mensagem)
		{
			mensagem = string.Empty;

			try
			{
				if (!UtilsUsuario.NomeEhValido(nome, out string mensagemNome))
					mensagem += mensagemNome;

				if (!UtilsUsuario.EmailEhValido(email, out string mensagemEmail))
					mensagem += mensagemEmail;

				if (!UtilsUsuario.SenhaEhValida(senha, out string mensagemSenha))
					mensagem += mensagemSenha;

				if (senha != confirmacaoSenha)
					mensagem += "As senhas devem ser iguais.\n";

				if (mensagem.Length > 0)
					return false;

				if (_usuarioBusiness.VerificarEmailJaCadastrado(email, codigoUsuario))
				{
					mensagem = "Este e-mail já está cadastrado.";
					return false;
				}

				var usuario = new Usuario
				{
					Codigo = codigoUsuario,
					Nome = nome,
					Email = email,
					HashSenha = UtilsCriptografia.RetornarHash(senha)
				};

				if (_usuarioBusiness.Editar(usuario))
					return true;

				mensagem += "Erro ao alterar usuário\n";
				return false;
			}
			catch (Exception ex)
			{
				mensagem += ex.Message;
				return false;
			}
		}

		private void ckbExibirSenha_CheckedChanged(object sender, EventArgs e)
		{
			bool ocultarSenha = !ckbExibirSenha.Checked;
			txtSenha.Properties.UseSystemPasswordChar = ocultarSenha;
			txtConfirmacaoSenha.Properties.UseSystemPasswordChar = ocultarSenha;
		}
	}
}
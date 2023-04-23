using Desktop.Mercado.Business;
using Desktop.Mercado.Models;
using Desktop.Mercado.Utils;
using System;
using System.Windows.Forms;

namespace Desktop.Mercado
{
	public partial class frmCadastro : DevExpress.XtraEditors.XtraForm
	{
		private frmLogin formLogin;
		private readonly UsuarioBusiness _usuarioBusiness;

		public frmCadastro(frmLogin _formLogin)
		{
			InitializeComponent();

			formLogin = _formLogin;
			_usuarioBusiness = new UsuarioBusiness();
		}

		private void btnCriarConta_Click(object sender, EventArgs e)
		{
			btnCriarConta.Enabled = false;
			string textoAnterior = btnCriarConta.Text;
			btnCriarConta.Text = "CRIANDO CONTA...";
			btnCriarConta.Update();

			string nome = txtNome.Text;
			string email = txtEmail.Text.ToLower();
			string senha = txtSenha.Text;
			string confirmacaoSenha = txtConfirmacaoSenha.Text;

			if (RealizarCadastro(nome, email, senha, confirmacaoSenha, out string mensagem))
			{
				MessageBox.Show($"Cadastro realizado com sucesso", "Sucesso", MessageBoxButtons.OK);
				AbrirFormLogin();
				return;
			}

			btnCriarConta.Enabled = true;
			btnCriarConta.Text = textoAnterior;
			btnCriarConta.Update();
			MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK);
		}

		private bool RealizarCadastro(string nome, string email, string senha, string confirmacaoSenha, out string mensagem)
		{
			mensagem = string.Empty;

			if (!ValidadorUsuario.NomeEhValido(nome, out string mensagemNome))
				mensagem += mensagemNome;

			if (!ValidadorUsuario.EmailEhValido(email, out string mensagemEmail))
				mensagem += mensagemEmail;

			if (!ValidadorUsuario.SenhaEhValida(senha, out string mensagemSenha))
				mensagem += mensagemSenha;

			if (senha != confirmacaoSenha)
				mensagem += "As senhas devem ser iguais.\n";

			if (mensagem.Length > 0)
				return false;

			if (_usuarioBusiness.VerificarEmailJaCadastrado(email))
			{
				mensagem = "Este e-mail já está cadastrado, entre com sua conta.";
				AbrirFormLogin();
				return false;
			}

			var usuario = new Usuario {
				Nome = nome,
				Email = email,
				HashSenha = Criptografia.RetornarHash(senha)
			};

			if(_usuarioBusiness.Cadastrar(usuario))
				return true;

			mensagem += "Erro ao cadastrar usuário\n";
			return false;
		}

		private void linkEntrar_Click(object sender, EventArgs e)
		{
			AbrirFormLogin();
		}

		private void AbrirFormLogin()
		{
			formLogin.txtEmail.Text = txtEmail.Text;
			formLogin.txtSenha.Text = txtSenha.Text;
			formLogin.Show();
			this.Hide();
		}

		private void frmCadastro_FormClosed(object sender, FormClosedEventArgs e)
		{
			formLogin.Close();
		}
	}
}
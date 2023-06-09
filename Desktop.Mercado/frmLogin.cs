﻿using Desktop.Mercado.Business;
using Desktop.Mercado.Models;
using Desktop.Mercado.Utils;
using System;
using System.Net;
using System.Net.Mail;
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

			this.MinimumSize = this.Size;
			this.MaximumSize = this.Size;
		}

		private void btnEntrar_Click(object sender, EventArgs e)
		{
			var loadingEntrar = new Loading(btnEntrar);
			loadingEntrar.Habilitar("ENTRANDO...");

			string email = txtEmail.Text;
			string senha = txtSenha.Text;

			if (RealizarLogin(email, senha, out string mensagem))
			{
				var formHome = new frmHome(this);
				formHome.Show();
				this.Hide();
				loadingEntrar.Desabilitar();
				return;
			}

			loadingEntrar.Desabilitar();
			MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK);
		}

		private bool RealizarLogin(string email, string senha, out string mensagem)
		{
			mensagem = string.Empty;

			try
			{
				if (!UtilsUsuario.EmailEhValido(email, out string mensagemEmail))
					mensagem += mensagemEmail;

				if (mensagem.Length > 0)
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
			catch (Exception ex)
			{
				mensagem += ex.Message;
				return false;
			}
		}

		private void linkCriarConta_Click(object sender, EventArgs e)
		{
			var formCadastro = new frmCadastro(this);
			formCadastro.txtEmail.Text = txtEmail.Text;
			formCadastro.txtSenha.Text = txtSenha.Text;
			formCadastro.Show();
			this.Hide();
		}

		private void ckbExibirSenha_CheckedChanged(object sender, EventArgs e)
		{
			bool ocultarSenha = !ckbExibirSenha.Checked;
			txtSenha.Properties.UseSystemPasswordChar = ocultarSenha;
		}
	}
}
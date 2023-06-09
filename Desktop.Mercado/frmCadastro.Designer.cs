﻿namespace Desktop.Mercado
{
	partial class frmCadastro
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblLogin = new DevExpress.XtraEditors.LabelControl();
			this.linkEntrar = new DevExpress.XtraEditors.HyperlinkLabelControl();
			this.btnCriarConta = new DevExpress.XtraEditors.SimpleButton();
			this.lblSenha = new DevExpress.XtraEditors.LabelControl();
			this.lblEmail = new DevExpress.XtraEditors.LabelControl();
			this.txtSenha = new DevExpress.XtraEditors.TextEdit();
			this.txtEmail = new DevExpress.XtraEditors.TextEdit();
			this.lblNome = new DevExpress.XtraEditors.LabelControl();
			this.txtNome = new DevExpress.XtraEditors.TextEdit();
			this.lblConfirmacaoSenha = new DevExpress.XtraEditors.LabelControl();
			this.txtConfirmacaoSenha = new DevExpress.XtraEditors.TextEdit();
			this.lblTitulo = new DevExpress.XtraEditors.LabelControl();
			this.ckbExibirSenha = new DevExpress.XtraEditors.CheckEdit();
			((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtConfirmacaoSenha.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ckbExibirSenha.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// lblLogin
			// 
			this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblLogin.Location = new System.Drawing.Point(12, 289);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(90, 13);
			this.lblLogin.TabIndex = 15;
			this.lblLogin.Text = "Já tem uma conta?";
			// 
			// linkEntrar
			// 
			this.linkEntrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkEntrar.Location = new System.Drawing.Point(108, 289);
			this.linkEntrar.Name = "linkEntrar";
			this.linkEntrar.Size = new System.Drawing.Size(30, 13);
			this.linkEntrar.TabIndex = 6;
			this.linkEntrar.Text = "Entrar";
			this.linkEntrar.Click += new System.EventHandler(this.linkEntrar_Click);
			// 
			// btnCriarConta
			// 
			this.btnCriarConta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCriarConta.Location = new System.Drawing.Point(12, 253);
			this.btnCriarConta.Name = "btnCriarConta";
			this.btnCriarConta.Size = new System.Drawing.Size(274, 30);
			this.btnCriarConta.TabIndex = 5;
			this.btnCriarConta.Text = "CRIAR";
			this.btnCriarConta.Click += new System.EventHandler(this.btnCriarConta_Click);
			// 
			// lblSenha
			// 
			this.lblSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblSenha.Location = new System.Drawing.Point(12, 137);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(30, 13);
			this.lblSenha.TabIndex = 11;
			this.lblSenha.Text = "Senha";
			// 
			// lblEmail
			// 
			this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblEmail.Location = new System.Drawing.Point(12, 92);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(28, 13);
			this.lblEmail.TabIndex = 10;
			this.lblEmail.Text = "E-mail";
			// 
			// txtSenha
			// 
			this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSenha.Location = new System.Drawing.Point(12, 156);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Properties.UseSystemPasswordChar = true;
			this.txtSenha.Size = new System.Drawing.Size(274, 20);
			this.txtSenha.TabIndex = 3;
			// 
			// txtEmail
			// 
			this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtEmail.Location = new System.Drawing.Point(12, 111);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(274, 20);
			this.txtEmail.TabIndex = 2;
			// 
			// lblNome
			// 
			this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblNome.Location = new System.Drawing.Point(12, 47);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(27, 13);
			this.lblNome.TabIndex = 17;
			this.lblNome.Text = "Nome";
			// 
			// txtNome
			// 
			this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNome.Location = new System.Drawing.Point(12, 66);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(274, 20);
			this.txtNome.TabIndex = 1;
			// 
			// lblConfirmacaoSenha
			// 
			this.lblConfirmacaoSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblConfirmacaoSenha.Location = new System.Drawing.Point(12, 182);
			this.lblConfirmacaoSenha.Name = "lblConfirmacaoSenha";
			this.lblConfirmacaoSenha.Size = new System.Drawing.Size(95, 13);
			this.lblConfirmacaoSenha.TabIndex = 19;
			this.lblConfirmacaoSenha.Text = "Confirme sua senha";
			// 
			// txtConfirmacaoSenha
			// 
			this.txtConfirmacaoSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtConfirmacaoSenha.Location = new System.Drawing.Point(12, 201);
			this.txtConfirmacaoSenha.Name = "txtConfirmacaoSenha";
			this.txtConfirmacaoSenha.Properties.UseSystemPasswordChar = true;
			this.txtConfirmacaoSenha.Size = new System.Drawing.Size(274, 20);
			this.txtConfirmacaoSenha.TabIndex = 4;
			// 
			// lblTitulo
			// 
			this.lblTitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Appearance.Options.UseFont = true;
			this.lblTitulo.Location = new System.Drawing.Point(12, 12);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(119, 29);
			this.lblTitulo.TabIndex = 22;
			this.lblTitulo.Text = "Criar Conta";
			// 
			// ckbExibirSenha
			// 
			this.ckbExibirSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ckbExibirSenha.Location = new System.Drawing.Point(12, 227);
			this.ckbExibirSenha.Name = "ckbExibirSenha";
			this.ckbExibirSenha.Properties.Caption = "Exibir senha";
			this.ckbExibirSenha.Size = new System.Drawing.Size(82, 20);
			this.ckbExibirSenha.TabIndex = 23;
			this.ckbExibirSenha.CheckedChanged += new System.EventHandler(this.ckbExibirSenha_CheckedChanged);
			// 
			// frmCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(298, 313);
			this.Controls.Add(this.ckbExibirSenha);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.lblConfirmacaoSenha);
			this.Controls.Add(this.txtConfirmacaoSenha);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.lblLogin);
			this.Controls.Add(this.linkEntrar);
			this.Controls.Add(this.btnCriarConta);
			this.Controls.Add(this.lblSenha);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtEmail);
			this.MaximizeBox = false;
			this.Name = "frmCadastro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mercado";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastro_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtConfirmacaoSenha.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ckbExibirSenha.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DevExpress.XtraEditors.LabelControl lblSenha;
		private DevExpress.XtraEditors.LabelControl lblEmail;
		private DevExpress.XtraEditors.LabelControl lblNome;
		public DevExpress.XtraEditors.TextEdit txtSenha;
		public DevExpress.XtraEditors.TextEdit txtEmail;
		private DevExpress.XtraEditors.LabelControl lblConfirmacaoSenha;
		public DevExpress.XtraEditors.TextEdit txtConfirmacaoSenha;
		public DevExpress.XtraEditors.TextEdit txtNome;
		public DevExpress.XtraEditors.LabelControl lblLogin;
		public DevExpress.XtraEditors.HyperlinkLabelControl linkEntrar;
		public DevExpress.XtraEditors.SimpleButton btnCriarConta;
		private DevExpress.XtraEditors.LabelControl lblTitulo;
		private DevExpress.XtraEditors.CheckEdit ckbExibirSenha;
	}
}
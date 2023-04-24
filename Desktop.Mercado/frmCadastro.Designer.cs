namespace Desktop.Mercado
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
			((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtConfirmacaoSenha.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// lblLogin
			// 
			this.lblLogin.Location = new System.Drawing.Point(12, 241);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(90, 13);
			this.lblLogin.TabIndex = 15;
			this.lblLogin.Text = "Já tem uma conta?";
			// 
			// linkEntrar
			// 
			this.linkEntrar.Location = new System.Drawing.Point(108, 241);
			this.linkEntrar.Name = "linkEntrar";
			this.linkEntrar.Size = new System.Drawing.Size(30, 13);
			this.linkEntrar.TabIndex = 6;
			this.linkEntrar.Text = "Entrar";
			this.linkEntrar.Click += new System.EventHandler(this.linkEntrar_Click);
			// 
			// btnCriarConta
			// 
			this.btnCriarConta.Location = new System.Drawing.Point(12, 205);
			this.btnCriarConta.Name = "btnCriarConta";
			this.btnCriarConta.Size = new System.Drawing.Size(274, 30);
			this.btnCriarConta.TabIndex = 5;
			this.btnCriarConta.Text = "CRIAR CONTA";
			this.btnCriarConta.Click += new System.EventHandler(this.btnCriarConta_Click);
			// 
			// lblSenha
			// 
			this.lblSenha.Location = new System.Drawing.Point(12, 102);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(30, 13);
			this.lblSenha.TabIndex = 11;
			this.lblSenha.Text = "Senha";
			// 
			// lblEmail
			// 
			this.lblEmail.Location = new System.Drawing.Point(12, 57);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(28, 13);
			this.lblEmail.TabIndex = 10;
			this.lblEmail.Text = "E-mail";
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(12, 121);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Properties.UseSystemPasswordChar = true;
			this.txtSenha.Size = new System.Drawing.Size(274, 20);
			this.txtSenha.TabIndex = 3;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(12, 76);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(274, 20);
			this.txtEmail.TabIndex = 2;
			// 
			// lblNome
			// 
			this.lblNome.Location = new System.Drawing.Point(12, 12);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(27, 13);
			this.lblNome.TabIndex = 17;
			this.lblNome.Text = "Nome";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(12, 31);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(274, 20);
			this.txtNome.TabIndex = 1;
			// 
			// lblConfirmacaoSenha
			// 
			this.lblConfirmacaoSenha.Location = new System.Drawing.Point(12, 147);
			this.lblConfirmacaoSenha.Name = "lblConfirmacaoSenha";
			this.lblConfirmacaoSenha.Size = new System.Drawing.Size(107, 13);
			this.lblConfirmacaoSenha.TabIndex = 19;
			this.lblConfirmacaoSenha.Text = "Confirmação de senha";
			// 
			// txtConfirmacaoSenha
			// 
			this.txtConfirmacaoSenha.Location = new System.Drawing.Point(12, 166);
			this.txtConfirmacaoSenha.Name = "txtConfirmacaoSenha";
			this.txtConfirmacaoSenha.Properties.UseSystemPasswordChar = true;
			this.txtConfirmacaoSenha.Size = new System.Drawing.Size(274, 20);
			this.txtConfirmacaoSenha.TabIndex = 4;
			// 
			// frmCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(298, 268);
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
			this.MaximumSize = new System.Drawing.Size(300, 300);
			this.MinimumSize = new System.Drawing.Size(300, 300);
			this.Name = "frmCadastro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mercado - Cadastro";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastro_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtConfirmacaoSenha.Properties)).EndInit();
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
	}
}
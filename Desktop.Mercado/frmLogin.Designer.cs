namespace Desktop.Mercado
{
	partial class frmLogin
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
			this.txtEmail = new DevExpress.XtraEditors.TextEdit();
			this.txtSenha = new DevExpress.XtraEditors.TextEdit();
			this.lblEmail = new DevExpress.XtraEditors.LabelControl();
			this.lblSenha = new DevExpress.XtraEditors.LabelControl();
			this.btnEntrar = new DevExpress.XtraEditors.SimpleButton();
			this.linkEsqueciSenha = new DevExpress.XtraEditors.HyperlinkLabelControl();
			this.linkCriarConta = new DevExpress.XtraEditors.HyperlinkLabelControl();
			this.lblCriarConta = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// txtEmail
			// 
			this.txtEmail.EditValue = "victoralvesbug@gmail.com";
			this.txtEmail.Location = new System.Drawing.Point(12, 31);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(274, 20);
			this.txtEmail.TabIndex = 0;
			// 
			// txtSenha
			// 
			this.txtSenha.EditValue = "Teste.12345";
			this.txtSenha.Location = new System.Drawing.Point(12, 76);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Properties.UseSystemPasswordChar = true;
			this.txtSenha.Size = new System.Drawing.Size(274, 20);
			this.txtSenha.TabIndex = 1;
			// 
			// lblEmail
			// 
			this.lblEmail.Location = new System.Drawing.Point(12, 12);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(28, 13);
			this.lblEmail.TabIndex = 2;
			this.lblEmail.Text = "E-mail";
			// 
			// lblSenha
			// 
			this.lblSenha.Location = new System.Drawing.Point(12, 57);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(30, 13);
			this.lblSenha.TabIndex = 3;
			this.lblSenha.Text = "Senha";
			// 
			// btnEntrar
			// 
			this.btnEntrar.Location = new System.Drawing.Point(12, 131);
			this.btnEntrar.Name = "btnEntrar";
			this.btnEntrar.Size = new System.Drawing.Size(274, 30);
			this.btnEntrar.TabIndex = 4;
			this.btnEntrar.Text = "ENTRAR";
			this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
			// 
			// linkEsqueciSenha
			// 
			this.linkEsqueciSenha.Location = new System.Drawing.Point(187, 102);
			this.linkEsqueciSenha.Name = "linkEsqueciSenha";
			this.linkEsqueciSenha.Size = new System.Drawing.Size(99, 13);
			this.linkEsqueciSenha.TabIndex = 5;
			this.linkEsqueciSenha.Text = "Esqueci minha senha";
			this.linkEsqueciSenha.Visible = false;
			// 
			// linkCriarConta
			// 
			this.linkCriarConta.Location = new System.Drawing.Point(90, 167);
			this.linkCriarConta.Name = "linkCriarConta";
			this.linkCriarConta.Size = new System.Drawing.Size(76, 13);
			this.linkCriarConta.TabIndex = 6;
			this.linkCriarConta.Text = "Criar uma conta";
			this.linkCriarConta.Click += new System.EventHandler(this.linkCriarConta_Click);
			// 
			// lblCriarConta
			// 
			this.lblCriarConta.Location = new System.Drawing.Point(12, 167);
			this.lblCriarConta.Name = "lblCriarConta";
			this.lblCriarConta.Size = new System.Drawing.Size(72, 13);
			this.lblCriarConta.TabIndex = 7;
			this.lblCriarConta.Text = "Novo por aqui?";
			// 
			// frmLogin
			// 
			this.ClientSize = new System.Drawing.Size(298, 193);
			this.Controls.Add(this.lblCriarConta);
			this.Controls.Add(this.linkCriarConta);
			this.Controls.Add(this.linkEsqueciSenha);
			this.Controls.Add(this.btnEntrar);
			this.Controls.Add(this.lblSenha);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtEmail);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(300, 225);
			this.MinimumSize = new System.Drawing.Size(300, 225);
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mercado - Login";
			((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DevExpress.XtraEditors.LabelControl lblEmail;
		private DevExpress.XtraEditors.LabelControl lblSenha;
		private DevExpress.XtraEditors.SimpleButton btnEntrar;
		private DevExpress.XtraEditors.HyperlinkLabelControl linkEsqueciSenha;
		private DevExpress.XtraEditors.HyperlinkLabelControl linkCriarConta;
		private DevExpress.XtraEditors.LabelControl lblCriarConta;
		public DevExpress.XtraEditors.TextEdit txtEmail;
		public DevExpress.XtraEditors.TextEdit txtSenha;
	}
}
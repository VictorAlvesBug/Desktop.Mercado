namespace Desktop.Mercado
{
	partial class frmProduto
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
			this.lblNome = new DevExpress.XtraEditors.LabelControl();
			this.txtNome = new DevExpress.XtraEditors.TextEdit();
			this.lblPreco = new DevExpress.XtraEditors.LabelControl();
			this.txtPreco = new DevExpress.XtraEditors.TextEdit();
			this.lblFoto = new DevExpress.XtraEditors.LabelControl();
			this.lblCategoria = new DevExpress.XtraEditors.LabelControl();
			this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
			this.cmbCategoria = new System.Windows.Forms.ComboBox();
			this.btnUploadFoto = new DevExpress.XtraEditors.SimpleButton();
			this.ptbFoto = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPreco.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).BeginInit();
			this.SuspendLayout();
			// 
			// lblNome
			// 
			this.lblNome.Location = new System.Drawing.Point(12, 12);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(27, 13);
			this.lblNome.TabIndex = 4;
			this.lblNome.Text = "Nome";
			// 
			// txtNome
			// 
			this.txtNome.EditValue = "";
			this.txtNome.Location = new System.Drawing.Point(12, 31);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(184, 20);
			this.txtNome.TabIndex = 3;
			// 
			// lblPreco
			// 
			this.lblPreco.Location = new System.Drawing.Point(12, 57);
			this.lblPreco.Name = "lblPreco";
			this.lblPreco.Size = new System.Drawing.Size(27, 13);
			this.lblPreco.TabIndex = 6;
			this.lblPreco.Text = "Preço";
			// 
			// txtPreco
			// 
			this.txtPreco.EditValue = "";
			this.txtPreco.Location = new System.Drawing.Point(12, 76);
			this.txtPreco.Name = "txtPreco";
			this.txtPreco.Properties.MaxLength = 13;
			this.txtPreco.Size = new System.Drawing.Size(184, 20);
			this.txtPreco.TabIndex = 5;
			this.txtPreco.Click += new System.EventHandler(this.txtPreco_Click);
			this.txtPreco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPreco_KeyDown);
			this.txtPreco.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPreco_KeyUp);
			// 
			// lblFoto
			// 
			this.lblFoto.Location = new System.Drawing.Point(202, 12);
			this.lblFoto.Name = "lblFoto";
			this.lblFoto.Size = new System.Drawing.Size(22, 13);
			this.lblFoto.TabIndex = 8;
			this.lblFoto.Text = "Foto";
			// 
			// lblCategoria
			// 
			this.lblCategoria.Location = new System.Drawing.Point(12, 102);
			this.lblCategoria.Name = "lblCategoria";
			this.lblCategoria.Size = new System.Drawing.Size(47, 13);
			this.lblCategoria.TabIndex = 10;
			this.lblCategoria.Text = "Categoria";
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(12, 163);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(274, 33);
			this.btnSalvar.TabIndex = 16;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// cmbCategoria
			// 
			this.cmbCategoria.FormattingEnabled = true;
			this.cmbCategoria.Location = new System.Drawing.Point(12, 121);
			this.cmbCategoria.Name = "cmbCategoria";
			this.cmbCategoria.Size = new System.Drawing.Size(184, 21);
			this.cmbCategoria.TabIndex = 14;
			// 
			// btnUploadFoto
			// 
			this.btnUploadFoto.Location = new System.Drawing.Point(202, 121);
			this.btnUploadFoto.Name = "btnUploadFoto";
			this.btnUploadFoto.Size = new System.Drawing.Size(84, 21);
			this.btnUploadFoto.TabIndex = 15;
			this.btnUploadFoto.Text = "Escolher foto";
			this.btnUploadFoto.Click += new System.EventHandler(this.btnUploadFoto_Click);
			// 
			// ptbFoto
			// 
			this.ptbFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ptbFoto.Location = new System.Drawing.Point(202, 31);
			this.ptbFoto.Name = "ptbFoto";
			this.ptbFoto.Size = new System.Drawing.Size(84, 84);
			this.ptbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.ptbFoto.TabIndex = 16;
			this.ptbFoto.TabStop = false;
			// 
			// frmProduto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(298, 212);
			this.Controls.Add(this.ptbFoto);
			this.Controls.Add(this.btnUploadFoto);
			this.Controls.Add(this.cmbCategoria);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.lblCategoria);
			this.Controls.Add(this.lblFoto);
			this.Controls.Add(this.lblPreco);
			this.Controls.Add(this.txtPreco);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.txtNome);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(300, 244);
			this.MinimumSize = new System.Drawing.Size(300, 244);
			this.Name = "frmProduto";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Produto";
			((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPreco.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl lblNome;
		public DevExpress.XtraEditors.TextEdit txtNome;
		private DevExpress.XtraEditors.LabelControl lblPreco;
		public DevExpress.XtraEditors.TextEdit txtPreco;
		private DevExpress.XtraEditors.LabelControl lblFoto;
		private DevExpress.XtraEditors.LabelControl lblCategoria;
		private DevExpress.XtraEditors.SimpleButton btnSalvar;
		private System.Windows.Forms.ComboBox cmbCategoria;
		private DevExpress.XtraEditors.SimpleButton btnUploadFoto;
		private System.Windows.Forms.PictureBox ptbFoto;
	}
}
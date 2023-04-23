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
			this.imgFoto = new DevExpress.XtraEditors.ImageEdit();
			this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
			this.cmbCategoria = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPreco.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgFoto.Properties)).BeginInit();
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
			this.txtNome.Size = new System.Drawing.Size(274, 20);
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
			this.txtPreco.Size = new System.Drawing.Size(274, 20);
			this.txtPreco.TabIndex = 5;
			this.txtPreco.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPreco_KeyUp);
			// 
			// lblFoto
			// 
			this.lblFoto.Location = new System.Drawing.Point(12, 102);
			this.lblFoto.Name = "lblFoto";
			this.lblFoto.Size = new System.Drawing.Size(22, 13);
			this.lblFoto.TabIndex = 8;
			this.lblFoto.Text = "Foto";
			// 
			// lblCategoria
			// 
			this.lblCategoria.Location = new System.Drawing.Point(12, 147);
			this.lblCategoria.Name = "lblCategoria";
			this.lblCategoria.Size = new System.Drawing.Size(47, 13);
			this.lblCategoria.TabIndex = 10;
			this.lblCategoria.Text = "Categoria";
			// 
			// imgFoto
			// 
			this.imgFoto.Location = new System.Drawing.Point(12, 121);
			this.imgFoto.Name = "imgFoto";
			this.imgFoto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.imgFoto.Size = new System.Drawing.Size(274, 20);
			this.imgFoto.TabIndex = 12;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(12, 205);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(274, 33);
			this.btnSalvar.TabIndex = 13;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// cmbCategoria
			// 
			this.cmbCategoria.FormattingEnabled = true;
			this.cmbCategoria.Location = new System.Drawing.Point(12, 166);
			this.cmbCategoria.Name = "cmbCategoria";
			this.cmbCategoria.Size = new System.Drawing.Size(274, 21);
			this.cmbCategoria.TabIndex = 14;
			// 
			// frmProduto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(298, 254);
			this.Controls.Add(this.cmbCategoria);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.imgFoto);
			this.Controls.Add(this.lblCategoria);
			this.Controls.Add(this.lblFoto);
			this.Controls.Add(this.lblPreco);
			this.Controls.Add(this.txtPreco);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.txtNome);
			this.Name = "frmProduto";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Produto";
			((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPreco.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgFoto.Properties)).EndInit();
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
		private DevExpress.XtraEditors.ImageEdit imgFoto;
		private DevExpress.XtraEditors.SimpleButton btnSalvar;
		private System.Windows.Forms.ComboBox cmbCategoria;
	}
}
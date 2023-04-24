namespace Desktop.Mercado
{
	partial class frmCategoria
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
			this.lstCategoria = new System.Windows.Forms.ListBox();
			this.txtNome = new DevExpress.XtraEditors.TextEdit();
			this.lblNome = new DevExpress.XtraEditors.LabelControl();
			this.btnExcluir = new DevExpress.XtraEditors.SimpleButton();
			this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// lstCategoria
			// 
			this.lstCategoria.FormattingEnabled = true;
			this.lstCategoria.Location = new System.Drawing.Point(12, 12);
			this.lstCategoria.Name = "lstCategoria";
			this.lstCategoria.Size = new System.Drawing.Size(274, 212);
			this.lstCategoria.TabIndex = 0;
			this.lstCategoria.Click += new System.EventHandler(this.lstCategoria_Click);
			this.lstCategoria.SelectedIndexChanged += new System.EventHandler(this.lstCategoria_SelectedIndexChanged);
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(49, 232);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(237, 20);
			this.txtNome.TabIndex = 1;
			// 
			// lblNome
			// 
			this.lblNome.Location = new System.Drawing.Point(12, 235);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(31, 13);
			this.lblNome.TabIndex = 2;
			this.lblNome.Text = "Nome:";
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(12, 265);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(123, 35);
			this.btnExcluir.TabIndex = 3;
			this.btnExcluir.Text = "EXCLUIR";
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(150, 265);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(136, 35);
			this.btnSalvar.TabIndex = 4;
			this.btnSalvar.Text = "SALVAR";
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// frmCategoria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(298, 312);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.lstCategoria);
			this.Name = "frmCategoria";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Categorias";
			((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstCategoria;
		private DevExpress.XtraEditors.TextEdit txtNome;
		private DevExpress.XtraEditors.LabelControl lblNome;
		private DevExpress.XtraEditors.SimpleButton btnExcluir;
		private DevExpress.XtraEditors.SimpleButton btnSalvar;
	}
}
namespace Desktop.Mercado
{
	partial class frmHome
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
			this.components = new System.ComponentModel.Container();
			this.formContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
			this.btnAtualizar = new DevExpress.XtraEditors.SimpleButton();
			this.btnExcluir = new DevExpress.XtraEditors.SimpleButton();
			this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
			this.btnCadastrar = new DevExpress.XtraEditors.SimpleButton();
			this.dgvProduto = new System.Windows.Forms.DataGridView();
			this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
			this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataHoraCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.accControl = new DevExpress.XtraBars.Navigation.AccordionControl();
			this.accCategorias = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.accMinhaConta = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
			this.btnSair = new DevExpress.XtraBars.BarButtonItem();
			this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
			this.formContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.accControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// formContainer
			// 
			this.formContainer.Controls.Add(this.btnAtualizar);
			this.formContainer.Controls.Add(this.btnExcluir);
			this.formContainer.Controls.Add(this.btnEditar);
			this.formContainer.Controls.Add(this.btnCadastrar);
			this.formContainer.Controls.Add(this.dgvProduto);
			this.formContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.formContainer.Location = new System.Drawing.Point(184, 31);
			this.formContainer.Name = "formContainer";
			this.formContainer.Size = new System.Drawing.Size(738, 586);
			this.formContainer.TabIndex = 0;
			this.formContainer.Click += new System.EventHandler(this.formContainer_Click);
			// 
			// btnAtualizar
			// 
			this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAtualizar.Location = new System.Drawing.Point(-130, 542);
			this.btnAtualizar.Name = "btnAtualizar";
			this.btnAtualizar.Size = new System.Drawing.Size(95, 32);
			this.btnAtualizar.TabIndex = 4;
			this.btnAtualizar.Text = "ATUALIZAR";
			this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExcluir.Location = new System.Drawing.Point(631, 542);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(95, 32);
			this.btnExcluir.TabIndex = 3;
			this.btnExcluir.Text = "EXCLUIR";
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEditar.Location = new System.Drawing.Point(530, 542);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(95, 32);
			this.btnEditar.TabIndex = 2;
			this.btnEditar.Text = "EDITAR";
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCadastrar.Location = new System.Drawing.Point(429, 542);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(95, 32);
			this.btnCadastrar.TabIndex = 1;
			this.btnCadastrar.Text = "CADASTRAR";
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// dgvProduto
			// 
			this.dgvProduto.AllowUserToAddRows = false;
			this.dgvProduto.AllowUserToDeleteRows = false;
			this.dgvProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Foto,
            this.Nome,
            this.Preco,
            this.Categoria,
            this.DataHoraCadastro});
			this.dgvProduto.Location = new System.Drawing.Point(-130, 6);
			this.dgvProduto.Name = "dgvProduto";
			this.dgvProduto.ReadOnly = true;
			this.dgvProduto.RowTemplate.Height = 84;
			this.dgvProduto.Size = new System.Drawing.Size(856, 530);
			this.dgvProduto.TabIndex = 0;
			// 
			// Codigo
			// 
			this.Codigo.HeaderText = "Codigo";
			this.Codigo.Name = "Codigo";
			this.Codigo.ReadOnly = true;
			this.Codigo.Visible = false;
			this.Codigo.Width = 50;
			// 
			// Foto
			// 
			this.Foto.HeaderText = "Foto";
			this.Foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.Foto.Name = "Foto";
			this.Foto.ReadOnly = true;
			this.Foto.Width = 80;
			// 
			// Nome
			// 
			this.Nome.HeaderText = "Nome";
			this.Nome.Name = "Nome";
			this.Nome.ReadOnly = true;
			this.Nome.Width = 200;
			// 
			// Preco
			// 
			this.Preco.HeaderText = "Preço";
			this.Preco.Name = "Preco";
			this.Preco.ReadOnly = true;
			// 
			// Categoria
			// 
			this.Categoria.HeaderText = "Categoria";
			this.Categoria.Name = "Categoria";
			this.Categoria.ReadOnly = true;
			this.Categoria.Width = 200;
			// 
			// DataHoraCadastro
			// 
			this.DataHoraCadastro.HeaderText = "Data/Hora Cadastro";
			this.DataHoraCadastro.Name = "DataHoraCadastro";
			this.DataHoraCadastro.ReadOnly = true;
			this.DataHoraCadastro.Width = 200;
			// 
			// accControl
			// 
			this.accControl.Dock = System.Windows.Forms.DockStyle.Left;
			this.accControl.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accCategorias,
            this.accMinhaConta});
			this.accControl.Location = new System.Drawing.Point(0, 31);
			this.accControl.Name = "accControl";
			this.accControl.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
			this.accControl.Size = new System.Drawing.Size(184, 586);
			this.accControl.TabIndex = 1;
			this.accControl.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
			// 
			// accCategorias
			// 
			this.accCategorias.Name = "accCategorias";
			this.accCategorias.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.accCategorias.Text = "Categorias";
			this.accCategorias.Click += new System.EventHandler(this.accCategorias_Click);
			// 
			// accMinhaConta
			// 
			this.accMinhaConta.Name = "accMinhaConta";
			this.accMinhaConta.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.accMinhaConta.Text = "Minha conta";
			this.accMinhaConta.Click += new System.EventHandler(this.accMinhaConta_Click);
			// 
			// fluentDesignFormControl1
			// 
			this.fluentDesignFormControl1.FluentDesignForm = this;
			this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSair});
			this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
			this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
			this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
			this.fluentDesignFormControl1.Size = new System.Drawing.Size(922, 31);
			this.fluentDesignFormControl1.TabIndex = 2;
			this.fluentDesignFormControl1.TabStop = false;
			this.fluentDesignFormControl1.TitleItemLinks.Add(this.btnSair);
			// 
			// btnSair
			// 
			this.btnSair.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.btnSair.Caption = "Sair";
			this.btnSair.Id = 0;
			this.btnSair.Name = "btnSair";
			this.btnSair.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSair_ItemClick);
			// 
			// fluentFormDefaultManager1
			// 
			this.fluentFormDefaultManager1.Form = this;
			this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSair});
			this.fluentFormDefaultManager1.MaxItemId = 1;
			// 
			// frmHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(922, 617);
			this.ControlContainer = this.formContainer;
			this.Controls.Add(this.formContainer);
			this.Controls.Add(this.accControl);
			this.Controls.Add(this.fluentDesignFormControl1);
			this.FluentDesignFormControl = this.fluentDesignFormControl1;
			this.Name = "frmHome";
			this.NavigationControl = this.accControl;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mercado - Produtos";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHome_FormClosed);
			this.formContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.accControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer formContainer;
		private DevExpress.XtraBars.Navigation.AccordionControl accControl;
		private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
		private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
		private System.Windows.Forms.DataGridView dgvProduto;
		private DevExpress.XtraEditors.SimpleButton btnExcluir;
		private DevExpress.XtraEditors.SimpleButton btnEditar;
		private DevExpress.XtraEditors.SimpleButton btnCadastrar;
		private DevExpress.XtraBars.BarButtonItem btnSair;
		private DevExpress.XtraEditors.SimpleButton btnAtualizar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
		private System.Windows.Forms.DataGridViewImageColumn Foto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
		private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
		private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
		private System.Windows.Forms.DataGridViewTextBoxColumn DataHoraCadastro;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accCategorias;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accMinhaConta;
	}
}
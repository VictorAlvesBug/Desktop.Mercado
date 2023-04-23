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
			this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
			this.btnCategorias = new DevExpress.XtraEditors.SimpleButton();
			this.btnExcluir = new DevExpress.XtraEditors.SimpleButton();
			this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
			this.btnCadastrar = new DevExpress.XtraEditors.SimpleButton();
			this.dgvProduto = new System.Windows.Forms.DataGridView();
			this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
			this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
			this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
			this.btnSair = new DevExpress.XtraBars.BarButtonItem();
			this.fluentDesignFormContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// fluentDesignFormContainer1
			// 
			this.fluentDesignFormContainer1.Controls.Add(this.btnCategorias);
			this.fluentDesignFormContainer1.Controls.Add(this.btnExcluir);
			this.fluentDesignFormContainer1.Controls.Add(this.btnEditar);
			this.fluentDesignFormContainer1.Controls.Add(this.btnCadastrar);
			this.fluentDesignFormContainer1.Controls.Add(this.dgvProduto);
			this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fluentDesignFormContainer1.Location = new System.Drawing.Point(48, 31);
			this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
			this.fluentDesignFormContainer1.Size = new System.Drawing.Size(1061, 592);
			this.fluentDesignFormContainer1.TabIndex = 0;
			// 
			// btnCategorias
			// 
			this.btnCategorias.Location = new System.Drawing.Point(6, 548);
			this.btnCategorias.Name = "btnCategorias";
			this.btnCategorias.Size = new System.Drawing.Size(95, 32);
			this.btnCategorias.TabIndex = 4;
			this.btnCategorias.Text = "CATEGORIAS";
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(954, 548);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(95, 32);
			this.btnExcluir.TabIndex = 3;
			this.btnExcluir.Text = "EXCLUIR";
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(853, 548);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(95, 32);
			this.btnEditar.TabIndex = 2;
			this.btnEditar.Text = "EDITAR";
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Location = new System.Drawing.Point(752, 548);
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
			this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProduto.Location = new System.Drawing.Point(6, 6);
			this.dgvProduto.Name = "dgvProduto";
			this.dgvProduto.Size = new System.Drawing.Size(1043, 536);
			this.dgvProduto.TabIndex = 0;
			// 
			// accordionControl1
			// 
			this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1});
			this.accordionControl1.Location = new System.Drawing.Point(0, 31);
			this.accordionControl1.Name = "accordionControl1";
			this.accordionControl1.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
			this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
			this.accordionControl1.Size = new System.Drawing.Size(48, 592);
			this.accordionControl1.TabIndex = 1;
			this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
			// 
			// accordionControlElement1
			// 
			this.accordionControlElement1.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
			this.accordionControlElement1.Name = "accordionControlElement1";
			this.accordionControlElement1.Text = "Element1";
			// 
			// fluentDesignFormControl1
			// 
			this.fluentDesignFormControl1.FluentDesignForm = this;
			this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSair});
			this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
			this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
			this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
			this.fluentDesignFormControl1.Size = new System.Drawing.Size(1109, 31);
			this.fluentDesignFormControl1.TabIndex = 2;
			this.fluentDesignFormControl1.TabStop = false;
			this.fluentDesignFormControl1.TitleItemLinks.Add(this.btnSair);
			// 
			// fluentFormDefaultManager1
			// 
			this.fluentFormDefaultManager1.Form = this;
			this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSair});
			this.fluentFormDefaultManager1.MaxItemId = 1;
			// 
			// btnSair
			// 
			this.btnSair.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.btnSair.Caption = "Sair";
			this.btnSair.Id = 0;
			this.btnSair.Name = "btnSair";
			this.btnSair.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSair_ItemClick);
			// 
			// frmHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1109, 623);
			this.ControlContainer = this.fluentDesignFormContainer1;
			this.Controls.Add(this.fluentDesignFormContainer1);
			this.Controls.Add(this.accordionControl1);
			this.Controls.Add(this.fluentDesignFormControl1);
			this.FluentDesignFormControl = this.fluentDesignFormControl1;
			this.Name = "frmHome";
			this.NavigationControl = this.accordionControl1;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmHome";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHome_FormClosed);
			this.fluentDesignFormContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
		private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
		private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
		private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
		private System.Windows.Forms.DataGridView dgvProduto;
		private DevExpress.XtraEditors.SimpleButton btnCategorias;
		private DevExpress.XtraEditors.SimpleButton btnExcluir;
		private DevExpress.XtraEditors.SimpleButton btnEditar;
		private DevExpress.XtraEditors.SimpleButton btnCadastrar;
		private DevExpress.XtraBars.BarButtonItem btnSair;
	}
}
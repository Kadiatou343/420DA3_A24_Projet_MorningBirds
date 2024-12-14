namespace _420DA3_A24_Projet.Presentation;

partial class OffEmployeeMainMenu {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.topBarPanel = new Panel();
        this.botttomBarPanel = new Panel();
        this.logoutButton = new Button();
        this.primaryTableLayoutPanel = new TableLayoutPanel();
        this.soManagementPanel = new Panel();
        this.soListBox = new ListBox();
        this.searchSOTextBox = new TextBox();
        this.createSOPanel = new Panel();
        this.createSoButton = new Button();
        this.poActionButttonsPanel = new Panel();
        this.containerPanel = new Panel();
        this.soActionTableLayoutPanel = new TableLayoutPanel();
        this.deleteSoButton = new Button();
        this.updateSoButtton = new Button();
        this.seeSoDetailsButton = new Button();
        this.enititesTableLayoutPanel = new TableLayoutPanel();
        this.supplierManagementTbLytPanel = new TableLayoutPanel();
        this.supplierActionBtnPanel = new Panel();
        this.tableLayoutPanel2 = new TableLayoutPanel();
        this.deleteSupplierButton = new Button();
        this.updateSupplierButton = new Button();
        this.createSupplierButton = new Button();
        this.seeSupplierDetailsButton = new Button();
        this.supplierSearchPanel = new Panel();
        this.supplierListBox = new ListBox();
        this.supplierSearchTextBox = new TextBox();
        this.productManagementTbLytPanel = new TableLayoutPanel();
        this.productActionBtnPanel = new Panel();
        this.tableLayoutPanel1 = new TableLayoutPanel();
        this.deleteProductButton = new Button();
        this.updateProductButton = new Button();
        this.createProductButton = new Button();
        this.seeProductDetailsButton = new Button();
        this.productSearchPanel = new Panel();
        this.productListBox = new ListBox();
        this.productSearchTextBox = new TextBox();
        this.clientManagementTbLytPanel = new TableLayoutPanel();
        this.clientActionBtnPanel = new Panel();
        this.clientActionBtnTbLytPanel = new TableLayoutPanel();
        this.deleteClientButton = new Button();
        this.updateClientButton = new Button();
        this.createClientButton = new Button();
        this.seeClientDetailsButton = new Button();
        this.clientSearchPanel = new Panel();
        this.clientListBox = new ListBox();
        this.clientSearchTextBox = new TextBox();
        this.botttomBarPanel.SuspendLayout();
        this.primaryTableLayoutPanel.SuspendLayout();
        this.soManagementPanel.SuspendLayout();
        this.createSOPanel.SuspendLayout();
        this.poActionButttonsPanel.SuspendLayout();
        this.containerPanel.SuspendLayout();
        this.soActionTableLayoutPanel.SuspendLayout();
        this.enititesTableLayoutPanel.SuspendLayout();
        this.supplierManagementTbLytPanel.SuspendLayout();
        this.supplierActionBtnPanel.SuspendLayout();
        this.tableLayoutPanel2.SuspendLayout();
        this.supplierSearchPanel.SuspendLayout();
        this.productManagementTbLytPanel.SuspendLayout();
        this.productActionBtnPanel.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        this.productSearchPanel.SuspendLayout();
        this.clientManagementTbLytPanel.SuspendLayout();
        this.clientActionBtnPanel.SuspendLayout();
        this.clientActionBtnTbLytPanel.SuspendLayout();
        this.clientSearchPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Margin = new Padding(2);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(1090, 40);
        this.topBarPanel.TabIndex = 0;
        // 
        // botttomBarPanel
        // 
        this.botttomBarPanel.Controls.Add(this.logoutButton);
        this.botttomBarPanel.Dock = DockStyle.Bottom;
        this.botttomBarPanel.Location = new Point(0, 554);
        this.botttomBarPanel.Margin = new Padding(2);
        this.botttomBarPanel.Name = "botttomBarPanel";
        this.botttomBarPanel.Size = new Size(1090, 40);
        this.botttomBarPanel.TabIndex = 1;
        // 
        // logoutButton
        // 
        this.logoutButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.logoutButton.Location = new Point(953, 5);
        this.logoutButton.Margin = new Padding(2);
        this.logoutButton.Name = "logoutButton";
        this.logoutButton.Size = new Size(120, 27);
        this.logoutButton.TabIndex = 0;
        this.logoutButton.Text = "Deconnexion";
        this.logoutButton.UseVisualStyleBackColor = true;
        this.logoutButton.Click += this.logoutButton_Click;
        // 
        // primaryTableLayoutPanel
        // 
        this.primaryTableLayoutPanel.ColumnCount = 2;
        this.primaryTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.primaryTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.primaryTableLayoutPanel.Controls.Add(this.soManagementPanel, 0, 0);
        this.primaryTableLayoutPanel.Controls.Add(this.enititesTableLayoutPanel, 1, 0);
        this.primaryTableLayoutPanel.Dock = DockStyle.Fill;
        this.primaryTableLayoutPanel.Location = new Point(0, 40);
        this.primaryTableLayoutPanel.Margin = new Padding(2);
        this.primaryTableLayoutPanel.Name = "primaryTableLayoutPanel";
        this.primaryTableLayoutPanel.RowCount = 1;
        this.primaryTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.primaryTableLayoutPanel.Size = new Size(1090, 514);
        this.primaryTableLayoutPanel.TabIndex = 2;
        // 
        // soManagementPanel
        // 
        this.soManagementPanel.Controls.Add(this.soListBox);
        this.soManagementPanel.Controls.Add(this.searchSOTextBox);
        this.soManagementPanel.Controls.Add(this.createSOPanel);
        this.soManagementPanel.Controls.Add(this.poActionButttonsPanel);
        this.soManagementPanel.Dock = DockStyle.Fill;
        this.soManagementPanel.Location = new Point(2, 2);
        this.soManagementPanel.Margin = new Padding(2);
        this.soManagementPanel.Name = "soManagementPanel";
        this.soManagementPanel.Size = new Size(541, 510);
        this.soManagementPanel.TabIndex = 0;
        // 
        // soListBox
        // 
        this.soListBox.Dock = DockStyle.Fill;
        this.soListBox.FormattingEnabled = true;
        this.soListBox.ItemHeight = 20;
        this.soListBox.Location = new Point(0, 67);
        this.soListBox.Margin = new Padding(2);
        this.soListBox.Name = "soListBox";
        this.soListBox.Size = new Size(541, 323);
        this.soListBox.TabIndex = 3;
        // 
        // searchSOTextBox
        // 
        this.searchSOTextBox.Dock = DockStyle.Top;
        this.searchSOTextBox.Location = new Point(0, 40);
        this.searchSOTextBox.Margin = new Padding(2);
        this.searchSOTextBox.Name = "searchSOTextBox";
        this.searchSOTextBox.PlaceholderText = "Rechercher un ordre d'expédition";
        this.searchSOTextBox.Size = new Size(541, 27);
        this.searchSOTextBox.TabIndex = 2;
        // 
        // createSOPanel
        // 
        this.createSOPanel.Controls.Add(this.createSoButton);
        this.createSOPanel.Dock = DockStyle.Top;
        this.createSOPanel.Location = new Point(0, 0);
        this.createSOPanel.Margin = new Padding(2);
        this.createSOPanel.Name = "createSOPanel";
        this.createSOPanel.Size = new Size(541, 40);
        this.createSOPanel.TabIndex = 1;
        // 
        // createSoButton
        // 
        this.createSoButton.Location = new Point(180, 4);
        this.createSoButton.Margin = new Padding(2);
        this.createSoButton.Name = "createSoButton";
        this.createSoButton.Size = new Size(194, 32);
        this.createSoButton.TabIndex = 2;
        this.createSoButton.Text = "Créer un ordre d'expédition";
        this.createSoButton.UseVisualStyleBackColor = true;
        // 
        // poActionButttonsPanel
        // 
        this.poActionButttonsPanel.BackgroundImageLayout = ImageLayout.Zoom;
        this.poActionButttonsPanel.Controls.Add(this.containerPanel);
        this.poActionButttonsPanel.Dock = DockStyle.Bottom;
        this.poActionButttonsPanel.Location = new Point(0, 390);
        this.poActionButttonsPanel.Margin = new Padding(2);
        this.poActionButttonsPanel.Name = "poActionButttonsPanel";
        this.poActionButttonsPanel.Size = new Size(541, 120);
        this.poActionButttonsPanel.TabIndex = 0;
        // 
        // containerPanel
        // 
        this.containerPanel.Controls.Add(this.soActionTableLayoutPanel);
        this.containerPanel.Location = new Point(126, 2);
        this.containerPanel.Margin = new Padding(2);
        this.containerPanel.Name = "containerPanel";
        this.containerPanel.Size = new Size(283, 116);
        this.containerPanel.TabIndex = 0;
        // 
        // soActionTableLayoutPanel
        // 
        this.soActionTableLayoutPanel.ColumnCount = 1;
        this.soActionTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        this.soActionTableLayoutPanel.Controls.Add(this.deleteSoButton, 0, 2);
        this.soActionTableLayoutPanel.Controls.Add(this.updateSoButtton, 0, 1);
        this.soActionTableLayoutPanel.Controls.Add(this.seeSoDetailsButton, 0, 0);
        this.soActionTableLayoutPanel.Dock = DockStyle.Fill;
        this.soActionTableLayoutPanel.Location = new Point(0, 0);
        this.soActionTableLayoutPanel.Margin = new Padding(2);
        this.soActionTableLayoutPanel.Name = "soActionTableLayoutPanel";
        this.soActionTableLayoutPanel.RowCount = 3;
        this.soActionTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        this.soActionTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        this.soActionTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        this.soActionTableLayoutPanel.Size = new Size(283, 116);
        this.soActionTableLayoutPanel.TabIndex = 0;
        // 
        // deleteSoButton
        // 
        this.deleteSoButton.Dock = DockStyle.Fill;
        this.deleteSoButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        this.deleteSoButton.Location = new Point(2, 78);
        this.deleteSoButton.Margin = new Padding(2);
        this.deleteSoButton.Name = "deleteSoButton";
        this.deleteSoButton.Size = new Size(279, 36);
        this.deleteSoButton.TabIndex = 2;
        this.deleteSoButton.Text = "Supprimer ordre d'expédition";
        this.deleteSoButton.UseVisualStyleBackColor = true;
        // 
        // updateSoButtton
        // 
        this.updateSoButtton.Dock = DockStyle.Fill;
        this.updateSoButtton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        this.updateSoButtton.Location = new Point(2, 40);
        this.updateSoButtton.Margin = new Padding(2);
        this.updateSoButtton.Name = "updateSoButtton";
        this.updateSoButtton.Size = new Size(279, 34);
        this.updateSoButtton.TabIndex = 1;
        this.updateSoButtton.Text = "Modifier ordre d'expédition";
        this.updateSoButtton.UseVisualStyleBackColor = true;
        // 
        // seeSoDetailsButton
        // 
        this.seeSoDetailsButton.Dock = DockStyle.Fill;
        this.seeSoDetailsButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        this.seeSoDetailsButton.Location = new Point(2, 2);
        this.seeSoDetailsButton.Margin = new Padding(2);
        this.seeSoDetailsButton.Name = "seeSoDetailsButton";
        this.seeSoDetailsButton.Size = new Size(279, 34);
        this.seeSoDetailsButton.TabIndex = 0;
        this.seeSoDetailsButton.Text = "Voir ordre d'expédition détails";
        this.seeSoDetailsButton.UseVisualStyleBackColor = true;
        // 
        // enititesTableLayoutPanel
        // 
        this.enititesTableLayoutPanel.ColumnCount = 1;
        this.enititesTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        this.enititesTableLayoutPanel.Controls.Add(this.supplierManagementTbLytPanel, 0, 2);
        this.enititesTableLayoutPanel.Controls.Add(this.productManagementTbLytPanel, 0, 1);
        this.enititesTableLayoutPanel.Controls.Add(this.clientManagementTbLytPanel, 0, 0);
        this.enititesTableLayoutPanel.Dock = DockStyle.Fill;
        this.enititesTableLayoutPanel.Location = new Point(547, 2);
        this.enititesTableLayoutPanel.Margin = new Padding(2);
        this.enititesTableLayoutPanel.Name = "enititesTableLayoutPanel";
        this.enititesTableLayoutPanel.RowCount = 3;
        this.enititesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        this.enititesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        this.enititesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        this.enititesTableLayoutPanel.Size = new Size(541, 510);
        this.enititesTableLayoutPanel.TabIndex = 1;
        // 
        // supplierManagementTbLytPanel
        // 
        this.supplierManagementTbLytPanel.ColumnCount = 2;
        this.supplierManagementTbLytPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.supplierManagementTbLytPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.supplierManagementTbLytPanel.Controls.Add(this.supplierActionBtnPanel, 1, 0);
        this.supplierManagementTbLytPanel.Controls.Add(this.supplierSearchPanel, 0, 0);
        this.supplierManagementTbLytPanel.Dock = DockStyle.Fill;
        this.supplierManagementTbLytPanel.Location = new Point(2, 342);
        this.supplierManagementTbLytPanel.Margin = new Padding(2);
        this.supplierManagementTbLytPanel.Name = "supplierManagementTbLytPanel";
        this.supplierManagementTbLytPanel.RowCount = 1;
        this.supplierManagementTbLytPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.supplierManagementTbLytPanel.Size = new Size(537, 166);
        this.supplierManagementTbLytPanel.TabIndex = 2;
        // 
        // supplierActionBtnPanel
        // 
        this.supplierActionBtnPanel.Controls.Add(this.tableLayoutPanel2);
        this.supplierActionBtnPanel.Dock = DockStyle.Fill;
        this.supplierActionBtnPanel.Location = new Point(270, 2);
        this.supplierActionBtnPanel.Margin = new Padding(2);
        this.supplierActionBtnPanel.Name = "supplierActionBtnPanel";
        this.supplierActionBtnPanel.Size = new Size(265, 162);
        this.supplierActionBtnPanel.TabIndex = 3;
        // 
        // tableLayoutPanel2
        // 
        this.tableLayoutPanel2.ColumnCount = 1;
        this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel2.Controls.Add(this.deleteSupplierButton, 0, 3);
        this.tableLayoutPanel2.Controls.Add(this.updateSupplierButton, 0, 2);
        this.tableLayoutPanel2.Controls.Add(this.createSupplierButton, 0, 0);
        this.tableLayoutPanel2.Controls.Add(this.seeSupplierDetailsButton, 0, 1);
        this.tableLayoutPanel2.Dock = DockStyle.Fill;
        this.tableLayoutPanel2.Location = new Point(0, 0);
        this.tableLayoutPanel2.Margin = new Padding(2);
        this.tableLayoutPanel2.Name = "tableLayoutPanel2";
        this.tableLayoutPanel2.RowCount = 4;
        this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        this.tableLayoutPanel2.Size = new Size(265, 162);
        this.tableLayoutPanel2.TabIndex = 1;
        // 
        // deleteSupplierButton
        // 
        this.deleteSupplierButton.Dock = DockStyle.Fill;
        this.deleteSupplierButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        this.deleteSupplierButton.Location = new Point(2, 122);
        this.deleteSupplierButton.Margin = new Padding(2);
        this.deleteSupplierButton.Name = "deleteSupplierButton";
        this.deleteSupplierButton.Size = new Size(261, 38);
        this.deleteSupplierButton.TabIndex = 3;
        this.deleteSupplierButton.Text = "Supprimer fournisseur";
        this.deleteSupplierButton.UseVisualStyleBackColor = true;
        // 
        // updateSupplierButton
        // 
        this.updateSupplierButton.Dock = DockStyle.Fill;
        this.updateSupplierButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        this.updateSupplierButton.Location = new Point(2, 82);
        this.updateSupplierButton.Margin = new Padding(2);
        this.updateSupplierButton.Name = "updateSupplierButton";
        this.updateSupplierButton.Size = new Size(261, 36);
        this.updateSupplierButton.TabIndex = 2;
        this.updateSupplierButton.Text = "Modifier fournisseur";
        this.updateSupplierButton.UseVisualStyleBackColor = true;
        // 
        // createSupplierButton
        // 
        this.createSupplierButton.Dock = DockStyle.Fill;
        this.createSupplierButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        this.createSupplierButton.Location = new Point(2, 2);
        this.createSupplierButton.Margin = new Padding(2);
        this.createSupplierButton.Name = "createSupplierButton";
        this.createSupplierButton.Size = new Size(261, 36);
        this.createSupplierButton.TabIndex = 0;
        this.createSupplierButton.Text = "Créer un fournisseur";
        this.createSupplierButton.UseVisualStyleBackColor = true;
        // 
        // seeSupplierDetailsButton
        // 
        this.seeSupplierDetailsButton.Dock = DockStyle.Fill;
        this.seeSupplierDetailsButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        this.seeSupplierDetailsButton.Location = new Point(2, 42);
        this.seeSupplierDetailsButton.Margin = new Padding(2);
        this.seeSupplierDetailsButton.Name = "seeSupplierDetailsButton";
        this.seeSupplierDetailsButton.Size = new Size(261, 36);
        this.seeSupplierDetailsButton.TabIndex = 1;
        this.seeSupplierDetailsButton.Text = "Voir fournisseur détails";
        this.seeSupplierDetailsButton.UseVisualStyleBackColor = true;
        // 
        // supplierSearchPanel
        // 
        this.supplierSearchPanel.Controls.Add(this.supplierListBox);
        this.supplierSearchPanel.Controls.Add(this.supplierSearchTextBox);
        this.supplierSearchPanel.Dock = DockStyle.Fill;
        this.supplierSearchPanel.Location = new Point(2, 2);
        this.supplierSearchPanel.Margin = new Padding(2);
        this.supplierSearchPanel.Name = "supplierSearchPanel";
        this.supplierSearchPanel.Size = new Size(264, 162);
        this.supplierSearchPanel.TabIndex = 1;
        // 
        // supplierListBox
        // 
        this.supplierListBox.Dock = DockStyle.Fill;
        this.supplierListBox.FormattingEnabled = true;
        this.supplierListBox.ItemHeight = 20;
        this.supplierListBox.Location = new Point(0, 27);
        this.supplierListBox.Margin = new Padding(2);
        this.supplierListBox.Name = "supplierListBox";
        this.supplierListBox.Size = new Size(264, 135);
        this.supplierListBox.TabIndex = 2;
        // 
        // supplierSearchTextBox
        // 
        this.supplierSearchTextBox.Dock = DockStyle.Top;
        this.supplierSearchTextBox.Location = new Point(0, 0);
        this.supplierSearchTextBox.Margin = new Padding(2);
        this.supplierSearchTextBox.Name = "supplierSearchTextBox";
        this.supplierSearchTextBox.PlaceholderText = "Rechercher un fournisseur";
        this.supplierSearchTextBox.Size = new Size(264, 27);
        this.supplierSearchTextBox.TabIndex = 1;
        // 
        // productManagementTbLytPanel
        // 
        this.productManagementTbLytPanel.ColumnCount = 2;
        this.productManagementTbLytPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.productManagementTbLytPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.productManagementTbLytPanel.Controls.Add(this.productActionBtnPanel, 1, 0);
        this.productManagementTbLytPanel.Controls.Add(this.productSearchPanel, 0, 0);
        this.productManagementTbLytPanel.Dock = DockStyle.Fill;
        this.productManagementTbLytPanel.Location = new Point(2, 172);
        this.productManagementTbLytPanel.Margin = new Padding(2);
        this.productManagementTbLytPanel.Name = "productManagementTbLytPanel";
        this.productManagementTbLytPanel.RowCount = 1;
        this.productManagementTbLytPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.productManagementTbLytPanel.Size = new Size(537, 166);
        this.productManagementTbLytPanel.TabIndex = 1;
        // 
        // productActionBtnPanel
        // 
        this.productActionBtnPanel.Controls.Add(this.tableLayoutPanel1);
        this.productActionBtnPanel.Dock = DockStyle.Fill;
        this.productActionBtnPanel.Location = new Point(270, 2);
        this.productActionBtnPanel.Margin = new Padding(2);
        this.productActionBtnPanel.Name = "productActionBtnPanel";
        this.productActionBtnPanel.Size = new Size(265, 162);
        this.productActionBtnPanel.TabIndex = 2;
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 1;
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel1.Controls.Add(this.deleteProductButton, 0, 3);
        this.tableLayoutPanel1.Controls.Add(this.updateProductButton, 0, 2);
        this.tableLayoutPanel1.Controls.Add(this.createProductButton, 0, 0);
        this.tableLayoutPanel1.Controls.Add(this.seeProductDetailsButton, 0, 1);
        this.tableLayoutPanel1.Dock = DockStyle.Fill;
        this.tableLayoutPanel1.Location = new Point(0, 0);
        this.tableLayoutPanel1.Margin = new Padding(2);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 4;
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        this.tableLayoutPanel1.Size = new Size(265, 162);
        this.tableLayoutPanel1.TabIndex = 1;
        // 
        // deleteProductButton
        // 
        this.deleteProductButton.Dock = DockStyle.Fill;
        this.deleteProductButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        this.deleteProductButton.Location = new Point(2, 122);
        this.deleteProductButton.Margin = new Padding(2);
        this.deleteProductButton.Name = "deleteProductButton";
        this.deleteProductButton.Size = new Size(261, 38);
        this.deleteProductButton.TabIndex = 3;
        this.deleteProductButton.Text = "Supprimer produit";
        this.deleteProductButton.UseVisualStyleBackColor = true;
        this.deleteProductButton.Click += this.deleteProductButton_Click;
        // 
        // updateProductButton
        // 
        this.updateProductButton.Dock = DockStyle.Fill;
        this.updateProductButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        this.updateProductButton.Location = new Point(2, 82);
        this.updateProductButton.Margin = new Padding(2);
        this.updateProductButton.Name = "updateProductButton";
        this.updateProductButton.Size = new Size(261, 36);
        this.updateProductButton.TabIndex = 2;
        this.updateProductButton.Text = "Modifier produit";
        this.updateProductButton.UseVisualStyleBackColor = true;
        this.updateProductButton.Click += this.updateProductButton_Click;
        // 
        // createProductButton
        // 
        this.createProductButton.Dock = DockStyle.Fill;
        this.createProductButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        this.createProductButton.Location = new Point(2, 2);
        this.createProductButton.Margin = new Padding(2);
        this.createProductButton.Name = "createProductButton";
        this.createProductButton.Size = new Size(261, 36);
        this.createProductButton.TabIndex = 0;
        this.createProductButton.Text = "Créer un produit";
        this.createProductButton.UseVisualStyleBackColor = true;
        this.createProductButton.Click += this.createProductButton_Click;
        // 
        // seeProductDetailsButton
        // 
        this.seeProductDetailsButton.Dock = DockStyle.Fill;
        this.seeProductDetailsButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        this.seeProductDetailsButton.Location = new Point(2, 42);
        this.seeProductDetailsButton.Margin = new Padding(2);
        this.seeProductDetailsButton.Name = "seeProductDetailsButton";
        this.seeProductDetailsButton.Size = new Size(261, 36);
        this.seeProductDetailsButton.TabIndex = 1;
        this.seeProductDetailsButton.Text = "Voir produit détails";
        this.seeProductDetailsButton.UseVisualStyleBackColor = true;
        this.seeProductDetailsButton.Click += this.seeProductDetailsButton_Click;
        // 
        // productSearchPanel
        // 
        this.productSearchPanel.Controls.Add(this.productListBox);
        this.productSearchPanel.Controls.Add(this.productSearchTextBox);
        this.productSearchPanel.Dock = DockStyle.Fill;
        this.productSearchPanel.Location = new Point(2, 2);
        this.productSearchPanel.Margin = new Padding(2);
        this.productSearchPanel.Name = "productSearchPanel";
        this.productSearchPanel.Size = new Size(264, 162);
        this.productSearchPanel.TabIndex = 1;
        // 
        // productListBox
        // 
        this.productListBox.Dock = DockStyle.Fill;
        this.productListBox.FormattingEnabled = true;
        this.productListBox.ItemHeight = 20;
        this.productListBox.Location = new Point(0, 27);
        this.productListBox.Margin = new Padding(2);
        this.productListBox.Name = "productListBox";
        this.productListBox.Size = new Size(264, 135);
        this.productListBox.TabIndex = 2;
        this.productListBox.SelectedIndexChanged += this.productListBox_SelectedIndexChanged;
        // 
        // productSearchTextBox
        // 
        this.productSearchTextBox.Dock = DockStyle.Top;
        this.productSearchTextBox.Location = new Point(0, 0);
        this.productSearchTextBox.Margin = new Padding(2);
        this.productSearchTextBox.Name = "productSearchTextBox";
        this.productSearchTextBox.PlaceholderText = "Rechercher un produit";
        this.productSearchTextBox.Size = new Size(264, 27);
        this.productSearchTextBox.TabIndex = 1;
        this.productSearchTextBox.TextChanged += this.productSearchTextBox_TextChanged;
        // 
        // clientManagementTbLytPanel
        // 
        this.clientManagementTbLytPanel.ColumnCount = 2;
        this.clientManagementTbLytPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.clientManagementTbLytPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.clientManagementTbLytPanel.Controls.Add(this.clientActionBtnPanel, 1, 0);
        this.clientManagementTbLytPanel.Controls.Add(this.clientSearchPanel, 0, 0);
        this.clientManagementTbLytPanel.Dock = DockStyle.Fill;
        this.clientManagementTbLytPanel.Location = new Point(2, 2);
        this.clientManagementTbLytPanel.Margin = new Padding(2);
        this.clientManagementTbLytPanel.Name = "clientManagementTbLytPanel";
        this.clientManagementTbLytPanel.RowCount = 1;
        this.clientManagementTbLytPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.clientManagementTbLytPanel.Size = new Size(537, 166);
        this.clientManagementTbLytPanel.TabIndex = 0;
        // 
        // clientActionBtnPanel
        // 
        this.clientActionBtnPanel.Controls.Add(this.clientActionBtnTbLytPanel);
        this.clientActionBtnPanel.Dock = DockStyle.Fill;
        this.clientActionBtnPanel.Location = new Point(270, 2);
        this.clientActionBtnPanel.Margin = new Padding(2);
        this.clientActionBtnPanel.Name = "clientActionBtnPanel";
        this.clientActionBtnPanel.Size = new Size(265, 162);
        this.clientActionBtnPanel.TabIndex = 1;
        // 
        // clientActionBtnTbLytPanel
        // 
        this.clientActionBtnTbLytPanel.ColumnCount = 1;
        this.clientActionBtnTbLytPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        this.clientActionBtnTbLytPanel.Controls.Add(this.deleteClientButton, 0, 3);
        this.clientActionBtnTbLytPanel.Controls.Add(this.updateClientButton, 0, 2);
        this.clientActionBtnTbLytPanel.Controls.Add(this.createClientButton, 0, 0);
        this.clientActionBtnTbLytPanel.Controls.Add(this.seeClientDetailsButton, 0, 1);
        this.clientActionBtnTbLytPanel.Dock = DockStyle.Fill;
        this.clientActionBtnTbLytPanel.Location = new Point(0, 0);
        this.clientActionBtnTbLytPanel.Margin = new Padding(2);
        this.clientActionBtnTbLytPanel.Name = "clientActionBtnTbLytPanel";
        this.clientActionBtnTbLytPanel.RowCount = 4;
        this.clientActionBtnTbLytPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        this.clientActionBtnTbLytPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        this.clientActionBtnTbLytPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        this.clientActionBtnTbLytPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        this.clientActionBtnTbLytPanel.Size = new Size(265, 162);
        this.clientActionBtnTbLytPanel.TabIndex = 0;
        // 
        // deleteClientButton
        // 
        this.deleteClientButton.Dock = DockStyle.Fill;
        this.deleteClientButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        this.deleteClientButton.Location = new Point(2, 122);
        this.deleteClientButton.Margin = new Padding(2);
        this.deleteClientButton.Name = "deleteClientButton";
        this.deleteClientButton.Size = new Size(261, 38);
        this.deleteClientButton.TabIndex = 3;
        this.deleteClientButton.Text = "Supprimer client";
        this.deleteClientButton.UseVisualStyleBackColor = true;
        // 
        // updateClientButton
        // 
        this.updateClientButton.Dock = DockStyle.Fill;
        this.updateClientButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        this.updateClientButton.Location = new Point(2, 82);
        this.updateClientButton.Margin = new Padding(2);
        this.updateClientButton.Name = "updateClientButton";
        this.updateClientButton.Size = new Size(261, 36);
        this.updateClientButton.TabIndex = 2;
        this.updateClientButton.Text = "Modifier client";
        this.updateClientButton.UseVisualStyleBackColor = true;
        // 
        // createClientButton
        // 
        this.createClientButton.Dock = DockStyle.Fill;
        this.createClientButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        this.createClientButton.Location = new Point(2, 2);
        this.createClientButton.Margin = new Padding(2);
        this.createClientButton.Name = "createClientButton";
        this.createClientButton.Size = new Size(261, 36);
        this.createClientButton.TabIndex = 0;
        this.createClientButton.Text = "Créer un client";
        this.createClientButton.UseVisualStyleBackColor = true;
        // 
        // seeClientDetailsButton
        // 
        this.seeClientDetailsButton.Dock = DockStyle.Fill;
        this.seeClientDetailsButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        this.seeClientDetailsButton.Location = new Point(2, 42);
        this.seeClientDetailsButton.Margin = new Padding(2);
        this.seeClientDetailsButton.Name = "seeClientDetailsButton";
        this.seeClientDetailsButton.Size = new Size(261, 36);
        this.seeClientDetailsButton.TabIndex = 1;
        this.seeClientDetailsButton.Text = "Voir client détails";
        this.seeClientDetailsButton.UseVisualStyleBackColor = true;
        // 
        // clientSearchPanel
        // 
        this.clientSearchPanel.Controls.Add(this.clientListBox);
        this.clientSearchPanel.Controls.Add(this.clientSearchTextBox);
        this.clientSearchPanel.Dock = DockStyle.Fill;
        this.clientSearchPanel.Location = new Point(2, 2);
        this.clientSearchPanel.Margin = new Padding(2);
        this.clientSearchPanel.Name = "clientSearchPanel";
        this.clientSearchPanel.Size = new Size(264, 162);
        this.clientSearchPanel.TabIndex = 0;
        // 
        // clientListBox
        // 
        this.clientListBox.Dock = DockStyle.Fill;
        this.clientListBox.FormattingEnabled = true;
        this.clientListBox.ItemHeight = 20;
        this.clientListBox.Location = new Point(0, 27);
        this.clientListBox.Margin = new Padding(2);
        this.clientListBox.Name = "clientListBox";
        this.clientListBox.Size = new Size(264, 135);
        this.clientListBox.TabIndex = 1;
        // 
        // clientSearchTextBox
        // 
        this.clientSearchTextBox.Dock = DockStyle.Top;
        this.clientSearchTextBox.Location = new Point(0, 0);
        this.clientSearchTextBox.Margin = new Padding(2);
        this.clientSearchTextBox.Name = "clientSearchTextBox";
        this.clientSearchTextBox.PlaceholderText = "Rechercher un client";
        this.clientSearchTextBox.Size = new Size(264, 27);
        this.clientSearchTextBox.TabIndex = 0;
        // 
        // OffEmployeeMainMenu
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1090, 594);
        this.Controls.Add(this.primaryTableLayoutPanel);
        this.Controls.Add(this.botttomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.Margin = new Padding(2);
        this.Name = "OffEmployeeMainMenu";
        this.Text = "Menu principal - employé de bureau";
        this.botttomBarPanel.ResumeLayout(false);
        this.primaryTableLayoutPanel.ResumeLayout(false);
        this.soManagementPanel.ResumeLayout(false);
        this.soManagementPanel.PerformLayout();
        this.createSOPanel.ResumeLayout(false);
        this.poActionButttonsPanel.ResumeLayout(false);
        this.containerPanel.ResumeLayout(false);
        this.soActionTableLayoutPanel.ResumeLayout(false);
        this.enititesTableLayoutPanel.ResumeLayout(false);
        this.supplierManagementTbLytPanel.ResumeLayout(false);
        this.supplierActionBtnPanel.ResumeLayout(false);
        this.tableLayoutPanel2.ResumeLayout(false);
        this.supplierSearchPanel.ResumeLayout(false);
        this.supplierSearchPanel.PerformLayout();
        this.productManagementTbLytPanel.ResumeLayout(false);
        this.productActionBtnPanel.ResumeLayout(false);
        this.tableLayoutPanel1.ResumeLayout(false);
        this.productSearchPanel.ResumeLayout(false);
        this.productSearchPanel.PerformLayout();
        this.clientManagementTbLytPanel.ResumeLayout(false);
        this.clientActionBtnPanel.ResumeLayout(false);
        this.clientActionBtnTbLytPanel.ResumeLayout(false);
        this.clientSearchPanel.ResumeLayout(false);
        this.clientSearchPanel.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Panel botttomBarPanel;
    private TableLayoutPanel primaryTableLayoutPanel;
    private Button logoutButton;
    private Panel soManagementPanel;
    private TableLayoutPanel enititesTableLayoutPanel;
    private Panel poActionButttonsPanel;
    private Button deleteSoButton;
    private Button updateSoButtton;
    private Button seeSoDetailsButton;
    private Panel containerPanel;
    private Panel createSOPanel;
    private Button createSoButton;
    private ListBox soListBox;
    private TextBox searchSOTextBox;
    private TableLayoutPanel supplierManagementTbLytPanel;
    private TableLayoutPanel productManagementTbLytPanel;
    private Panel productSearchPanel;
    private TableLayoutPanel clientManagementTbLytPanel;
    private Panel clientSearchPanel;
    private Panel supplierSearchPanel;
    private Panel productActionBtnPanel;
    private Panel clientActionBtnPanel;
    private TextBox clientSearchTextBox;
    private ListBox supplierListBox;
    private TextBox supplierSearchTextBox;
    private ListBox productListBox;
    private TextBox productSearchTextBox;
    private ListBox clientListBox;
    private Panel supplierActionBtnPanel;
    private TableLayoutPanel clientActionBtnTbLytPanel;
    private TableLayoutPanel tableLayoutPanel2;
    private Button deleteSupplierButton;
    private Button updateSupplierButton;
    private Button createSupplierButton;
    private Button seeSupplierDetailsButton;
    private TableLayoutPanel tableLayoutPanel1;
    private Button deleteProductButton;
    private Button updateProductButton;
    private Button createProductButton;
    private Button seeProductDetailsButton;
    private Button deleteClientButton;
    private Button updateClientButton;
    private Button createClientButton;
    private Button seeClientDetailsButton;
    private TableLayoutPanel soActionTableLayoutPanel;
}
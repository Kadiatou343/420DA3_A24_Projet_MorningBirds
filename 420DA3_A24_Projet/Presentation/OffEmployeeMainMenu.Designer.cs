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
        this.primaryTableLayoutPanel = new TableLayoutPanel();
        this.logoutButton = new Button();
        this.soManagementPanel = new Panel();
        this.enititesTableLayoutPanel = new TableLayoutPanel();
        this.poActionButttonsPanel = new Panel();
        this.seeSODetailsButton = new Button();
        this.updateSOButtton = new Button();
        this.deleteSOButton = new Button();
        this.containerPanel = new Panel();
        this.createSOPanel = new Panel();
        this.createSOButton = new Button();
        this.searchSOTextBox = new TextBox();
        this.soListBox = new ListBox();
        this.clientManagementTbLytPanel = new TableLayoutPanel();
        this.productManagementTbLytPanel = new TableLayoutPanel();
        this.supplierManagementTbLytPanel = new TableLayoutPanel();
        this.clientSearchPanel = new Panel();
        this.productSearchPanel = new Panel();
        this.supplierSearchPanel = new Panel();
        this.clientActionBtnPanel = new Panel();
        this.productActionBtnPanel = new Panel();
        this.supplierActionBtnPanel = new Panel();
        this.clientSearchTextBox = new TextBox();
        this.clientListBox = new ListBox();
        this.productSearchTextBox = new TextBox();
        this.supplierSearchTextBox = new TextBox();
        this.productListBox = new ListBox();
        this.supplierListBox = new ListBox();
        this.createClientButton = new Button();
        this.seeClientDetailsButton = new Button();
        this.updateClientButton = new Button();
        this.deleteClientButton = new Button();
        this.deleteProductButton = new Button();
        this.updateProductButton = new Button();
        this.seeProductDetailsButton = new Button();
        this.createProductButton = new Button();
        this.deleteSupplierButton = new Button();
        this.updateSupplierButton = new Button();
        this.seeSupplierDetailsButton = new Button();
        this.createSupplierButton = new Button();
        this.botttomBarPanel.SuspendLayout();
        this.primaryTableLayoutPanel.SuspendLayout();
        this.soManagementPanel.SuspendLayout();
        this.enititesTableLayoutPanel.SuspendLayout();
        this.poActionButttonsPanel.SuspendLayout();
        this.containerPanel.SuspendLayout();
        this.createSOPanel.SuspendLayout();
        this.clientManagementTbLytPanel.SuspendLayout();
        this.productManagementTbLytPanel.SuspendLayout();
        this.supplierManagementTbLytPanel.SuspendLayout();
        this.clientSearchPanel.SuspendLayout();
        this.productSearchPanel.SuspendLayout();
        this.supplierSearchPanel.SuspendLayout();
        this.clientActionBtnPanel.SuspendLayout();
        this.productActionBtnPanel.SuspendLayout();
        this.supplierActionBtnPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(1363, 50);
        this.topBarPanel.TabIndex = 0;
        // 
        // botttomBarPanel
        // 
        this.botttomBarPanel.Controls.Add(this.logoutButton);
        this.botttomBarPanel.Dock = DockStyle.Bottom;
        this.botttomBarPanel.Location = new Point(0, 692);
        this.botttomBarPanel.Name = "botttomBarPanel";
        this.botttomBarPanel.Size = new Size(1363, 50);
        this.botttomBarPanel.TabIndex = 1;
        // 
        // primaryTableLayoutPanel
        // 
        this.primaryTableLayoutPanel.ColumnCount = 2;
        this.primaryTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.primaryTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.primaryTableLayoutPanel.Controls.Add(this.soManagementPanel, 0, 0);
        this.primaryTableLayoutPanel.Controls.Add(this.enititesTableLayoutPanel, 1, 0);
        this.primaryTableLayoutPanel.Dock = DockStyle.Fill;
        this.primaryTableLayoutPanel.Location = new Point(0, 50);
        this.primaryTableLayoutPanel.Name = "primaryTableLayoutPanel";
        this.primaryTableLayoutPanel.RowCount = 1;
        this.primaryTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.primaryTableLayoutPanel.Size = new Size(1363, 642);
        this.primaryTableLayoutPanel.TabIndex = 2;
        // 
        // logoutButton
        // 
        this.logoutButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.logoutButton.Location = new Point(1191, 6);
        this.logoutButton.Name = "logoutButton";
        this.logoutButton.Size = new Size(150, 34);
        this.logoutButton.TabIndex = 0;
        this.logoutButton.Text = "Deconnexion";
        this.logoutButton.UseVisualStyleBackColor = true;
        // 
        // soManagementPanel
        // 
        this.soManagementPanel.Controls.Add(this.soListBox);
        this.soManagementPanel.Controls.Add(this.searchSOTextBox);
        this.soManagementPanel.Controls.Add(this.createSOPanel);
        this.soManagementPanel.Controls.Add(this.poActionButttonsPanel);
        this.soManagementPanel.Dock = DockStyle.Fill;
        this.soManagementPanel.Location = new Point(3, 3);
        this.soManagementPanel.Name = "soManagementPanel";
        this.soManagementPanel.Size = new Size(675, 636);
        this.soManagementPanel.TabIndex = 0;
        // 
        // enititesTableLayoutPanel
        // 
        this.enititesTableLayoutPanel.ColumnCount = 1;
        this.enititesTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        this.enititesTableLayoutPanel.Controls.Add(this.supplierManagementTbLytPanel, 0, 2);
        this.enititesTableLayoutPanel.Controls.Add(this.productManagementTbLytPanel, 0, 1);
        this.enititesTableLayoutPanel.Controls.Add(this.clientManagementTbLytPanel, 0, 0);
        this.enititesTableLayoutPanel.Dock = DockStyle.Fill;
        this.enititesTableLayoutPanel.Location = new Point(684, 3);
        this.enititesTableLayoutPanel.Name = "enititesTableLayoutPanel";
        this.enititesTableLayoutPanel.RowCount = 3;
        this.enititesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        this.enititesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        this.enititesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        this.enititesTableLayoutPanel.Size = new Size(676, 636);
        this.enititesTableLayoutPanel.TabIndex = 1;
        // 
        // poActionButttonsPanel
        // 
        this.poActionButttonsPanel.BackgroundImageLayout = ImageLayout.Zoom;
        this.poActionButttonsPanel.Controls.Add(this.containerPanel);
        this.poActionButttonsPanel.Dock = DockStyle.Bottom;
        this.poActionButttonsPanel.Location = new Point(0, 486);
        this.poActionButttonsPanel.Name = "poActionButttonsPanel";
        this.poActionButttonsPanel.Size = new Size(675, 150);
        this.poActionButttonsPanel.TabIndex = 0;
        // 
        // seeSODetailsButton
        // 
        this.seeSODetailsButton.Dock = DockStyle.Top;
        this.seeSODetailsButton.Location = new Point(0, 0);
        this.seeSODetailsButton.Name = "seeSODetailsButton";
        this.seeSODetailsButton.Size = new Size(224, 40);
        this.seeSODetailsButton.TabIndex = 0;
        this.seeSODetailsButton.Text = "Voir détails";
        this.seeSODetailsButton.UseVisualStyleBackColor = true;
        // 
        // updateSOButtton
        // 
        this.updateSOButtton.Location = new Point(0, 46);
        this.updateSOButtton.Name = "updateSOButtton";
        this.updateSOButtton.Size = new Size(224, 50);
        this.updateSOButtton.TabIndex = 1;
        this.updateSOButtton.Text = "Modifier";
        this.updateSOButtton.UseVisualStyleBackColor = true;
        // 
        // deleteSOButton
        // 
        this.deleteSOButton.Dock = DockStyle.Bottom;
        this.deleteSOButton.Location = new Point(0, 105);
        this.deleteSOButton.Name = "deleteSOButton";
        this.deleteSOButton.Size = new Size(224, 40);
        this.deleteSOButton.TabIndex = 2;
        this.deleteSOButton.Text = "Supprimer";
        this.deleteSOButton.UseVisualStyleBackColor = true;
        // 
        // containerPanel
        // 
        this.containerPanel.Controls.Add(this.deleteSOButton);
        this.containerPanel.Controls.Add(this.seeSODetailsButton);
        this.containerPanel.Controls.Add(this.updateSOButtton);
        this.containerPanel.Location = new Point(217, 2);
        this.containerPanel.Name = "containerPanel";
        this.containerPanel.Size = new Size(224, 145);
        this.containerPanel.TabIndex = 0;
        // 
        // createSOPanel
        // 
        this.createSOPanel.Controls.Add(this.createSOButton);
        this.createSOPanel.Dock = DockStyle.Top;
        this.createSOPanel.Location = new Point(0, 0);
        this.createSOPanel.Name = "createSOPanel";
        this.createSOPanel.Size = new Size(675, 50);
        this.createSOPanel.TabIndex = 1;
        // 
        // createSOButton
        // 
        this.createSOButton.Location = new Point(225, 5);
        this.createSOButton.Name = "createSOButton";
        this.createSOButton.Size = new Size(243, 40);
        this.createSOButton.TabIndex = 2;
        this.createSOButton.Text = "Créer un ordre d'expédition";
        this.createSOButton.UseVisualStyleBackColor = true;
        // 
        // searchSOTextBox
        // 
        this.searchSOTextBox.Dock = DockStyle.Top;
        this.searchSOTextBox.Location = new Point(0, 50);
        this.searchSOTextBox.Name = "searchSOTextBox";
        this.searchSOTextBox.PlaceholderText = "Rechercher un ordre d'expédition";
        this.searchSOTextBox.Size = new Size(675, 31);
        this.searchSOTextBox.TabIndex = 2;
        // 
        // soListBox
        // 
        this.soListBox.Dock = DockStyle.Fill;
        this.soListBox.FormattingEnabled = true;
        this.soListBox.ItemHeight = 25;
        this.soListBox.Location = new Point(0, 81);
        this.soListBox.Name = "soListBox";
        this.soListBox.Size = new Size(675, 405);
        this.soListBox.TabIndex = 3;
        // 
        // clientManagementTbLytPanel
        // 
        this.clientManagementTbLytPanel.ColumnCount = 2;
        this.clientManagementTbLytPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.clientManagementTbLytPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.clientManagementTbLytPanel.Controls.Add(this.clientActionBtnPanel, 1, 0);
        this.clientManagementTbLytPanel.Controls.Add(this.clientSearchPanel, 0, 0);
        this.clientManagementTbLytPanel.Dock = DockStyle.Fill;
        this.clientManagementTbLytPanel.Location = new Point(3, 3);
        this.clientManagementTbLytPanel.Name = "clientManagementTbLytPanel";
        this.clientManagementTbLytPanel.RowCount = 1;
        this.clientManagementTbLytPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.clientManagementTbLytPanel.Size = new Size(670, 206);
        this.clientManagementTbLytPanel.TabIndex = 0;
        // 
        // productManagementTbLytPanel
        // 
        this.productManagementTbLytPanel.ColumnCount = 2;
        this.productManagementTbLytPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.productManagementTbLytPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.productManagementTbLytPanel.Controls.Add(this.productActionBtnPanel, 1, 0);
        this.productManagementTbLytPanel.Controls.Add(this.productSearchPanel, 0, 0);
        this.productManagementTbLytPanel.Dock = DockStyle.Fill;
        this.productManagementTbLytPanel.Location = new Point(3, 215);
        this.productManagementTbLytPanel.Name = "productManagementTbLytPanel";
        this.productManagementTbLytPanel.RowCount = 1;
        this.productManagementTbLytPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.productManagementTbLytPanel.Size = new Size(670, 206);
        this.productManagementTbLytPanel.TabIndex = 1;
        // 
        // supplierManagementTbLytPanel
        // 
        this.supplierManagementTbLytPanel.ColumnCount = 2;
        this.supplierManagementTbLytPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.supplierManagementTbLytPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.supplierManagementTbLytPanel.Controls.Add(this.supplierActionBtnPanel, 1, 0);
        this.supplierManagementTbLytPanel.Controls.Add(this.supplierSearchPanel, 0, 0);
        this.supplierManagementTbLytPanel.Dock = DockStyle.Fill;
        this.supplierManagementTbLytPanel.Location = new Point(3, 427);
        this.supplierManagementTbLytPanel.Name = "supplierManagementTbLytPanel";
        this.supplierManagementTbLytPanel.RowCount = 1;
        this.supplierManagementTbLytPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.supplierManagementTbLytPanel.Size = new Size(670, 206);
        this.supplierManagementTbLytPanel.TabIndex = 2;
        // 
        // clientSearchPanel
        // 
        this.clientSearchPanel.Controls.Add(this.clientListBox);
        this.clientSearchPanel.Controls.Add(this.clientSearchTextBox);
        this.clientSearchPanel.Dock = DockStyle.Fill;
        this.clientSearchPanel.Location = new Point(3, 3);
        this.clientSearchPanel.Name = "clientSearchPanel";
        this.clientSearchPanel.Size = new Size(329, 200);
        this.clientSearchPanel.TabIndex = 0;
        // 
        // productSearchPanel
        // 
        this.productSearchPanel.Controls.Add(this.productListBox);
        this.productSearchPanel.Controls.Add(this.productSearchTextBox);
        this.productSearchPanel.Dock = DockStyle.Fill;
        this.productSearchPanel.Location = new Point(3, 3);
        this.productSearchPanel.Name = "productSearchPanel";
        this.productSearchPanel.Size = new Size(329, 200);
        this.productSearchPanel.TabIndex = 1;
        // 
        // supplierSearchPanel
        // 
        this.supplierSearchPanel.Controls.Add(this.supplierListBox);
        this.supplierSearchPanel.Controls.Add(this.supplierSearchTextBox);
        this.supplierSearchPanel.Dock = DockStyle.Fill;
        this.supplierSearchPanel.Location = new Point(3, 3);
        this.supplierSearchPanel.Name = "supplierSearchPanel";
        this.supplierSearchPanel.Size = new Size(329, 200);
        this.supplierSearchPanel.TabIndex = 1;
        // 
        // clientActionBtnPanel
        // 
        this.clientActionBtnPanel.Controls.Add(this.deleteClientButton);
        this.clientActionBtnPanel.Controls.Add(this.updateClientButton);
        this.clientActionBtnPanel.Controls.Add(this.seeClientDetailsButton);
        this.clientActionBtnPanel.Controls.Add(this.createClientButton);
        this.clientActionBtnPanel.Dock = DockStyle.Fill;
        this.clientActionBtnPanel.Location = new Point(338, 3);
        this.clientActionBtnPanel.Name = "clientActionBtnPanel";
        this.clientActionBtnPanel.Size = new Size(329, 200);
        this.clientActionBtnPanel.TabIndex = 1;
        // 
        // productActionBtnPanel
        // 
        this.productActionBtnPanel.Controls.Add(this.deleteProductButton);
        this.productActionBtnPanel.Controls.Add(this.updateProductButton);
        this.productActionBtnPanel.Controls.Add(this.seeProductDetailsButton);
        this.productActionBtnPanel.Controls.Add(this.createProductButton);
        this.productActionBtnPanel.Dock = DockStyle.Fill;
        this.productActionBtnPanel.Location = new Point(338, 3);
        this.productActionBtnPanel.Name = "productActionBtnPanel";
        this.productActionBtnPanel.Size = new Size(329, 200);
        this.productActionBtnPanel.TabIndex = 2;
        // 
        // supplierActionBtnPanel
        // 
        this.supplierActionBtnPanel.Controls.Add(this.deleteSupplierButton);
        this.supplierActionBtnPanel.Controls.Add(this.updateSupplierButton);
        this.supplierActionBtnPanel.Controls.Add(this.seeSupplierDetailsButton);
        this.supplierActionBtnPanel.Controls.Add(this.createSupplierButton);
        this.supplierActionBtnPanel.Dock = DockStyle.Fill;
        this.supplierActionBtnPanel.Location = new Point(338, 3);
        this.supplierActionBtnPanel.Name = "supplierActionBtnPanel";
        this.supplierActionBtnPanel.Size = new Size(329, 200);
        this.supplierActionBtnPanel.TabIndex = 2;
        // 
        // clientSearchTextBox
        // 
        this.clientSearchTextBox.Dock = DockStyle.Top;
        this.clientSearchTextBox.Location = new Point(0, 0);
        this.clientSearchTextBox.Name = "clientSearchTextBox";
        this.clientSearchTextBox.PlaceholderText = "Rechercher un client";
        this.clientSearchTextBox.Size = new Size(329, 31);
        this.clientSearchTextBox.TabIndex = 0;
        // 
        // clientListBox
        // 
        this.clientListBox.Dock = DockStyle.Fill;
        this.clientListBox.FormattingEnabled = true;
        this.clientListBox.ItemHeight = 25;
        this.clientListBox.Location = new Point(0, 31);
        this.clientListBox.Name = "clientListBox";
        this.clientListBox.Size = new Size(329, 169);
        this.clientListBox.TabIndex = 1;
        // 
        // productSearchTextBox
        // 
        this.productSearchTextBox.Dock = DockStyle.Top;
        this.productSearchTextBox.Location = new Point(0, 0);
        this.productSearchTextBox.Name = "productSearchTextBox";
        this.productSearchTextBox.PlaceholderText = "Rechercher un produit";
        this.productSearchTextBox.Size = new Size(329, 31);
        this.productSearchTextBox.TabIndex = 1;
        // 
        // supplierSearchTextBox
        // 
        this.supplierSearchTextBox.Dock = DockStyle.Top;
        this.supplierSearchTextBox.Location = new Point(0, 0);
        this.supplierSearchTextBox.Name = "supplierSearchTextBox";
        this.supplierSearchTextBox.PlaceholderText = "Rechercher un fournisseur";
        this.supplierSearchTextBox.Size = new Size(329, 31);
        this.supplierSearchTextBox.TabIndex = 1;
        // 
        // productListBox
        // 
        this.productListBox.Dock = DockStyle.Fill;
        this.productListBox.FormattingEnabled = true;
        this.productListBox.ItemHeight = 25;
        this.productListBox.Location = new Point(0, 31);
        this.productListBox.Name = "productListBox";
        this.productListBox.Size = new Size(329, 169);
        this.productListBox.TabIndex = 2;
        // 
        // supplierListBox
        // 
        this.supplierListBox.Dock = DockStyle.Fill;
        this.supplierListBox.FormattingEnabled = true;
        this.supplierListBox.ItemHeight = 25;
        this.supplierListBox.Location = new Point(0, 31);
        this.supplierListBox.Name = "supplierListBox";
        this.supplierListBox.Size = new Size(329, 169);
        this.supplierListBox.TabIndex = 2;
        // 
        // createClientButton
        // 
        this.createClientButton.Dock = DockStyle.Top;
        this.createClientButton.Location = new Point(0, 0);
        this.createClientButton.Name = "createClientButton";
        this.createClientButton.Size = new Size(329, 34);
        this.createClientButton.TabIndex = 0;
        this.createClientButton.Text = "Créer un client";
        this.createClientButton.UseVisualStyleBackColor = true;
        // 
        // seeClientDetailsButton
        // 
        this.seeClientDetailsButton.Dock = DockStyle.Top;
        this.seeClientDetailsButton.Location = new Point(0, 34);
        this.seeClientDetailsButton.Name = "seeClientDetailsButton";
        this.seeClientDetailsButton.Size = new Size(329, 34);
        this.seeClientDetailsButton.TabIndex = 1;
        this.seeClientDetailsButton.Text = "Voir détails";
        this.seeClientDetailsButton.UseVisualStyleBackColor = true;
        // 
        // updateClientButton
        // 
        this.updateClientButton.Location = new Point(0, 126);
        this.updateClientButton.Name = "updateClientButton";
        this.updateClientButton.Size = new Size(329, 34);
        this.updateClientButton.TabIndex = 2;
        this.updateClientButton.Text = "Modifier";
        this.updateClientButton.UseVisualStyleBackColor = true;
        // 
        // deleteClientButton
        // 
        this.deleteClientButton.Dock = DockStyle.Bottom;
        this.deleteClientButton.Location = new Point(0, 166);
        this.deleteClientButton.Name = "deleteClientButton";
        this.deleteClientButton.Size = new Size(329, 34);
        this.deleteClientButton.TabIndex = 3;
        this.deleteClientButton.Text = "Supprimer";
        this.deleteClientButton.UseVisualStyleBackColor = true;
        // 
        // deleteProductButton
        // 
        this.deleteProductButton.Dock = DockStyle.Bottom;
        this.deleteProductButton.Location = new Point(0, 166);
        this.deleteProductButton.Name = "deleteProductButton";
        this.deleteProductButton.Size = new Size(329, 34);
        this.deleteProductButton.TabIndex = 7;
        this.deleteProductButton.Text = "Supprimer";
        this.deleteProductButton.UseVisualStyleBackColor = true;
        // 
        // updateProductButton
        // 
        this.updateProductButton.Location = new Point(0, 126);
        this.updateProductButton.Name = "updateProductButton";
        this.updateProductButton.Size = new Size(329, 34);
        this.updateProductButton.TabIndex = 6;
        this.updateProductButton.Text = "Modifier";
        this.updateProductButton.UseVisualStyleBackColor = true;
        // 
        // seeProductDetailsButton
        // 
        this.seeProductDetailsButton.Dock = DockStyle.Top;
        this.seeProductDetailsButton.Location = new Point(0, 34);
        this.seeProductDetailsButton.Name = "seeProductDetailsButton";
        this.seeProductDetailsButton.Size = new Size(329, 34);
        this.seeProductDetailsButton.TabIndex = 5;
        this.seeProductDetailsButton.Text = "Voir détails";
        this.seeProductDetailsButton.UseVisualStyleBackColor = true;
        // 
        // createProductButton
        // 
        this.createProductButton.Dock = DockStyle.Top;
        this.createProductButton.Location = new Point(0, 0);
        this.createProductButton.Name = "createProductButton";
        this.createProductButton.Size = new Size(329, 34);
        this.createProductButton.TabIndex = 4;
        this.createProductButton.Text = "Créer un produit";
        this.createProductButton.UseVisualStyleBackColor = true;
        // 
        // deleteSupplierButton
        // 
        this.deleteSupplierButton.Location = new Point(172, 136);
        this.deleteSupplierButton.Name = "deleteSupplierButton";
        this.deleteSupplierButton.Size = new Size(112, 34);
        this.deleteSupplierButton.TabIndex = 7;
        this.deleteSupplierButton.Text = "Supprimer";
        this.deleteSupplierButton.UseVisualStyleBackColor = true;
        // 
        // updateSupplierButton
        // 
        this.updateSupplierButton.Location = new Point(44, 122);
        this.updateSupplierButton.Name = "updateSupplierButton";
        this.updateSupplierButton.Size = new Size(112, 34);
        this.updateSupplierButton.TabIndex = 6;
        this.updateSupplierButton.Text = "Modifier";
        this.updateSupplierButton.UseVisualStyleBackColor = true;
        // 
        // seeSupplierDetailsButton
        // 
        this.seeSupplierDetailsButton.Location = new Point(126, 82);
        this.seeSupplierDetailsButton.Name = "seeSupplierDetailsButton";
        this.seeSupplierDetailsButton.Size = new Size(112, 34);
        this.seeSupplierDetailsButton.TabIndex = 5;
        this.seeSupplierDetailsButton.Text = "Voir détails";
        this.seeSupplierDetailsButton.UseVisualStyleBackColor = true;
        // 
        // createSupplierButton
        // 
        this.createSupplierButton.Location = new Point(122, 31);
        this.createSupplierButton.Name = "createSupplierButton";
        this.createSupplierButton.Size = new Size(112, 34);
        this.createSupplierButton.TabIndex = 4;
        this.createSupplierButton.Text = "Créer un fournisseur";
        this.createSupplierButton.UseVisualStyleBackColor = true;
        // 
        // OffEmployeeMainMenu
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1363, 742);
        this.Controls.Add(this.primaryTableLayoutPanel);
        this.Controls.Add(this.botttomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.Name = "OffEmployeeMainMenu";
        this.Text = "Menu principal - employé de bureau";
        this.botttomBarPanel.ResumeLayout(false);
        this.primaryTableLayoutPanel.ResumeLayout(false);
        this.soManagementPanel.ResumeLayout(false);
        this.soManagementPanel.PerformLayout();
        this.enititesTableLayoutPanel.ResumeLayout(false);
        this.poActionButttonsPanel.ResumeLayout(false);
        this.containerPanel.ResumeLayout(false);
        this.createSOPanel.ResumeLayout(false);
        this.clientManagementTbLytPanel.ResumeLayout(false);
        this.productManagementTbLytPanel.ResumeLayout(false);
        this.supplierManagementTbLytPanel.ResumeLayout(false);
        this.clientSearchPanel.ResumeLayout(false);
        this.clientSearchPanel.PerformLayout();
        this.productSearchPanel.ResumeLayout(false);
        this.productSearchPanel.PerformLayout();
        this.supplierSearchPanel.ResumeLayout(false);
        this.supplierSearchPanel.PerformLayout();
        this.clientActionBtnPanel.ResumeLayout(false);
        this.productActionBtnPanel.ResumeLayout(false);
        this.supplierActionBtnPanel.ResumeLayout(false);
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
    private Button deleteSOButton;
    private Button updateSOButtton;
    private Button seeSODetailsButton;
    private Panel containerPanel;
    private Panel createSOPanel;
    private Button createSOButton;
    private ListBox soListBox;
    private TextBox searchSOTextBox;
    private TableLayoutPanel supplierManagementTbLytPanel;
    private TableLayoutPanel productManagementTbLytPanel;
    private Panel productSearchPanel;
    private TableLayoutPanel clientManagementTbLytPanel;
    private Panel clientSearchPanel;
    private Panel supplierActionBtnPanel;
    private Panel supplierSearchPanel;
    private Panel productActionBtnPanel;
    private Panel clientActionBtnPanel;
    private TextBox clientSearchTextBox;
    private ListBox supplierListBox;
    private TextBox supplierSearchTextBox;
    private ListBox productListBox;
    private TextBox productSearchTextBox;
    private Button deleteClientButton;
    private Button updateClientButton;
    private Button seeClientDetailsButton;
    private Button createClientButton;
    private ListBox clientListBox;
    private Button deleteSupplierButton;
    private Button updateSupplierButton;
    private Button seeSupplierDetailsButton;
    private Button createSupplierButton;
    private Button deleteProductButton;
    private Button updateProductButton;
    private Button seeProductDetailsButton;
    private Button createProductButton;
}
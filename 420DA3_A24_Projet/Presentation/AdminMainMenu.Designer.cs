namespace _420DA3_A24_Projet.Presentation;

partial class AdminMainMenu {
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
        this.panel1 = new Panel();
        this.panel2 = new Panel();
        this.logoutButtton = new Button();
        this.primaryTableLayout = new TableLayoutPanel();
        this.purchaseOrderManagementPanel = new Panel();
        this.purchaseOrderPanelHeader = new Label();
        this.shippingOrderManagementPanel = new Panel();
        this.shippingOrderPanelHeader = new Label();
        this.warehouseManagementPanel = new Panel();
        this.warehousePanelHeader = new Label();
        this.shipmentManagementPanel = new Panel();
        this.shipmentPanelHeader = new Label();
        this.clientManagementPanel = new Panel();
        this.clientPanelHeader = new Label();
        this.addressManagementPanel = new Panel();
        this.addressPanelHeader = new Label();
        this.supplierManagementPanel = new Panel();
        this.supplierPanelHeader = new Label();
        this.productManagementPanel = new Panel();
        this.productPanelHeader = new Label();
        this.roleManagementPanel = new Panel();
        this.mainPanel = new Panel();
        this.searchPanel = new Panel();
        this.roleListBox = new ListBox();
        this.roleSearchTextBox = new TextBox();
        this.tableLayoutPanel1 = new TableLayoutPanel();
        this.panel3 = new Panel();
        this.seeRoleDetailsButton = new Button();
        this.updateRoleButton = new Button();
        this.deleteRoleButton = new Button();
        this.roleCreateTableLayoutPanel = new TableLayoutPanel();
        this.createRoleButton = new Button();
        this.rolePanelHeader = new Label();
        this.userManagementPanel = new Panel();
        this.userListBox = new ListBox();
        this.userSearchTextBox = new TextBox();
        this.userActionTableLayout = new TableLayoutPanel();
        this.userActionPanel = new Panel();
        this.seeUserDetailsButton = new Button();
        this.updateUserButton = new Button();
        this.deleteUserButton = new Button();
        this.userCreateTableLayout = new TableLayoutPanel();
        this.createUserButton = new Button();
        this.userPanelHeader = new Label();
        this.panel2.SuspendLayout();
        this.primaryTableLayout.SuspendLayout();
        this.purchaseOrderManagementPanel.SuspendLayout();
        this.shippingOrderManagementPanel.SuspendLayout();
        this.warehouseManagementPanel.SuspendLayout();
        this.shipmentManagementPanel.SuspendLayout();
        this.clientManagementPanel.SuspendLayout();
        this.addressManagementPanel.SuspendLayout();
        this.supplierManagementPanel.SuspendLayout();
        this.productManagementPanel.SuspendLayout();
        this.roleManagementPanel.SuspendLayout();
        this.mainPanel.SuspendLayout();
        this.searchPanel.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        this.panel3.SuspendLayout();
        this.roleCreateTableLayoutPanel.SuspendLayout();
        this.userManagementPanel.SuspendLayout();
        this.userActionTableLayout.SuspendLayout();
        this.userActionPanel.SuspendLayout();
        this.userCreateTableLayout.SuspendLayout();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.Dock = DockStyle.Top;
        this.panel1.Location = new Point(0, 0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(1356, 50);
        this.panel1.TabIndex = 0;
        // 
        // panel2
        // 
        this.panel2.Controls.Add(this.logoutButtton);
        this.panel2.Dock = DockStyle.Bottom;
        this.panel2.Location = new Point(0, 795);
        this.panel2.Name = "panel2";
        this.panel2.Size = new Size(1356, 50);
        this.panel2.TabIndex = 1;
        // 
        // logoutButtton
        // 
        this.logoutButtton.Location = new Point(1001, 6);
        this.logoutButtton.Name = "logoutButtton";
        this.logoutButtton.Size = new Size(133, 34);
        this.logoutButtton.TabIndex = 0;
        this.logoutButtton.Text = "Deconnexion";
        this.logoutButtton.UseVisualStyleBackColor = true;
        this.logoutButtton.Click += this.LogoutButtton_Click;
        // 
        // primaryTableLayout
        // 
        this.primaryTableLayout.ColumnCount = 5;
        this.primaryTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.primaryTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.primaryTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.primaryTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.primaryTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.primaryTableLayout.Controls.Add(this.purchaseOrderManagementPanel, 4, 1);
        this.primaryTableLayout.Controls.Add(this.shippingOrderManagementPanel, 3, 1);
        this.primaryTableLayout.Controls.Add(this.warehouseManagementPanel, 2, 1);
        this.primaryTableLayout.Controls.Add(this.shipmentManagementPanel, 1, 1);
        this.primaryTableLayout.Controls.Add(this.clientManagementPanel, 0, 1);
        this.primaryTableLayout.Controls.Add(this.addressManagementPanel, 4, 0);
        this.primaryTableLayout.Controls.Add(this.supplierManagementPanel, 3, 0);
        this.primaryTableLayout.Controls.Add(this.productManagementPanel, 2, 0);
        this.primaryTableLayout.Controls.Add(this.roleManagementPanel, 1, 0);
        this.primaryTableLayout.Controls.Add(this.userManagementPanel, 0, 0);
        this.primaryTableLayout.Dock = DockStyle.Fill;
        this.primaryTableLayout.Location = new Point(0, 50);
        this.primaryTableLayout.Name = "primaryTableLayout";
        this.primaryTableLayout.RowCount = 2;
        this.primaryTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.primaryTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.primaryTableLayout.Size = new Size(1356, 745);
        this.primaryTableLayout.TabIndex = 2;
        // 
        // purchaseOrderManagementPanel
        // 
        this.purchaseOrderManagementPanel.Controls.Add(this.purchaseOrderPanelHeader);
        this.purchaseOrderManagementPanel.Dock = DockStyle.Fill;
        this.purchaseOrderManagementPanel.Location = new Point(1087, 375);
        this.purchaseOrderManagementPanel.Name = "purchaseOrderManagementPanel";
        this.purchaseOrderManagementPanel.Size = new Size(266, 367);
        this.purchaseOrderManagementPanel.TabIndex = 9;
        // 
        // purchaseOrderPanelHeader
        // 
        this.purchaseOrderPanelHeader.Dock = DockStyle.Top;
        this.purchaseOrderPanelHeader.Location = new Point(0, 0);
        this.purchaseOrderPanelHeader.Name = "purchaseOrderPanelHeader";
        this.purchaseOrderPanelHeader.Size = new Size(266, 38);
        this.purchaseOrderPanelHeader.TabIndex = 0;
        this.purchaseOrderPanelHeader.Text = "Ordres de restockage";
        this.purchaseOrderPanelHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // shippingOrderManagementPanel
        // 
        this.shippingOrderManagementPanel.Controls.Add(this.shippingOrderPanelHeader);
        this.shippingOrderManagementPanel.Dock = DockStyle.Fill;
        this.shippingOrderManagementPanel.Location = new Point(816, 375);
        this.shippingOrderManagementPanel.Name = "shippingOrderManagementPanel";
        this.shippingOrderManagementPanel.Size = new Size(265, 367);
        this.shippingOrderManagementPanel.TabIndex = 8;
        // 
        // shippingOrderPanelHeader
        // 
        this.shippingOrderPanelHeader.Dock = DockStyle.Top;
        this.shippingOrderPanelHeader.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        this.shippingOrderPanelHeader.Location = new Point(0, 0);
        this.shippingOrderPanelHeader.Name = "shippingOrderPanelHeader";
        this.shippingOrderPanelHeader.Size = new Size(265, 38);
        this.shippingOrderPanelHeader.TabIndex = 0;
        this.shippingOrderPanelHeader.Text = "Ordres d'expéditions";
        this.shippingOrderPanelHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // warehouseManagementPanel
        // 
        this.warehouseManagementPanel.Controls.Add(this.warehousePanelHeader);
        this.warehouseManagementPanel.Dock = DockStyle.Fill;
        this.warehouseManagementPanel.Location = new Point(545, 375);
        this.warehouseManagementPanel.Name = "warehouseManagementPanel";
        this.warehouseManagementPanel.Size = new Size(265, 367);
        this.warehouseManagementPanel.TabIndex = 7;
        // 
        // warehousePanelHeader
        // 
        this.warehousePanelHeader.Dock = DockStyle.Top;
        this.warehousePanelHeader.Location = new Point(0, 0);
        this.warehousePanelHeader.Name = "warehousePanelHeader";
        this.warehousePanelHeader.Size = new Size(265, 38);
        this.warehousePanelHeader.TabIndex = 0;
        this.warehousePanelHeader.Text = "Gestion des entrepôts";
        this.warehousePanelHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // shipmentManagementPanel
        // 
        this.shipmentManagementPanel.Controls.Add(this.shipmentPanelHeader);
        this.shipmentManagementPanel.Dock = DockStyle.Fill;
        this.shipmentManagementPanel.Location = new Point(274, 375);
        this.shipmentManagementPanel.Name = "shipmentManagementPanel";
        this.shipmentManagementPanel.Size = new Size(265, 367);
        this.shipmentManagementPanel.TabIndex = 6;
        // 
        // shipmentPanelHeader
        // 
        this.shipmentPanelHeader.Dock = DockStyle.Top;
        this.shipmentPanelHeader.Location = new Point(0, 0);
        this.shipmentPanelHeader.Name = "shipmentPanelHeader";
        this.shipmentPanelHeader.Size = new Size(265, 38);
        this.shipmentPanelHeader.TabIndex = 0;
        this.shipmentPanelHeader.Text = "Gestion des expéditions";
        this.shipmentPanelHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // clientManagementPanel
        // 
        this.clientManagementPanel.Controls.Add(this.clientPanelHeader);
        this.clientManagementPanel.Dock = DockStyle.Fill;
        this.clientManagementPanel.Location = new Point(3, 375);
        this.clientManagementPanel.Name = "clientManagementPanel";
        this.clientManagementPanel.Size = new Size(265, 367);
        this.clientManagementPanel.TabIndex = 5;
        // 
        // clientPanelHeader
        // 
        this.clientPanelHeader.Dock = DockStyle.Top;
        this.clientPanelHeader.Location = new Point(0, 0);
        this.clientPanelHeader.Name = "clientPanelHeader";
        this.clientPanelHeader.Size = new Size(265, 38);
        this.clientPanelHeader.TabIndex = 0;
        this.clientPanelHeader.Text = "Gestion des clients";
        this.clientPanelHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // addressManagementPanel
        // 
        this.addressManagementPanel.Controls.Add(this.addressPanelHeader);
        this.addressManagementPanel.Dock = DockStyle.Fill;
        this.addressManagementPanel.Location = new Point(1087, 3);
        this.addressManagementPanel.Name = "addressManagementPanel";
        this.addressManagementPanel.Size = new Size(266, 366);
        this.addressManagementPanel.TabIndex = 4;
        // 
        // addressPanelHeader
        // 
        this.addressPanelHeader.Dock = DockStyle.Top;
        this.addressPanelHeader.Location = new Point(0, 0);
        this.addressPanelHeader.Name = "addressPanelHeader";
        this.addressPanelHeader.Size = new Size(266, 38);
        this.addressPanelHeader.TabIndex = 0;
        this.addressPanelHeader.Text = "Gestion des adresses";
        this.addressPanelHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // supplierManagementPanel
        // 
        this.supplierManagementPanel.Controls.Add(this.supplierPanelHeader);
        this.supplierManagementPanel.Dock = DockStyle.Fill;
        this.supplierManagementPanel.Location = new Point(816, 3);
        this.supplierManagementPanel.Name = "supplierManagementPanel";
        this.supplierManagementPanel.Size = new Size(265, 366);
        this.supplierManagementPanel.TabIndex = 3;
        // 
        // supplierPanelHeader
        // 
        this.supplierPanelHeader.Dock = DockStyle.Top;
        this.supplierPanelHeader.Location = new Point(0, 0);
        this.supplierPanelHeader.Name = "supplierPanelHeader";
        this.supplierPanelHeader.Size = new Size(265, 38);
        this.supplierPanelHeader.TabIndex = 0;
        this.supplierPanelHeader.Text = "Gestion des fournisseurs";
        this.supplierPanelHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // productManagementPanel
        // 
        this.productManagementPanel.Controls.Add(this.productPanelHeader);
        this.productManagementPanel.Dock = DockStyle.Fill;
        this.productManagementPanel.Location = new Point(545, 3);
        this.productManagementPanel.Name = "productManagementPanel";
        this.productManagementPanel.Size = new Size(265, 366);
        this.productManagementPanel.TabIndex = 2;
        // 
        // productPanelHeader
        // 
        this.productPanelHeader.Dock = DockStyle.Top;
        this.productPanelHeader.Location = new Point(0, 0);
        this.productPanelHeader.Name = "productPanelHeader";
        this.productPanelHeader.Size = new Size(265, 38);
        this.productPanelHeader.TabIndex = 0;
        this.productPanelHeader.Text = "Gestion des produits";
        this.productPanelHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // roleManagementPanel
        // 
        this.roleManagementPanel.Controls.Add(this.mainPanel);
        this.roleManagementPanel.Controls.Add(this.rolePanelHeader);
        this.roleManagementPanel.Dock = DockStyle.Fill;
        this.roleManagementPanel.Location = new Point(274, 3);
        this.roleManagementPanel.Name = "roleManagementPanel";
        this.roleManagementPanel.Size = new Size(265, 366);
        this.roleManagementPanel.TabIndex = 1;
        // 
        // mainPanel
        // 
        this.mainPanel.Controls.Add(this.searchPanel);
        this.mainPanel.Controls.Add(this.tableLayoutPanel1);
        this.mainPanel.Controls.Add(this.roleCreateTableLayoutPanel);
        this.mainPanel.Dock = DockStyle.Fill;
        this.mainPanel.Location = new Point(0, 38);
        this.mainPanel.Name = "mainPanel";
        this.mainPanel.Size = new Size(265, 328);
        this.mainPanel.TabIndex = 1;
        // 
        // searchPanel
        // 
        this.searchPanel.Controls.Add(this.roleListBox);
        this.searchPanel.Controls.Add(this.roleSearchTextBox);
        this.searchPanel.Dock = DockStyle.Fill;
        this.searchPanel.Location = new Point(0, 40);
        this.searchPanel.Name = "searchPanel";
        this.searchPanel.Size = new Size(265, 178);
        this.searchPanel.TabIndex = 4;
        // 
        // roleListBox
        // 
        this.roleListBox.Dock = DockStyle.Fill;
        this.roleListBox.FormattingEnabled = true;
        this.roleListBox.ItemHeight = 25;
        this.roleListBox.Location = new Point(0, 31);
        this.roleListBox.Name = "roleListBox";
        this.roleListBox.Size = new Size(265, 147);
        this.roleListBox.TabIndex = 5;
        this.roleListBox.SelectedIndexChanged += this.RoleListBox_SelectedIndexChanged;
        // 
        // roleSearchTextBox
        // 
        this.roleSearchTextBox.Dock = DockStyle.Top;
        this.roleSearchTextBox.Location = new Point(0, 0);
        this.roleSearchTextBox.Margin = new Padding(5, 3, 5, 3);
        this.roleSearchTextBox.Name = "roleSearchTextBox";
        this.roleSearchTextBox.PlaceholderText = "Rechercher un rôle";
        this.roleSearchTextBox.Size = new Size(265, 31);
        this.roleSearchTextBox.TabIndex = 4;
        this.roleSearchTextBox.TextChanged += this.RoleSearchTextBox_TextChanged;
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 3;
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
        this.tableLayoutPanel1.Dock = DockStyle.Bottom;
        this.tableLayoutPanel1.Location = new Point(0, 218);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 1;
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel1.Size = new Size(265, 110);
        this.tableLayoutPanel1.TabIndex = 3;
        // 
        // panel3
        // 
        this.panel3.Controls.Add(this.seeRoleDetailsButton);
        this.panel3.Controls.Add(this.updateRoleButton);
        this.panel3.Controls.Add(this.deleteRoleButton);
        this.panel3.Dock = DockStyle.Fill;
        this.panel3.Location = new Point(45, 3);
        this.panel3.Name = "panel3";
        this.panel3.Size = new Size(174, 104);
        this.panel3.TabIndex = 0;
        // 
        // seeRoleDetailsButton
        // 
        this.seeRoleDetailsButton.Dock = DockStyle.Top;
        this.seeRoleDetailsButton.Enabled = false;
        this.seeRoleDetailsButton.Location = new Point(0, 0);
        this.seeRoleDetailsButton.Name = "seeRoleDetailsButton";
        this.seeRoleDetailsButton.Size = new Size(174, 31);
        this.seeRoleDetailsButton.TabIndex = 2;
        this.seeRoleDetailsButton.Text = "Voir details";
        this.seeRoleDetailsButton.TextAlign = ContentAlignment.TopCenter;
        this.seeRoleDetailsButton.UseVisualStyleBackColor = true;
        this.seeRoleDetailsButton.Click += this.SeeRoleDetailsButton_Click;
        // 
        // updateRoleButton
        // 
        this.updateRoleButton.Enabled = false;
        this.updateRoleButton.Location = new Point(0, 34);
        this.updateRoleButton.Name = "updateRoleButton";
        this.updateRoleButton.Size = new Size(174, 31);
        this.updateRoleButton.TabIndex = 1;
        this.updateRoleButton.Text = "Modifier";
        this.updateRoleButton.TextAlign = ContentAlignment.TopCenter;
        this.updateRoleButton.UseVisualStyleBackColor = true;
        this.updateRoleButton.Click += this.UpdateRoleButton_Click;
        // 
        // deleteRoleButton
        // 
        this.deleteRoleButton.Dock = DockStyle.Bottom;
        this.deleteRoleButton.Enabled = false;
        this.deleteRoleButton.Location = new Point(0, 68);
        this.deleteRoleButton.Name = "deleteRoleButton";
        this.deleteRoleButton.Size = new Size(174, 36);
        this.deleteRoleButton.TabIndex = 0;
        this.deleteRoleButton.Text = "Supprimer";
        this.deleteRoleButton.TextAlign = ContentAlignment.TopCenter;
        this.deleteRoleButton.UseVisualStyleBackColor = true;
        this.deleteRoleButton.Click += this.DeleteRoleButton_Click;
        // 
        // roleCreateTableLayoutPanel
        // 
        this.roleCreateTableLayoutPanel.ColumnCount = 3;
        this.roleCreateTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.roleCreateTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
        this.roleCreateTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.roleCreateTableLayoutPanel.Controls.Add(this.createRoleButton, 1, 0);
        this.roleCreateTableLayoutPanel.Dock = DockStyle.Top;
        this.roleCreateTableLayoutPanel.Location = new Point(0, 0);
        this.roleCreateTableLayoutPanel.Name = "roleCreateTableLayoutPanel";
        this.roleCreateTableLayoutPanel.RowCount = 1;
        this.roleCreateTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.roleCreateTableLayoutPanel.Size = new Size(265, 40);
        this.roleCreateTableLayoutPanel.TabIndex = 0;
        // 
        // createRoleButton
        // 
        this.createRoleButton.Dock = DockStyle.Fill;
        this.createRoleButton.Location = new Point(45, 3);
        this.createRoleButton.Name = "createRoleButton";
        this.createRoleButton.Size = new Size(174, 34);
        this.createRoleButton.TabIndex = 0;
        this.createRoleButton.Text = "Créer un rôle";
        this.createRoleButton.UseVisualStyleBackColor = true;
        this.createRoleButton.Click += this.CreateRoleButton_Click;
        // 
        // rolePanelHeader
        // 
        this.rolePanelHeader.Dock = DockStyle.Top;
        this.rolePanelHeader.Location = new Point(0, 0);
        this.rolePanelHeader.Name = "rolePanelHeader";
        this.rolePanelHeader.Size = new Size(265, 38);
        this.rolePanelHeader.TabIndex = 0;
        this.rolePanelHeader.Text = "Gestion des rôles";
        this.rolePanelHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // userManagementPanel
        // 
        this.userManagementPanel.Controls.Add(this.userListBox);
        this.userManagementPanel.Controls.Add(this.userSearchTextBox);
        this.userManagementPanel.Controls.Add(this.userActionTableLayout);
        this.userManagementPanel.Controls.Add(this.userCreateTableLayout);
        this.userManagementPanel.Controls.Add(this.userPanelHeader);
        this.userManagementPanel.Dock = DockStyle.Fill;
        this.userManagementPanel.Location = new Point(3, 3);
        this.userManagementPanel.Name = "userManagementPanel";
        this.userManagementPanel.Size = new Size(265, 366);
        this.userManagementPanel.TabIndex = 0;
        // 
        // userListBox
        // 
        this.userListBox.Dock = DockStyle.Fill;
        this.userListBox.FormattingEnabled = true;
        this.userListBox.ItemHeight = 25;
        this.userListBox.Location = new Point(0, 109);
        this.userListBox.Name = "userListBox";
        this.userListBox.Size = new Size(265, 147);
        this.userListBox.TabIndex = 4;
        this.userListBox.SelectedIndexChanged += this.UserListBox_SelectedIndexChanged;
        // 
        // userSearchTextBox
        // 
        this.userSearchTextBox.Dock = DockStyle.Top;
        this.userSearchTextBox.Location = new Point(0, 78);
        this.userSearchTextBox.Margin = new Padding(5, 3, 5, 3);
        this.userSearchTextBox.Name = "userSearchTextBox";
        this.userSearchTextBox.PlaceholderText = "Rechercher un utilisateur";
        this.userSearchTextBox.Size = new Size(265, 31);
        this.userSearchTextBox.TabIndex = 3;
        this.userSearchTextBox.TextChanged += this.UserSearchTextBox_TextChanged;
        // 
        // userActionTableLayout
        // 
        this.userActionTableLayout.ColumnCount = 3;
        this.userActionTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.userActionTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
        this.userActionTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.userActionTableLayout.Controls.Add(this.userActionPanel, 1, 0);
        this.userActionTableLayout.Dock = DockStyle.Bottom;
        this.userActionTableLayout.Location = new Point(0, 256);
        this.userActionTableLayout.Name = "userActionTableLayout";
        this.userActionTableLayout.RowCount = 1;
        this.userActionTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.userActionTableLayout.Size = new Size(265, 110);
        this.userActionTableLayout.TabIndex = 2;
        // 
        // userActionPanel
        // 
        this.userActionPanel.Controls.Add(this.seeUserDetailsButton);
        this.userActionPanel.Controls.Add(this.updateUserButton);
        this.userActionPanel.Controls.Add(this.deleteUserButton);
        this.userActionPanel.Dock = DockStyle.Fill;
        this.userActionPanel.Location = new Point(45, 3);
        this.userActionPanel.Name = "userActionPanel";
        this.userActionPanel.Size = new Size(174, 104);
        this.userActionPanel.TabIndex = 0;
        // 
        // seeUserDetailsButton
        // 
        this.seeUserDetailsButton.Dock = DockStyle.Top;
        this.seeUserDetailsButton.Enabled = false;
        this.seeUserDetailsButton.Location = new Point(0, 0);
        this.seeUserDetailsButton.Name = "seeUserDetailsButton";
        this.seeUserDetailsButton.Size = new Size(174, 31);
        this.seeUserDetailsButton.TabIndex = 2;
        this.seeUserDetailsButton.Text = "Voir details";
        this.seeUserDetailsButton.TextAlign = ContentAlignment.TopCenter;
        this.seeUserDetailsButton.UseVisualStyleBackColor = true;
        this.seeUserDetailsButton.Click += this.SeeUserDetailsButton_Click;
        // 
        // updateUserButton
        // 
        this.updateUserButton.Enabled = false;
        this.updateUserButton.Location = new Point(0, 34);
        this.updateUserButton.Name = "updateUserButton";
        this.updateUserButton.Size = new Size(174, 31);
        this.updateUserButton.TabIndex = 1;
        this.updateUserButton.Text = "Modifier";
        this.updateUserButton.TextAlign = ContentAlignment.TopCenter;
        this.updateUserButton.UseVisualStyleBackColor = true;
        this.updateUserButton.Click += this.UpdateUserButton_Click;
        // 
        // deleteUserButton
        // 
        this.deleteUserButton.Dock = DockStyle.Bottom;
        this.deleteUserButton.Enabled = false;
        this.deleteUserButton.Location = new Point(0, 68);
        this.deleteUserButton.Name = "deleteUserButton";
        this.deleteUserButton.Size = new Size(174, 36);
        this.deleteUserButton.TabIndex = 0;
        this.deleteUserButton.Text = "Supprimer";
        this.deleteUserButton.TextAlign = ContentAlignment.TopCenter;
        this.deleteUserButton.UseVisualStyleBackColor = true;
        this.deleteUserButton.Click += this.DeleteUserButton_Click;
        // 
        // userCreateTableLayout
        // 
        this.userCreateTableLayout.ColumnCount = 3;
        this.userCreateTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.userCreateTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
        this.userCreateTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.userCreateTableLayout.Controls.Add(this.createUserButton, 1, 0);
        this.userCreateTableLayout.Dock = DockStyle.Top;
        this.userCreateTableLayout.Location = new Point(0, 38);
        this.userCreateTableLayout.Name = "userCreateTableLayout";
        this.userCreateTableLayout.RowCount = 1;
        this.userCreateTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.userCreateTableLayout.Size = new Size(265, 40);
        this.userCreateTableLayout.TabIndex = 1;
        // 
        // createUserButton
        // 
        this.createUserButton.Dock = DockStyle.Fill;
        this.createUserButton.Location = new Point(45, 3);
        this.createUserButton.Name = "createUserButton";
        this.createUserButton.Size = new Size(174, 34);
        this.createUserButton.TabIndex = 0;
        this.createUserButton.Text = "Créer un utilisateur";
        this.createUserButton.UseVisualStyleBackColor = true;
        this.createUserButton.Click += this.CreateUserButton_Click;
        // 
        // userPanelHeader
        // 
        this.userPanelHeader.Dock = DockStyle.Top;
        this.userPanelHeader.Location = new Point(0, 0);
        this.userPanelHeader.Name = "userPanelHeader";
        this.userPanelHeader.Size = new Size(265, 38);
        this.userPanelHeader.TabIndex = 0;
        this.userPanelHeader.Text = "Gestion des utilisateurs";
        this.userPanelHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // AdminMainMenu
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1356, 845);
        this.Controls.Add(this.primaryTableLayout);
        this.Controls.Add(this.panel2);
        this.Controls.Add(this.panel1);
        this.Name = "AdminMainMenu";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Menu principal - Admin";
        this.WindowState = FormWindowState.Maximized;
        this.panel2.ResumeLayout(false);
        this.primaryTableLayout.ResumeLayout(false);
        this.purchaseOrderManagementPanel.ResumeLayout(false);
        this.shippingOrderManagementPanel.ResumeLayout(false);
        this.warehouseManagementPanel.ResumeLayout(false);
        this.shipmentManagementPanel.ResumeLayout(false);
        this.clientManagementPanel.ResumeLayout(false);
        this.addressManagementPanel.ResumeLayout(false);
        this.supplierManagementPanel.ResumeLayout(false);
        this.productManagementPanel.ResumeLayout(false);
        this.roleManagementPanel.ResumeLayout(false);
        this.mainPanel.ResumeLayout(false);
        this.searchPanel.ResumeLayout(false);
        this.searchPanel.PerformLayout();
        this.tableLayoutPanel1.ResumeLayout(false);
        this.panel3.ResumeLayout(false);
        this.roleCreateTableLayoutPanel.ResumeLayout(false);
        this.userManagementPanel.ResumeLayout(false);
        this.userManagementPanel.PerformLayout();
        this.userActionTableLayout.ResumeLayout(false);
        this.userActionPanel.ResumeLayout(false);
        this.userCreateTableLayout.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Panel panel2;
    private TableLayoutPanel primaryTableLayout;
    private Panel userManagementPanel;
    private Label userPanelHeader;
    private Panel purchaseOrderManagementPanel;
    private Label purchaseOrderPanelHeader;
    private Panel shippingOrderManagementPanel;
    private Label shippingOrderPanelHeader;
    private Panel warehouseManagementPanel;
    private Label warehousePanelHeader;
    private Panel shipmentManagementPanel;
    private Label shipmentPanelHeader;
    private Panel clientManagementPanel;
    private Label clientPanelHeader;
    private Panel addressManagementPanel;
    private Label addressPanelHeader;
    private Panel supplierManagementPanel;
    private Label supplierPanelHeader;
    private Panel productManagementPanel;
    private Label productPanelHeader;
    private Panel roleManagementPanel;
    private Label rolePanelHeader;
    private Button logoutButtton;
    private TableLayoutPanel userCreateTableLayout;
    private Panel userCreateButtonPanel;
    private TableLayoutPanel userActionTableLayout;
    private Panel userActionPanel;
    private Button seeUserDetailsButton;
    private Button updateUserButton;
    private Button deleteUserButton;
    private ListBox userListBox;
    private TextBox userSearchTextBox;
    private Panel mainPanel;
    private TableLayoutPanel roleCreateTableLayoutPanel;
    private Button createRoleButton;
    private Button createUserButton;
    private TableLayoutPanel tableLayoutPanel1;
    private Panel panel3;
    private Button seeRoleDetailsButton;
    private Button updateRoleButton;
    private Button deleteRoleButton;
    private Panel searchPanel;
    private TextBox roleSearchTextBox;
    private ListBox roleListBox;
}
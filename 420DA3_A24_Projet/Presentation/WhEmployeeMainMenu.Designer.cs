namespace _420DA3_A24_Projet.Presentation;

partial class WhEmployeeMainMenu {
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
        this.bottomBarPanel = new Panel();
        this.logout = new Button();
        this.primaryTableLayoutPanel = new TableLayoutPanel();
        this.poTableLayoutPanel = new TableLayoutPanel();
        this.expectedPoListBox = new ListBox();
        this.poRefreshBtnPanel = new Panel();
        this.poRefreshBtn = new Button();
        this.poActionBtnPanel = new Panel();
        this.setReceivedButton = new Button();
        this.soPackagedTableLayoutPanel = new TableLayoutPanel();
        this.packagedSoListBox = new ListBox();
        this.soPackagedRefreshBtnPanel = new Panel();
        this.soPackagedRefreshBtn = new Button();
        this.soPackagedActBtnPanel = new Panel();
        this.setShippedButton = new Button();
        this.soAssignedProcTableLayoutPanel = new TableLayoutPanel();
        this.processingSoListBox = new ListBox();
        this.soAssignedRefreshBtnPanel = new Panel();
        this.soAssignedRefreshBtn = new Button();
        this.soAssignedActionTbLytPanel = new TableLayoutPanel();
        this.setPackagedButton = new Button();
        this.seeDetailsButton = new Button();
        this.soUnForWhEmpTableLayoutPanel = new TableLayoutPanel();
        this.soUnassignedRefreshBtnPanel = new Panel();
        this.soUnassignedRefreshBtn = new Button();
        this.soUnassignedActBtnPanel = new Panel();
        this.assignToMeButton = new Button();
        this.unassignedSoListBox = new ListBox();
        this.bottomBarPanel.SuspendLayout();
        this.primaryTableLayoutPanel.SuspendLayout();
        this.poTableLayoutPanel.SuspendLayout();
        this.poRefreshBtnPanel.SuspendLayout();
        this.poActionBtnPanel.SuspendLayout();
        this.soPackagedTableLayoutPanel.SuspendLayout();
        this.soPackagedRefreshBtnPanel.SuspendLayout();
        this.soPackagedActBtnPanel.SuspendLayout();
        this.soAssignedProcTableLayoutPanel.SuspendLayout();
        this.soAssignedRefreshBtnPanel.SuspendLayout();
        this.soAssignedActionTbLytPanel.SuspendLayout();
        this.soUnForWhEmpTableLayoutPanel.SuspendLayout();
        this.soUnassignedRefreshBtnPanel.SuspendLayout();
        this.soUnassignedActBtnPanel.SuspendLayout();
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
        // bottomBarPanel
        // 
        this.bottomBarPanel.Controls.Add(this.logout);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 692);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(1363, 50);
        this.bottomBarPanel.TabIndex = 1;
        // 
        // logout
        // 
        this.logout.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.logout.Location = new Point(1198, 6);
        this.logout.Name = "logout";
        this.logout.Size = new Size(153, 34);
        this.logout.TabIndex = 0;
        this.logout.Text = "Deconnexion";
        this.logout.UseVisualStyleBackColor = true;
        // 
        // primaryTableLayoutPanel
        // 
        this.primaryTableLayoutPanel.ColumnCount = 4;
        this.primaryTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        this.primaryTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        this.primaryTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        this.primaryTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        this.primaryTableLayoutPanel.Controls.Add(this.poTableLayoutPanel, 3, 0);
        this.primaryTableLayoutPanel.Controls.Add(this.soPackagedTableLayoutPanel, 2, 0);
        this.primaryTableLayoutPanel.Controls.Add(this.soAssignedProcTableLayoutPanel, 1, 0);
        this.primaryTableLayoutPanel.Controls.Add(this.soUnForWhEmpTableLayoutPanel, 0, 0);
        this.primaryTableLayoutPanel.Dock = DockStyle.Fill;
        this.primaryTableLayoutPanel.Location = new Point(0, 50);
        this.primaryTableLayoutPanel.Name = "primaryTableLayoutPanel";
        this.primaryTableLayoutPanel.RowCount = 1;
        this.primaryTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.primaryTableLayoutPanel.Size = new Size(1363, 642);
        this.primaryTableLayoutPanel.TabIndex = 2;
        // 
        // poTableLayoutPanel
        // 
        this.poTableLayoutPanel.ColumnCount = 1;
        this.poTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        this.poTableLayoutPanel.Controls.Add(this.expectedPoListBox, 0, 1);
        this.poTableLayoutPanel.Controls.Add(this.poRefreshBtnPanel, 0, 0);
        this.poTableLayoutPanel.Controls.Add(this.poActionBtnPanel, 0, 2);
        this.poTableLayoutPanel.Dock = DockStyle.Fill;
        this.poTableLayoutPanel.Location = new Point(1023, 3);
        this.poTableLayoutPanel.Name = "poTableLayoutPanel";
        this.poTableLayoutPanel.RowCount = 3;
        this.poTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
        this.poTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 83.3333359F));
        this.poTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
        this.poTableLayoutPanel.Size = new Size(337, 636);
        this.poTableLayoutPanel.TabIndex = 3;
        // 
        // expectedPoListBox
        // 
        this.expectedPoListBox.Dock = DockStyle.Fill;
        this.expectedPoListBox.FormattingEnabled = true;
        this.expectedPoListBox.ItemHeight = 25;
        this.expectedPoListBox.Location = new Point(3, 55);
        this.expectedPoListBox.Name = "expectedPoListBox";
        this.expectedPoListBox.Size = new Size(331, 523);
        this.expectedPoListBox.TabIndex = 3;
        // 
        // poRefreshBtnPanel
        // 
        this.poRefreshBtnPanel.Controls.Add(this.poRefreshBtn);
        this.poRefreshBtnPanel.Dock = DockStyle.Fill;
        this.poRefreshBtnPanel.Location = new Point(3, 3);
        this.poRefreshBtnPanel.Name = "poRefreshBtnPanel";
        this.poRefreshBtnPanel.Size = new Size(331, 46);
        this.poRefreshBtnPanel.TabIndex = 1;
        // 
        // poRefreshBtn
        // 
        this.poRefreshBtn.Dock = DockStyle.Fill;
        this.poRefreshBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        this.poRefreshBtn.Location = new Point(0, 0);
        this.poRefreshBtn.Name = "poRefreshBtn";
        this.poRefreshBtn.Size = new Size(331, 46);
        this.poRefreshBtn.TabIndex = 1;
        this.poRefreshBtn.Text = "Rafraichir";
        this.poRefreshBtn.UseVisualStyleBackColor = true;
        // 
        // poActionBtnPanel
        // 
        this.poActionBtnPanel.Controls.Add(this.setReceivedButton);
        this.poActionBtnPanel.Dock = DockStyle.Fill;
        this.poActionBtnPanel.Location = new Point(3, 584);
        this.poActionBtnPanel.Name = "poActionBtnPanel";
        this.poActionBtnPanel.Size = new Size(331, 49);
        this.poActionBtnPanel.TabIndex = 2;
        // 
        // setReceivedButton
        // 
        this.setReceivedButton.Location = new Point(86, 3);
        this.setReceivedButton.Name = "setReceivedButton";
        this.setReceivedButton.Size = new Size(158, 43);
        this.setReceivedButton.TabIndex = 1;
        this.setReceivedButton.Text = "Mettre reçu";
        this.setReceivedButton.UseVisualStyleBackColor = true;
        // 
        // soPackagedTableLayoutPanel
        // 
        this.soPackagedTableLayoutPanel.ColumnCount = 1;
        this.soPackagedTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        this.soPackagedTableLayoutPanel.Controls.Add(this.packagedSoListBox, 0, 1);
        this.soPackagedTableLayoutPanel.Controls.Add(this.soPackagedRefreshBtnPanel, 0, 0);
        this.soPackagedTableLayoutPanel.Controls.Add(this.soPackagedActBtnPanel, 0, 2);
        this.soPackagedTableLayoutPanel.Dock = DockStyle.Fill;
        this.soPackagedTableLayoutPanel.Location = new Point(683, 3);
        this.soPackagedTableLayoutPanel.Name = "soPackagedTableLayoutPanel";
        this.soPackagedTableLayoutPanel.RowCount = 3;
        this.soPackagedTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
        this.soPackagedTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 83.3333359F));
        this.soPackagedTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
        this.soPackagedTableLayoutPanel.Size = new Size(334, 636);
        this.soPackagedTableLayoutPanel.TabIndex = 2;
        // 
        // packagedSoListBox
        // 
        this.packagedSoListBox.Dock = DockStyle.Fill;
        this.packagedSoListBox.FormattingEnabled = true;
        this.packagedSoListBox.ItemHeight = 25;
        this.packagedSoListBox.Location = new Point(3, 55);
        this.packagedSoListBox.Name = "packagedSoListBox";
        this.packagedSoListBox.Size = new Size(328, 523);
        this.packagedSoListBox.TabIndex = 3;
        // 
        // soPackagedRefreshBtnPanel
        // 
        this.soPackagedRefreshBtnPanel.Controls.Add(this.soPackagedRefreshBtn);
        this.soPackagedRefreshBtnPanel.Dock = DockStyle.Fill;
        this.soPackagedRefreshBtnPanel.Location = new Point(3, 3);
        this.soPackagedRefreshBtnPanel.Name = "soPackagedRefreshBtnPanel";
        this.soPackagedRefreshBtnPanel.Size = new Size(328, 46);
        this.soPackagedRefreshBtnPanel.TabIndex = 1;
        // 
        // soPackagedRefreshBtn
        // 
        this.soPackagedRefreshBtn.Dock = DockStyle.Fill;
        this.soPackagedRefreshBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        this.soPackagedRefreshBtn.Location = new Point(0, 0);
        this.soPackagedRefreshBtn.Name = "soPackagedRefreshBtn";
        this.soPackagedRefreshBtn.Size = new Size(328, 46);
        this.soPackagedRefreshBtn.TabIndex = 1;
        this.soPackagedRefreshBtn.Text = "Rafraichir";
        this.soPackagedRefreshBtn.UseVisualStyleBackColor = true;
        // 
        // soPackagedActBtnPanel
        // 
        this.soPackagedActBtnPanel.Controls.Add(this.setShippedButton);
        this.soPackagedActBtnPanel.Dock = DockStyle.Fill;
        this.soPackagedActBtnPanel.Location = new Point(3, 584);
        this.soPackagedActBtnPanel.Name = "soPackagedActBtnPanel";
        this.soPackagedActBtnPanel.Size = new Size(328, 49);
        this.soPackagedActBtnPanel.TabIndex = 2;
        // 
        // setShippedButton
        // 
        this.setShippedButton.Location = new Point(85, 3);
        this.setShippedButton.Name = "setShippedButton";
        this.setShippedButton.Size = new Size(158, 43);
        this.setShippedButton.TabIndex = 1;
        this.setShippedButton.Text = "Mettre Expédié";
        this.setShippedButton.UseVisualStyleBackColor = true;
        // 
        // soAssignedProcTableLayoutPanel
        // 
        this.soAssignedProcTableLayoutPanel.ColumnCount = 1;
        this.soAssignedProcTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        this.soAssignedProcTableLayoutPanel.Controls.Add(this.processingSoListBox, 0, 1);
        this.soAssignedProcTableLayoutPanel.Controls.Add(this.soAssignedRefreshBtnPanel, 0, 0);
        this.soAssignedProcTableLayoutPanel.Controls.Add(this.soAssignedActionTbLytPanel, 0, 2);
        this.soAssignedProcTableLayoutPanel.Dock = DockStyle.Fill;
        this.soAssignedProcTableLayoutPanel.Location = new Point(343, 3);
        this.soAssignedProcTableLayoutPanel.Name = "soAssignedProcTableLayoutPanel";
        this.soAssignedProcTableLayoutPanel.RowCount = 3;
        this.soAssignedProcTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
        this.soAssignedProcTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 83.3333359F));
        this.soAssignedProcTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
        this.soAssignedProcTableLayoutPanel.Size = new Size(334, 636);
        this.soAssignedProcTableLayoutPanel.TabIndex = 1;
        // 
        // processingSoListBox
        // 
        this.processingSoListBox.Dock = DockStyle.Fill;
        this.processingSoListBox.FormattingEnabled = true;
        this.processingSoListBox.ItemHeight = 25;
        this.processingSoListBox.Location = new Point(3, 55);
        this.processingSoListBox.Name = "processingSoListBox";
        this.processingSoListBox.Size = new Size(328, 523);
        this.processingSoListBox.TabIndex = 3;
        // 
        // soAssignedRefreshBtnPanel
        // 
        this.soAssignedRefreshBtnPanel.Controls.Add(this.soAssignedRefreshBtn);
        this.soAssignedRefreshBtnPanel.Dock = DockStyle.Fill;
        this.soAssignedRefreshBtnPanel.Location = new Point(3, 3);
        this.soAssignedRefreshBtnPanel.Name = "soAssignedRefreshBtnPanel";
        this.soAssignedRefreshBtnPanel.Size = new Size(328, 46);
        this.soAssignedRefreshBtnPanel.TabIndex = 1;
        // 
        // soAssignedRefreshBtn
        // 
        this.soAssignedRefreshBtn.Dock = DockStyle.Fill;
        this.soAssignedRefreshBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        this.soAssignedRefreshBtn.Location = new Point(0, 0);
        this.soAssignedRefreshBtn.Name = "soAssignedRefreshBtn";
        this.soAssignedRefreshBtn.Size = new Size(328, 46);
        this.soAssignedRefreshBtn.TabIndex = 1;
        this.soAssignedRefreshBtn.Text = "Rafraichir";
        this.soAssignedRefreshBtn.UseVisualStyleBackColor = true;
        // 
        // soAssignedActionTbLytPanel
        // 
        this.soAssignedActionTbLytPanel.ColumnCount = 2;
        this.soAssignedActionTbLytPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.soAssignedActionTbLytPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.soAssignedActionTbLytPanel.Controls.Add(this.setPackagedButton, 1, 0);
        this.soAssignedActionTbLytPanel.Controls.Add(this.seeDetailsButton, 0, 0);
        this.soAssignedActionTbLytPanel.Dock = DockStyle.Fill;
        this.soAssignedActionTbLytPanel.Location = new Point(3, 584);
        this.soAssignedActionTbLytPanel.Name = "soAssignedActionTbLytPanel";
        this.soAssignedActionTbLytPanel.RowCount = 1;
        this.soAssignedActionTbLytPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.soAssignedActionTbLytPanel.Size = new Size(328, 49);
        this.soAssignedActionTbLytPanel.TabIndex = 0;
        // 
        // setPackagedButton
        // 
        this.setPackagedButton.Dock = DockStyle.Fill;
        this.setPackagedButton.Location = new Point(167, 3);
        this.setPackagedButton.Name = "setPackagedButton";
        this.setPackagedButton.Size = new Size(158, 43);
        this.setPackagedButton.TabIndex = 1;
        this.setPackagedButton.Text = "Mettre emballé";
        this.setPackagedButton.UseVisualStyleBackColor = true;
        // 
        // seeDetailsButton
        // 
        this.seeDetailsButton.Dock = DockStyle.Fill;
        this.seeDetailsButton.Location = new Point(3, 3);
        this.seeDetailsButton.Name = "seeDetailsButton";
        this.seeDetailsButton.Size = new Size(158, 43);
        this.seeDetailsButton.TabIndex = 0;
        this.seeDetailsButton.Text = "Voir Détails";
        this.seeDetailsButton.UseVisualStyleBackColor = true;
        // 
        // soUnForWhEmpTableLayoutPanel
        // 
        this.soUnForWhEmpTableLayoutPanel.ColumnCount = 1;
        this.soUnForWhEmpTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        this.soUnForWhEmpTableLayoutPanel.Controls.Add(this.soUnassignedRefreshBtnPanel, 0, 0);
        this.soUnForWhEmpTableLayoutPanel.Controls.Add(this.soUnassignedActBtnPanel, 0, 2);
        this.soUnForWhEmpTableLayoutPanel.Controls.Add(this.unassignedSoListBox, 0, 1);
        this.soUnForWhEmpTableLayoutPanel.Dock = DockStyle.Fill;
        this.soUnForWhEmpTableLayoutPanel.Location = new Point(3, 3);
        this.soUnForWhEmpTableLayoutPanel.Name = "soUnForWhEmpTableLayoutPanel";
        this.soUnForWhEmpTableLayoutPanel.RowCount = 3;
        this.soUnForWhEmpTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
        this.soUnForWhEmpTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 83.3333359F));
        this.soUnForWhEmpTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
        this.soUnForWhEmpTableLayoutPanel.Size = new Size(334, 636);
        this.soUnForWhEmpTableLayoutPanel.TabIndex = 0;
        // 
        // soUnassignedRefreshBtnPanel
        // 
        this.soUnassignedRefreshBtnPanel.Controls.Add(this.soUnassignedRefreshBtn);
        this.soUnassignedRefreshBtnPanel.Dock = DockStyle.Fill;
        this.soUnassignedRefreshBtnPanel.Location = new Point(3, 3);
        this.soUnassignedRefreshBtnPanel.Name = "soUnassignedRefreshBtnPanel";
        this.soUnassignedRefreshBtnPanel.Size = new Size(328, 46);
        this.soUnassignedRefreshBtnPanel.TabIndex = 0;
        // 
        // soUnassignedRefreshBtn
        // 
        this.soUnassignedRefreshBtn.Dock = DockStyle.Fill;
        this.soUnassignedRefreshBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        this.soUnassignedRefreshBtn.Location = new Point(0, 0);
        this.soUnassignedRefreshBtn.Name = "soUnassignedRefreshBtn";
        this.soUnassignedRefreshBtn.Size = new Size(328, 46);
        this.soUnassignedRefreshBtn.TabIndex = 0;
        this.soUnassignedRefreshBtn.Text = "Rafraichir";
        this.soUnassignedRefreshBtn.UseVisualStyleBackColor = true;
        // 
        // soUnassignedActBtnPanel
        // 
        this.soUnassignedActBtnPanel.Controls.Add(this.assignToMeButton);
        this.soUnassignedActBtnPanel.Dock = DockStyle.Fill;
        this.soUnassignedActBtnPanel.Location = new Point(3, 584);
        this.soUnassignedActBtnPanel.Name = "soUnassignedActBtnPanel";
        this.soUnassignedActBtnPanel.Size = new Size(328, 49);
        this.soUnassignedActBtnPanel.TabIndex = 1;
        // 
        // assignToMeButton
        // 
        this.assignToMeButton.Location = new Point(80, 3);
        this.assignToMeButton.Name = "assignToMeButton";
        this.assignToMeButton.Size = new Size(158, 43);
        this.assignToMeButton.TabIndex = 0;
        this.assignToMeButton.Text = "M'assigner";
        this.assignToMeButton.UseVisualStyleBackColor = true;
        // 
        // unassignedSoListBox
        // 
        this.unassignedSoListBox.Dock = DockStyle.Fill;
        this.unassignedSoListBox.FormattingEnabled = true;
        this.unassignedSoListBox.ItemHeight = 25;
        this.unassignedSoListBox.Location = new Point(3, 55);
        this.unassignedSoListBox.Name = "unassignedSoListBox";
        this.unassignedSoListBox.Size = new Size(328, 523);
        this.unassignedSoListBox.TabIndex = 2;
        // 
        // WhEmployeeMainMenu
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1363, 742);
        this.Controls.Add(this.primaryTableLayoutPanel);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.Name = "WhEmployeeMainMenu";
        this.Text = "WhEmployeeMainMenu";
        this.bottomBarPanel.ResumeLayout(false);
        this.primaryTableLayoutPanel.ResumeLayout(false);
        this.poTableLayoutPanel.ResumeLayout(false);
        this.poRefreshBtnPanel.ResumeLayout(false);
        this.poActionBtnPanel.ResumeLayout(false);
        this.soPackagedTableLayoutPanel.ResumeLayout(false);
        this.soPackagedRefreshBtnPanel.ResumeLayout(false);
        this.soPackagedActBtnPanel.ResumeLayout(false);
        this.soAssignedProcTableLayoutPanel.ResumeLayout(false);
        this.soAssignedRefreshBtnPanel.ResumeLayout(false);
        this.soAssignedActionTbLytPanel.ResumeLayout(false);
        this.soUnForWhEmpTableLayoutPanel.ResumeLayout(false);
        this.soUnassignedRefreshBtnPanel.ResumeLayout(false);
        this.soUnassignedActBtnPanel.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Panel bottomBarPanel;
    private TableLayoutPanel primaryTableLayoutPanel;
    private TableLayoutPanel soUnForWhEmpTableLayoutPanel;
    private TableLayoutPanel poTableLayoutPanel;
    private TableLayoutPanel soPackagedTableLayoutPanel;
    private TableLayoutPanel soAssignedProcTableLayoutPanel;
    private TableLayoutPanel soAssignedActionTbLytPanel;
    private Panel poRefreshBtnPanel;
    private Panel soPackagedRefreshBtnPanel;
    private Panel soAssignedRefreshBtnPanel;
    private Panel soUnassignedRefreshBtnPanel;
    private Button soUnassignedRefreshBtn;
    private Button poRefreshBtn;
    private Button soPackagedRefreshBtn;
    private Button soAssignedRefreshBtn;
    private Button setPackagedButton;
    private Button seeDetailsButton;
    private Panel soUnassignedActBtnPanel;
    private Panel poActionBtnPanel;
    private Button setReceivedButton;
    private Panel soPackagedActBtnPanel;
    private Button setShippedButton;
    private Button assignToMeButton;
    private ListBox unassignedSoListBox;
    private Button logout;
    private ListBox expectedPoListBox;
    private ListBox packagedSoListBox;
    private ListBox processingSoListBox;
}
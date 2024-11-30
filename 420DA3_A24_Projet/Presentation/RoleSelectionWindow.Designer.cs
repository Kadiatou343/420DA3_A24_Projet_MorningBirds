namespace _420DA3_A24_Projet.Presentation;

partial class RoleSelectionWindow {
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
        this.mainTableLayout = new TableLayoutPanel();
        this.centrePanel = new Panel();
        this.userRolesListBox = new ListBox();
        this.titleLable = new Label();
        this.chooseRoleButton = new Button();
        this.cancelButton = new Button();
        this.mainTableLayout.SuspendLayout();
        this.centrePanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // mainTableLayout
        // 
        this.mainTableLayout.ColumnCount = 3;
        this.mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        this.mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.mainTableLayout.Controls.Add(this.centrePanel, 1, 1);
        this.mainTableLayout.Controls.Add(this.titleLable, 1, 0);
        this.mainTableLayout.Dock = DockStyle.Fill;
        this.mainTableLayout.Location = new Point(0, 0);
        this.mainTableLayout.Name = "mainTableLayout";
        this.mainTableLayout.RowCount = 3;
        this.mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 250F));
        this.mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.mainTableLayout.Size = new Size(373, 437);
        this.mainTableLayout.TabIndex = 0;
        // 
        // centrePanel
        // 
        this.centrePanel.Controls.Add(this.cancelButton);
        this.centrePanel.Controls.Add(this.chooseRoleButton);
        this.centrePanel.Controls.Add(this.userRolesListBox);
        this.centrePanel.Dock = DockStyle.Fill;
        this.centrePanel.Location = new Point(89, 101);
        this.centrePanel.Margin = new Padding(3, 8, 3, 3);
        this.centrePanel.Name = "centrePanel";
        this.centrePanel.Size = new Size(194, 239);
        this.centrePanel.TabIndex = 0;
        // 
        // userRolesListBox
        // 
        this.userRolesListBox.Dock = DockStyle.Top;
        this.userRolesListBox.FormattingEnabled = true;
        this.userRolesListBox.ItemHeight = 25;
        this.userRolesListBox.Location = new Point(0, 0);
        this.userRolesListBox.Name = "userRolesListBox";
        this.userRolesListBox.Size = new Size(194, 129);
        this.userRolesListBox.TabIndex = 0;
        this.userRolesListBox.SelectedIndexChanged += this.UserRolesListBox_SelectedIndexChanged;
        // 
        // titleLable
        // 
        this.titleLable.Dock = DockStyle.Fill;
        this.titleLable.Location = new Point(89, 0);
        this.titleLable.Name = "titleLable";
        this.titleLable.Size = new Size(194, 93);
        this.titleLable.TabIndex = 1;
        this.titleLable.Text = "Selectionnez un rôle à utiliser";
        this.titleLable.TextAlign = ContentAlignment.BottomCenter;
        // 
        // chooseRoleButton
        // 
        this.chooseRoleButton.Enabled = false;
        this.chooseRoleButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        this.chooseRoleButton.Location = new Point(27, 135);
        this.chooseRoleButton.Name = "chooseRoleButton";
        this.chooseRoleButton.Size = new Size(141, 50);
        this.chooseRoleButton.TabIndex = 1;
        this.chooseRoleButton.Text = "Choisir Rôle";
        this.chooseRoleButton.UseVisualStyleBackColor = true;
        this.chooseRoleButton.Click += this.ChooseRoleButton_Click;
        // 
        // cancelButton
        // 
        this.cancelButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        this.cancelButton.Location = new Point(27, 191);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new Size(141, 45);
        this.cancelButton.TabIndex = 2;
        this.cancelButton.Text = "Annuler";
        this.cancelButton.UseVisualStyleBackColor = true;
        this.cancelButton.Click += this.CancelButton_Click;
        // 
        // RoleSelectionWindow
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(373, 437);
        this.Controls.Add(this.mainTableLayout);
        this.Name = "RoleSelectionWindow";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Choix de rôle";
        this.mainTableLayout.ResumeLayout(false);
        this.centrePanel.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel mainTableLayout;
    private Panel centrePanel;
    private ListBox userRolesListBox;
    private Label titleLable;
    private Button cancelButton;
    private Button chooseRoleButton;
}
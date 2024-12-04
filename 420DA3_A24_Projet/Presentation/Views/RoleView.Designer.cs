namespace _420DA3_A24_Projet.Presentation.Views;

partial class RoleView {
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
        this.viewModeValueLabel = new Label();
        this.viewModeLabal = new Label();
        this.panel1 = new Panel();
        this.cancelButton = new Button();
        this.actionButton = new Button();
        this.copyrightLabel = new Label();
        this.primaryTableLayout = new TableLayoutPanel();
        this.mainPanel = new Panel();
        this.roleDescLabel = new Label();
        this.roleDescRichTextBox = new RichTextBox();
        this.roleNameLabel = new Label();
        this.roleNameTextBox = new TextBox();
        this.idLabel = new Label();
        this.idNumUpDown = new NumericUpDown();
        this.metaDataPanel = new Panel();
        this.dateCreatedLabel = new Label();
        this.dateModifiedLabel = new Label();
        this.dateDeletedLabel = new Label();
        this.dateDeletedDTPicker = new DateTimePicker();
        this.dateCreatedDTPicker = new DateTimePicker();
        this.dateModifiedDTPicker = new DateTimePicker();
        this.topBarPanel.SuspendLayout();
        this.panel1.SuspendLayout();
        this.primaryTableLayout.SuspendLayout();
        this.mainPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.idNumUpDown).BeginInit();
        this.metaDataPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        this.topBarPanel.Controls.Add(this.viewModeValueLabel);
        this.topBarPanel.Controls.Add(this.viewModeLabal);
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(1024, 60);
        this.topBarPanel.TabIndex = 0;
        // 
        // viewModeValueLabel
        // 
        this.viewModeValueLabel.AutoSize = true;
        this.viewModeValueLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.viewModeValueLabel.Location = new Point(158, 20);
        this.viewModeValueLabel.Margin = new Padding(4, 0, 4, 0);
        this.viewModeValueLabel.Name = "viewModeValueLabel";
        this.viewModeValueLabel.Size = new Size(64, 25);
        this.viewModeValueLabel.TabIndex = 3;
        this.viewModeValueLabel.Text = "NONE";
        // 
        // viewModeLabal
        // 
        this.viewModeLabal.AutoSize = true;
        this.viewModeLabal.Location = new Point(13, 20);
        this.viewModeLabal.Margin = new Padding(4, 0, 4, 0);
        this.viewModeLabal.Name = "viewModeLabal";
        this.viewModeLabal.Size = new Size(137, 25);
        this.viewModeLabal.TabIndex = 2;
        this.viewModeLabal.Text = "MODE DE VUE :";
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.cancelButton);
        this.panel1.Controls.Add(this.actionButton);
        this.panel1.Controls.Add(this.copyrightLabel);
        this.panel1.Dock = DockStyle.Bottom;
        this.panel1.Location = new Point(0, 558);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(1024, 80);
        this.panel1.TabIndex = 1;
        // 
        // cancelButton
        // 
        this.cancelButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.cancelButton.Location = new Point(859, 13);
        this.cancelButton.Margin = new Padding(4, 5, 4, 5);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new Size(143, 53);
        this.cancelButton.TabIndex = 6;
        this.cancelButton.Text = "Cancel";
        this.cancelButton.UseVisualStyleBackColor = true;
        this.cancelButton.Click += this.CancelButton_Click;
        // 
        // actionButton
        // 
        this.actionButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.actionButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.actionButton.Location = new Point(687, 13);
        this.actionButton.Margin = new Padding(4, 5, 4, 5);
        this.actionButton.Name = "actionButton";
        this.actionButton.Size = new Size(143, 53);
        this.actionButton.TabIndex = 5;
        this.actionButton.Text = "ACTION";
        this.actionButton.UseVisualStyleBackColor = true;
        this.actionButton.Click += this.ActionButton_Click;
        // 
        // copyrightLabel
        // 
        this.copyrightLabel.AutoSize = true;
        this.copyrightLabel.Location = new Point(13, 24);
        this.copyrightLabel.Margin = new Padding(4, 0, 4, 0);
        this.copyrightLabel.Name = "copyrightLabel";
        this.copyrightLabel.Size = new Size(91, 25);
        this.copyrightLabel.TabIndex = 4;
        this.copyrightLabel.Text = "Copyright";
        // 
        // primaryTableLayout
        // 
        this.primaryTableLayout.ColumnCount = 3;
        this.primaryTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        this.primaryTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
        this.primaryTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        this.primaryTableLayout.Controls.Add(this.mainPanel, 1, 0);
        this.primaryTableLayout.Dock = DockStyle.Fill;
        this.primaryTableLayout.Location = new Point(0, 60);
        this.primaryTableLayout.Name = "primaryTableLayout";
        this.primaryTableLayout.RowCount = 1;
        this.primaryTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.primaryTableLayout.Size = new Size(1024, 498);
        this.primaryTableLayout.TabIndex = 2;
        // 
        // mainPanel
        // 
        this.mainPanel.Controls.Add(this.roleDescLabel);
        this.mainPanel.Controls.Add(this.roleDescRichTextBox);
        this.mainPanel.Controls.Add(this.roleNameLabel);
        this.mainPanel.Controls.Add(this.roleNameTextBox);
        this.mainPanel.Controls.Add(this.idLabel);
        this.mainPanel.Controls.Add(this.idNumUpDown);
        this.mainPanel.Controls.Add(this.metaDataPanel);
        this.mainPanel.Dock = DockStyle.Fill;
        this.mainPanel.Location = new Point(105, 3);
        this.mainPanel.Name = "mainPanel";
        this.mainPanel.Size = new Size(813, 492);
        this.mainPanel.TabIndex = 0;
        // 
        // roleDescLabel
        // 
        this.roleDescLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.roleDescLabel.Location = new Point(53, 195);
        this.roleDescLabel.Margin = new Padding(4, 0, 4, 0);
        this.roleDescLabel.Name = "roleDescLabel";
        this.roleDescLabel.Size = new Size(286, 50);
        this.roleDescLabel.TabIndex = 11;
        this.roleDescLabel.Text = "Description du rôle:";
        this.roleDescLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // roleDescRichTextBox
        // 
        this.roleDescRichTextBox.Location = new Point(351, 167);
        this.roleDescRichTextBox.Name = "roleDescRichTextBox";
        this.roleDescRichTextBox.Size = new Size(350, 115);
        this.roleDescRichTextBox.TabIndex = 10;
        this.roleDescRichTextBox.Text = "";
        // 
        // roleNameLabel
        // 
        this.roleNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.roleNameLabel.Location = new Point(53, 85);
        this.roleNameLabel.Margin = new Padding(4, 0, 4, 0);
        this.roleNameLabel.Name = "roleNameLabel";
        this.roleNameLabel.Size = new Size(286, 50);
        this.roleNameLabel.TabIndex = 9;
        this.roleNameLabel.Text = "Nom du rôle:";
        this.roleNameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // roleNameTextBox
        // 
        this.roleNameTextBox.Location = new Point(351, 95);
        this.roleNameTextBox.Name = "roleNameTextBox";
        this.roleNameTextBox.Size = new Size(350, 31);
        this.roleNameTextBox.TabIndex = 7;
        // 
        // idLabel
        // 
        this.idLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.idLabel.Location = new Point(53, 11);
        this.idLabel.Margin = new Padding(4, 0, 4, 0);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(286, 50);
        this.idLabel.TabIndex = 6;
        this.idLabel.Text = "ID: ";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idNumUpDown
        // 
        this.idNumUpDown.Enabled = false;
        this.idNumUpDown.Location = new Point(351, 22);
        this.idNumUpDown.Name = "idNumUpDown";
        this.idNumUpDown.Size = new Size(350, 31);
        this.idNumUpDown.TabIndex = 5;
        // 
        // metaDataPanel
        // 
        this.metaDataPanel.Controls.Add(this.dateCreatedLabel);
        this.metaDataPanel.Controls.Add(this.dateModifiedLabel);
        this.metaDataPanel.Controls.Add(this.dateDeletedLabel);
        this.metaDataPanel.Controls.Add(this.dateDeletedDTPicker);
        this.metaDataPanel.Controls.Add(this.dateCreatedDTPicker);
        this.metaDataPanel.Controls.Add(this.dateModifiedDTPicker);
        this.metaDataPanel.Dock = DockStyle.Bottom;
        this.metaDataPanel.Location = new Point(0, 362);
        this.metaDataPanel.Name = "metaDataPanel";
        this.metaDataPanel.Size = new Size(813, 130);
        this.metaDataPanel.TabIndex = 4;
        // 
        // dateCreatedLabel
        // 
        this.dateCreatedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.dateCreatedLabel.Location = new Point(64, 13);
        this.dateCreatedLabel.Margin = new Padding(4, 0, 4, 0);
        this.dateCreatedLabel.Name = "dateCreatedLabel";
        this.dateCreatedLabel.Size = new Size(286, 31);
        this.dateCreatedLabel.TabIndex = 9;
        this.dateCreatedLabel.Text = "Date de création: ";
        this.dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateModifiedLabel
        // 
        this.dateModifiedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.dateModifiedLabel.Location = new Point(64, 52);
        this.dateModifiedLabel.Margin = new Padding(4, 0, 4, 0);
        this.dateModifiedLabel.Name = "dateModifiedLabel";
        this.dateModifiedLabel.Size = new Size(286, 31);
        this.dateModifiedLabel.TabIndex = 8;
        this.dateModifiedLabel.Text = "Date de modification: ";
        this.dateModifiedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateDeletedLabel
        // 
        this.dateDeletedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.dateDeletedLabel.Location = new Point(64, 87);
        this.dateDeletedLabel.Margin = new Padding(4, 0, 4, 0);
        this.dateDeletedLabel.Name = "dateDeletedLabel";
        this.dateDeletedLabel.Size = new Size(286, 31);
        this.dateDeletedLabel.TabIndex = 7;
        this.dateDeletedLabel.Text = "Date de suppression: ";
        this.dateDeletedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateDeletedDTPicker
        // 
        this.dateDeletedDTPicker.Enabled = false;
        this.dateDeletedDTPicker.Location = new Point(368, 87);
        this.dateDeletedDTPicker.Name = "dateDeletedDTPicker";
        this.dateDeletedDTPicker.Size = new Size(300, 31);
        this.dateDeletedDTPicker.TabIndex = 0;
        // 
        // dateCreatedDTPicker
        // 
        this.dateCreatedDTPicker.Enabled = false;
        this.dateCreatedDTPicker.Location = new Point(368, 13);
        this.dateCreatedDTPicker.Name = "dateCreatedDTPicker";
        this.dateCreatedDTPicker.Size = new Size(300, 31);
        this.dateCreatedDTPicker.TabIndex = 1;
        // 
        // dateModifiedDTPicker
        // 
        this.dateModifiedDTPicker.Enabled = false;
        this.dateModifiedDTPicker.Location = new Point(368, 50);
        this.dateModifiedDTPicker.Name = "dateModifiedDTPicker";
        this.dateModifiedDTPicker.Size = new Size(300, 31);
        this.dateModifiedDTPicker.TabIndex = 2;
        // 
        // RoleView
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1024, 638);
        this.Controls.Add(this.primaryTableLayout);
        this.Controls.Add(this.panel1);
        this.Controls.Add(this.topBarPanel);
        this.Name = "RoleView";
        this.Text = "RoleView";
        this.topBarPanel.ResumeLayout(false);
        this.topBarPanel.PerformLayout();
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.primaryTableLayout.ResumeLayout(false);
        this.mainPanel.ResumeLayout(false);
        this.mainPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.idNumUpDown).EndInit();
        this.metaDataPanel.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Panel panel1;
    private Label viewModeLabal;
    private Label viewModeValueLabel;
    private Label copyrightLabel;
    private Button actionButton;
    private Button cancelButton;
    private TableLayoutPanel primaryTableLayout;
    private Panel mainPanel;
    private Panel metaDataPanel;
    private Label dateCreatedLabel;
    private Label dateModifiedLabel;
    private Label dateDeletedLabel;
    private DateTimePicker dateDeletedDTPicker;
    private DateTimePicker dateCreatedDTPicker;
    private DateTimePicker dateModifiedDTPicker;
    private NumericUpDown idNumUpDown;
    private Label idLabel;
    private TextBox roleNameTextBox;
    private Label roleNameLabel;
    private RichTextBox roleDescRichTextBox;
    private Label roleDescLabel;
}
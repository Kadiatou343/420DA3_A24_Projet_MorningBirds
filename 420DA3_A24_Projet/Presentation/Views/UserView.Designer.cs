namespace _420DA3_A24_Projet.Presentation.Views;

partial class UserView {
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
        this.viewModeValue = new Label();
        this.viewModeLabel = new Label();
        this.bottomBarPanel = new Panel();
        this.cancelButton = new Button();
        this.actionButton = new Button();
        this.copyrightLabel = new Label();
        this.mainTableLayout = new TableLayoutPanel();
        this.mainPanel = new Panel();
        this.userRolesListBox = new ListBox();
        this.employeeWhListBox = new ListBox();
        this.passwordLabel = new Label();
        this.usernameLabel = new Label();
        this.passwordTextBox = new TextBox();
        this.usernameTextBox = new TextBox();
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
        this.bottomBarPanel.SuspendLayout();
        this.mainTableLayout.SuspendLayout();
        this.mainPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.idNumUpDown).BeginInit();
        this.metaDataPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        this.topBarPanel.Controls.Add(this.viewModeValue);
        this.topBarPanel.Controls.Add(this.viewModeLabel);
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(1128, 60);
        this.topBarPanel.TabIndex = 0;
        // 
        // viewModeValue
        // 
        this.viewModeValue.AutoSize = true;
        this.viewModeValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.viewModeValue.Location = new Point(168, 19);
        this.viewModeValue.Margin = new Padding(4, 0, 4, 0);
        this.viewModeValue.Name = "viewModeValue";
        this.viewModeValue.Size = new Size(64, 25);
        this.viewModeValue.TabIndex = 2;
        this.viewModeValue.Text = "NONE";
        // 
        // viewModeLabel
        // 
        this.viewModeLabel.AutoSize = true;
        this.viewModeLabel.Location = new Point(13, 19);
        this.viewModeLabel.Margin = new Padding(4, 0, 4, 0);
        this.viewModeLabel.Name = "viewModeLabel";
        this.viewModeLabel.Size = new Size(137, 25);
        this.viewModeLabel.TabIndex = 1;
        this.viewModeLabel.Text = "MODE DE VUE :";
        // 
        // bottomBarPanel
        // 
        this.bottomBarPanel.Controls.Add(this.cancelButton);
        this.bottomBarPanel.Controls.Add(this.actionButton);
        this.bottomBarPanel.Controls.Add(this.copyrightLabel);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 648);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(1128, 80);
        this.bottomBarPanel.TabIndex = 1;
        // 
        // cancelButton
        // 
        this.cancelButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.cancelButton.Location = new Point(972, 13);
        this.cancelButton.Margin = new Padding(4, 5, 4, 5);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new Size(143, 53);
        this.cancelButton.TabIndex = 5;
        this.cancelButton.Text = "Cancel";
        this.cancelButton.UseVisualStyleBackColor = true;
        this.cancelButton.Click += this.CancelButton_Click;
        // 
        // actionButton
        // 
        this.actionButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.actionButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.actionButton.Location = new Point(815, 13);
        this.actionButton.Margin = new Padding(4, 5, 4, 5);
        this.actionButton.Name = "actionButton";
        this.actionButton.Size = new Size(143, 53);
        this.actionButton.TabIndex = 4;
        this.actionButton.Text = "ACTION";
        this.actionButton.UseVisualStyleBackColor = true;
        this.actionButton.Click += this.ActionButton_Click;
        // 
        // copyrightLabel
        // 
        this.copyrightLabel.AutoSize = true;
        this.copyrightLabel.Location = new Point(13, 31);
        this.copyrightLabel.Margin = new Padding(4, 0, 4, 0);
        this.copyrightLabel.Name = "copyrightLabel";
        this.copyrightLabel.Size = new Size(91, 25);
        this.copyrightLabel.TabIndex = 3;
        this.copyrightLabel.Text = "Copyright";
        // 
        // mainTableLayout
        // 
        this.mainTableLayout.ColumnCount = 3;
        this.mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        this.mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
        this.mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        this.mainTableLayout.Controls.Add(this.mainPanel, 1, 0);
        this.mainTableLayout.Dock = DockStyle.Fill;
        this.mainTableLayout.Location = new Point(0, 60);
        this.mainTableLayout.Name = "mainTableLayout";
        this.mainTableLayout.RowCount = 1;
        this.mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.mainTableLayout.Size = new Size(1128, 588);
        this.mainTableLayout.TabIndex = 2;
        // 
        // mainPanel
        // 
        this.mainPanel.Controls.Add(this.userRolesListBox);
        this.mainPanel.Controls.Add(this.employeeWhListBox);
        this.mainPanel.Controls.Add(this.passwordLabel);
        this.mainPanel.Controls.Add(this.usernameLabel);
        this.mainPanel.Controls.Add(this.passwordTextBox);
        this.mainPanel.Controls.Add(this.usernameTextBox);
        this.mainPanel.Controls.Add(this.idLabel);
        this.mainPanel.Controls.Add(this.idNumUpDown);
        this.mainPanel.Controls.Add(this.metaDataPanel);
        this.mainPanel.Dock = DockStyle.Fill;
        this.mainPanel.Location = new Point(115, 3);
        this.mainPanel.Name = "mainPanel";
        this.mainPanel.Size = new Size(896, 582);
        this.mainPanel.TabIndex = 0;
        // 
        // userRolesListBox
        // 
        this.userRolesListBox.FormattingEnabled = true;
        this.userRolesListBox.ItemHeight = 25;
        this.userRolesListBox.Location = new Point(53, 257);
        this.userRolesListBox.Name = "userRolesListBox";
        this.userRolesListBox.SelectionMode = SelectionMode.MultiExtended;
        this.userRolesListBox.Size = new Size(314, 154);
        this.userRolesListBox.TabIndex = 11;
        // 
        // employeeWhListBox
        // 
        this.employeeWhListBox.FormattingEnabled = true;
        this.employeeWhListBox.ItemHeight = 25;
        this.employeeWhListBox.Location = new Point(495, 257);
        this.employeeWhListBox.Name = "employeeWhListBox";
        this.employeeWhListBox.Size = new Size(314, 154);
        this.employeeWhListBox.TabIndex = 10;
        // 
        // passwordLabel
        // 
        this.passwordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.passwordLabel.Location = new Point(53, 132);
        this.passwordLabel.Margin = new Padding(4, 0, 4, 0);
        this.passwordLabel.Name = "passwordLabel";
        this.passwordLabel.Size = new Size(286, 50);
        this.passwordLabel.TabIndex = 9;
        this.passwordLabel.Text = "Mot de passe:";
        this.passwordLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // usernameLabel
        // 
        this.usernameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.usernameLabel.Location = new Point(53, 69);
        this.usernameLabel.Margin = new Padding(4, 0, 4, 0);
        this.usernameLabel.Name = "usernameLabel";
        this.usernameLabel.Size = new Size(286, 50);
        this.usernameLabel.TabIndex = 8;
        this.usernameLabel.Text = "Nom d'utilisateur:";
        this.usernameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // passwordTextBox
        // 
        this.passwordTextBox.Location = new Point(373, 142);
        this.passwordTextBox.Name = "passwordTextBox";
        this.passwordTextBox.Size = new Size(350, 31);
        this.passwordTextBox.TabIndex = 7;
        this.passwordTextBox.UseSystemPasswordChar = true;
        // 
        // usernameTextBox
        // 
        this.usernameTextBox.Location = new Point(373, 79);
        this.usernameTextBox.Name = "usernameTextBox";
        this.usernameTextBox.Size = new Size(350, 31);
        this.usernameTextBox.TabIndex = 6;
        // 
        // idLabel
        // 
        this.idLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.idLabel.Location = new Point(53, 6);
        this.idLabel.Margin = new Padding(4, 0, 4, 0);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(286, 50);
        this.idLabel.TabIndex = 5;
        this.idLabel.Text = "ID: ";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idNumUpDown
        // 
        this.idNumUpDown.Enabled = false;
        this.idNumUpDown.Location = new Point(373, 17);
        this.idNumUpDown.Name = "idNumUpDown";
        this.idNumUpDown.Size = new Size(350, 31);
        this.idNumUpDown.TabIndex = 4;
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
        this.metaDataPanel.Location = new Point(0, 452);
        this.metaDataPanel.Name = "metaDataPanel";
        this.metaDataPanel.Size = new Size(896, 130);
        this.metaDataPanel.TabIndex = 3;
        // 
        // dateCreatedLabel
        // 
        this.dateCreatedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.dateCreatedLabel.Location = new Point(134, 13);
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
        this.dateModifiedLabel.Location = new Point(134, 52);
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
        this.dateDeletedLabel.Location = new Point(134, 89);
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
        this.dateDeletedDTPicker.Location = new Point(442, 89);
        this.dateDeletedDTPicker.Name = "dateDeletedDTPicker";
        this.dateDeletedDTPicker.Size = new Size(300, 31);
        this.dateDeletedDTPicker.TabIndex = 0;
        // 
        // dateCreatedDTPicker
        // 
        this.dateCreatedDTPicker.Enabled = false;
        this.dateCreatedDTPicker.Location = new Point(442, 13);
        this.dateCreatedDTPicker.Name = "dateCreatedDTPicker";
        this.dateCreatedDTPicker.Size = new Size(300, 31);
        this.dateCreatedDTPicker.TabIndex = 1;
        // 
        // dateModifiedDTPicker
        // 
        this.dateModifiedDTPicker.Enabled = false;
        this.dateModifiedDTPicker.Location = new Point(442, 52);
        this.dateModifiedDTPicker.Name = "dateModifiedDTPicker";
        this.dateModifiedDTPicker.Size = new Size(300, 31);
        this.dateModifiedDTPicker.TabIndex = 2;
        // 
        // UserView
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1128, 728);
        this.Controls.Add(this.mainTableLayout);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.Name = "UserView";
        this.Text = "Gestions des utilisateurs";
        this.topBarPanel.ResumeLayout(false);
        this.topBarPanel.PerformLayout();
        this.bottomBarPanel.ResumeLayout(false);
        this.bottomBarPanel.PerformLayout();
        this.mainTableLayout.ResumeLayout(false);
        this.mainPanel.ResumeLayout(false);
        this.mainPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.idNumUpDown).EndInit();
        this.metaDataPanel.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Panel bottomBarPanel;
    private Label viewModeLabel;
    private Label viewModeValue;
    private Label copyrightLabel;
    private Button actionButton;
    private Button cancelButton;
    private TableLayoutPanel mainTableLayout;
    private Panel mainPanel;
    private DateTimePicker dateModifiedDTPicker;
    private DateTimePicker dateCreatedDTPicker;
    private DateTimePicker dateDeletedDTPicker;
    private Panel metaDataPanel;
    private Label dateModifiedLabel;
    private Label dateDeletedLabel;
    private Label dateCreatedLabel;
    private Label idLabel;
    private NumericUpDown idNumUpDown;
    private Label passwordLabel;
    private Label usernameLabel;
    private TextBox passwordTextBox;
    private TextBox usernameTextBox;
    private ListBox employeeWhListBox;
    private ListBox userRolesListBox;
}
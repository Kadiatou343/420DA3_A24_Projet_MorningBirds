namespace _420DA3_A24_Projet.Presentation;

partial class LoginWindow {
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
        this.connectionButton = new Button();
        this.passwordTextBox = new TextBox();
        this.usernameTextBox = new TextBox();
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
        this.mainTableLayout.Controls.Add(this.centrePanel, 1, 0);
        this.mainTableLayout.Dock = DockStyle.Fill;
        this.mainTableLayout.Location = new Point(0, 0);
        this.mainTableLayout.Name = "mainTableLayout";
        this.mainTableLayout.RowCount = 1;
        this.mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.mainTableLayout.Size = new Size(328, 322);
        this.mainTableLayout.TabIndex = 0;
        // 
        // centrePanel
        // 
        this.centrePanel.Controls.Add(this.cancelButton);
        this.centrePanel.Controls.Add(this.connectionButton);
        this.centrePanel.Controls.Add(this.passwordTextBox);
        this.centrePanel.Controls.Add(this.usernameTextBox);
        this.centrePanel.Dock = DockStyle.Fill;
        this.centrePanel.Location = new Point(67, 3);
        this.centrePanel.Name = "centrePanel";
        this.centrePanel.Size = new Size(194, 316);
        this.centrePanel.TabIndex = 0;
        // 
        // connectionButton
        // 
        this.connectionButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        this.connectionButton.Location = new Point(0, 215);
        this.connectionButton.Name = "connectionButton";
        this.connectionButton.Size = new Size(194, 42);
        this.connectionButton.TabIndex = 2;
        this.connectionButton.Text = "Connexion";
        this.connectionButton.UseVisualStyleBackColor = true;
        this.connectionButton.Click += this.ConnectionButton_Click;
        // 
        // passwordTextBox
        // 
        this.passwordTextBox.Location = new Point(0, 143);
        this.passwordTextBox.Name = "passwordTextBox";
        this.passwordTextBox.PlaceholderText = "Mot de passe";
        this.passwordTextBox.Size = new Size(194, 31);
        this.passwordTextBox.TabIndex = 1;
        this.passwordTextBox.TextAlign = HorizontalAlignment.Center;
        this.passwordTextBox.UseSystemPasswordChar = true;
        // 
        // usernameTextBox
        // 
        this.usernameTextBox.Location = new Point(0, 90);
        this.usernameTextBox.Name = "usernameTextBox";
        this.usernameTextBox.PlaceholderText = "Nom d'utilisateur";
        this.usernameTextBox.Size = new Size(194, 31);
        this.usernameTextBox.TabIndex = 0;
        this.usernameTextBox.TextAlign = HorizontalAlignment.Center;
        // 
        // cancelButton
        // 
        this.cancelButton.Location = new Point(3, 277);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new Size(188, 34);
        this.cancelButton.TabIndex = 3;
        this.cancelButton.Text = "Annuler";
        this.cancelButton.UseVisualStyleBackColor = true;
        this.cancelButton.Click += this.CancelButton_Click;
        // 
        // LoginWindow
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(328, 322);
        this.Controls.Add(this.mainTableLayout);
        this.Name = "LoginWindow";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Connexion";
        this.mainTableLayout.ResumeLayout(false);
        this.centrePanel.ResumeLayout(false);
        this.centrePanel.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel mainTableLayout;
    private Panel centrePanel;
    private TextBox passwordTextBox;
    private TextBox usernameTextBox;
    private Button connectionButton;
    private Button cancelButton;
}
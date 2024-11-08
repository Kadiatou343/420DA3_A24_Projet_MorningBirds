namespace Exemple_Enseignant_Avance.Presentation;

partial class MainMenu {
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
        this.button1 = new Button();
        this.SuspendLayout();
        // 
        // button1
        // 
        this.button1.Location = new Point(320, 245);
        this.button1.Name = "button1";
        this.button1.Size = new Size(134, 23);
        this.button1.TabIndex = 0;
        this.button1.Text = "Test Logging";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += this.button1_Click;
        // 
        // MainMenu
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(this.button1);
        this.Name = "MainMenu";
        this.Text = "MainMenu";
        this.FormClosing += this.MainMenu_FormClosing;
        this.ResumeLayout(false);
    }

    #endregion

    private Button button1;
}
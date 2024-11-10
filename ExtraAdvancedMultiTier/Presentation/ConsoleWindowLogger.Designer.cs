namespace ExtraAdvancedMultiTier.Presentation;

partial class ConsoleWindowLogger {
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
        this.consoleRTB = new RichTextBox();
        this.SuspendLayout();
        // 
        // consoleRTB
        // 
        this.consoleRTB.BackColor = Color.Black;
        this.consoleRTB.Dock = DockStyle.Fill;
        this.consoleRTB.Location = new Point(0, 0);
        this.consoleRTB.Name = "consoleRTB";
        this.consoleRTB.ReadOnly = true;
        this.consoleRTB.Size = new Size(584, 461);
        this.consoleRTB.TabIndex = 0;
        this.consoleRTB.Text = "";
        // 
        // ConsoleWindowLogger
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(584, 461);
        this.Controls.Add(this.consoleRTB);
        this.Name = "ConsoleWindowLogger";
        this.Text = "Console Window Logger";
        this.ResumeLayout(false);
    }

    #endregion

    private RichTextBox consoleRTB;
}
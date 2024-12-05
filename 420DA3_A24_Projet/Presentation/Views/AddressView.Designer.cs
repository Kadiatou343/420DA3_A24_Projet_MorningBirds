namespace _420DA3_A24_Projet.Presentation.Views;

partial class AddressView {
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
        this.panel3 = new Panel();
        this.flowLayoutPanel1 = new FlowLayoutPanel();
        this.panel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.flowLayoutPanel1);
        this.panel1.Dock = DockStyle.Fill;
        this.panel1.Location = new Point(0, 0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(800, 450);
        this.panel1.TabIndex = 0;
        // 
        // panel2
        // 
        this.panel2.Dock = DockStyle.Top;
        this.panel2.Location = new Point(0, 0);
        this.panel2.Name = "panel2";
        this.panel2.Size = new Size(800, 50);
        this.panel2.TabIndex = 1;
        // 
        // panel3
        // 
        this.panel3.Dock = DockStyle.Bottom;
        this.panel3.Location = new Point(0, 370);
        this.panel3.Name = "panel3";
        this.panel3.Size = new Size(800, 80);
        this.panel3.TabIndex = 1;
        // 
        // flowLayoutPanel1
        // 
        this.flowLayoutPanel1.Location = new Point(12, 67);
        this.flowLayoutPanel1.Name = "flowLayoutPanel1";
        this.flowLayoutPanel1.Size = new Size(250, 125);
        this.flowLayoutPanel1.TabIndex = 0;
        // 
        // AddressView
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(this.panel3);
        this.Controls.Add(this.panel2);
        this.Controls.Add(this.panel1);
        this.Name = "AddressView";
        this.Text = "AddressView";
        this.panel1.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Panel panel2;
    private Panel panel3;
    private FlowLayoutPanel flowLayoutPanel1;
}
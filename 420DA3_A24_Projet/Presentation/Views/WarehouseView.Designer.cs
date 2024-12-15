namespace _420DA3_A24_Projet.Presentation.Views;

partial class WarehouseView {
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
        topBarPanel = new Panel();
        bottomBarPanel = new Panel();
        centreTLP = new TableLayoutPanel();
        panel1 = new Panel();
        cancelBtn = new Button();
        actionBtn = new Button();
        idLabel = new Label();
        clientsValue = new ListBox();
        employesValue = new ListBox();
        restockValue = new ListBox();
        warehouseNameLabel = new Label();
        codePostalLabel = new Label();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        idValue = new NumericUpDown();
        nameValue = new TextBox();
        codePostalValue = new TextBox();
        bottomBarPanel.SuspendLayout();
        centreTLP.SuspendLayout();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) idValue).BeginInit();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        topBarPanel.Dock = DockStyle.Top;
        topBarPanel.Location = new Point(0, 0);
        topBarPanel.Name = "topBarPanel";
        topBarPanel.Size = new Size(784, 50);
        topBarPanel.TabIndex = 0;
        // 
        // bottomBarPanel
        // 
        bottomBarPanel.Controls.Add(actionBtn);
        bottomBarPanel.Controls.Add(cancelBtn);
        bottomBarPanel.Dock = DockStyle.Bottom;
        bottomBarPanel.Location = new Point(0, 361);
        bottomBarPanel.Name = "bottomBarPanel";
        bottomBarPanel.Size = new Size(784, 50);
        bottomBarPanel.TabIndex = 1;
        // 
        // centreTLP
        // 
        centreTLP.ColumnCount = 3;
        centreTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        centreTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 620F));
        centreTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        centreTLP.Controls.Add(panel1, 1, 0);
        centreTLP.Dock = DockStyle.Fill;
        centreTLP.Location = new Point(0, 50);
        centreTLP.Name = "centreTLP";
        centreTLP.RowCount = 1;
        centreTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        centreTLP.Size = new Size(784, 311);
        centreTLP.TabIndex = 2;
        // 
        // panel1
        // 
        panel1.Controls.Add(codePostalValue);
        panel1.Controls.Add(nameValue);
        panel1.Controls.Add(idValue);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(codePostalLabel);
        panel1.Controls.Add(warehouseNameLabel);
        panel1.Controls.Add(restockValue);
        panel1.Controls.Add(employesValue);
        panel1.Controls.Add(clientsValue);
        panel1.Controls.Add(idLabel);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(85, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(614, 305);
        panel1.TabIndex = 0;
        // 
        // cancelBtn
        // 
        cancelBtn.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        cancelBtn.Location = new Point(662, 13);
        cancelBtn.Name = "cancelBtn";
        cancelBtn.Size = new Size(110, 25);
        cancelBtn.TabIndex = 0;
        cancelBtn.Text = "Cancel";
        cancelBtn.UseVisualStyleBackColor = true;
        // 
        // actionBtn
        // 
        actionBtn.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        actionBtn.Location = new Point(527, 13);
        actionBtn.Name = "actionBtn";
        actionBtn.Size = new Size(110, 25);
        actionBtn.TabIndex = 1;
        actionBtn.Text = "PLACEHOLDER";
        actionBtn.UseVisualStyleBackColor = true;
        // 
        // idLabel
        // 
        idLabel.Location = new Point(3, 9);
        idLabel.Name = "idLabel";
        idLabel.Size = new Size(190, 20);
        idLabel.TabIndex = 0;
        idLabel.Text = "Id:";
        idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // clientsValue
        // 
        clientsValue.FormattingEnabled = true;
        clientsValue.ItemHeight = 15;
        clientsValue.Location = new Point(3, 163);
        clientsValue.Name = "clientsValue";
        clientsValue.Size = new Size(190, 139);
        clientsValue.TabIndex = 1;
        // 
        // employesValue
        // 
        employesValue.FormattingEnabled = true;
        employesValue.ItemHeight = 15;
        employesValue.Location = new Point(211, 163);
        employesValue.Name = "employesValue";
        employesValue.Size = new Size(190, 139);
        employesValue.TabIndex = 2;
        // 
        // restockValue
        // 
        restockValue.FormattingEnabled = true;
        restockValue.ItemHeight = 15;
        restockValue.Location = new Point(421, 163);
        restockValue.Name = "restockValue";
        restockValue.Size = new Size(190, 139);
        restockValue.TabIndex = 3;
        // 
        // warehouseNameLabel
        // 
        warehouseNameLabel.Location = new Point(3, 48);
        warehouseNameLabel.Name = "warehouseNameLabel";
        warehouseNameLabel.Size = new Size(190, 20);
        warehouseNameLabel.TabIndex = 4;
        warehouseNameLabel.Text = "Name:";
        warehouseNameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // codePostalLabel
        // 
        codePostalLabel.Location = new Point(3, 91);
        codePostalLabel.Name = "codePostalLabel";
        codePostalLabel.Size = new Size(190, 20);
        codePostalLabel.TabIndex = 5;
        codePostalLabel.Text = "Code Postal:";
        codePostalLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label1
        // 
        label1.Location = new Point(3, 140);
        label1.Name = "label1";
        label1.Size = new Size(190, 20);
        label1.TabIndex = 6;
        label1.Text = "Clients:";
        label1.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label2
        // 
        label2.Location = new Point(211, 140);
        label2.Name = "label2";
        label2.Size = new Size(190, 20);
        label2.TabIndex = 7;
        label2.Text = "Employees:";
        label2.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label3
        // 
        label3.Location = new Point(421, 140);
        label3.Name = "label3";
        label3.Size = new Size(190, 20);
        label3.TabIndex = 8;
        label3.Text = "Restock Orders:";
        label3.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // idValue
        // 
        idValue.Location = new Point(211, 10);
        idValue.Name = "idValue";
        idValue.Size = new Size(250, 23);
        idValue.TabIndex = 9;
        // 
        // nameValue
        // 
        nameValue.Location = new Point(211, 48);
        nameValue.Name = "nameValue";
        nameValue.PlaceholderText = "Warehouse Name";
        nameValue.Size = new Size(250, 23);
        nameValue.TabIndex = 10;
        // 
        // codePostalValue
        // 
        codePostalValue.Location = new Point(211, 91);
        codePostalValue.Name = "codePostalValue";
        codePostalValue.PlaceholderText = "Warehouse Code Postal";
        codePostalValue.Size = new Size(250, 23);
        codePostalValue.TabIndex = 11;
        // 
        // WarehouseView
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(784, 411);
        this.Controls.Add(centreTLP);
        this.Controls.Add(bottomBarPanel);
        this.Controls.Add(topBarPanel);
        this.MinimumSize = new Size(800, 450);
        this.Name = "WarehouseView";
        this.Text = "WarehouseView";
        bottomBarPanel.ResumeLayout(false);
        centreTLP.ResumeLayout(false);
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) idValue).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Panel bottomBarPanel;
    private TableLayoutPanel centreTLP;
    private Panel panel1;
    private Button actionBtn;
    private Button cancelBtn;
    private Label idLabel;
    private ListBox clientsValue;
    private ListBox restockValue;
    private ListBox employesValue;
    private Label warehouseNameLabel;
    private Label codePostalLabel;
    private Label label1;
    private Label label3;
    private Label label2;
    private NumericUpDown idValue;
    private TextBox nameValue;
    private TextBox codePostalValue;
}
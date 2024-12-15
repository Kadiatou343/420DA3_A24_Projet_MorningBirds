namespace _420DA3_A24_Projet.Presentation.Views;

partial class ShippingOrderView {
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
        this.panelTop = new Panel();
        this.middleTLP = new TableLayoutPanel();
        this.midPanel = new Panel();
        this.shipmentValue = new ListBox();
        this.label3 = new Label();
        this.btnAction = new Button();
        this.btnCancel = new Button();
        this.ClientValue = new ListBox();
        this.label1 = new Label();
        this.EmployeValue = new ListBox();
        this.label2 = new Label();
        this.userValue = new ListBox();
        this.label10 = new Label();
        this.AdressValue = new ListBox();
        this.label9 = new Label();
        this.idValue = new NumericUpDown();
        this.idLabel = new Label();
        this.middleTLP.SuspendLayout();
        this.midPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.idValue).BeginInit();
        this.SuspendLayout();
        // 
        // panelTop
        // 
        this.panelTop.Dock = DockStyle.Top;
        this.panelTop.Location = new Point(0, 0);
        this.panelTop.Margin = new Padding(5);
        this.panelTop.Name = "panelTop";
        this.panelTop.Size = new Size(1512, 120);
        this.panelTop.TabIndex = 10;
        // 
        // middleTLP
        // 
        this.middleTLP.ColumnCount = 3;
        this.middleTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.middleTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1138F));
        this.middleTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.middleTLP.Controls.Add(this.midPanel, 1, 0);
        this.middleTLP.Dock = DockStyle.Fill;
        this.middleTLP.Location = new Point(0, 120);
        this.middleTLP.Margin = new Padding(5);
        this.middleTLP.Name = "middleTLP";
        this.middleTLP.RowCount = 1;
        this.middleTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.middleTLP.Size = new Size(1512, 957);
        this.middleTLP.TabIndex = 11;
        // 
        // midPanel
        // 
        this.midPanel.Controls.Add(this.shipmentValue);
        this.midPanel.Controls.Add(this.label3);
        this.midPanel.Controls.Add(this.btnAction);
        this.midPanel.Controls.Add(this.btnCancel);
        this.midPanel.Controls.Add(this.ClientValue);
        this.midPanel.Controls.Add(this.label1);
        this.midPanel.Controls.Add(this.EmployeValue);
        this.midPanel.Controls.Add(this.label2);
        this.midPanel.Controls.Add(this.userValue);
        this.midPanel.Controls.Add(this.label10);
        this.midPanel.Controls.Add(this.AdressValue);
        this.midPanel.Controls.Add(this.label9);
        this.midPanel.Controls.Add(this.idValue);
        this.midPanel.Controls.Add(this.idLabel);
        this.midPanel.Dock = DockStyle.Fill;
        this.midPanel.Location = new Point(192, 5);
        this.midPanel.Margin = new Padding(5);
        this.midPanel.Name = "midPanel";
        this.midPanel.Size = new Size(1128, 947);
        this.midPanel.TabIndex = 0;
        // 
        // shipmentValue
        // 
        this.shipmentValue.FormattingEnabled = true;
        this.shipmentValue.ItemHeight = 32;
        this.shipmentValue.Location = new Point(35, 692);
        this.shipmentValue.Margin = new Padding(5);
        this.shipmentValue.Name = "shipmentValue";
        this.shipmentValue.Size = new Size(547, 228);
        this.shipmentValue.TabIndex = 31;
        // 
        // label3
        // 
        this.label3.Location = new Point(220, 646);
        this.label3.Margin = new Padding(5, 0, 5, 0);
        this.label3.Name = "label3";
        this.label3.Size = new Size(190, 42);
        this.label3.TabIndex = 30;
        this.label3.Text = "Shippement ID :";
        this.label3.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnAction
        // 
        this.btnAction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnAction.Location = new Point(693, 822);
        this.btnAction.Margin = new Padding(5);
        this.btnAction.Name = "btnAction";
        this.btnAction.Size = new Size(210, 91);
        this.btnAction.TabIndex = 29;
        this.btnAction.Text = "ACTION";
        this.btnAction.UseVisualStyleBackColor = true;
        this.btnAction.Click += this.btnAction_Click;
        // 
        // btnCancel
        // 
        this.btnCancel.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnCancel.Location = new Point(913, 822);
        this.btnCancel.Margin = new Padding(5);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new Size(210, 91);
        this.btnCancel.TabIndex = 28;
        this.btnCancel.Text = "Cancel";
        this.btnCancel.UseVisualStyleBackColor = true;
        this.btnCancel.Click += this.btnCancel_Click;
        // 
        // ClientValue
        // 
        this.ClientValue.FormattingEnabled = true;
        this.ClientValue.ItemHeight = 32;
        this.ClientValue.Location = new Point(17, 399);
        this.ClientValue.Margin = new Padding(5);
        this.ClientValue.Name = "ClientValue";
        this.ClientValue.Size = new Size(547, 196);
        this.ClientValue.TabIndex = 27;
        // 
        // label1
        // 
        this.label1.Location = new Point(202, 353);
        this.label1.Margin = new Padding(5, 0, 5, 0);
        this.label1.Name = "label1";
        this.label1.Size = new Size(190, 42);
        this.label1.TabIndex = 26;
        this.label1.Text = "Client ID :";
        this.label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // EmployeValue
        // 
        this.EmployeValue.FormattingEnabled = true;
        this.EmployeValue.ItemHeight = 32;
        this.EmployeValue.Location = new Point(17, 118);
        this.EmployeValue.Margin = new Padding(5);
        this.EmployeValue.Name = "EmployeValue";
        this.EmployeValue.Size = new Size(547, 196);
        this.EmployeValue.TabIndex = 25;
        // 
        // label2
        // 
        this.label2.Location = new Point(202, 75);
        this.label2.Margin = new Padding(5, 0, 5, 0);
        this.label2.Name = "label2";
        this.label2.Size = new Size(190, 42);
        this.label2.TabIndex = 24;
        this.label2.Text = "Employe ID :";
        this.label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // userValue
        // 
        this.userValue.FormattingEnabled = true;
        this.userValue.ItemHeight = 32;
        this.userValue.Location = new Point(581, 399);
        this.userValue.Margin = new Padding(5);
        this.userValue.Name = "userValue";
        this.userValue.Size = new Size(547, 196);
        this.userValue.TabIndex = 23;
        // 
        // label10
        // 
        this.label10.Location = new Point(766, 353);
        this.label10.Margin = new Padding(5, 0, 5, 0);
        this.label10.Name = "label10";
        this.label10.Size = new Size(190, 42);
        this.label10.TabIndex = 22;
        this.label10.Text = "User ID :";
        this.label10.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // AdressValue
        // 
        this.AdressValue.FormattingEnabled = true;
        this.AdressValue.ItemHeight = 32;
        this.AdressValue.Location = new Point(581, 118);
        this.AdressValue.Margin = new Padding(5);
        this.AdressValue.Name = "AdressValue";
        this.AdressValue.Size = new Size(547, 196);
        this.AdressValue.TabIndex = 21;
        // 
        // label9
        // 
        this.label9.Location = new Point(766, 75);
        this.label9.Margin = new Padding(5, 0, 5, 0);
        this.label9.Name = "label9";
        this.label9.Size = new Size(190, 42);
        this.label9.TabIndex = 20;
        this.label9.Text = "Adress ID :";
        this.label9.TextAlign = ContentAlignment.MiddleCenter;
        this.label9.Click += this.label9_Click_1;
        // 
        // idValue
        // 
        this.idValue.Enabled = false;
        this.idValue.Location = new Point(205, 26);
        this.idValue.Margin = new Padding(5);
        this.idValue.Maximum = new decimal(new int[] { 30000000, 0, 0, 0 });
        this.idValue.Name = "idValue";
        this.idValue.Size = new Size(344, 39);
        this.idValue.TabIndex = 11;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(5, 24);
        this.idLabel.Margin = new Padding(5, 0, 5, 0);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(190, 42);
        this.idLabel.TabIndex = 2;
        this.idLabel.Text = "Id :";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // ShippingOrderView
        // 
        this.AutoScaleDimensions = new SizeF(13F, 32F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1512, 1077);
        this.Controls.Add(this.middleTLP);
        this.Controls.Add(this.panelTop);
        this.Name = "ShippingOrderView";
        this.Text = "ShippingOrderView";
        this.Load += this.ShippingOrderView_Load;
        this.middleTLP.ResumeLayout(false);
        this.midPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize) this.idValue).EndInit();
        this.ResumeLayout(false);
    }

    #endregion
    private Panel panelTop;
    private TableLayoutPanel middleTLP;
    private Panel midPanel;
    private ListBox userValue;
    private Label label10;
    private ListBox AdressValue;
    private Label label9;
    private NumericUpDown idValue;
    private Label idLabel;
    private ListBox ClientValue;
    private Label label1;
    private ListBox EmployeValue;
    private Label label2;
    private Button btnAction;
    private Button btnCancel;
    private ListBox shipmentValue;
    private Label label3;
}
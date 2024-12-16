namespace _420DA3_A24_Projet.Presentation.Views;

partial class PurchaseOrderView {
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
        this.middleTLP = new TableLayoutPanel();
        this.midPanel = new Panel();
        this.button1 = new Button();
        this.button2 = new Button();
        this.quantiteValue = new NumericUpDown();
        this.label1 = new Label();
        this.btnAction = new Button();
        this.btnCancel = new Button();
        this.produitValue = new ListBox();
        this.label2 = new Label();
        this.WarehouseValue = new ListBox();
        this.label9 = new Label();
        this.idValue = new NumericUpDown();
        this.idLabel = new Label();
        this.panelTop = new Panel();
        this.middleTLP.SuspendLayout();
        this.midPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.quantiteValue).BeginInit();
        ((System.ComponentModel.ISupportInitialize) this.idValue).BeginInit();
        this.SuspendLayout();
        // 
        // middleTLP
        // 
        this.middleTLP.ColumnCount = 3;
        this.middleTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.middleTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 875F));
        this.middleTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.middleTLP.Controls.Add(this.midPanel, 1, 0);
        this.middleTLP.Dock = DockStyle.Fill;
        this.middleTLP.Location = new Point(0, 94);
        this.middleTLP.Margin = new Padding(4, 4, 4, 4);
        this.middleTLP.Name = "middleTLP";
        this.middleTLP.RowCount = 1;
        this.middleTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.middleTLP.Size = new Size(1122, 391);
        this.middleTLP.TabIndex = 13;
        // 
        // midPanel
        // 
        this.midPanel.Controls.Add(this.button1);
        this.midPanel.Controls.Add(this.button2);
        this.midPanel.Controls.Add(this.quantiteValue);
        this.midPanel.Controls.Add(this.label1);
        this.midPanel.Controls.Add(this.btnAction);
        this.midPanel.Controls.Add(this.btnCancel);
        this.midPanel.Controls.Add(this.produitValue);
        this.midPanel.Controls.Add(this.label2);
        this.midPanel.Controls.Add(this.WarehouseValue);
        this.midPanel.Controls.Add(this.label9);
        this.midPanel.Controls.Add(this.idValue);
        this.midPanel.Controls.Add(this.idLabel);
        this.midPanel.Dock = DockStyle.Fill;
        this.midPanel.Location = new Point(127, 4);
        this.midPanel.Margin = new Padding(4, 4, 4, 4);
        this.midPanel.Name = "midPanel";
        this.midPanel.Size = new Size(867, 383);
        this.midPanel.TabIndex = 0;
        // 
        // button1
        // 
        this.button1.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.button1.Location = new Point(505, 273);
        this.button1.Margin = new Padding(4, 4, 4, 4);
        this.button1.Name = "button1";
        this.button1.Size = new Size(162, 71);
        this.button1.TabIndex = 33;
        this.button1.Text = "ACTION";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += this.button1_Click;
        // 
        // button2
        // 
        this.button2.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.button2.Location = new Point(674, 273);
        this.button2.Margin = new Padding(4, 4, 4, 4);
        this.button2.Name = "button2";
        this.button2.Size = new Size(162, 71);
        this.button2.TabIndex = 32;
        this.button2.Text = "Cancel";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Click += this.button2_Click;
        // 
        // quantiteValue
        // 
        this.quantiteValue.Enabled = false;
        this.quantiteValue.Location = new Point(169, 288);
        this.quantiteValue.Margin = new Padding(4, 4, 4, 4);
        this.quantiteValue.Maximum = new decimal(new int[] { 30000000, 0, 0, 0 });
        this.quantiteValue.Name = "quantiteValue";
        this.quantiteValue.Size = new Size(265, 31);
        this.quantiteValue.TabIndex = 31;
        // 
        // label1
        // 
        this.label1.Location = new Point(15, 286);
        this.label1.Margin = new Padding(4, 0, 4, 0);
        this.label1.Name = "label1";
        this.label1.Size = new Size(146, 33);
        this.label1.TabIndex = 30;
        this.label1.Text = "Quantite :";
        this.label1.TextAlign = ContentAlignment.MiddleRight;
        // 
        // btnAction
        // 
        this.btnAction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnAction.Location = new Point(1246, 947);
        this.btnAction.Margin = new Padding(4, 4, 4, 4);
        this.btnAction.Name = "btnAction";
        this.btnAction.Size = new Size(162, 71);
        this.btnAction.TabIndex = 29;
        this.btnAction.Text = "ACTION";
        this.btnAction.UseVisualStyleBackColor = true;
        // 
        // btnCancel
        // 
        this.btnCancel.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnCancel.Location = new Point(1415, 947);
        this.btnCancel.Margin = new Padding(4, 4, 4, 4);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new Size(162, 71);
        this.btnCancel.TabIndex = 28;
        this.btnCancel.Text = "Cancel";
        this.btnCancel.UseVisualStyleBackColor = true;
        // 
        // produitValue
        // 
        this.produitValue.FormattingEnabled = true;
        this.produitValue.ItemHeight = 25;
        this.produitValue.Location = new Point(13, 92);
        this.produitValue.Margin = new Padding(4, 4, 4, 4);
        this.produitValue.Name = "produitValue";
        this.produitValue.Size = new Size(422, 154);
        this.produitValue.TabIndex = 25;
        // 
        // label2
        // 
        this.label2.Location = new Point(155, 59);
        this.label2.Margin = new Padding(4, 0, 4, 0);
        this.label2.Name = "label2";
        this.label2.Size = new Size(146, 33);
        this.label2.TabIndex = 24;
        this.label2.Text = "Produit ID :";
        this.label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // WarehouseValue
        // 
        this.WarehouseValue.FormattingEnabled = true;
        this.WarehouseValue.ItemHeight = 25;
        this.WarehouseValue.Location = new Point(447, 92);
        this.WarehouseValue.Margin = new Padding(4, 4, 4, 4);
        this.WarehouseValue.Name = "WarehouseValue";
        this.WarehouseValue.Size = new Size(422, 154);
        this.WarehouseValue.TabIndex = 21;
        // 
        // label9
        // 
        this.label9.Location = new Point(589, 59);
        this.label9.Margin = new Padding(4, 0, 4, 0);
        this.label9.Name = "label9";
        this.label9.Size = new Size(146, 33);
        this.label9.TabIndex = 20;
        this.label9.Text = "Warehouse ID :";
        this.label9.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // idValue
        // 
        this.idValue.Enabled = false;
        this.idValue.Location = new Point(158, 20);
        this.idValue.Margin = new Padding(4, 4, 4, 4);
        this.idValue.Maximum = new decimal(new int[] { 30000000, 0, 0, 0 });
        this.idValue.Name = "idValue";
        this.idValue.Size = new Size(265, 31);
        this.idValue.TabIndex = 11;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(4, 19);
        this.idLabel.Margin = new Padding(4, 0, 4, 0);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(146, 33);
        this.idLabel.TabIndex = 2;
        this.idLabel.Text = "Id :";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // panelTop
        // 
        this.panelTop.Dock = DockStyle.Top;
        this.panelTop.Location = new Point(0, 0);
        this.panelTop.Margin = new Padding(4, 4, 4, 4);
        this.panelTop.Name = "panelTop";
        this.panelTop.Size = new Size(1122, 94);
        this.panelTop.TabIndex = 12;
        // 
        // PurchaseOrderView
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1122, 485);
        this.Controls.Add(this.middleTLP);
        this.Controls.Add(this.panelTop);
        this.Margin = new Padding(2, 2, 2, 2);
        this.Name = "PurchaseOrderView";
        this.Text = "PurchaseOrderView";
        this.middleTLP.ResumeLayout(false);
        this.midPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize) this.quantiteValue).EndInit();
        ((System.ComponentModel.ISupportInitialize) this.idValue).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel middleTLP;
    private Panel midPanel;
    private Button btnAction;
    private Button btnCancel;
    private ListBox produitValue;
    private Label label2;
    private ListBox WarehouseValue;
    private Label label9;
    private NumericUpDown idValue;
    private Label idLabel;
    private Panel panelTop;
    private NumericUpDown quantiteValue;
    private Label label1;
    private Button button1;
    private Button button2;
}
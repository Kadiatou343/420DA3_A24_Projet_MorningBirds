namespace _420DA3_A24_Projet.Presentation.Views;

partial class ProductView {
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
        this.clientIdValue = new ListBox();
        this.label10 = new Label();
        this.supplierIdValue = new ListBox();
        this.label9 = new Label();
        this.pictureNameValue = new TextBox();
        this.supplierCodeValue = new TextBox();
        this.codeUpcValue = new TextBox();
        this.descValue = new TextBox();
        this.nameValue = new TextBox();
        this.weightValue = new NumericUpDown();
        this.aimQuantityValue = new NumericUpDown();
        this.quantityValue = new NumericUpDown();
        this.idValue = new NumericUpDown();
        this.label8 = new Label();
        this.label7 = new Label();
        this.label6 = new Label();
        this.label5 = new Label();
        this.label4 = new Label();
        this.label3 = new Label();
        this.label2 = new Label();
        this.label1 = new Label();
        this.idLabel = new Label();
        this.middleTLP = new TableLayoutPanel();
        this.midPanel = new Panel();
        this.actionBtn = new Button();
        this.cancelBtn = new Button();
        this.panelButtom = new Panel();
        this.btnAction = new Button();
        this.btnCancel = new Button();
        this.panelTop = new Panel();
        ((System.ComponentModel.ISupportInitialize) this.weightValue).BeginInit();
        ((System.ComponentModel.ISupportInitialize) this.aimQuantityValue).BeginInit();
        ((System.ComponentModel.ISupportInitialize) this.quantityValue).BeginInit();
        ((System.ComponentModel.ISupportInitialize) this.idValue).BeginInit();
        this.middleTLP.SuspendLayout();
        this.midPanel.SuspendLayout();
        this.panelButtom.SuspendLayout();
        this.SuspendLayout();
        // 
        // clientIdValue
        // 
        this.clientIdValue.FormattingEnabled = true;
        this.clientIdValue.ItemHeight = 20;
        this.clientIdValue.Location = new Point(353, 219);
        this.clientIdValue.Name = "clientIdValue";
        this.clientIdValue.Size = new Size(338, 164);
        this.clientIdValue.TabIndex = 23;
        this.clientIdValue.SelectedIndexChanged += this.clientIdValue_SelectedIndexChanged;
        // 
        // label10
        // 
        this.label10.Location = new Point(467, 190);
        this.label10.Name = "label10";
        this.label10.Size = new Size(117, 26);
        this.label10.TabIndex = 22;
        this.label10.Text = "Client ID :";
        this.label10.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // supplierIdValue
        // 
        this.supplierIdValue.FormattingEnabled = true;
        this.supplierIdValue.ItemHeight = 20;
        this.supplierIdValue.Location = new Point(353, 43);
        this.supplierIdValue.Name = "supplierIdValue";
        this.supplierIdValue.Size = new Size(338, 144);
        this.supplierIdValue.TabIndex = 21;
        this.supplierIdValue.SelectedIndexChanged += this.supplierIdValue_SelectedIndexChanged;
        // 
        // label9
        // 
        this.label9.Location = new Point(467, 16);
        this.label9.Name = "label9";
        this.label9.Size = new Size(117, 26);
        this.label9.TabIndex = 20;
        this.label9.Text = "Supplier ID :";
        this.label9.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pictureNameValue
        // 
        this.pictureNameValue.Location = new Point(126, 361);
        this.pictureNameValue.Name = "pictureNameValue";
        this.pictureNameValue.PlaceholderText = "Picture of the product";
        this.pictureNameValue.Size = new Size(212, 27);
        this.pictureNameValue.TabIndex = 19;
        // 
        // supplierCodeValue
        // 
        this.supplierCodeValue.Location = new Point(126, 175);
        this.supplierCodeValue.Name = "supplierCodeValue";
        this.supplierCodeValue.PlaceholderText = "Code of the Supplier";
        this.supplierCodeValue.Size = new Size(212, 27);
        this.supplierCodeValue.TabIndex = 18;
        // 
        // codeUpcValue
        // 
        this.codeUpcValue.Location = new Point(126, 133);
        this.codeUpcValue.Name = "codeUpcValue";
        this.codeUpcValue.PlaceholderText = "Code UPC of product";
        this.codeUpcValue.Size = new Size(212, 27);
        this.codeUpcValue.TabIndex = 17;
        // 
        // descValue
        // 
        this.descValue.Location = new Point(126, 94);
        this.descValue.Name = "descValue";
        this.descValue.PlaceholderText = "Description of product";
        this.descValue.Size = new Size(212, 27);
        this.descValue.TabIndex = 16;
        // 
        // nameValue
        // 
        this.nameValue.Location = new Point(126, 56);
        this.nameValue.Name = "nameValue";
        this.nameValue.PlaceholderText = "Name of product";
        this.nameValue.Size = new Size(212, 27);
        this.nameValue.TabIndex = 15;
        // 
        // weightValue
        // 
        this.weightValue.Enabled = false;
        this.weightValue.Location = new Point(126, 315);
        this.weightValue.Maximum = new decimal(new int[] { 30000000, 0, 0, 0 });
        this.weightValue.Name = "weightValue";
        this.weightValue.Size = new Size(212, 27);
        this.weightValue.TabIndex = 14;
        // 
        // aimQuantityValue
        // 
        this.aimQuantityValue.Enabled = false;
        this.aimQuantityValue.Location = new Point(126, 262);
        this.aimQuantityValue.Maximum = new decimal(new int[] { 30000000, 0, 0, 0 });
        this.aimQuantityValue.Name = "aimQuantityValue";
        this.aimQuantityValue.Size = new Size(212, 27);
        this.aimQuantityValue.TabIndex = 13;
        // 
        // quantityValue
        // 
        this.quantityValue.Enabled = false;
        this.quantityValue.Location = new Point(126, 220);
        this.quantityValue.Maximum = new decimal(new int[] { 30000000, 0, 0, 0 });
        this.quantityValue.Name = "quantityValue";
        this.quantityValue.Size = new Size(212, 27);
        this.quantityValue.TabIndex = 12;
        // 
        // idValue
        // 
        this.idValue.Enabled = false;
        this.idValue.Location = new Point(126, 16);
        this.idValue.Maximum = new decimal(new int[] { 30000000, 0, 0, 0 });
        this.idValue.Name = "idValue";
        this.idValue.Size = new Size(212, 27);
        this.idValue.TabIndex = 11;
        // 
        // label8
        // 
        this.label8.Location = new Point(3, 361);
        this.label8.Name = "label8";
        this.label8.Size = new Size(117, 26);
        this.label8.TabIndex = 10;
        this.label8.Text = "Picture Name :";
        this.label8.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label7
        // 
        this.label7.Location = new Point(3, 314);
        this.label7.Name = "label7";
        this.label7.Size = new Size(117, 26);
        this.label7.TabIndex = 9;
        this.label7.Text = "Weight :";
        this.label7.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label6
        // 
        this.label6.Location = new Point(3, 261);
        this.label6.Name = "label6";
        this.label6.Size = new Size(117, 26);
        this.label6.TabIndex = 8;
        this.label6.Text = "Aim Quantity :";
        this.label6.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label5
        // 
        this.label5.Location = new Point(3, 219);
        this.label5.Name = "label5";
        this.label5.Size = new Size(117, 26);
        this.label5.TabIndex = 7;
        this.label5.Text = "Quantity :";
        this.label5.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label4
        // 
        this.label4.Location = new Point(3, 176);
        this.label4.Name = "label4";
        this.label4.Size = new Size(117, 26);
        this.label4.TabIndex = 6;
        this.label4.Text = "Supplier Code :";
        this.label4.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label3
        // 
        this.label3.Location = new Point(3, 133);
        this.label3.Name = "label3";
        this.label3.Size = new Size(117, 26);
        this.label3.TabIndex = 5;
        this.label3.Text = "Code UPC :";
        this.label3.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label2
        // 
        this.label2.Location = new Point(3, 94);
        this.label2.Name = "label2";
        this.label2.Size = new Size(117, 26);
        this.label2.TabIndex = 4;
        this.label2.Text = "Description :";
        this.label2.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label1
        // 
        this.label1.Location = new Point(3, 56);
        this.label1.Name = "label1";
        this.label1.Size = new Size(117, 26);
        this.label1.TabIndex = 3;
        this.label1.Text = "Name :";
        this.label1.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(3, 15);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(117, 26);
        this.idLabel.TabIndex = 2;
        this.idLabel.Text = "Id :";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // middleTLP
        // 
        this.middleTLP.ColumnCount = 3;
        this.middleTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.middleTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 700F));
        this.middleTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.middleTLP.Controls.Add(this.midPanel, 1, 0);
        this.middleTLP.Dock = DockStyle.Fill;
        this.middleTLP.Location = new Point(0, 75);
        this.middleTLP.Name = "middleTLP";
        this.middleTLP.RowCount = 1;
        this.middleTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.middleTLP.Size = new Size(891, 409);
        this.middleTLP.TabIndex = 5;
        // 
        // midPanel
        // 
        this.midPanel.Controls.Add(this.clientIdValue);
        this.midPanel.Controls.Add(this.label10);
        this.midPanel.Controls.Add(this.supplierIdValue);
        this.midPanel.Controls.Add(this.label9);
        this.midPanel.Controls.Add(this.pictureNameValue);
        this.midPanel.Controls.Add(this.supplierCodeValue);
        this.midPanel.Controls.Add(this.codeUpcValue);
        this.midPanel.Controls.Add(this.descValue);
        this.midPanel.Controls.Add(this.nameValue);
        this.midPanel.Controls.Add(this.weightValue);
        this.midPanel.Controls.Add(this.aimQuantityValue);
        this.midPanel.Controls.Add(this.quantityValue);
        this.midPanel.Controls.Add(this.idValue);
        this.midPanel.Controls.Add(this.label8);
        this.midPanel.Controls.Add(this.label7);
        this.midPanel.Controls.Add(this.label6);
        this.midPanel.Controls.Add(this.label5);
        this.midPanel.Controls.Add(this.label4);
        this.midPanel.Controls.Add(this.label3);
        this.midPanel.Controls.Add(this.label2);
        this.midPanel.Controls.Add(this.label1);
        this.midPanel.Controls.Add(this.idLabel);
        this.midPanel.Dock = DockStyle.Fill;
        this.midPanel.Location = new Point(98, 3);
        this.midPanel.Name = "midPanel";
        this.midPanel.Size = new Size(694, 403);
        this.midPanel.TabIndex = 0;
        // 
        // actionBtn
        // 
        this.actionBtn.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.actionBtn.Location = new Point(1268, -19);
        this.actionBtn.Name = "actionBtn";
        this.actionBtn.Size = new Size(129, 57);
        this.actionBtn.TabIndex = 3;
        this.actionBtn.Text = "ACTION";
        this.actionBtn.UseVisualStyleBackColor = true;
        // 
        // cancelBtn
        // 
        this.cancelBtn.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.cancelBtn.Location = new Point(1403, -19);
        this.cancelBtn.Name = "cancelBtn";
        this.cancelBtn.Size = new Size(129, 57);
        this.cancelBtn.TabIndex = 2;
        this.cancelBtn.Text = "Cancel";
        this.cancelBtn.UseVisualStyleBackColor = true;
        // 
        // panelButtom
        // 
        this.panelButtom.Controls.Add(this.btnAction);
        this.panelButtom.Controls.Add(this.btnCancel);
        this.panelButtom.Controls.Add(this.actionBtn);
        this.panelButtom.Controls.Add(this.cancelBtn);
        this.panelButtom.Dock = DockStyle.Bottom;
        this.panelButtom.Location = new Point(0, 484);
        this.panelButtom.Name = "panelButtom";
        this.panelButtom.Size = new Size(891, 75);
        this.panelButtom.TabIndex = 4;
        // 
        // btnAction
        // 
        this.btnAction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnAction.Location = new Point(615, 6);
        this.btnAction.Name = "btnAction";
        this.btnAction.Size = new Size(129, 57);
        this.btnAction.TabIndex = 5;
        this.btnAction.Text = "ACTION";
        this.btnAction.UseVisualStyleBackColor = true;
        this.btnAction.Click += this.btnAction_Click;
        // 
        // btnCancel
        // 
        this.btnCancel.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnCancel.Location = new Point(750, 6);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new Size(129, 57);
        this.btnCancel.TabIndex = 4;
        this.btnCancel.Text = "Cancel";
        this.btnCancel.UseVisualStyleBackColor = true;
        this.btnCancel.Click += this.btnCancel_Click;
        // 
        // panelTop
        // 
        this.panelTop.Dock = DockStyle.Top;
        this.panelTop.Location = new Point(0, 0);
        this.panelTop.Name = "panelTop";
        this.panelTop.Size = new Size(891, 75);
        this.panelTop.TabIndex = 3;
        // 
        // ProductView
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(891, 559);
        this.Controls.Add(this.middleTLP);
        this.Controls.Add(this.panelButtom);
        this.Controls.Add(this.panelTop);
        this.Name = "ProductView";
        this.Text = "ProductView";
        ((System.ComponentModel.ISupportInitialize) this.weightValue).EndInit();
        ((System.ComponentModel.ISupportInitialize) this.aimQuantityValue).EndInit();
        ((System.ComponentModel.ISupportInitialize) this.quantityValue).EndInit();
        ((System.ComponentModel.ISupportInitialize) this.idValue).EndInit();
        this.middleTLP.ResumeLayout(false);
        this.midPanel.ResumeLayout(false);
        this.midPanel.PerformLayout();
        this.panelButtom.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private ListBox clientIdValue;
    private Label label10;
    private ListBox supplierIdValue;
    private Label label9;
    private TextBox pictureNameValue;
    private TextBox supplierCodeValue;
    private TextBox codeUpcValue;
    private TextBox descValue;
    private TextBox nameValue;
    private NumericUpDown weightValue;
    private NumericUpDown aimQuantityValue;
    private NumericUpDown quantityValue;
    private NumericUpDown idValue;
    private Label label8;
    private Label label7;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private Label idLabel;
    private TableLayoutPanel middleTLP;
    private Panel midPanel;
    private Button actionBtn;
    private Button cancelBtn;
    private Panel panelButtom;
    private Panel panelTop;
    private Button btnAction;
    private Button btnCancel;
}
namespace _420DA3_A24_Projet.Presentation.Views;

partial class SupplierView {
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
        this.btnCancel = new Button();
        this.productsValue = new ListBox();
        this.label9 = new Label();
        this.ctcPhoneValue = new TextBox();
        this.ctcEmailValue = new TextBox();
        this.ctcFirstNameValue = new TextBox();
        this.ctcLastNameValue = new TextBox();
        this.supplierNameValue = new TextBox();
        this.panelButtom = new Panel();
        this.actionBtn = new Button();
        this.cancelBtn = new Button();
        this.btnAction = new Button();
        this.midPanel = new Panel();
        this.idValue = new NumericUpDown();
        this.label5 = new Label();
        this.label4 = new Label();
        this.label3 = new Label();
        this.label2 = new Label();
        this.label1 = new Label();
        this.idLabel = new Label();
        this.middleTLP = new TableLayoutPanel();
        this.panelTop = new Panel();
        this.panelButtom.SuspendLayout();
        this.midPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.idValue).BeginInit();
        this.middleTLP.SuspendLayout();
        this.SuspendLayout();
        // 
        // btnCancel
        // 
        this.btnCancel.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnCancel.Location = new Point(1005, -19);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new Size(129, 57);
        this.btnCancel.TabIndex = 4;
        this.btnCancel.Text = "Cancel";
        this.btnCancel.UseVisualStyleBackColor = true;
        // 
        // productsValue
        // 
        this.productsValue.FormattingEnabled = true;
        this.productsValue.ItemHeight = 20;
        this.productsValue.Location = new Point(0, 311);
        this.productsValue.Name = "productsValue";
        this.productsValue.SelectionMode = SelectionMode.MultiSimple;
        this.productsValue.Size = new Size(391, 144);
        this.productsValue.TabIndex = 21;
        // 
        // label9
        // 
        this.label9.Location = new Point(3, 282);
        this.label9.Name = "label9";
        this.label9.Size = new Size(388, 26);
        this.label9.TabIndex = 20;
        this.label9.Text = "Products :";
        this.label9.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // ctcPhoneValue
        // 
        this.ctcPhoneValue.Location = new Point(148, 219);
        this.ctcPhoneValue.Name = "ctcPhoneValue";
        this.ctcPhoneValue.PlaceholderText = "Contact Phone Number";
        this.ctcPhoneValue.Size = new Size(243, 27);
        this.ctcPhoneValue.TabIndex = 19;
        // 
        // ctcEmailValue
        // 
        this.ctcEmailValue.Location = new Point(148, 175);
        this.ctcEmailValue.Name = "ctcEmailValue";
        this.ctcEmailValue.PlaceholderText = "Contact Email";
        this.ctcEmailValue.Size = new Size(243, 27);
        this.ctcEmailValue.TabIndex = 18;
        // 
        // ctcFirstNameValue
        // 
        this.ctcFirstNameValue.Location = new Point(148, 132);
        this.ctcFirstNameValue.Name = "ctcFirstNameValue";
        this.ctcFirstNameValue.PlaceholderText = "Contact First Name";
        this.ctcFirstNameValue.Size = new Size(243, 27);
        this.ctcFirstNameValue.TabIndex = 17;
        // 
        // ctcLastNameValue
        // 
        this.ctcLastNameValue.Location = new Point(148, 94);
        this.ctcLastNameValue.Name = "ctcLastNameValue";
        this.ctcLastNameValue.PlaceholderText = "Contact Last Name";
        this.ctcLastNameValue.Size = new Size(243, 27);
        this.ctcLastNameValue.TabIndex = 16;
        // 
        // supplierNameValue
        // 
        this.supplierNameValue.Location = new Point(148, 55);
        this.supplierNameValue.Name = "supplierNameValue";
        this.supplierNameValue.PlaceholderText = "Name of the supplier";
        this.supplierNameValue.Size = new Size(243, 27);
        this.supplierNameValue.TabIndex = 15;
        // 
        // panelButtom
        // 
        this.panelButtom.Controls.Add(this.actionBtn);
        this.panelButtom.Controls.Add(this.cancelBtn);
        this.panelButtom.Controls.Add(this.btnAction);
        this.panelButtom.Controls.Add(this.btnCancel);
        this.panelButtom.Dock = DockStyle.Bottom;
        this.panelButtom.Location = new Point(0, 545);
        this.panelButtom.Name = "panelButtom";
        this.panelButtom.Size = new Size(455, 75);
        this.panelButtom.TabIndex = 7;
        // 
        // actionBtn
        // 
        this.actionBtn.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.actionBtn.Location = new Point(179, 15);
        this.actionBtn.Name = "actionBtn";
        this.actionBtn.Size = new Size(129, 54);
        this.actionBtn.TabIndex = 7;
        this.actionBtn.Text = "ACTION";
        this.actionBtn.UseVisualStyleBackColor = true;
        this.actionBtn.Click += this.actionBtn_Click;
        // 
        // cancelBtn
        // 
        this.cancelBtn.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.cancelBtn.Location = new Point(314, 15);
        this.cancelBtn.Name = "cancelBtn";
        this.cancelBtn.Size = new Size(129, 54);
        this.cancelBtn.TabIndex = 6;
        this.cancelBtn.Text = "Cancel";
        this.cancelBtn.UseVisualStyleBackColor = true;
        this.cancelBtn.Click += this.cancelBtn_Click;
        // 
        // btnAction
        // 
        this.btnAction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnAction.Location = new Point(870, -19);
        this.btnAction.Name = "btnAction";
        this.btnAction.Size = new Size(129, 57);
        this.btnAction.TabIndex = 5;
        this.btnAction.Text = "ACTION";
        this.btnAction.UseVisualStyleBackColor = true;
        // 
        // midPanel
        // 
        this.midPanel.Controls.Add(this.productsValue);
        this.midPanel.Controls.Add(this.label9);
        this.midPanel.Controls.Add(this.ctcPhoneValue);
        this.midPanel.Controls.Add(this.ctcEmailValue);
        this.midPanel.Controls.Add(this.ctcFirstNameValue);
        this.midPanel.Controls.Add(this.ctcLastNameValue);
        this.midPanel.Controls.Add(this.supplierNameValue);
        this.midPanel.Controls.Add(this.idValue);
        this.midPanel.Controls.Add(this.label5);
        this.midPanel.Controls.Add(this.label4);
        this.midPanel.Controls.Add(this.label3);
        this.midPanel.Controls.Add(this.label2);
        this.midPanel.Controls.Add(this.label1);
        this.midPanel.Controls.Add(this.idLabel);
        this.midPanel.Dock = DockStyle.Fill;
        this.midPanel.Location = new Point(30, 3);
        this.midPanel.Name = "midPanel";
        this.midPanel.Size = new Size(394, 539);
        this.midPanel.TabIndex = 0;
        // 
        // idValue
        // 
        this.idValue.Enabled = false;
        this.idValue.Location = new Point(148, 16);
        this.idValue.Maximum = new decimal(new int[] { 30000000, 0, 0, 0 });
        this.idValue.Name = "idValue";
        this.idValue.Size = new Size(243, 27);
        this.idValue.TabIndex = 11;
        // 
        // label5
        // 
        this.label5.Location = new Point(3, 219);
        this.label5.Name = "label5";
        this.label5.Size = new Size(117, 26);
        this.label5.TabIndex = 7;
        this.label5.Text = "Contact Phone :";
        this.label5.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label4
        // 
        this.label4.Location = new Point(3, 176);
        this.label4.Name = "label4";
        this.label4.Size = new Size(117, 26);
        this.label4.TabIndex = 6;
        this.label4.Text = "Contact Email :";
        this.label4.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label3
        // 
        this.label3.Location = new Point(3, 133);
        this.label3.Name = "label3";
        this.label3.Size = new Size(139, 26);
        this.label3.TabIndex = 5;
        this.label3.Text = "Contact First Name :";
        this.label3.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label2
        // 
        this.label2.Location = new Point(3, 94);
        this.label2.Name = "label2";
        this.label2.Size = new Size(139, 26);
        this.label2.TabIndex = 4;
        this.label2.Text = "Contact Last Name :";
        this.label2.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label1
        // 
        this.label1.Location = new Point(3, 56);
        this.label1.Name = "label1";
        this.label1.Size = new Size(139, 26);
        this.label1.TabIndex = 3;
        this.label1.Text = "Supplier Name :";
        this.label1.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(3, 15);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(139, 26);
        this.idLabel.TabIndex = 2;
        this.idLabel.Text = "Id :";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // middleTLP
        // 
        this.middleTLP.ColumnCount = 3;
        this.middleTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.middleTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
        this.middleTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.middleTLP.Controls.Add(this.midPanel, 1, 0);
        this.middleTLP.Dock = DockStyle.Fill;
        this.middleTLP.Location = new Point(0, 75);
        this.middleTLP.Name = "middleTLP";
        this.middleTLP.RowCount = 1;
        this.middleTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.middleTLP.Size = new Size(455, 545);
        this.middleTLP.TabIndex = 8;
        // 
        // panelTop
        // 
        this.panelTop.Dock = DockStyle.Top;
        this.panelTop.Location = new Point(0, 0);
        this.panelTop.Name = "panelTop";
        this.panelTop.Size = new Size(455, 75);
        this.panelTop.TabIndex = 6;
        // 
        // SupplierView
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(455, 620);
        this.Controls.Add(this.panelButtom);
        this.Controls.Add(this.middleTLP);
        this.Controls.Add(this.panelTop);
        this.Name = "SupplierView";
        this.Text = "SupplierView";
        this.Load += this.SupplierView_Load;
        this.panelButtom.ResumeLayout(false);
        this.midPanel.ResumeLayout(false);
        this.midPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.idValue).EndInit();
        this.middleTLP.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private Button btnCancel;
    private ListBox productsValue;
    private Label label9;
    private TextBox ctcPhoneValue;
    private TextBox ctcEmailValue;
    private TextBox ctcFirstNameValue;
    private TextBox ctcLastNameValue;
    private TextBox supplierNameValue;
    private Panel panelButtom;
    private Button btnAction;
    private Panel midPanel;
    private NumericUpDown idValue;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private Label idLabel;
    private TableLayoutPanel middleTLP;
    private Panel panelTop;
    private Button actionBtn;
    private Button cancelBtn;
}
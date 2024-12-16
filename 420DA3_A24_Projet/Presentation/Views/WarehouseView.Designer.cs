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
        actionBtn = new Button();
        cancelBtn = new Button();
        centreTLP = new TableLayoutPanel();
        panel1 = new Panel();
        metaDataPanel = new Panel();
        dateModificationPicker = new DateTimePicker();
        dateCreationPicker = new DateTimePicker();
        dateModificationLabel = new Label();
        dateCreationLabel = new Label();
        creationAdressBtn = new Button();
        codePostalValue = new TextBox();
        nameValue = new TextBox();
        idValue = new NumericUpDown();
        label2 = new Label();
        codePostalLabel = new Label();
        warehouseNameLabel = new Label();
        employesValue = new ListBox();
        idLabel = new Label();
        addresseIdLabel = new Label();
        addresseIdValue = new TextBox();
        bottomBarPanel.SuspendLayout();
        centreTLP.SuspendLayout();
        panel1.SuspendLayout();
        metaDataPanel.SuspendLayout();
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
        // actionBtn
        // 
        actionBtn.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        actionBtn.Location = new Point(527, 13);
        actionBtn.Name = "actionBtn";
        actionBtn.Size = new Size(110, 25);
        actionBtn.TabIndex = 1;
        actionBtn.Text = "PLACEHOLDER";
        actionBtn.UseVisualStyleBackColor = true;
        actionBtn.Click += this.actionBtn_Click;
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
        cancelBtn.Click += this.cancelBtn_Click;
        // 
        // centreTLP
        // 
        centreTLP.ColumnCount = 3;
        centreTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        centreTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 500F));
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
        panel1.Controls.Add(addresseIdValue);
        panel1.Controls.Add(addresseIdLabel);
        panel1.Controls.Add(metaDataPanel);
        panel1.Controls.Add(creationAdressBtn);
        panel1.Controls.Add(codePostalValue);
        panel1.Controls.Add(nameValue);
        panel1.Controls.Add(idValue);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(codePostalLabel);
        panel1.Controls.Add(warehouseNameLabel);
        panel1.Controls.Add(employesValue);
        panel1.Controls.Add(idLabel);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(145, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(494, 305);
        panel1.TabIndex = 0;
        // 
        // metaDataPanel
        // 
        metaDataPanel.Controls.Add(dateModificationPicker);
        metaDataPanel.Controls.Add(dateCreationPicker);
        metaDataPanel.Controls.Add(dateModificationLabel);
        metaDataPanel.Controls.Add(dateCreationLabel);
        metaDataPanel.Location = new Point(0, 188);
        metaDataPanel.Name = "metaDataPanel";
        metaDataPanel.Size = new Size(494, 117);
        metaDataPanel.TabIndex = 12;
        // 
        // dateModificationPicker
        // 
        dateModificationPicker.Location = new Point(215, 61);
        dateModificationPicker.Name = "dateModificationPicker";
        dateModificationPicker.Size = new Size(200, 23);
        dateModificationPicker.TabIndex = 16;
        // 
        // dateCreationPicker
        // 
        dateCreationPicker.Location = new Point(215, 21);
        dateCreationPicker.Name = "dateCreationPicker";
        dateCreationPicker.Size = new Size(200, 23);
        dateCreationPicker.TabIndex = 15;
        // 
        // dateModificationLabel
        // 
        dateModificationLabel.Location = new Point(3, 64);
        dateModificationLabel.Name = "dateModificationLabel";
        dateModificationLabel.Size = new Size(206, 20);
        dateModificationLabel.TabIndex = 14;
        dateModificationLabel.Text = "Date Modification:";
        dateModificationLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreationLabel
        // 
        dateCreationLabel.Location = new Point(3, 21);
        dateCreationLabel.Name = "dateCreationLabel";
        dateCreationLabel.Size = new Size(206, 20);
        dateCreationLabel.TabIndex = 13;
        dateCreationLabel.Text = "Date Creation:";
        dateCreationLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // creationAdressBtn
        // 
        creationAdressBtn.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        creationAdressBtn.Location = new Point(99, 146);
        creationAdressBtn.Name = "creationAdressBtn";
        creationAdressBtn.Size = new Size(110, 25);
        creationAdressBtn.TabIndex = 2;
        creationAdressBtn.Text = "Create Address";
        creationAdressBtn.UseVisualStyleBackColor = true;
        creationAdressBtn.Click += this.creationAdressBtn_Click;
        // 
        // codePostalValue
        // 
        codePostalValue.Location = new Point(99, 116);
        codePostalValue.Name = "codePostalValue";
        codePostalValue.PlaceholderText = "Warehouse Code Postal";
        codePostalValue.Size = new Size(145, 23);
        codePostalValue.TabIndex = 11;
        // 
        // nameValue
        // 
        nameValue.Location = new Point(99, 61);
        nameValue.Name = "nameValue";
        nameValue.PlaceholderText = "Warehouse Name";
        nameValue.Size = new Size(145, 23);
        nameValue.TabIndex = 10;
        // 
        // idValue
        // 
        idValue.Location = new Point(99, 32);
        idValue.Name = "idValue";
        idValue.Size = new Size(145, 23);
        idValue.TabIndex = 9;
        // 
        // label2
        // 
        label2.Location = new Point(262, 9);
        label2.Name = "label2";
        label2.Size = new Size(190, 20);
        label2.TabIndex = 7;
        label2.Text = "Employees:";
        label2.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // codePostalLabel
        // 
        codePostalLabel.Location = new Point(3, 115);
        codePostalLabel.Name = "codePostalLabel";
        codePostalLabel.Size = new Size(90, 20);
        codePostalLabel.TabIndex = 5;
        codePostalLabel.Text = "Code Postal:";
        codePostalLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // warehouseNameLabel
        // 
        warehouseNameLabel.Location = new Point(3, 59);
        warehouseNameLabel.Name = "warehouseNameLabel";
        warehouseNameLabel.Size = new Size(90, 20);
        warehouseNameLabel.TabIndex = 4;
        warehouseNameLabel.Text = "Name:";
        warehouseNameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // employesValue
        // 
        employesValue.FormattingEnabled = true;
        employesValue.ItemHeight = 15;
        employesValue.Location = new Point(262, 32);
        employesValue.Name = "employesValue";
        employesValue.Size = new Size(190, 139);
        employesValue.TabIndex = 2;
        // 
        // idLabel
        // 
        idLabel.Location = new Point(3, 31);
        idLabel.Name = "idLabel";
        idLabel.Size = new Size(90, 20);
        idLabel.TabIndex = 0;
        idLabel.Text = "Id:";
        idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // addresseIdLabel
        // 
        addresseIdLabel.Location = new Point(3, 87);
        addresseIdLabel.Name = "addresseIdLabel";
        addresseIdLabel.Size = new Size(90, 20);
        addresseIdLabel.TabIndex = 13;
        addresseIdLabel.Text = "Addresse Id:";
        addresseIdLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // addresseIdValue
        // 
        addresseIdValue.Location = new Point(99, 87);
        addresseIdValue.Name = "addresseIdValue";
        addresseIdValue.PlaceholderText = "Addresse Id";
        addresseIdValue.Size = new Size(145, 23);
        addresseIdValue.TabIndex = 14;
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
        metaDataPanel.ResumeLayout(false);
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
    private Label warehouseNameLabel;
    private Label codePostalLabel;
    private NumericUpDown idValue;
    private TextBox nameValue;
    private TextBox codePostalValue;
    private Label label2;
    private ListBox employesValue;
    private Panel metaDataPanel;
    private Button creationAdressBtn;
    private Label dateCreationLabel;
    private Label dateModificationLabel;
    private DateTimePicker dateCreationPicker;
    private DateTimePicker dateModificationPicker;
    private TextBox addresseIdValue;
    private Label addresseIdLabel;
}
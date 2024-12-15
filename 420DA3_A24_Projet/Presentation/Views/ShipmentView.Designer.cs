namespace _420DA3_A24_Projet.Presentation.Views;

partial class ShipmentView {
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
        panel1 = new Panel();
        actionBtn = new Button();
        cancelBtn = new Button();
        centreTLP = new TableLayoutPanel();
        mainPanel = new Panel();
        metaDataPanel = new Panel();
        idLabel = new Label();
        statusLabel = new Label();
        serviceLabel = new Label();
        trackingNumberLabel = new Label();
        shippingOrderIdLabel = new Label();
        dateCreationLabel = new Label();
        dateModificationLabel = new Label();
        dateCreationPicker = new DateTimePicker();
        dateModificationPicker = new DateTimePicker();
        trackingNumberValue = new TextBox();
        shippinOrderIdValue = new TextBox();
        idValue = new NumericUpDown();
        statusValue = new ComboBox();
        shippinServiceValue = new ComboBox();
        panel1.SuspendLayout();
        centreTLP.SuspendLayout();
        mainPanel.SuspendLayout();
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
        // panel1
        // 
        panel1.Controls.Add(actionBtn);
        panel1.Controls.Add(cancelBtn);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 361);
        panel1.Name = "panel1";
        panel1.Size = new Size(784, 50);
        panel1.TabIndex = 1;
        // 
        // actionBtn
        // 
        actionBtn.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        actionBtn.Location = new Point(528, 13);
        actionBtn.Name = "actionBtn";
        actionBtn.Size = new Size(110, 25);
        actionBtn.TabIndex = 1;
        actionBtn.Text = "PLACEHOLDER";
        actionBtn.UseVisualStyleBackColor = true;
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
        // centreTLP
        // 
        centreTLP.ColumnCount = 3;
        centreTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        centreTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 620F));
        centreTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
        centreTLP.Controls.Add(mainPanel, 1, 0);
        centreTLP.Dock = DockStyle.Fill;
        centreTLP.Location = new Point(0, 50);
        centreTLP.Name = "centreTLP";
        centreTLP.RowCount = 1;
        centreTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        centreTLP.Size = new Size(784, 311);
        centreTLP.TabIndex = 2;
        // 
        // mainPanel
        // 
        mainPanel.Controls.Add(shippinServiceValue);
        mainPanel.Controls.Add(statusValue);
        mainPanel.Controls.Add(idValue);
        mainPanel.Controls.Add(shippinOrderIdValue);
        mainPanel.Controls.Add(trackingNumberValue);
        mainPanel.Controls.Add(shippingOrderIdLabel);
        mainPanel.Controls.Add(trackingNumberLabel);
        mainPanel.Controls.Add(serviceLabel);
        mainPanel.Controls.Add(statusLabel);
        mainPanel.Controls.Add(idLabel);
        mainPanel.Controls.Add(metaDataPanel);
        mainPanel.Dock = DockStyle.Fill;
        mainPanel.Location = new Point(84, 3);
        mainPanel.Name = "mainPanel";
        mainPanel.Size = new Size(614, 305);
        mainPanel.TabIndex = 0;
        // 
        // metaDataPanel
        // 
        metaDataPanel.Controls.Add(dateModificationPicker);
        metaDataPanel.Controls.Add(dateCreationPicker);
        metaDataPanel.Controls.Add(dateModificationLabel);
        metaDataPanel.Controls.Add(dateCreationLabel);
        metaDataPanel.Location = new Point(3, 203);
        metaDataPanel.Name = "metaDataPanel";
        metaDataPanel.Size = new Size(608, 99);
        metaDataPanel.TabIndex = 1;
        // 
        // idLabel
        // 
        idLabel.Location = new Point(3, 17);
        idLabel.Name = "idLabel";
        idLabel.Size = new Size(210, 25);
        idLabel.TabIndex = 2;
        idLabel.Text = "Id:";
        idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // statusLabel
        // 
        statusLabel.Location = new Point(3, 53);
        statusLabel.Name = "statusLabel";
        statusLabel.Size = new Size(210, 25);
        statusLabel.TabIndex = 3;
        statusLabel.Text = "Status:";
        statusLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // serviceLabel
        // 
        serviceLabel.Location = new Point(3, 89);
        serviceLabel.Name = "serviceLabel";
        serviceLabel.Size = new Size(210, 25);
        serviceLabel.TabIndex = 4;
        serviceLabel.Text = "Shipping Service:";
        serviceLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // trackingNumberLabel
        // 
        trackingNumberLabel.Location = new Point(3, 125);
        trackingNumberLabel.Name = "trackingNumberLabel";
        trackingNumberLabel.Size = new Size(210, 25);
        trackingNumberLabel.TabIndex = 5;
        trackingNumberLabel.Text = "Tracking Number:";
        trackingNumberLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // shippingOrderIdLabel
        // 
        shippingOrderIdLabel.Location = new Point(3, 161);
        shippingOrderIdLabel.Name = "shippingOrderIdLabel";
        shippingOrderIdLabel.Size = new Size(210, 25);
        shippingOrderIdLabel.TabIndex = 6;
        shippingOrderIdLabel.Text = "Shipping Order Id:";
        shippingOrderIdLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreationLabel
        // 
        dateCreationLabel.Location = new Point(3, 14);
        dateCreationLabel.Name = "dateCreationLabel";
        dateCreationLabel.Size = new Size(207, 25);
        dateCreationLabel.TabIndex = 7;
        dateCreationLabel.Text = "Date Creation:";
        dateCreationLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateModificationLabel
        // 
        dateModificationLabel.Location = new Point(3, 57);
        dateModificationLabel.Name = "dateModificationLabel";
        dateModificationLabel.Size = new Size(207, 25);
        dateModificationLabel.TabIndex = 8;
        dateModificationLabel.Text = "Date Modification:";
        dateModificationLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreationPicker
        // 
        dateCreationPicker.Location = new Point(216, 16);
        dateCreationPicker.Name = "dateCreationPicker";
        dateCreationPicker.Size = new Size(220, 23);
        dateCreationPicker.TabIndex = 9;
        // 
        // dateModificationPicker
        // 
        dateModificationPicker.Location = new Point(216, 59);
        dateModificationPicker.Name = "dateModificationPicker";
        dateModificationPicker.Size = new Size(220, 23);
        dateModificationPicker.TabIndex = 10;
        // 
        // trackingNumberValue
        // 
        trackingNumberValue.Location = new Point(219, 125);
        trackingNumberValue.Name = "trackingNumberValue";
        trackingNumberValue.PlaceholderText = "Shipment Tracking Number";
        trackingNumberValue.Size = new Size(220, 23);
        trackingNumberValue.TabIndex = 7;
        // 
        // shippinOrderIdValue
        // 
        shippinOrderIdValue.Location = new Point(219, 160);
        shippinOrderIdValue.Name = "shippinOrderIdValue";
        shippinOrderIdValue.PlaceholderText = "Shipping Order Id";
        shippinOrderIdValue.Size = new Size(220, 23);
        shippinOrderIdValue.TabIndex = 8;
        // 
        // idValue
        // 
        idValue.Location = new Point(219, 20);
        idValue.Name = "idValue";
        idValue.Size = new Size(220, 23);
        idValue.TabIndex = 9;
        // 
        // statusValue
        // 
        statusValue.FormattingEnabled = true;
        statusValue.Items.AddRange(new object[] { "New", "PickedUp", "Delivered" });
        statusValue.Location = new Point(219, 55);
        statusValue.Name = "statusValue";
        statusValue.Size = new Size(220, 23);
        statusValue.TabIndex = 10;
        // 
        // shippinServiceValue
        // 
        shippinServiceValue.FormattingEnabled = true;
        shippinServiceValue.Items.AddRange(new object[] { "FedEx", "Purolator", "PostesCanada" });
        shippinServiceValue.Location = new Point(219, 90);
        shippinServiceValue.Name = "shippinServiceValue";
        shippinServiceValue.Size = new Size(220, 23);
        shippinServiceValue.TabIndex = 11;
        // 
        // ShipmentView
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(784, 411);
        this.Controls.Add(centreTLP);
        this.Controls.Add(panel1);
        this.Controls.Add(topBarPanel);
        this.MinimumSize = new Size(800, 450);
        this.Name = "ShipmentView";
        this.Text = "ShipmentView";
        panel1.ResumeLayout(false);
        centreTLP.ResumeLayout(false);
        mainPanel.ResumeLayout(false);
        mainPanel.PerformLayout();
        metaDataPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize) idValue).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Panel panel1;
    private TableLayoutPanel centreTLP;
    private Button cancelBtn;
    private Button actionBtn;
    private Panel mainPanel;
    private Panel metaDataPanel;
    private Label idLabel;
    private Label serviceLabel;
    private Label statusLabel;
    private Label shippingOrderIdLabel;
    private Label trackingNumberLabel;
    private Label dateCreationLabel;
    private Label dateModificationLabel;
    private DateTimePicker dateCreationPicker;
    private DateTimePicker dateModificationPicker;
    private TextBox trackingNumberValue;
    private TextBox shippinOrderIdValue;
    private NumericUpDown idValue;
    private ComboBox statusValue;
    private ComboBox shippinServiceValue;
}
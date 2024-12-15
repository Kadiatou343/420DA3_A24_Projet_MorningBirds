namespace _420DA3_A24_Projet.Presentation.Views;

partial class ClientView {
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
        this.label7 = new Label();
        this.label6 = new Label();
        this.panel3 = new Panel();
        this.btncancel = new Button();
        this.btnaction = new Button();
        this.tableLayoutPanel1 = new TableLayoutPanel();
        this.Control = new Panel();
        this.label8 = new Label();
        this.ListClient = new ListBox();
        this.textBoxtel = new TextBox();
        this.textBoxemail = new TextBox();
        this.dateTimedel = new DateTimePicker();
        this.dateTimePickercreation = new DateTimePicker();
        this.dateTimemodif = new DateTimePicker();
        this.textBoxcontactLN = new TextBox();
        this.textboxcontactFN = new TextBox();
        this.textboxnomclient = new TextBox();
        this.label5 = new Label();
        this.label4 = new Label();
        this.label3 = new Label();
        this.label2 = new Label();
        this.label1 = new Label();
        this.labelLastName = new Label();
        this.labelFirstName = new Label();
        this.labelClientname = new Label();
        this.IdValue = new NumericUpDown();
        this.IdLabel = new Label();
        this.panel1.SuspendLayout();
        this.panel2.SuspendLayout();
        this.panel3.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        this.Control.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.IdValue).BeginInit();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.panel2);
        this.panel1.Dock = DockStyle.Top;
        this.panel1.Location = new Point(0, 0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(865, 50);
        this.panel1.TabIndex = 0;
        // 
        // panel2
        // 
        this.panel2.Controls.Add(this.label7);
        this.panel2.Controls.Add(this.label6);
        this.panel2.Dock = DockStyle.Top;
        this.panel2.Location = new Point(0, 0);
        this.panel2.Name = "panel2";
        this.panel2.Size = new Size(865, 50);
        this.panel2.TabIndex = 1;
        // 
        // label7
        // 
        this.label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.label7.Location = new Point(105, 22);
        this.label7.Name = "label7";
        this.label7.Size = new Size(53, 25);
        this.label7.TabIndex = 4;
        this.label7.Text = "NONE";
        // 
        // label6
        // 
        this.label6.Location = new Point(17, 22);
        this.label6.Name = "label6";
        this.label6.Size = new Size(90, 25);
        this.label6.TabIndex = 3;
        this.label6.Text = "MODE VUE :";
        // 
        // panel3
        // 
        this.panel3.Controls.Add(this.btncancel);
        this.panel3.Controls.Add(this.btnaction);
        this.panel3.Dock = DockStyle.Bottom;
        this.panel3.Location = new Point(0, 429);
        this.panel3.Name = "panel3";
        this.panel3.Size = new Size(865, 58);
        this.panel3.TabIndex = 1;
        // 
        // btncancel
        // 
        this.btncancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        this.btncancel.Location = new Point(747, 6);
        this.btncancel.Name = "btncancel";
        this.btncancel.Size = new Size(103, 40);
        this.btncancel.TabIndex = 5;
        this.btncancel.Text = "CANCEL";
        this.btncancel.Click += this.btncancel_Click;
        // 
        // btnaction
        // 
        this.btnaction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.btnaction.Location = new Point(638, 6);
        this.btnaction.Name = "btnaction";
        this.btnaction.Size = new Size(103, 40);
        this.btnaction.TabIndex = 4;
        this.btnaction.Text = "ACTION";
        this.btnaction.Click += this.btnaction_Click;
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 3;
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 800F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.Controls.Add(this.Control, 1, 0);
        this.tableLayoutPanel1.Dock = DockStyle.Fill;
        this.tableLayoutPanel1.Location = new Point(0, 50);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 1;
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel1.Size = new Size(865, 379);
        this.tableLayoutPanel1.TabIndex = 2;
        // 
        // Control
        // 
        this.Control.Controls.Add(this.label8);
        this.Control.Controls.Add(this.ListClient);
        this.Control.Controls.Add(this.textBoxtel);
        this.Control.Controls.Add(this.textBoxemail);
        this.Control.Controls.Add(this.dateTimedel);
        this.Control.Controls.Add(this.dateTimePickercreation);
        this.Control.Controls.Add(this.dateTimemodif);
        this.Control.Controls.Add(this.textBoxcontactLN);
        this.Control.Controls.Add(this.textboxcontactFN);
        this.Control.Controls.Add(this.textboxnomclient);
        this.Control.Controls.Add(this.label5);
        this.Control.Controls.Add(this.label4);
        this.Control.Controls.Add(this.label3);
        this.Control.Controls.Add(this.label2);
        this.Control.Controls.Add(this.label1);
        this.Control.Controls.Add(this.labelLastName);
        this.Control.Controls.Add(this.labelFirstName);
        this.Control.Controls.Add(this.labelClientname);
        this.Control.Controls.Add(this.IdValue);
        this.Control.Controls.Add(this.IdLabel);
        this.Control.Dock = DockStyle.Fill;
        this.Control.Location = new Point(35, 3);
        this.Control.Name = "Control";
        this.Control.Size = new Size(794, 373);
        this.Control.TabIndex = 0;
        // 
        // label8
        // 
        this.label8.Location = new Point(55, 186);
        this.label8.Name = "label8";
        this.label8.Size = new Size(93, 25);
        this.label8.TabIndex = 20;
        this.label8.Text = "Telephone :";
        this.label8.TextAlign = ContentAlignment.MiddleRight;
        // 
        // ListClient
        // 
        this.ListClient.FormattingEnabled = true;
        this.ListClient.ItemHeight = 20;
        this.ListClient.Location = new Point(116, 233);
        this.ListClient.Name = "ListClient";
        this.ListClient.Size = new Size(283, 124);
        this.ListClient.TabIndex = 18;
        // 
        // textBoxtel
        // 
        this.textBoxtel.Enabled = false;
        this.textBoxtel.Location = new Point(154, 185);
        this.textBoxtel.Name = "textBoxtel";
        this.textBoxtel.Size = new Size(189, 27);
        this.textBoxtel.TabIndex = 17;
        // 
        // textBoxemail
        // 
        this.textBoxemail.Enabled = false;
        this.textBoxemail.Location = new Point(154, 152);
        this.textBoxemail.Name = "textBoxemail";
        this.textBoxemail.Size = new Size(189, 27);
        this.textBoxemail.TabIndex = 16;
        // 
        // dateTimedel
        // 
        this.dateTimedel.Location = new Point(553, 147);
        this.dateTimedel.Name = "dateTimedel";
        this.dateTimedel.Size = new Size(189, 27);
        this.dateTimedel.TabIndex = 15;
        // 
        // dateTimePickercreation
        // 
        this.dateTimePickercreation.Location = new Point(553, 54);
        this.dateTimePickercreation.Name = "dateTimePickercreation";
        this.dateTimePickercreation.Size = new Size(189, 27);
        this.dateTimePickercreation.TabIndex = 14;
        // 
        // dateTimemodif
        // 
        this.dateTimemodif.Location = new Point(553, 99);
        this.dateTimemodif.Name = "dateTimemodif";
        this.dateTimemodif.Size = new Size(189, 27);
        this.dateTimemodif.TabIndex = 13;
        // 
        // textBoxcontactLN
        // 
        this.textBoxcontactLN.Enabled = false;
        this.textBoxcontactLN.Location = new Point(154, 119);
        this.textBoxcontactLN.Name = "textBoxcontactLN";
        this.textBoxcontactLN.Size = new Size(189, 27);
        this.textBoxcontactLN.TabIndex = 12;
        // 
        // textboxcontactFN
        // 
        this.textboxcontactFN.Enabled = false;
        this.textboxcontactFN.Location = new Point(154, 83);
        this.textboxcontactFN.Name = "textboxcontactFN";
        this.textboxcontactFN.Size = new Size(189, 27);
        this.textboxcontactFN.TabIndex = 11;
        // 
        // textboxnomclient
        // 
        this.textboxnomclient.Enabled = false;
        this.textboxnomclient.Location = new Point(154, 50);
        this.textboxnomclient.Name = "textboxnomclient";
        this.textboxnomclient.Size = new Size(189, 27);
        this.textboxnomclient.TabIndex = 10;
        // 
        // label5
        // 
        this.label5.Location = new Point(388, 152);
        this.label5.Name = "label5";
        this.label5.Size = new Size(159, 25);
        this.label5.TabIndex = 9;
        this.label5.Text = "Date de suppression  :";
        // 
        // label4
        // 
        this.label4.Location = new Point(388, 104);
        this.label4.Name = "label4";
        this.label4.Size = new Size(159, 25);
        this.label4.TabIndex = 8;
        this.label4.Text = "Date de modification :";
        // 
        // label3
        // 
        this.label3.Location = new Point(70, 153);
        this.label3.Name = "label3";
        this.label3.Size = new Size(78, 25);
        this.label3.TabIndex = 7;
        this.label3.Text = "Email :";
        this.label3.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label2
        // 
        this.label2.Location = new Point(0, 0);
        this.label2.Name = "label2";
        this.label2.Size = new Size(100, 23);
        this.label2.TabIndex = 19;
        // 
        // label1
        // 
        this.label1.Location = new Point(388, 59);
        this.label1.Name = "label1";
        this.label1.Size = new Size(131, 25);
        this.label1.TabIndex = 5;
        this.label1.Text = "Date de création :";
        // 
        // labelLastName
        // 
        this.labelLastName.Location = new Point(12, 118);
        this.labelLastName.Name = "labelLastName";
        this.labelLastName.Size = new Size(136, 25);
        this.labelLastName.TabIndex = 4;
        this.labelLastName.Text = "ContactLastName :";
        this.labelLastName.TextAlign = ContentAlignment.MiddleRight;
        // 
        // labelFirstName
        // 
        this.labelFirstName.Location = new Point(0, 85);
        this.labelFirstName.Name = "labelFirstName";
        this.labelFirstName.Size = new Size(148, 25);
        this.labelFirstName.TabIndex = 3;
        this.labelFirstName.Text = "ContactFirstName :";
        this.labelFirstName.TextAlign = ContentAlignment.MiddleRight;
        // 
        // labelClientname
        // 
        this.labelClientname.Location = new Point(36, 52);
        this.labelClientname.Name = "labelClientname";
        this.labelClientname.Size = new Size(112, 25);
        this.labelClientname.TabIndex = 2;
        this.labelClientname.Text = "Nom du client :";
        this.labelClientname.TextAlign = ContentAlignment.MiddleRight;
        // 
        // IdValue
        // 
        this.IdValue.Enabled = false;
        this.IdValue.Location = new Point(154, 19);
        this.IdValue.Maximum = new decimal(new int[] { -1486618624, 232830643, 0, 0 });
        this.IdValue.Name = "IdValue";
        this.IdValue.Size = new Size(189, 27);
        this.IdValue.TabIndex = 1;
        // 
        // IdLabel
        // 
        this.IdLabel.Location = new Point(116, 27);
        this.IdLabel.Name = "IdLabel";
        this.IdLabel.Size = new Size(32, 25);
        this.IdLabel.TabIndex = 0;
        this.IdLabel.Text = "ID :";
        // 
        // ClientView
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(865, 487);
        this.Controls.Add(this.tableLayoutPanel1);
        this.Controls.Add(this.panel3);
        this.Controls.Add(this.panel1);
        this.MinimumSize = new Size(500, 500);
        this.Name = "ClientView";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Gestion des Clients";
        this.panel1.ResumeLayout(false);
        this.panel2.ResumeLayout(false);
        this.panel3.ResumeLayout(false);
        this.tableLayoutPanel1.ResumeLayout(false);
        this.Control.ResumeLayout(false);
        this.Control.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.IdValue).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Panel panel2;
    private Panel panel3;
    private TableLayoutPanel tableLayoutPanel1;
    private Panel Control;
    private NumericUpDown IdValue;
    private Label IdLabel;
    private Label labelClientname;
    private Label labelFirstName;
    private Label labelLastName;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private TextBox textBoxcontactLN;
    private TextBox textboxcontactFN;
    private TextBox textboxnomclient;
    private Label label6;
    private Label label7;
    private DateTimePicker dateTimemodif;
    private DateTimePicker dateTimedel;
    private DateTimePicker dateTimePickercreation;
    private TextBox textBoxemail;
    private TextBox textBoxtel;
    private ListBox ListClient;
    private Button Cancel;
    private Button btnaction;
    private Label label8;
    private Button btncancel;
}
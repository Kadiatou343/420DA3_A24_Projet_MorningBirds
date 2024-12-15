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
        this.tableLayoutPanel1 = new TableLayoutPanel();
        this.btnaction = new Button();
        this.btncancel = new Button();
        this.panel3 = new Panel();
        this.label1 = new Label();
        this.label2 = new Label();
        this.label3 = new Label();
        this.label4 = new Label();
        this.label5 = new Label();
        this.label6 = new Label();
        this.label7 = new Label();
        this.label8 = new Label();
        this.IdVALUE = new TextBox();
        this.civiquevalue = new TextBox();
        this.ruevalue = new TextBox();
        this.villevalue = new TextBox();
        this.paysvalue = new TextBox();
        this.postalvalue = new TextBox();
        this.provincevalue = new TextBox();
        this.ListeEntrepot = new ListBox();
        this.listeordreexpedition = new ListBox();
        this.label9 = new Label();
        this.label10 = new Label();
        this.typeadresse = new VScrollBar();
        this.panel1.SuspendLayout();
        this.panel2.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        this.panel3.SuspendLayout();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.label10);
        this.panel1.Controls.Add(this.label9);
        this.panel1.Dock = DockStyle.Top;
        this.panel1.Location = new Point(0, 0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(820, 48);
        this.panel1.TabIndex = 0;
        // 
        // panel2
        // 
        this.panel2.Controls.Add(this.btncancel);
        this.panel2.Controls.Add(this.btnaction);
        this.panel2.Dock = DockStyle.Bottom;
        this.panel2.Location = new Point(0, 337);
        this.panel2.Name = "panel2";
        this.panel2.Size = new Size(820, 48);
        this.panel2.TabIndex = 1;
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 3;
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 500F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
        this.tableLayoutPanel1.Dock = DockStyle.Fill;
        this.tableLayoutPanel1.Location = new Point(0, 48);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 1;
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel1.Size = new Size(820, 289);
        this.tableLayoutPanel1.TabIndex = 2;
        // 
        // btnaction
        // 
        this.btnaction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnaction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.btnaction.Location = new Point(605, 9);
        this.btnaction.Name = "btnaction";
        this.btnaction.Size = new Size(94, 29);
        this.btnaction.TabIndex = 0;
        this.btnaction.Text = "ACTION";
        this.btnaction.UseVisualStyleBackColor = true;
        // 
        // btncancel
        // 
        this.btncancel.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btncancel.Location = new Point(705, 12);
        this.btncancel.Name = "btncancel";
        this.btncancel.Size = new Size(101, 26);
        this.btncancel.TabIndex = 1;
        this.btncancel.Text = "CANCEL";
        this.btncancel.UseVisualStyleBackColor = true;
        // 
        // panel3
        // 
        this.panel3.Controls.Add(this.typeadresse);
        this.panel3.Controls.Add(this.listeordreexpedition);
        this.panel3.Controls.Add(this.ListeEntrepot);
        this.panel3.Controls.Add(this.provincevalue);
        this.panel3.Controls.Add(this.postalvalue);
        this.panel3.Controls.Add(this.paysvalue);
        this.panel3.Controls.Add(this.villevalue);
        this.panel3.Controls.Add(this.ruevalue);
        this.panel3.Controls.Add(this.civiquevalue);
        this.panel3.Controls.Add(this.IdVALUE);
        this.panel3.Controls.Add(this.label8);
        this.panel3.Controls.Add(this.label7);
        this.panel3.Controls.Add(this.label6);
        this.panel3.Controls.Add(this.label5);
        this.panel3.Controls.Add(this.label4);
        this.panel3.Controls.Add(this.label3);
        this.panel3.Controls.Add(this.label2);
        this.panel3.Controls.Add(this.label1);
        this.panel3.Dock = DockStyle.Fill;
        this.panel3.Location = new Point(163, 3);
        this.panel3.Name = "panel3";
        this.panel3.Size = new Size(494, 283);
        this.panel3.TabIndex = 0;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new Point(93, 12);
        this.label1.Name = "label1";
        this.label1.Size = new Size(31, 20);
        this.label1.TabIndex = 0;
        this.label1.Text = "ID :";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new Point(6, 52);
        this.label2.Name = "label2";
        this.label2.Size = new Size(124, 20);
        this.label2.TabIndex = 1;
        this.label2.Text = "Type D'addresse :";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new Point(6, 83);
        this.label3.Name = "label3";
        this.label3.Size = new Size(121, 20);
        this.label3.TabIndex = 2;
        this.label3.Text = "Numéro civique :";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new Point(83, 116);
        this.label4.Name = "label4";
        this.label4.Size = new Size(41, 20);
        this.label4.TabIndex = 3;
        this.label4.Text = "Rue :";
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new Point(295, 50);
        this.label5.Name = "label5";
        this.label5.Size = new Size(72, 20);
        this.label5.TabIndex = 4;
        this.label5.Text = "Province :";
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new Point(313, 9);
        this.label6.Name = "label6";
        this.label6.Size = new Size(45, 20);
        this.label6.TabIndex = 4;
        this.label6.Text = "Ville :";
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Location = new Point(271, 116);
        this.label7.Name = "label7";
        this.label7.Size = new Size(96, 20);
        this.label7.TabIndex = 5;
        this.label7.Text = "Code postal :";
        // 
        // label8
        // 
        this.label8.AutoSize = true;
        this.label8.Location = new Point(323, 83);
        this.label8.Name = "label8";
        this.label8.Size = new Size(44, 20);
        this.label8.TabIndex = 5;
        this.label8.Text = "Pays :";
        // 
        // IdVALUE
        // 
        this.IdVALUE.Location = new Point(130, 9);
        this.IdVALUE.Name = "IdVALUE";
        this.IdVALUE.Size = new Size(125, 27);
        this.IdVALUE.TabIndex = 6;
        // 
        // civiquevalue
        // 
        this.civiquevalue.Location = new Point(130, 76);
        this.civiquevalue.Name = "civiquevalue";
        this.civiquevalue.Size = new Size(125, 27);
        this.civiquevalue.TabIndex = 8;
        // 
        // ruevalue
        // 
        this.ruevalue.Location = new Point(130, 109);
        this.ruevalue.Name = "ruevalue";
        this.ruevalue.Size = new Size(125, 27);
        this.ruevalue.TabIndex = 9;
        // 
        // villevalue
        // 
        this.villevalue.Location = new Point(364, 12);
        this.villevalue.Name = "villevalue";
        this.villevalue.Size = new Size(125, 27);
        this.villevalue.TabIndex = 10;
        // 
        // paysvalue
        // 
        this.paysvalue.Location = new Point(366, 80);
        this.paysvalue.Name = "paysvalue";
        this.paysvalue.Size = new Size(125, 27);
        this.paysvalue.TabIndex = 11;
        // 
        // postalvalue
        // 
        this.postalvalue.Location = new Point(364, 113);
        this.postalvalue.Name = "postalvalue";
        this.postalvalue.Size = new Size(125, 27);
        this.postalvalue.TabIndex = 12;
        // 
        // provincevalue
        // 
        this.provincevalue.Location = new Point(366, 45);
        this.provincevalue.Name = "provincevalue";
        this.provincevalue.Size = new Size(125, 27);
        this.provincevalue.TabIndex = 13;
        // 
        // ListeEntrepot
        // 
        this.ListeEntrepot.FormattingEnabled = true;
        this.ListeEntrepot.ItemHeight = 20;
        this.ListeEntrepot.Location = new Point(93, 161);
        this.ListeEntrepot.Name = "ListeEntrepot";
        this.ListeEntrepot.Size = new Size(150, 104);
        this.ListeEntrepot.TabIndex = 15;
        // 
        // listeordreexpedition
        // 
        this.listeordreexpedition.FormattingEnabled = true;
        this.listeordreexpedition.ItemHeight = 20;
        this.listeordreexpedition.Location = new Point(313, 161);
        this.listeordreexpedition.Name = "listeordreexpedition";
        this.listeordreexpedition.Size = new Size(150, 104);
        this.listeordreexpedition.TabIndex = 16;
        // 
        // label9
        // 
        this.label9.AutoSize = true;
        this.label9.Location = new Point(12, 9);
        this.label9.Name = "label9";
        this.label9.Size = new Size(90, 20);
        this.label9.TabIndex = 17;
        this.label9.Text = "MODE VUE :";
        // 
        // label10
        // 
        this.label10.AutoSize = true;
        this.label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.label10.Location = new Point(99, 9);
        this.label10.Name = "label10";
        this.label10.Size = new Size(52, 20);
        this.label10.TabIndex = 18;
        this.label10.Text = "NONE";
        // 
        // typeadresse
        // 
        this.typeadresse.Location = new Point(133, 44);
        this.typeadresse.Name = "typeadresse";
        this.typeadresse.Size = new Size(109, 28);
        this.typeadresse.TabIndex = 17;
        // 
        // AddressView
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(820, 385);
        this.Controls.Add(this.tableLayoutPanel1);
        this.Controls.Add(this.panel2);
        this.Controls.Add(this.panel1);
        this.Name = "AddressView";
        this.Text = "Gestion des adresses";
        this.Load += this.AddressView_Load;
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.panel2.ResumeLayout(false);
        this.tableLayoutPanel1.ResumeLayout(false);
        this.panel3.ResumeLayout(false);
        this.panel3.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Panel panel2;
    private TableLayoutPanel tableLayoutPanel1;
    private Button btncancel;
    private Button btnaction;
    private Panel panel3;
    private Label label8;
    private Label label7;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private TextBox provincevalue;
    private TextBox postalvalue;
    private TextBox paysvalue;
    private TextBox villevalue;
    private TextBox ruevalue;
    private TextBox civiquevalue;
    private TextBox IdVALUE;
    private Label label10;
    private Label label9;
    private ListBox listeordreexpedition;
    private ListBox ListeEntrepot;
    private VScrollBar typeadresse;
}
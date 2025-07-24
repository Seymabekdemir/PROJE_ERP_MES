namespace ERP_MES;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        panel1 = new Panel();
        label2 = new Label();
        button2 = new Button();
        button1 = new Button();
        colorDialog1 = new ColorDialog();
        label1 = new Label();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.LightSteelBlue;
        panel1.Controls.Add(label2);
        panel1.Controls.Add(button2);
        panel1.Controls.Add(button1);
        panel1.Location = new Point(581, 12);
        panel1.Name = "panel1";
        panel1.Size = new Size(237, 394);
        panel1.TabIndex = 0;
        panel1.Paint += panel1_Paint;
        // 
        // label2
        // 
        label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
        label2.Location = new Point(22, 14);
        label2.Name = "label2";
        label2.Size = new Size(195, 34);
        label2.TabIndex = 2;
        label2.Text = "ANA MENÜ";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // button2
        // 
        button2.BackColor = Color.Thistle;
        button2.FlatAppearance.BorderColor = Color.Black;
        button2.FlatAppearance.MouseDownBackColor = Color.MediumOrchid;
        button2.FlatAppearance.MouseOverBackColor = Color.Orchid;
        button2.FlatStyle = FlatStyle.Flat;
        button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
        button2.ForeColor = SystemColors.ActiveCaptionText;
        button2.Location = new Point(22, 118);
        button2.Name = "button2";
        button2.Size = new Size(195, 42);
        button2.TabIndex = 1;
        button2.Text = "SİPARİŞLER";
        button2.UseVisualStyleBackColor = false;
        button2.Click += button2_Click;
        // 
        // button1
        // 
        button1.BackColor = Color.Thistle;
        button1.FlatAppearance.BorderColor = Color.Black;
        button1.FlatAppearance.MouseDownBackColor = Color.MediumOrchid;
        button1.FlatAppearance.MouseOverBackColor = Color.Violet;
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
        button1.ForeColor = SystemColors.ActiveCaptionText;
        button1.Location = new Point(22, 61);
        button1.Name = "button1";
        button1.Size = new Size(195, 42);
        button1.TabIndex = 0;
        button1.Text = "CİHAZLAR";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // label1
        // 
        label1.BackColor = SystemColors.GradientInactiveCaption;
        label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
        label1.Location = new Point(12, 12);
        label1.Name = "label1";
        label1.Padding = new Padding(25, 10, 10, 5);
        label1.Size = new Size(563, 64);
        label1.TabIndex = 1;
        label1.Text = "Akım Metal Sipariş ve Cihaz Takibi Uygulamasına\r\nHoş Geldiniz!";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.AliceBlue;
        ClientSize = new Size(830, 446);
        Controls.Add(label1);
        Controls.Add(panel1);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(3, 2, 3, 2);
        Name = "Form1";
        Text = "Ana Menü";
        Load += Form1_Load;
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion


    private Panel panel1;
    private Button button1;
    private Button button2;
    private ColorDialog colorDialog1;
    private Label label1;
    private Label label2;
}

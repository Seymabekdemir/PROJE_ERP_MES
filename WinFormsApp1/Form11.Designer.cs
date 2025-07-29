namespace ERP_MES
{
    partial class Form11
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            panel1 = new Panel();
            dataGridViewSiparisGuncelle = new DataGridView();
            txtAramaSiparisGuncelle = new TextBox();
            textBox = new TextBox();
            textBoxSilCihazAdi = new TextBox();
            btnSil = new Button();
            textBoxSilCihazTuru = new TextBox();
            textBoxSilCihazAciklamasi = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSiparisGuncelle).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(btnSil);
            panel1.Controls.Add(textBoxSilCihazAciklamasi);
            panel1.Controls.Add(textBoxSilCihazTuru);
            panel1.Controls.Add(textBoxSilCihazAdi);
            panel1.Controls.Add(textBox);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(449, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 410);
            panel1.TabIndex = 20;
            // 
            // dataGridViewSiparisGuncelle
            // 
            dataGridViewSiparisGuncelle.BackgroundColor = SystemColors.Info;
            dataGridViewSiparisGuncelle.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewSiparisGuncelle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewSiparisGuncelle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Info;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.AliceBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewSiparisGuncelle.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewSiparisGuncelle.Location = new Point(12, 53);
            dataGridViewSiparisGuncelle.Name = "dataGridViewSiparisGuncelle";
            dataGridViewSiparisGuncelle.Size = new Size(431, 381);
            dataGridViewSiparisGuncelle.TabIndex = 19;
            // 
            // txtAramaSiparisGuncelle
            // 
            txtAramaSiparisGuncelle.Location = new Point(12, 24);
            txtAramaSiparisGuncelle.Name = "txtAramaSiparisGuncelle";
            txtAramaSiparisGuncelle.Size = new Size(388, 23);
            txtAramaSiparisGuncelle.TabIndex = 18;
            // 
            // textBox
            // 
            textBox.Location = new Point(169, 12);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(189, 22);
            textBox.TabIndex = 2;
            // 
            // textBoxSilCihazAdi
            // 
            textBoxSilCihazAdi.Location = new Point(169, 46);
            textBoxSilCihazAdi.Multiline = true;
            textBoxSilCihazAdi.Name = "textBoxSilCihazAdi";
            textBoxSilCihazAdi.Size = new Size(189, 22);
            textBoxSilCihazAdi.TabIndex = 3;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.MistyRose;
            btnSil.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnSil.FlatAppearance.MouseDownBackColor = Color.Red;
            btnSil.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            btnSil.Location = new Point(234, 357);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(128, 36);
            btnSil.TabIndex = 11;
            btnSil.Text = "GÜNCELLE";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // textBoxSilCihazTuru
            // 
            textBoxSilCihazTuru.Location = new Point(169, 86);
            textBoxSilCihazTuru.Multiline = true;
            textBoxSilCihazTuru.Name = "textBoxSilCihazTuru";
            textBoxSilCihazTuru.Size = new Size(189, 22);
            textBoxSilCihazTuru.TabIndex = 4;
            textBoxSilCihazTuru.TextChanged += textBoxSilCihazTuru_TextChanged;
            // 
            // textBoxSilCihazAciklamasi
            // 
            textBoxSilCihazAciklamasi.Location = new Point(169, 125);
            textBoxSilCihazAciklamasi.Multiline = true;
            textBoxSilCihazAciklamasi.Name = "textBoxSilCihazAciklamasi";
            textBoxSilCihazAciklamasi.Size = new Size(189, 22);
            textBoxSilCihazAciklamasi.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(169, 263);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 88);
            textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(169, 232);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 22);
            textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(169, 195);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(189, 22);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(169, 160);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(189, 22);
            textBox4.TabIndex = 12;
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 84);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 19;
            label3.Text = "Sipariş STT:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(15, 125);
            label4.Name = "label4";
            label4.Size = new Size(99, 23);
            label4.TabIndex = 18;
            label4.Text = "Sipariş Türü:";
            label4.Click += this.label4_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(15, 45);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 17;
            label2.Text = "Sipariş OT:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += this.label2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(15, 12);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 16;
            label1.Text = "Sipariş No:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += this.label1_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label7.Location = new Point(15, 263);
            label7.Name = "label7";
            label7.Size = new Size(137, 38);
            label7.TabIndex = 23;
            label7.Text = "Sipariş Açıklaması:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(15, 193);
            label5.Name = "label5";
            label5.Size = new Size(116, 23);
            label5.TabIndex = 21;
            label5.Text = "Sipariş Veren:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(15, 156);
            label6.Name = "label6";
            label6.Size = new Size(117, 35);
            label6.TabIndex = 20;
            label6.Text = "Sipariş Miktarı:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            label6.Click += label6_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label8.Location = new Point(15, 225);
            label8.Name = "label8";
            label8.Size = new Size(83, 33);
            label8.TabIndex = 22;
            label8.Text = "Cihaz Id:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(830, 446);
            Controls.Add(panel1);
            Controls.Add(dataGridViewSiparisGuncelle);
            Controls.Add(txtAramaSiparisGuncelle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form11";
            Text = "Sipariş Bilgilerini Düzenle ve Güncelle";
            Load += Form11_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSiparisGuncelle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewSiparisGuncelle;
        private TextBox txtAramaSiparisGuncelle;
        private Button btnSil;
        private TextBox textBoxSilCihazAciklamasi;
        private TextBox textBoxSilCihazTuru;
        private TextBox textBoxSilCihazAdi;
        private TextBox textBox;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label6;
    }
}
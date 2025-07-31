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
            comboBoxGuncelleSiparisTuru = new ComboBox();
            comboBoxGuncelleSiparisDurumu = new ComboBox();
            comboBoxGuncelleCihazId = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            textBoxGuncelleSiparisAdı = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxGuncelleSiparisAcıklaması = new TextBox();
            textBoxGuncelleSiparisVeren = new TextBox();
            textBoxGuncelleSiparisMiktarı = new TextBox();
            btnGuncelleSiparisBilgilerini = new Button();
            textBoxGuncelleSiparisSTT = new TextBox();
            textBoxGuncelleSiparisOT = new TextBox();
            textBoxGuncelleSiparisNo = new TextBox();
            dataGridViewSiparisGuncelle = new DataGridView();
            txtAramaSiparisGuncelle = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSiparisGuncelle).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(comboBoxGuncelleSiparisTuru);
            panel1.Controls.Add(comboBoxGuncelleSiparisDurumu);
            panel1.Controls.Add(comboBoxGuncelleCihazId);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBoxGuncelleSiparisAdı);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxGuncelleSiparisAcıklaması);
            panel1.Controls.Add(textBoxGuncelleSiparisVeren);
            panel1.Controls.Add(textBoxGuncelleSiparisMiktarı);
            panel1.Controls.Add(btnGuncelleSiparisBilgilerini);
            panel1.Controls.Add(textBoxGuncelleSiparisSTT);
            panel1.Controls.Add(textBoxGuncelleSiparisOT);
            panel1.Controls.Add(textBoxGuncelleSiparisNo);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(513, 32);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 543);
            panel1.TabIndex = 20;
            panel1.Paint += panel1_Paint;
            // 
            // comboBoxGuncelleSiparisTuru
            // 
            comboBoxGuncelleSiparisTuru.FormattingEnabled = true;
            comboBoxGuncelleSiparisTuru.Items.AddRange(new object[] { "Üretim Siparişi", "Bakım Siparişi", "Standart Sipariş", "Acil Sipariş", "Tekrar Sipariş", "Numune Siparişi", "Özel Üretim Siparişi" });
            comboBoxGuncelleSiparisTuru.Location = new Point(193, 151);
            comboBoxGuncelleSiparisTuru.Name = "comboBoxGuncelleSiparisTuru";
            comboBoxGuncelleSiparisTuru.Size = new Size(215, 28);
            comboBoxGuncelleSiparisTuru.TabIndex = 30;
            // 
            // comboBoxGuncelleSiparisDurumu
            // 
            comboBoxGuncelleSiparisDurumu.FormattingEnabled = true;
            comboBoxGuncelleSiparisDurumu.Items.AddRange(new object[] { "Yeni sipariş girildi.", "Sipariş üretimden onay bekliyor.", "Sipariş üretimde.", "Siparişin üretimi tamamlandı.", "Sipariş paketlemede.", "Sipariş kargoya hazır.", "Sipariş kargoya verildi.", "Sipariş alıcıya ulaştı." });
            comboBoxGuncelleSiparisDurumu.Location = new Point(193, 385);
            comboBoxGuncelleSiparisDurumu.Name = "comboBoxGuncelleSiparisDurumu";
            comboBoxGuncelleSiparisDurumu.Size = new Size(215, 28);
            comboBoxGuncelleSiparisDurumu.TabIndex = 29;
            comboBoxGuncelleSiparisDurumu.SelectedIndexChanged += comboBoxGuncelleSiparisDurumu_SelectedIndexChanged;
            // 
            // comboBoxGuncelleCihazId
            // 
            comboBoxGuncelleCihazId.FormattingEnabled = true;
            comboBoxGuncelleCihazId.Location = new Point(193, 295);
            comboBoxGuncelleCihazId.Name = "comboBoxGuncelleCihazId";
            comboBoxGuncelleCihazId.Size = new Size(215, 28);
            comboBoxGuncelleCihazId.TabIndex = 28;
            comboBoxGuncelleCihazId.SelectedIndexChanged += comboBoxGuncelleCihazId_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label10.Location = new Point(17, 385);
            label10.Name = "label10";
            label10.Size = new Size(157, 29);
            label10.TabIndex = 27;
            label10.Text = "Siparis Durumu:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label9.Location = new Point(17, 336);
            label9.Name = "label9";
            label9.Size = new Size(120, 33);
            label9.TabIndex = 25;
            label9.Text = "Cihaz Adı:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxGuncelleSiparisAdı
            // 
            textBoxGuncelleSiparisAdı.Location = new Point(193, 340);
            textBoxGuncelleSiparisAdı.Margin = new Padding(3, 4, 3, 4);
            textBoxGuncelleSiparisAdı.Multiline = true;
            textBoxGuncelleSiparisAdı.Name = "textBoxGuncelleSiparisAdı";
            textBoxGuncelleSiparisAdı.Size = new Size(215, 28);
            textBoxGuncelleSiparisAdı.TabIndex = 24;
            // 
            // label7
            // 
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label7.Location = new Point(17, 430);
            label7.Name = "label7";
            label7.Size = new Size(170, 51);
            label7.TabIndex = 23;
            label7.Text = "Sipariş Açıklaması:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label8.Location = new Point(17, 295);
            label8.Name = "label8";
            label8.Size = new Size(95, 24);
            label8.TabIndex = 22;
            label8.Text = "Cihaz Id:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            label8.Click += label8_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(17, 243);
            label5.Name = "label5";
            label5.Size = new Size(133, 31);
            label5.TabIndex = 21;
            label5.Text = "Sipariş Veren:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(17, 192);
            label6.Name = "label6";
            label6.Size = new Size(170, 47);
            label6.TabIndex = 20;
            label6.Text = "Sipariş Miktarı:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 104);
            label3.Name = "label3";
            label3.Size = new Size(120, 31);
            label3.TabIndex = 19;
            label3.Text = "Sipariş STT:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.Click += label3_Click_1;
            // 
            // label4
            // 
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(17, 152);
            label4.Name = "label4";
            label4.Size = new Size(143, 31);
            label4.TabIndex = 18;
            label4.Text = "Sipariş Türü:";
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(17, 60);
            label2.Name = "label2";
            label2.Size = new Size(113, 27);
            label2.TabIndex = 17;
            label2.Text = "Sipariş OT:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(17, 16);
            label1.Name = "label1";
            label1.Size = new Size(113, 27);
            label1.TabIndex = 16;
            label1.Text = "Sipariş No:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxGuncelleSiparisAcıklaması
            // 
            textBoxGuncelleSiparisAcıklaması.Location = new Point(193, 430);
            textBoxGuncelleSiparisAcıklaması.Margin = new Padding(3, 4, 3, 4);
            textBoxGuncelleSiparisAcıklaması.Multiline = true;
            textBoxGuncelleSiparisAcıklaması.Name = "textBoxGuncelleSiparisAcıklaması";
            textBoxGuncelleSiparisAcıklaması.ScrollBars = ScrollBars.Vertical;
            textBoxGuncelleSiparisAcıklaması.Size = new Size(215, 51);
            textBoxGuncelleSiparisAcıklaması.TabIndex = 15;
            // 
            // textBoxGuncelleSiparisVeren
            // 
            textBoxGuncelleSiparisVeren.Location = new Point(193, 248);
            textBoxGuncelleSiparisVeren.Margin = new Padding(3, 4, 3, 4);
            textBoxGuncelleSiparisVeren.Multiline = true;
            textBoxGuncelleSiparisVeren.Name = "textBoxGuncelleSiparisVeren";
            textBoxGuncelleSiparisVeren.Size = new Size(215, 28);
            textBoxGuncelleSiparisVeren.TabIndex = 13;
            // 
            // textBoxGuncelleSiparisMiktarı
            // 
            textBoxGuncelleSiparisMiktarı.Location = new Point(193, 197);
            textBoxGuncelleSiparisMiktarı.Margin = new Padding(3, 4, 3, 4);
            textBoxGuncelleSiparisMiktarı.Multiline = true;
            textBoxGuncelleSiparisMiktarı.Name = "textBoxGuncelleSiparisMiktarı";
            textBoxGuncelleSiparisMiktarı.Size = new Size(215, 28);
            textBoxGuncelleSiparisMiktarı.TabIndex = 12;
            // 
            // btnGuncelleSiparisBilgilerini
            // 
            btnGuncelleSiparisBilgilerini.BackColor = Color.MistyRose;
            btnGuncelleSiparisBilgilerini.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnGuncelleSiparisBilgilerini.FlatAppearance.MouseDownBackColor = Color.Red;
            btnGuncelleSiparisBilgilerini.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnGuncelleSiparisBilgilerini.FlatStyle = FlatStyle.Flat;
            btnGuncelleSiparisBilgilerini.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            btnGuncelleSiparisBilgilerini.Location = new Point(251, 489);
            btnGuncelleSiparisBilgilerini.Margin = new Padding(3, 4, 3, 4);
            btnGuncelleSiparisBilgilerini.Name = "btnGuncelleSiparisBilgilerini";
            btnGuncelleSiparisBilgilerini.Size = new Size(157, 37);
            btnGuncelleSiparisBilgilerini.TabIndex = 11;
            btnGuncelleSiparisBilgilerini.Text = "GÜNCELLE";
            btnGuncelleSiparisBilgilerini.UseVisualStyleBackColor = false;
            btnGuncelleSiparisBilgilerini.Click += btnGuncelle_Click;
            // 
            // textBoxGuncelleSiparisSTT
            // 
            textBoxGuncelleSiparisSTT.Location = new Point(193, 107);
            textBoxGuncelleSiparisSTT.Margin = new Padding(3, 4, 3, 4);
            textBoxGuncelleSiparisSTT.Multiline = true;
            textBoxGuncelleSiparisSTT.Name = "textBoxGuncelleSiparisSTT";
            textBoxGuncelleSiparisSTT.Size = new Size(215, 28);
            textBoxGuncelleSiparisSTT.TabIndex = 4;
            textBoxGuncelleSiparisSTT.TextChanged += textBoxSilCihazTuru_TextChanged;
            // 
            // textBoxGuncelleSiparisOT
            // 
            textBoxGuncelleSiparisOT.Location = new Point(193, 61);
            textBoxGuncelleSiparisOT.Margin = new Padding(3, 4, 3, 4);
            textBoxGuncelleSiparisOT.Multiline = true;
            textBoxGuncelleSiparisOT.Name = "textBoxGuncelleSiparisOT";
            textBoxGuncelleSiparisOT.Size = new Size(215, 28);
            textBoxGuncelleSiparisOT.TabIndex = 3;
            // 
            // textBoxGuncelleSiparisNo
            // 
            textBoxGuncelleSiparisNo.Location = new Point(193, 16);
            textBoxGuncelleSiparisNo.Margin = new Padding(3, 4, 3, 4);
            textBoxGuncelleSiparisNo.Multiline = true;
            textBoxGuncelleSiparisNo.Name = "textBoxGuncelleSiparisNo";
            textBoxGuncelleSiparisNo.Size = new Size(215, 28);
            textBoxGuncelleSiparisNo.TabIndex = 2;
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
            dataGridViewSiparisGuncelle.Location = new Point(14, 67);
            dataGridViewSiparisGuncelle.Margin = new Padding(3, 4, 3, 4);
            dataGridViewSiparisGuncelle.Name = "dataGridViewSiparisGuncelle";
            dataGridViewSiparisGuncelle.RowHeadersWidth = 51;
            dataGridViewSiparisGuncelle.Size = new Size(493, 508);
            dataGridViewSiparisGuncelle.TabIndex = 19;
            dataGridViewSiparisGuncelle.CellContentClick += dataGridViewSiparisGuncelle_CellContentClick;
            // 
            // txtAramaSiparisGuncelle
            // 
            txtAramaSiparisGuncelle.Location = new Point(14, 32);
            txtAramaSiparisGuncelle.Margin = new Padding(3, 4, 3, 4);
            txtAramaSiparisGuncelle.Name = "txtAramaSiparisGuncelle";
            txtAramaSiparisGuncelle.Size = new Size(492, 27);
            txtAramaSiparisGuncelle.TabIndex = 18;
            txtAramaSiparisGuncelle.TextChanged += txtAramaSiparisGuncelle_TextChanged;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(949, 595);
            Controls.Add(panel1);
            Controls.Add(dataGridViewSiparisGuncelle);
            Controls.Add(txtAramaSiparisGuncelle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnGuncelleSiparisBilgilerini;
        private TextBox textBoxGuncelleSiparisSTT;
        private TextBox textBoxGuncelleSiparisOT;
        private TextBox textBoxGuncelleSiparisNo;
        private TextBox textBoxGuncelleSiparisAcıklaması;
        private TextBox textBoxGuncelleSiparisVeren;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label9;
        private TextBox textBoxGuncelleSiparisAdı;
        private Label label10;
        private ComboBox comboBoxGuncelleSiparisTuru;
        private ComboBox comboBoxGuncelleCihazId;
        private TextBox textBoxGuncelleSiparisMiktarı;
        private ComboBox comboBoxGuncelleSiparisDurumu;
    }
}
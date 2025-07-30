namespace ERP_MES
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            label1 = new Label();
            panel1 = new Panel();
            numericUpDownSiparisMiktarı = new NumericUpDown();
            btnSiparisOluştur = new Button();
            comboBoxSiparisTuru = new ComboBox();
            textBoxSiparisinSahibi = new TextBox();
            comboBoxCihazId = new ComboBox();
            comboBoxDurumu = new ComboBox();
            dateTimePickerSiparisSTT = new DateTimePicker();
            dateTimePickerSiparisOT = new DateTimePicker();
            textBoxSiparisAcıklamasi = new TextBox();
            textBoxSiparisNo = new TextBox();
            label9 = new Label();
            labelSiparisveren = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSiparisMiktarı).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(19, 81);
            label1.Margin = new Padding(0, 0, 0, 27);
            label1.Name = "label1";
            label1.Size = new Size(143, 29);
            label1.TabIndex = 0;
            label1.Text = "Sipariş No:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(numericUpDownSiparisMiktarı);
            panel1.Controls.Add(btnSiparisOluştur);
            panel1.Controls.Add(comboBoxSiparisTuru);
            panel1.Controls.Add(textBoxSiparisinSahibi);
            panel1.Controls.Add(comboBoxCihazId);
            panel1.Controls.Add(comboBoxDurumu);
            panel1.Controls.Add(dateTimePickerSiparisSTT);
            panel1.Controls.Add(dateTimePickerSiparisOT);
            panel1.Controls.Add(textBoxSiparisAcıklamasi);
            panel1.Controls.Add(textBoxSiparisNo);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(labelSiparisveren);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(886, 549);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint_1;
            // 
            // numericUpDownSiparisMiktarı
            // 
            numericUpDownSiparisMiktarı.Location = new Point(193, 417);
            numericUpDownSiparisMiktarı.Margin = new Padding(3, 4, 3, 4);
            numericUpDownSiparisMiktarı.Name = "numericUpDownSiparisMiktarı";
            numericUpDownSiparisMiktarı.Size = new Size(440, 27);
            numericUpDownSiparisMiktarı.TabIndex = 20;
            // 
            // btnSiparisOluştur
            // 
            btnSiparisOluştur.BackColor = Color.MistyRose;
            btnSiparisOluştur.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnSiparisOluştur.FlatAppearance.MouseDownBackColor = Color.Red;
            btnSiparisOluştur.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnSiparisOluştur.FlatStyle = FlatStyle.Flat;
            btnSiparisOluştur.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSiparisOluştur.Location = new Point(687, 457);
            btnSiparisOluştur.Margin = new Padding(3, 4, 3, 4);
            btnSiparisOluştur.Name = "btnSiparisOluştur";
            btnSiparisOluştur.Size = new Size(161, 56);
            btnSiparisOluştur.TabIndex = 19;
            btnSiparisOluştur.Text = "Kaydet";
            btnSiparisOluştur.UseVisualStyleBackColor = false;
            btnSiparisOluştur.Click += btnSiparisOluştur_Click;
            // 
            // comboBoxSiparisTuru
            // 
            comboBoxSiparisTuru.FormattingEnabled = true;
            comboBoxSiparisTuru.Items.AddRange(new object[] { "Üretim Siparişi", "Bakım Siparişi", "Standart Sipariş", "Acil Sipariş", "Tekrar Sipariş", "Numune Siparişi", "Özel Üretim Siparişi" });
            comboBoxSiparisTuru.Location = new Point(193, 305);
            comboBoxSiparisTuru.Margin = new Padding(3, 4, 3, 4);
            comboBoxSiparisTuru.Name = "comboBoxSiparisTuru";
            comboBoxSiparisTuru.Size = new Size(439, 28);
            comboBoxSiparisTuru.TabIndex = 18;
            comboBoxSiparisTuru.SelectedIndexChanged += comboBoxSiparisTuru_SelectedIndexChanged;
            // 
            // textBoxSiparisinSahibi
            // 
            textBoxSiparisinSahibi.Location = new Point(195, 473);
            textBoxSiparisinSahibi.Margin = new Padding(3, 4, 3, 4);
            textBoxSiparisinSahibi.Name = "textBoxSiparisinSahibi";
            textBoxSiparisinSahibi.Size = new Size(437, 27);
            textBoxSiparisinSahibi.TabIndex = 16;
            // 
            // comboBoxCihazId
            // 
            comboBoxCihazId.FormattingEnabled = true;
            comboBoxCihazId.Location = new Point(193, 25);
            comboBoxCihazId.Margin = new Padding(3, 4, 3, 4);
            comboBoxCihazId.Name = "comboBoxCihazId";
            comboBoxCihazId.Size = new Size(439, 28);
            comboBoxCihazId.TabIndex = 15;
            comboBoxCihazId.SelectedIndexChanged += comboBoxCihazId_SelectedIndexChanged;
            // 
            // comboBoxDurumu
            // 
            comboBoxDurumu.FormattingEnabled = true;
            comboBoxDurumu.Items.AddRange(new object[] { "Yeni sipariş girildi.", "Sipariş üretimden onay bekliyor.", "Sipariş üretimde.", "Siparişin üretimi tamamlandı.", "Sipariş paketlemede.", "Sipariş kargoya hazır.", "Sipariş kargoya verildi.", "Sipariş alıcıya ulaştı." });
            comboBoxDurumu.Location = new Point(192, 361);
            comboBoxDurumu.Margin = new Padding(3, 4, 3, 4);
            comboBoxDurumu.Name = "comboBoxDurumu";
            comboBoxDurumu.Size = new Size(441, 28);
            comboBoxDurumu.TabIndex = 14;
            // 
            // dateTimePickerSiparisSTT
            // 
            dateTimePickerSiparisSTT.Location = new Point(194, 248);
            dateTimePickerSiparisSTT.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerSiparisSTT.Name = "dateTimePickerSiparisSTT";
            dateTimePickerSiparisSTT.Size = new Size(438, 27);
            dateTimePickerSiparisSTT.TabIndex = 12;
            // 
            // dateTimePickerSiparisOT
            // 
            dateTimePickerSiparisOT.Location = new Point(193, 193);
            dateTimePickerSiparisOT.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerSiparisOT.Name = "dateTimePickerSiparisOT";
            dateTimePickerSiparisOT.Size = new Size(439, 27);
            dateTimePickerSiparisOT.TabIndex = 11;
            // 
            // textBoxSiparisAcıklamasi
            // 
            textBoxSiparisAcıklamasi.Location = new Point(194, 137);
            textBoxSiparisAcıklamasi.Margin = new Padding(3, 4, 3, 4);
            textBoxSiparisAcıklamasi.Multiline = true;
            textBoxSiparisAcıklamasi.Name = "textBoxSiparisAcıklamasi";
            textBoxSiparisAcıklamasi.Size = new Size(438, 28);
            textBoxSiparisAcıklamasi.TabIndex = 10;
            // 
            // textBoxSiparisNo
            // 
            textBoxSiparisNo.Location = new Point(193, 81);
            textBoxSiparisNo.Margin = new Padding(3, 4, 3, 4);
            textBoxSiparisNo.Multiline = true;
            textBoxSiparisNo.Name = "textBoxSiparisNo";
            textBoxSiparisNo.Size = new Size(439, 28);
            textBoxSiparisNo.TabIndex = 9;
            textBoxSiparisNo.TextChanged += textBox1_TextChanged;
            // 
            // label9
            // 
            label9.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(19, 25);
            label9.Margin = new Padding(0, 0, 0, 27);
            label9.Name = "label9";
            label9.Size = new Size(143, 29);
            label9.TabIndex = 8;
            label9.Text = "Cihaz Id:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelSiparisveren
            // 
            labelSiparisveren.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelSiparisveren.Location = new Point(19, 473);
            labelSiparisveren.Margin = new Padding(0, 0, 0, 27);
            labelSiparisveren.Name = "labelSiparisveren";
            labelSiparisveren.Size = new Size(160, 29);
            labelSiparisveren.TabIndex = 7;
            labelSiparisveren.Text = "Sipariş Veren:";
            labelSiparisveren.TextAlign = ContentAlignment.MiddleLeft;
            labelSiparisveren.Click += label5_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(19, 417);
            label6.Margin = new Padding(0, 0, 0, 27);
            label6.Name = "label6";
            label6.Size = new Size(143, 29);
            label6.TabIndex = 6;
            label6.Text = "Sipariş Miktarı:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(19, 361);
            label7.Margin = new Padding(0, 0, 0, 27);
            label7.Name = "label7";
            label7.Size = new Size(160, 29);
            label7.TabIndex = 5;
            label7.Text = "Sipariş Durumu:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(19, 305);
            label8.Margin = new Padding(0, 0, 0, 27);
            label8.Name = "label8";
            label8.Size = new Size(143, 29);
            label8.TabIndex = 4;
            label8.Text = "Sipariş Türü:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            label8.Click += label8_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(19, 249);
            label3.Margin = new Padding(0, 0, 0, 27);
            label3.Name = "label3";
            label3.Size = new Size(160, 29);
            label3.TabIndex = 3;
            label3.Text = "Sipariş STT:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(19, 193);
            label4.Margin = new Padding(0, 0, 0, 27);
            label4.Name = "label4";
            label4.Size = new Size(143, 29);
            label4.TabIndex = 2;
            label4.Text = "Sipariş OT:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(19, 137);
            label2.Margin = new Padding(0, 0, 0, 27);
            label2.Name = "label2";
            label2.Size = new Size(172, 29);
            label2.TabIndex = 1;
            label2.Text = "Sipariş Açıklaması:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label2_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form8";
            Text = "Yeni Sipariş Oluşturma";
            Load += Form8_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSiparisMiktarı).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelSiparisveren;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxSiparisNo;
        private TextBox textBoxSiparisAcıklamasi;
        private TextBox textBoxSiparisinSahibi;
        private ComboBox comboBoxCihazId;
        private ComboBox comboBoxDurumu;
        private DateTimePicker dateTimePickerSiparisSTT;
        private DateTimePicker dateTimePickerSiparisOT;
        private ComboBox comboBoxSiparisTuru;
        private Button btnSiparisOluştur;
        private NumericUpDown numericUpDownSiparisMiktarı;
    }
}
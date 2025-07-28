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
            label1.Location = new Point(17, 61);
            label1.Margin = new Padding(0, 0, 0, 20);
            label1.Name = "label1";
            label1.Size = new Size(125, 22);
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
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 413);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint_1;
            // 
            // numericUpDownSiparisMiktarı
            // 
            numericUpDownSiparisMiktarı.Location = new Point(169, 313);
            numericUpDownSiparisMiktarı.Name = "numericUpDownSiparisMiktarı";
            numericUpDownSiparisMiktarı.Size = new Size(385, 23);
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
            btnSiparisOluştur.Location = new Point(601, 343);
            btnSiparisOluştur.Name = "btnSiparisOluştur";
            btnSiparisOluştur.Size = new Size(141, 42);
            btnSiparisOluştur.TabIndex = 19;
            btnSiparisOluştur.Text = "Kaydet";
            btnSiparisOluştur.UseVisualStyleBackColor = false;
            btnSiparisOluştur.Click += btnSiparisOluştur_Click;
            // 
            // comboBoxSiparisTuru
            // 
            comboBoxSiparisTuru.FormattingEnabled = true;
            comboBoxSiparisTuru.Items.AddRange(new object[] { "Üretim Siparişi", "Bakım Siparişi", "Standart Sipariş", "Acil Sipariş", "Tekrar Sipariş", "Numune Siparişi", "Özel Üretim Siparişi" });
            comboBoxSiparisTuru.Location = new Point(169, 229);
            comboBoxSiparisTuru.Name = "comboBoxSiparisTuru";
            comboBoxSiparisTuru.Size = new Size(385, 23);
            comboBoxSiparisTuru.TabIndex = 18;
            comboBoxSiparisTuru.SelectedIndexChanged += comboBoxSiparisTuru_SelectedIndexChanged;
            // 
            // textBoxSiparisinSahibi
            // 
            textBoxSiparisinSahibi.Location = new Point(171, 355);
            textBoxSiparisinSahibi.Name = "textBoxSiparisinSahibi";
            textBoxSiparisinSahibi.Size = new Size(383, 23);
            textBoxSiparisinSahibi.TabIndex = 16;
            // 
            // comboBoxCihazId
            // 
            comboBoxCihazId.FormattingEnabled = true;
            comboBoxCihazId.Location = new Point(169, 19);
            comboBoxCihazId.Name = "comboBoxCihazId";
            comboBoxCihazId.Size = new Size(385, 23);
            comboBoxCihazId.TabIndex = 15;
            comboBoxCihazId.SelectedIndexChanged += comboBoxCihazId_SelectedIndexChanged;
            // 
            // comboBoxDurumu
            // 
            comboBoxDurumu.FormattingEnabled = true;
            comboBoxDurumu.Items.AddRange(new object[] { "Beklemede", "Onaylandı", "Hazırlanıyor", "Üretimde", "Paketlendi", "Kargoya Verildi", "Teslim Edildi", "Tamamlandı", "İptal Edildi" });
            comboBoxDurumu.Location = new Point(168, 271);
            comboBoxDurumu.Name = "comboBoxDurumu";
            comboBoxDurumu.Size = new Size(386, 23);
            comboBoxDurumu.TabIndex = 14;
            // 
            // dateTimePickerSiparisSTT
            // 
            dateTimePickerSiparisSTT.Location = new Point(170, 186);
            dateTimePickerSiparisSTT.Name = "dateTimePickerSiparisSTT";
            dateTimePickerSiparisSTT.Size = new Size(384, 23);
            dateTimePickerSiparisSTT.TabIndex = 12;
            // 
            // dateTimePickerSiparisOT
            // 
            dateTimePickerSiparisOT.Location = new Point(169, 145);
            dateTimePickerSiparisOT.Name = "dateTimePickerSiparisOT";
            dateTimePickerSiparisOT.Size = new Size(385, 23);
            dateTimePickerSiparisOT.TabIndex = 11;
            // 
            // textBoxSiparisAcıklamasi
            // 
            textBoxSiparisAcıklamasi.Location = new Point(170, 103);
            textBoxSiparisAcıklamasi.Multiline = true;
            textBoxSiparisAcıklamasi.Name = "textBoxSiparisAcıklamasi";
            textBoxSiparisAcıklamasi.Size = new Size(384, 22);
            textBoxSiparisAcıklamasi.TabIndex = 10;
            // 
            // textBoxSiparisNo
            // 
            textBoxSiparisNo.Location = new Point(169, 61);
            textBoxSiparisNo.Multiline = true;
            textBoxSiparisNo.Name = "textBoxSiparisNo";
            textBoxSiparisNo.Size = new Size(385, 22);
            textBoxSiparisNo.TabIndex = 9;
            textBoxSiparisNo.TextChanged += textBox1_TextChanged;
            // 
            // label9
            // 
            label9.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(17, 19);
            label9.Margin = new Padding(0, 0, 0, 20);
            label9.Name = "label9";
            label9.Size = new Size(125, 22);
            label9.TabIndex = 8;
            label9.Text = "Cihaz Id:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelSiparisveren
            // 
            labelSiparisveren.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelSiparisveren.Location = new Point(17, 355);
            labelSiparisveren.Margin = new Padding(0, 0, 0, 20);
            labelSiparisveren.Name = "labelSiparisveren";
            labelSiparisveren.Size = new Size(140, 22);
            labelSiparisveren.TabIndex = 7;
            labelSiparisveren.Text = "Sipariş Veren:";
            labelSiparisveren.TextAlign = ContentAlignment.MiddleLeft;
            labelSiparisveren.Click += label5_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(17, 313);
            label6.Margin = new Padding(0, 0, 0, 20);
            label6.Name = "label6";
            label6.Size = new Size(125, 22);
            label6.TabIndex = 6;
            label6.Text = "Sipariş Miktarı:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(17, 271);
            label7.Margin = new Padding(0, 0, 0, 20);
            label7.Name = "label7";
            label7.Size = new Size(140, 22);
            label7.TabIndex = 5;
            label7.Text = "Sipariş Durumu:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(17, 229);
            label8.Margin = new Padding(0, 0, 0, 20);
            label8.Name = "label8";
            label8.Size = new Size(125, 22);
            label8.TabIndex = 4;
            label8.Text = "Sipariş Türü:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            label8.Click += label8_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(17, 187);
            label3.Margin = new Padding(0, 0, 0, 20);
            label3.Name = "label3";
            label3.Size = new Size(140, 22);
            label3.TabIndex = 3;
            label3.Text = "Sipariş STT:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(17, 145);
            label4.Margin = new Padding(0, 0, 0, 20);
            label4.Name = "label4";
            label4.Size = new Size(125, 22);
            label4.TabIndex = 2;
            label4.Text = "Sipariş OT:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(17, 103);
            label2.Margin = new Padding(0, 0, 0, 20);
            label2.Name = "label2";
            label2.Size = new Size(140, 22);
            label2.TabIndex = 1;
            label2.Text = "Sipariş Açıklaması:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label2_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
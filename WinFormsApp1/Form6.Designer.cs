namespace ERP_MES
{
    partial class Form6
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            panel1 = new Panel();
            btnGuncelle = new Button();
            textBoxGuncelleCihazAciklamasi = new TextBox();
            label5 = new Label();
            textBoxGuncelleCihazTuru = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBoxGuncelleCihazAdi = new TextBox();
            label1 = new Label();
            textBoxGuncelleCihazId = new TextBox();
            dataGridViewCihazGoruntule = new DataGridView();
            txtAramaCihazGoruntule = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCihazGoruntule).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnGuncelle);
            panel1.Controls.Add(textBoxGuncelleCihazAciklamasi);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBoxGuncelleCihazTuru);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxGuncelleCihazAdi);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxGuncelleCihazId);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(449, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 356);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.MistyRose;
            btnGuncelle.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnGuncelle.FlatAppearance.MouseDownBackColor = Color.Red;
            btnGuncelle.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btnGuncelle.Location = new Point(230, 293);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(128, 36);
            btnGuncelle.TabIndex = 11;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // textBoxGuncelleCihazAciklamasi
            // 
            textBoxGuncelleCihazAciklamasi.Location = new Point(169, 172);
            textBoxGuncelleCihazAciklamasi.Multiline = true;
            textBoxGuncelleCihazAciklamasi.Name = "textBoxGuncelleCihazAciklamasi";
            textBoxGuncelleCihazAciklamasi.Size = new Size(189, 101);
            textBoxGuncelleCihazAciklamasi.TabIndex = 5;
            textBoxGuncelleCihazAciklamasi.TextChanged += textBoxGoruntuleCihazAciklamasi_TextChanged;
            // 
            // label5
            // 
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label5.ImageAlign = ContentAlignment.BottomCenter;
            label5.Location = new Point(6, 172);
            label5.Name = "label5";
            label5.Size = new Size(157, 29);
            label5.TabIndex = 10;
            label5.Text = "Cihaz Açıklaması:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            label5.Click += label5_Click;
            // 
            // textBoxGuncelleCihazTuru
            // 
            textBoxGuncelleCihazTuru.Location = new Point(169, 116);
            textBoxGuncelleCihazTuru.Multiline = true;
            textBoxGuncelleCihazTuru.Name = "textBoxGuncelleCihazTuru";
            textBoxGuncelleCihazTuru.Size = new Size(189, 36);
            textBoxGuncelleCihazTuru.TabIndex = 4;
            textBoxGuncelleCihazTuru.TextChanged += textBoxGoruntuleCihazTuru_TextChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label4.ImageAlign = ContentAlignment.BottomCenter;
            label4.Location = new Point(6, 116);
            label4.Name = "label4";
            label4.Size = new Size(143, 29);
            label4.TabIndex = 9;
            label4.Text = "Cihaz Türü:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label3.ImageAlign = ContentAlignment.BottomCenter;
            label3.Location = new Point(6, 62);
            label3.Name = "label3";
            label3.Size = new Size(119, 29);
            label3.TabIndex = 8;
            label3.Text = "Cihaz Adı:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.Click += label3_Click;
            // 
            // textBoxGuncelleCihazAdi
            // 
            textBoxGuncelleCihazAdi.Location = new Point(169, 62);
            textBoxGuncelleCihazAdi.Multiline = true;
            textBoxGuncelleCihazAdi.Name = "textBoxGuncelleCihazAdi";
            textBoxGuncelleCihazAdi.Size = new Size(189, 36);
            textBoxGuncelleCihazAdi.TabIndex = 3;
            textBoxGuncelleCihazAdi.TextChanged += textBoxGoruntuleCihazAdi_TextChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(6, 10);
            label1.Name = "label1";
            label1.Size = new Size(150, 29);
            label1.TabIndex = 6;
            label1.Text = "Cihaz Id:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // textBoxGuncelleCihazId
            // 
            textBoxGuncelleCihazId.Location = new Point(169, 10);
            textBoxGuncelleCihazId.Multiline = true;
            textBoxGuncelleCihazId.Name = "textBoxGuncelleCihazId";
            textBoxGuncelleCihazId.Size = new Size(189, 36);
            textBoxGuncelleCihazId.TabIndex = 2;
            textBoxGuncelleCihazId.TextChanged += textBoxGoruntuleCihazId_TextChanged;
            // 
            // dataGridViewCihazGoruntule
            // 
            dataGridViewCihazGoruntule.BackgroundColor = SystemColors.Info;
            dataGridViewCihazGoruntule.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewCihazGoruntule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCihazGoruntule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Info;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.AliceBlue;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewCihazGoruntule.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCihazGoruntule.Location = new Point(12, 41);
            dataGridViewCihazGoruntule.Name = "dataGridViewCihazGoruntule";
            dataGridViewCihazGoruntule.Size = new Size(431, 356);
            dataGridViewCihazGoruntule.TabIndex = 13;
            dataGridViewCihazGoruntule.CellContentClick += dataGridViewCihazGoruntule_CellContentClick;
            // 
            // txtAramaCihazGoruntule
            // 
            txtAramaCihazGoruntule.Location = new Point(12, 12);
            txtAramaCihazGoruntule.Name = "txtAramaCihazGoruntule";
            txtAramaCihazGoruntule.Size = new Size(388, 23);
            txtAramaCihazGoruntule.TabIndex = 12;
            txtAramaCihazGoruntule.TextChanged += txtAramaCihazGoruntule_TextChanged;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(830, 446);
            Controls.Add(panel1);
            Controls.Add(dataGridViewCihazGoruntule);
            Controls.Add(txtAramaCihazGoruntule);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form6";
            Text = "Cihaz Bilgileri Düzenle ve Güncelle";
            Load += Form6_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCihazGoruntule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBoxGuncelleCihazAciklamasi;
        private Label label5;
        private TextBox textBoxGuncelleCihazTuru;
        private Label label4;
        private Label label3;
        private TextBox textBoxGuncelleCihazAdi;
        private Label label1;
        private TextBox textBoxGuncelleCihazId;
        private DataGridView dataGridViewCihazGoruntule;
        private TextBox txtAramaCihazGoruntule;
        private Button btnGuncelle;
    }
}
namespace ERP_MES
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            panel1 = new Panel();
            btnSil = new Button();
            textBoxSilCihazAciklamasi = new TextBox();
            label5 = new Label();
            textBoxSilCihazTuru = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBoxSilCihazAdi = new TextBox();
            label1 = new Label();
            textBoxSilCihazId = new TextBox();
            dataGridViewCihazSil = new DataGridView();
            txtAramaCihazSil = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCihazSil).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnSil);
            panel1.Controls.Add(textBoxSilCihazAciklamasi);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBoxSilCihazTuru);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxSilCihazAdi);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxSilCihazId);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(449, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 356);
            panel1.TabIndex = 17;
            panel1.Paint += panel1_Paint;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.MistyRose;
            btnSil.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnSil.FlatAppearance.MouseDownBackColor = Color.Red;
            btnSil.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btnSil.Location = new Point(230, 293);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(128, 36);
            btnSil.TabIndex = 11;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // textBoxSilCihazAciklamasi
            // 
            textBoxSilCihazAciklamasi.Location = new Point(169, 172);
            textBoxSilCihazAciklamasi.Multiline = true;
            textBoxSilCihazAciklamasi.Name = "textBoxSilCihazAciklamasi";
            textBoxSilCihazAciklamasi.Size = new Size(189, 101);
            textBoxSilCihazAciklamasi.TabIndex = 5;
            textBoxSilCihazAciklamasi.TextChanged += textBoxSilCihazAciklamasi_TextChanged;
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
            // textBoxSilCihazTuru
            // 
            textBoxSilCihazTuru.Location = new Point(169, 116);
            textBoxSilCihazTuru.Multiline = true;
            textBoxSilCihazTuru.Name = "textBoxSilCihazTuru";
            textBoxSilCihazTuru.Size = new Size(189, 36);
            textBoxSilCihazTuru.TabIndex = 4;
            textBoxSilCihazTuru.TextChanged += textBoxSilCihazTuru_TextChanged;
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
            // textBoxSilCihazAdi
            // 
            textBoxSilCihazAdi.Location = new Point(169, 62);
            textBoxSilCihazAdi.Multiline = true;
            textBoxSilCihazAdi.Name = "textBoxSilCihazAdi";
            textBoxSilCihazAdi.Size = new Size(189, 36);
            textBoxSilCihazAdi.TabIndex = 3;
            textBoxSilCihazAdi.TextChanged += textBoxSilCihazAdi_TextChanged;
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
            // textBoxSilCihazId
            // 
            textBoxSilCihazId.Location = new Point(169, 10);
            textBoxSilCihazId.Multiline = true;
            textBoxSilCihazId.Name = "textBoxSilCihazId";
            textBoxSilCihazId.Size = new Size(189, 36);
            textBoxSilCihazId.TabIndex = 2;
            textBoxSilCihazId.TextChanged += textBoxSilCihazId_TextChanged;
            // 
            // dataGridViewCihazSil
            // 
            dataGridViewCihazSil.BackgroundColor = SystemColors.Info;
            dataGridViewCihazSil.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCihazSil.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCihazSil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Info;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.AliceBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewCihazSil.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCihazSil.Location = new Point(12, 49);
            dataGridViewCihazSil.Name = "dataGridViewCihazSil";
            dataGridViewCihazSil.Size = new Size(431, 356);
            dataGridViewCihazSil.TabIndex = 16;
            dataGridViewCihazSil.CellContentClick += dataGridViewCihazSil_CellContentClick;
            // 
            // txtAramaCihazSil
            // 
            txtAramaCihazSil.Location = new Point(12, 20);
            txtAramaCihazSil.Name = "txtAramaCihazSil";
            txtAramaCihazSil.Size = new Size(388, 23);
            txtAramaCihazSil.TabIndex = 15;
            txtAramaCihazSil.TextChanged += txtAramaCihazSil_TextChanged;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(830, 446);
            Controls.Add(panel1);
            Controls.Add(dataGridViewCihazSil);
            Controls.Add(txtAramaCihazSil);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form7";
            Text = "Cihaz Sil";
            Load += Form7_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCihazSil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnSil;
        private TextBox textBoxSilCihazAciklamasi;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private DataGridView dataGridViewCihazSil;
        private TextBox txtAramaCihazSil;
        private TextBox textBoxSilCihazTuru;
        private TextBox textBoxSilCihazAdi;
        private TextBox textBoxSilCihazId;
    }
}
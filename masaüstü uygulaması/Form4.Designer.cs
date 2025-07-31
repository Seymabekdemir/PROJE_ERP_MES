namespace ERP_MES
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            txtAramaCihazGoruntule = new TextBox();
            dataGridViewCihazGoruntule = new DataGridView();
            textBoxGoruntuleCihazId = new TextBox();
            textBoxGoruntuleCihazAdi = new TextBox();
            textBoxGoruntuleCihazTuru = new TextBox();
            textBoxGoruntuleCihazAciklamasi = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCihazGoruntule).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtAramaCihazGoruntule
            // 
            txtAramaCihazGoruntule.Location = new Point(12, 12);
            txtAramaCihazGoruntule.Name = "txtAramaCihazGoruntule";
            txtAramaCihazGoruntule.Size = new Size(388, 23);
            txtAramaCihazGoruntule.TabIndex = 0;
            txtAramaCihazGoruntule.TextChanged += txtAramaCihazGoruntule_TextChanged;
            // 
            // dataGridViewCihazGoruntule
            // 
            dataGridViewCihazGoruntule.BackgroundColor = SystemColors.Info;
            dataGridViewCihazGoruntule.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCihazGoruntule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCihazGoruntule.Location = new Point(12, 41);
            dataGridViewCihazGoruntule.Name = "dataGridViewCihazGoruntule";
            dataGridViewCihazGoruntule.Size = new Size(431, 356);
            dataGridViewCihazGoruntule.TabIndex = 1;
            dataGridViewCihazGoruntule.CellContentClick += dataGridViewCihazGoruntule_CellContentClick;
            // 
            // textBoxGoruntuleCihazId
            // 
            textBoxGoruntuleCihazId.Location = new Point(169, 10);
            textBoxGoruntuleCihazId.Multiline = true;
            textBoxGoruntuleCihazId.Name = "textBoxGoruntuleCihazId";
            textBoxGoruntuleCihazId.Size = new Size(189, 36);
            textBoxGoruntuleCihazId.TabIndex = 2;
            // 
            // textBoxGoruntuleCihazAdi
            // 
            textBoxGoruntuleCihazAdi.Location = new Point(169, 62);
            textBoxGoruntuleCihazAdi.Multiline = true;
            textBoxGoruntuleCihazAdi.Name = "textBoxGoruntuleCihazAdi";
            textBoxGoruntuleCihazAdi.Size = new Size(189, 36);
            textBoxGoruntuleCihazAdi.TabIndex = 3;
            textBoxGoruntuleCihazAdi.TextChanged += textBox2_TextChanged_1;
            // 
            // textBoxGoruntuleCihazTuru
            // 
            textBoxGoruntuleCihazTuru.Location = new Point(169, 116);
            textBoxGoruntuleCihazTuru.Multiline = true;
            textBoxGoruntuleCihazTuru.Name = "textBoxGoruntuleCihazTuru";
            textBoxGoruntuleCihazTuru.Size = new Size(189, 36);
            textBoxGoruntuleCihazTuru.TabIndex = 4;
            // 
            // textBoxGoruntuleCihazAciklamasi
            // 
            textBoxGoruntuleCihazAciklamasi.Location = new Point(169, 172);
            textBoxGoruntuleCihazAciklamasi.Multiline = true;
            textBoxGoruntuleCihazAciklamasi.Name = "textBoxGoruntuleCihazAciklamasi";
            textBoxGoruntuleCihazAciklamasi.Size = new Size(189, 101);
            textBoxGoruntuleCihazAciklamasi.TabIndex = 5;
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
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(textBoxGoruntuleCihazAciklamasi);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBoxGoruntuleCihazTuru);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxGoruntuleCihazAdi);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxGoruntuleCihazId);
            panel1.Location = new Point(449, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 291);
            panel1.TabIndex = 11;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(830, 446);
            Controls.Add(panel1);
            Controls.Add(dataGridViewCihazGoruntule);
            Controls.Add(txtAramaCihazGoruntule);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            Text = "Cihazlar görüntüle";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCihazGoruntule).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAramaCihazGoruntule;
        private DataGridView dataGridViewCihazGoruntule;
        private TextBox textBoxGoruntuleCihazId;
        private TextBox textBoxGoruntuleCihazAdi;
        private TextBox textBoxGoruntuleCihazTuru;
        private TextBox textBoxGoruntuleCihazAciklamasi;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
    }
}
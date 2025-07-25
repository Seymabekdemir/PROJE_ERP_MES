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
            textBoxGoruntuleCihazAciklaması = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCihazGoruntule).BeginInit();
            SuspendLayout();
            // 
            // txtAramaCihazGoruntule
            // 
            txtAramaCihazGoruntule.Location = new Point(12, 12);
            txtAramaCihazGoruntule.Name = "txtAramaCihazGoruntule";
            txtAramaCihazGoruntule.Size = new Size(388, 23);
            txtAramaCihazGoruntule.TabIndex = 0;
            // 
            // dataGridViewCihazGoruntule
            // 
            dataGridViewCihazGoruntule.BackgroundColor = SystemColors.Info;
            dataGridViewCihazGoruntule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCihazGoruntule.Location = new Point(12, 41);
            dataGridViewCihazGoruntule.Name = "dataGridViewCihazGoruntule";
            dataGridViewCihazGoruntule.Size = new Size(388, 356);
            dataGridViewCihazGoruntule.TabIndex = 1;
            dataGridViewCihazGoruntule.CellContentClick += dataGridViewCihazGoruntule_CellContentClick;
            // 
            // textBoxGoruntuleCihazId
            // 
            textBoxGoruntuleCihazId.Location = new Point(606, 41);
            textBoxGoruntuleCihazId.Multiline = true;
            textBoxGoruntuleCihazId.Name = "textBoxGoruntuleCihazId";
            textBoxGoruntuleCihazId.Size = new Size(189, 36);
            textBoxGoruntuleCihazId.TabIndex = 2;
            // 
            // textBoxGoruntuleCihazAdi
            // 
            textBoxGoruntuleCihazAdi.Location = new Point(606, 93);
            textBoxGoruntuleCihazAdi.Multiline = true;
            textBoxGoruntuleCihazAdi.Name = "textBoxGoruntuleCihazAdi";
            textBoxGoruntuleCihazAdi.Size = new Size(189, 36);
            textBoxGoruntuleCihazAdi.TabIndex = 3;
            textBoxGoruntuleCihazAdi.TextChanged += textBox2_TextChanged_1;
            // 
            // textBoxGoruntuleCihazTuru
            // 
            textBoxGoruntuleCihazTuru.Location = new Point(606, 147);
            textBoxGoruntuleCihazTuru.Multiline = true;
            textBoxGoruntuleCihazTuru.Name = "textBoxGoruntuleCihazTuru";
            textBoxGoruntuleCihazTuru.Size = new Size(189, 36);
            textBoxGoruntuleCihazTuru.TabIndex = 4;
            // 
            // textBoxGoruntuleCihazAciklaması
            // 
            textBoxGoruntuleCihazAciklaması.Location = new Point(606, 203);
            textBoxGoruntuleCihazAciklaması.Multiline = true;
            textBoxGoruntuleCihazAciklaması.Name = "textBoxGoruntuleCihazAciklaması";
            textBoxGoruntuleCihazAciklaması.Size = new Size(189, 101);
            textBoxGoruntuleCihazAciklaması.TabIndex = 5;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(428, 41);
            label1.Name = "label1";
            label1.Size = new Size(165, 29);
            label1.TabIndex = 6;
            label1.Text = "Cihaz Id:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ImageAlign = ContentAlignment.BottomCenter;
            label3.Location = new Point(428, 93);
            label3.Name = "label3";
            label3.Size = new Size(134, 29);
            label3.TabIndex = 8;
            label3.Text = "Cihaz Adı:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ImageAlign = ContentAlignment.BottomCenter;
            label4.Location = new Point(428, 147);
            label4.Name = "label4";
            label4.Size = new Size(158, 29);
            label4.TabIndex = 9;
            label4.Text = "Cihaz Türü:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ImageAlign = ContentAlignment.BottomCenter;
            label5.Location = new Point(428, 203);
            label5.Name = "label5";
            label5.Size = new Size(172, 29);
            label5.TabIndex = 10;
            label5.Text = "Cihaz Açıklaması:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(830, 446);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBoxGoruntuleCihazAciklaması);
            Controls.Add(textBoxGoruntuleCihazTuru);
            Controls.Add(textBoxGoruntuleCihazAdi);
            Controls.Add(textBoxGoruntuleCihazId);
            Controls.Add(dataGridViewCihazGoruntule);
            Controls.Add(txtAramaCihazGoruntule);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            Text = "Cihazlar görüntüle";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCihazGoruntule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAramaCihazGoruntule;
        private DataGridView dataGridViewCihazGoruntule;
        private TextBox textBoxGoruntuleCihazId;
        private TextBox textBoxGoruntuleCihazAdi;
        private TextBox textBoxGoruntuleCihazTuru;
        private TextBox textBoxGoruntuleCihazAciklaması;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
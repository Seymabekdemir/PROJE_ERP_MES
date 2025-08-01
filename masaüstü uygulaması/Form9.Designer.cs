namespace ERP_MES
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            textBoxAramaSiparis = new TextBox();
            dataGridViewSiparisDurumTakip = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxDurumOT = new TextBox();
            textBoxDurumSTT = new TextBox();
            textBoxDurumSiparisDurum = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSiparisDurumTakip).BeginInit();
            SuspendLayout();
            // 
            // textBoxAramaSiparis
            // 
            textBoxAramaSiparis.Location = new Point(12, 12);
            textBoxAramaSiparis.Name = "textBoxAramaSiparis";
            textBoxAramaSiparis.Size = new Size(783, 23);
            textBoxAramaSiparis.TabIndex = 0;
            textBoxAramaSiparis.TextChanged += textBoxAramaSiparis_TextChanged;
            // 
            // dataGridViewSiparisDurumTakip
            // 
            dataGridViewSiparisDurumTakip.BackgroundColor = SystemColors.Info;
            dataGridViewSiparisDurumTakip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSiparisDurumTakip.Location = new Point(12, 41);
            dataGridViewSiparisDurumTakip.Name = "dataGridViewSiparisDurumTakip";
            dataGridViewSiparisDurumTakip.RowHeadersWidth = 51;
            dataGridViewSiparisDurumTakip.Size = new Size(783, 207);
            dataGridViewSiparisDurumTakip.TabIndex = 1;
            dataGridViewSiparisDurumTakip.CellContentClick += dataGridViewSiparisDurumTakip_CellContentClick;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 261);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 20);
            label1.Size = new Size(270, 43);
            label1.TabIndex = 2;
            label1.Text = "Siparişin oluşturulma tarihi:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 311);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 20);
            label2.Size = new Size(270, 40);
            label2.TabIndex = 3;
            label2.Text = "Siparişin Son Teslim Tarihi:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(12, 360);
            label3.Name = "label3";
            label3.Size = new Size(233, 22);
            label3.TabIndex = 4;
            label3.Text = "Sipariş Durumu:";
            label3.Click += label3_Click;
            // 
            // textBoxDurumOT
            // 
            textBoxDurumOT.Location = new Point(303, 261);
            textBoxDurumOT.Multiline = true;
            textBoxDurumOT.Name = "textBoxDurumOT";
            textBoxDurumOT.Size = new Size(286, 25);
            textBoxDurumOT.TabIndex = 10;
            textBoxDurumOT.TextChanged += textBox1_TextChanged;
            // 
            // textBoxDurumSTT
            // 
            textBoxDurumSTT.Location = new Point(303, 311);
            textBoxDurumSTT.Multiline = true;
            textBoxDurumSTT.Name = "textBoxDurumSTT";
            textBoxDurumSTT.Size = new Size(286, 25);
            textBoxDurumSTT.TabIndex = 11;
            textBoxDurumSTT.TextChanged += textBox2_TextChanged;
            // 
            // textBoxDurumSiparisDurum
            // 
            textBoxDurumSiparisDurum.Location = new Point(303, 365);
            textBoxDurumSiparisDurum.Margin = new Padding(3, 2, 3, 2);
            textBoxDurumSiparisDurum.Name = "textBoxDurumSiparisDurum";
            textBoxDurumSiparisDurum.Size = new Size(286, 23);
            textBoxDurumSiparisDurum.TabIndex = 12;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxDurumSiparisDurum);
            Controls.Add(textBoxDurumSTT);
            Controls.Add(textBoxDurumOT);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewSiparisDurumTakip);
            Controls.Add(textBoxAramaSiparis);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form9";
            Text = "Sipariş Durumu Takip Ekranı";
            Load += Form9_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSiparisDurumTakip).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAramaSiparis;
        private DataGridView dataGridViewSiparisDurumTakip;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxDurumOT;
        private TextBox textBoxDurumSTT;
        private TextBox textBoxDurumSiparisDurum;
    }
}
namespace ERP_MES
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            textBoxDetayCihazArama = new TextBox();
            dataGridViewDetaySiparisTablosu = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBoxDetaySiparisNO = new TextBox();
            textBoxDetaySiparisOT = new TextBox();
            textBoxDetaySiparisSTT = new TextBox();
            textBoxDetaySiparisTuru = new TextBox();
            textBoxDetaySiparisMiktarı = new TextBox();
            textBoxDetaySiparisVeren = new TextBox();
            textBoxDetayCihazAdı = new TextBox();
            textBoxDetaySiparisAciklaması = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetaySiparisTablosu).BeginInit();
            SuspendLayout();
            // 
            // textBoxDetayCihazArama
            // 
            textBoxDetayCihazArama.Location = new Point(12, 12);
            textBoxDetayCihazArama.Name = "textBoxDetayCihazArama";
            textBoxDetayCihazArama.Size = new Size(776, 23);
            textBoxDetayCihazArama.TabIndex = 0;
            textBoxDetayCihazArama.TextChanged += textBoxDetayCihazArama_TextChanged;
            // 
            // dataGridViewDetaySiparisTablosu
            // 
            dataGridViewDetaySiparisTablosu.BackgroundColor = SystemColors.Info;
            dataGridViewDetaySiparisTablosu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetaySiparisTablosu.Location = new Point(12, 41);
            dataGridViewDetaySiparisTablosu.Name = "dataGridViewDetaySiparisTablosu";
            dataGridViewDetaySiparisTablosu.Size = new Size(776, 147);
            dataGridViewDetaySiparisTablosu.TabIndex = 1;
            dataGridViewDetaySiparisTablosu.CellContentClick += dataGridViewDetaySiparisTablosu_CellContentClick;
            // 
            // label1
            // 
            label1.Location = new Point(29, 203);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 2;
            label1.Text = "Sipariş No:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Location = new Point(29, 250);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 3;
            label2.Text = "Sipariş OT:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Location = new Point(29, 296);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 5;
            label3.Text = "Sipariş STT:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Location = new Point(29, 343);
            label4.Name = "label4";
            label4.Size = new Size(83, 23);
            label4.TabIndex = 4;
            label4.Text = "Sipariş Türü:";
            // 
            // label5
            // 
            label5.Location = new Point(416, 247);
            label5.Name = "label5";
            label5.Size = new Size(83, 23);
            label5.TabIndex = 7;
            label5.Text = "Sipariş Veren:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Location = new Point(416, 191);
            label6.Name = "label6";
            label6.Size = new Size(83, 44);
            label6.TabIndex = 6;
            label6.Text = "Sipariş Miktarı:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Location = new Point(416, 331);
            label7.Name = "label7";
            label7.Size = new Size(83, 38);
            label7.TabIndex = 9;
            label7.Text = "Sipariş Açıklaması:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Location = new Point(416, 291);
            label8.Name = "label8";
            label8.Size = new Size(83, 33);
            label8.TabIndex = 8;
            label8.Text = "Sipariş edilen Cihazın Adı:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxDetaySiparisNO
            // 
            textBoxDetaySiparisNO.Location = new Point(118, 203);
            textBoxDetaySiparisNO.Name = "textBoxDetaySiparisNO";
            textBoxDetaySiparisNO.Size = new Size(262, 23);
            textBoxDetaySiparisNO.TabIndex = 10;
            textBoxDetaySiparisNO.TextChanged += textBox2_TextChanged;
            // 
            // textBoxDetaySiparisOT
            // 
            textBoxDetaySiparisOT.Location = new Point(118, 247);
            textBoxDetaySiparisOT.Name = "textBoxDetaySiparisOT";
            textBoxDetaySiparisOT.Size = new Size(262, 23);
            textBoxDetaySiparisOT.TabIndex = 11;
            textBoxDetaySiparisOT.TextChanged += textBoxDetaySiparisOT_TextChanged;
            // 
            // textBoxDetaySiparisSTT
            // 
            textBoxDetaySiparisSTT.Location = new Point(118, 296);
            textBoxDetaySiparisSTT.Name = "textBoxDetaySiparisSTT";
            textBoxDetaySiparisSTT.Size = new Size(262, 23);
            textBoxDetaySiparisSTT.TabIndex = 12;
            textBoxDetaySiparisSTT.TextChanged += textBoxDetaySiparisSTT_TextChanged;
            // 
            // textBoxDetaySiparisTuru
            // 
            textBoxDetaySiparisTuru.Location = new Point(118, 340);
            textBoxDetaySiparisTuru.Name = "textBoxDetaySiparisTuru";
            textBoxDetaySiparisTuru.Size = new Size(262, 23);
            textBoxDetaySiparisTuru.TabIndex = 13;
            textBoxDetaySiparisTuru.TextChanged += textBoxDetaySiparisTuru_TextChanged;
            // 
            // textBoxDetaySiparisMiktarı
            // 
            textBoxDetaySiparisMiktarı.Location = new Point(505, 200);
            textBoxDetaySiparisMiktarı.Name = "textBoxDetaySiparisMiktarı";
            textBoxDetaySiparisMiktarı.Size = new Size(262, 23);
            textBoxDetaySiparisMiktarı.TabIndex = 14;
            textBoxDetaySiparisMiktarı.TextChanged += textBoxDetaySiparisMiktarı_TextChanged;
            // 
            // textBoxDetaySiparisVeren
            // 
            textBoxDetaySiparisVeren.Location = new Point(505, 247);
            textBoxDetaySiparisVeren.Name = "textBoxDetaySiparisVeren";
            textBoxDetaySiparisVeren.Size = new Size(262, 23);
            textBoxDetaySiparisVeren.TabIndex = 15;
            textBoxDetaySiparisVeren.TextChanged += textBoxDetaySiparisVeren_TextChanged;
            // 
            // textBoxDetayCihazAdı
            // 
            textBoxDetayCihazAdı.Location = new Point(505, 296);
            textBoxDetayCihazAdı.Name = "textBoxDetayCihazAdı";
            textBoxDetayCihazAdı.Size = new Size(262, 23);
            textBoxDetayCihazAdı.TabIndex = 16;
            textBoxDetayCihazAdı.TextChanged += textBoxDetayCihazAdı_TextChanged;
            // 
            // textBoxDetaySiparisAciklaması
            // 
            textBoxDetaySiparisAciklaması.Location = new Point(505, 340);
            textBoxDetaySiparisAciklaması.Multiline = true;
            textBoxDetaySiparisAciklaması.Name = "textBoxDetaySiparisAciklaması";
            textBoxDetaySiparisAciklaması.ScrollBars = ScrollBars.Vertical;
            textBoxDetaySiparisAciklaması.Size = new Size(262, 86);
            textBoxDetaySiparisAciklaması.TabIndex = 17;
            textBoxDetaySiparisAciklaması.TextChanged += textBoxDetaySiparisAciklaması_TextChanged;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxDetaySiparisAciklaması);
            Controls.Add(textBoxDetayCihazAdı);
            Controls.Add(textBoxDetaySiparisVeren);
            Controls.Add(textBoxDetaySiparisMiktarı);
            Controls.Add(textBoxDetaySiparisTuru);
            Controls.Add(textBoxDetaySiparisSTT);
            Controls.Add(textBoxDetaySiparisOT);
            Controls.Add(textBoxDetaySiparisNO);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewDetaySiparisTablosu);
            Controls.Add(textBoxDetayCihazArama);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form10";
            Text = "Sipariş Detayı";
            Load += Form10_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetaySiparisTablosu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDetayCihazArama;
        private DataGridView dataGridViewDetaySiparisTablosu;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxDetaySiparisNO;
        private TextBox textBoxDetaySiparisOT;
        private TextBox textBoxDetaySiparisSTT;
        private TextBox textBoxDetaySiparisTuru;
        private TextBox textBoxDetaySiparisMiktarı;
        private TextBox textBoxDetaySiparisVeren;
        private TextBox textBoxDetayCihazAdı;
        private TextBox textBoxDetaySiparisAciklaması;
    }
}
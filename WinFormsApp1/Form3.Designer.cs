namespace ERP_MES
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(664, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 524);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button5
            // 
            button5.BackColor = Color.Thistle;
            button5.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button5.FlatAppearance.MouseDownBackColor = Color.MediumOrchid;
            button5.FlatAppearance.MouseOverBackColor = Color.Violet;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button5.Location = new Point(25, 160);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(223, 68);
            button5.TabIndex = 5;
            button5.Text = "SİPARİŞİ AYRINTILI GÖR";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Thistle;
            button4.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button4.FlatAppearance.MouseDownBackColor = Color.MediumOrchid;
            button4.FlatAppearance.MouseOverBackColor = Color.Violet;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.Location = new Point(25, 411);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(223, 56);
            button4.TabIndex = 4;
            button4.Text = "SİPARİŞ SİL";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Thistle;
            button3.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button3.FlatAppearance.MouseDownBackColor = Color.MediumOrchid;
            button3.FlatAppearance.MouseOverBackColor = Color.Violet;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(25, 331);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(223, 56);
            button3.TabIndex = 3;
            button3.Text = "SİPARİŞİ GÜNCELLE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Thistle;
            button2.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button2.FlatAppearance.MouseDownBackColor = Color.MediumOrchid;
            button2.FlatAppearance.MouseOverBackColor = Color.Violet;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(25, 253);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(223, 56);
            button2.TabIndex = 2;
            button2.Text = "SİPARİŞ DURUMU İZLE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 12.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(223, 43);
            label1.TabIndex = 1;
            label1.Tag = "";
            label1.Text = "SİPARİŞLER MENÜSÜ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Thistle;
            button1.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button1.FlatAppearance.MouseDownBackColor = Color.MediumOrchid;
            button1.FlatAppearance.MouseOverBackColor = Color.Violet;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(25, 81);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(223, 56);
            button1.TabIndex = 0;
            button1.Text = "YENİ SİPARİŞ OLUŞTUR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ControlText;
            label2.ImageAlign = ContentAlignment.TopLeft;
            label2.Location = new Point(24, 16);
            label2.Name = "label2";
            label2.Padding = new Padding(29, 13, 11, 7);
            label2.Size = new Size(619, 71);
            label2.TabIndex = 6;
            label2.Text = "Güncel Sipariş Listesi:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Info;
            dataGridView1.Location = new Point(24, 96);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(619, 445);
            dataGridView1.TabIndex = 5;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(949, 595);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            Text = "Siparişler";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Label label1;
        private Button button1;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
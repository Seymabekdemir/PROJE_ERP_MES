﻿namespace ERP_MES
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            buttonCihazekle = new Button();
            textBoxCihazId = new TextBox();
            textBoxCihazAdi = new TextBox();
            textBoxCihazTuru = new TextBox();
            textBoxCihazAcıklaması = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCihazekle
            // 
            buttonCihazekle.BackColor = Color.MistyRose;
            buttonCihazekle.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            buttonCihazekle.FlatAppearance.MouseDownBackColor = Color.Red;
            buttonCihazekle.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            buttonCihazekle.FlatStyle = FlatStyle.Flat;
            buttonCihazekle.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonCihazekle.Location = new Point(444, 339);
            buttonCihazekle.Name = "buttonCihazekle";
            buttonCihazekle.Size = new Size(162, 38);
            buttonCihazekle.TabIndex = 0;
            buttonCihazekle.Text = "Ekle";
            buttonCihazekle.UseVisualStyleBackColor = false;
            buttonCihazekle.Click += buttonCihazEkle_Click;
            // 
            // textBoxCihazId
            // 
            textBoxCihazId.Location = new Point(228, 22);
            textBoxCihazId.Multiline = true;
            textBoxCihazId.Name = "textBoxCihazId";
            textBoxCihazId.Size = new Size(378, 40);
            textBoxCihazId.TabIndex = 1;
            textBoxCihazId.TextChanged += textBox1_TextChanged;
            // 
            // textBoxCihazAdi
            // 
            textBoxCihazAdi.Location = new Point(228, 86);
            textBoxCihazAdi.Multiline = true;
            textBoxCihazAdi.Name = "textBoxCihazAdi";
            textBoxCihazAdi.Size = new Size(378, 40);
            textBoxCihazAdi.TabIndex = 2;
            textBoxCihazAdi.TextChanged += textBoxCihazAdi_TextChanged;
            // 
            // textBoxCihazTuru
            // 
            textBoxCihazTuru.Location = new Point(228, 147);
            textBoxCihazTuru.Multiline = true;
            textBoxCihazTuru.Name = "textBoxCihazTuru";
            textBoxCihazTuru.Size = new Size(378, 40);
            textBoxCihazTuru.TabIndex = 3;
            textBoxCihazTuru.TextChanged += textBox3_TextChanged;
            // 
            // textBoxCihazAcıklaması
            // 
            textBoxCihazAcıklaması.Location = new Point(228, 211);
            textBoxCihazAcıklaması.Multiline = true;
            textBoxCihazAcıklaması.Name = "textBoxCihazAcıklaması";
            textBoxCihazAcıklaması.Size = new Size(378, 107);
            textBoxCihazAcıklaması.TabIndex = 4;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(9, 22);
            label1.Name = "label1";
            label1.Size = new Size(213, 40);
            label1.TabIndex = 5;
            label1.Text = "Cihaz Id:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ImageAlign = ContentAlignment.BottomCenter;
            label3.Location = new Point(9, 86);
            label3.Name = "label3";
            label3.Size = new Size(213, 40);
            label3.TabIndex = 7;
            label3.Text = "Cihaz Adı:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ImageAlign = ContentAlignment.BottomCenter;
            label4.Location = new Point(9, 147);
            label4.Name = "label4";
            label4.Size = new Size(213, 40);
            label4.TabIndex = 8;
            label4.Text = "Cihaz Türü:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ImageAlign = ContentAlignment.BottomCenter;
            label5.Location = new Point(9, 211);
            label5.Name = "label5";
            label5.Size = new Size(213, 47);
            label5.TabIndex = 9;
            label5.Text = "Cihaz Açıklaması:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(buttonCihazekle);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxCihazAcıklaması);
            panel1.Controls.Add(textBoxCihazTuru);
            panel1.Controls.Add(textBoxCihazAdi);
            panel1.Controls.Add(textBoxCihazId);
            panel1.Location = new Point(23, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(629, 412);
            panel1.TabIndex = 10;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(830, 446);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form5";
            Text = "Cihaz Ekle";
            Load += Form5_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCihazekle;
        private TextBox textBoxCihazId;
        private TextBox textBoxCihazAdi;
        private TextBox textBoxCihazTuru;
        private TextBox textBoxCihazAcıklaması;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
    }
}
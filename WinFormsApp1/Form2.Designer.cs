
namespace ERP_MES
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            btnCihazGoruntule = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCihazGoruntule);
            panel1.Location = new Point(581, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 394);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.Thistle;
            button4.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button4.FlatAppearance.MouseDownBackColor = Color.MediumOrchid;
            button4.FlatAppearance.MouseOverBackColor = Color.Violet;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.Location = new Point(22, 235);
            button4.Name = "button4";
            button4.Size = new Size(195, 42);
            button4.TabIndex = 4;
            button4.Text = "CİHAZ SİL";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Thistle;
            button3.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button3.FlatAppearance.MouseDownBackColor = Color.MediumOrchid;
            button3.FlatAppearance.MouseOverBackColor = Color.Violet;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(21, 176);
            button3.Name = "button3";
            button3.Size = new Size(195, 42);
            button3.TabIndex = 3;
            button3.Text = "CİHAZ DÜZENLE";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Thistle;
            button2.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button2.FlatAppearance.MouseDownBackColor = Color.MediumOrchid;
            button2.FlatAppearance.MouseOverBackColor = Color.Violet;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(22, 118);
            button2.Name = "button2";
            button2.Size = new Size(195, 42);
            button2.TabIndex = 2;
            button2.Text = "CİHAZ EKLE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 12.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label1.Location = new Point(22, 14);
            label1.Name = "label1";
            label1.Size = new Size(195, 32);
            label1.TabIndex = 1;
            label1.Tag = "";
            label1.Text = "CİHAZLAR MENÜSÜ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // btnCihazGoruntule
            // 
            btnCihazGoruntule.BackColor = Color.Thistle;
            btnCihazGoruntule.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnCihazGoruntule.FlatAppearance.MouseDownBackColor = Color.MediumOrchid;
            btnCihazGoruntule.FlatAppearance.MouseOverBackColor = Color.Violet;
            btnCihazGoruntule.FlatStyle = FlatStyle.Flat;
            btnCihazGoruntule.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCihazGoruntule.Location = new Point(22, 60);
            btnCihazGoruntule.Name = "btnCihazGoruntule";
            btnCihazGoruntule.Size = new Size(195, 42);
            btnCihazGoruntule.TabIndex = 0;
            btnCihazGoruntule.Text = "CİHAZ GÖRÜNTÜLE";
            btnCihazGoruntule.UseVisualStyleBackColor = false;
            btnCihazGoruntule.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Info;
            dataGridView1.Location = new Point(22, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(542, 334);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ControlText;
            label2.ImageAlign = ContentAlignment.TopLeft;
            label2.Location = new Point(22, 12);
            label2.Name = "label2";
            label2.Padding = new Padding(25, 10, 10, 5);
            label2.Size = new Size(542, 53);
            label2.TabIndex = 4;
            label2.Text = "Firmamızın ürettiği cihazlar:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(830, 446);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Cihazlar";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Panel panel1;
        private Button btnCihazGoruntule;
        private Label label1;
        private Button button4;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView1;
        private Label label2;
    }
}
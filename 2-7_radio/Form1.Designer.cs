namespace _2_7_radio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            rd_kadin = new RadioButton();
            rd_erkek = new RadioButton();
            groupBox2 = new GroupBox();
            rd_1 = new RadioButton();
            rd_4 = new RadioButton();
            rd_3 = new RadioButton();
            rd_2 = new RadioButton();
            button1 = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rd_kadin);
            groupBox1.Controls.Add(rd_erkek);
            groupBox1.Location = new Point(51, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(210, 172);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cinsiyet seçiniz";
            // 
            // rd_kadin
            // 
            rd_kadin.AutoSize = true;
            rd_kadin.BackColor = SystemColors.Control;
            rd_kadin.Location = new Point(40, 111);
            rd_kadin.Name = "rd_kadin";
            rd_kadin.Size = new Size(74, 29);
            rd_kadin.TabIndex = 1;
            rd_kadin.TabStop = true;
            rd_kadin.Text = "Kadın";
            rd_kadin.UseVisualStyleBackColor = false;
            // 
            // rd_erkek
            // 
            rd_erkek.AutoSize = true;
            rd_erkek.BackColor = SystemColors.Control;
            rd_erkek.Location = new Point(40, 57);
            rd_erkek.Name = "rd_erkek";
            rd_erkek.Size = new Size(72, 29);
            rd_erkek.TabIndex = 0;
            rd_erkek.TabStop = true;
            rd_erkek.Text = "Erkek";
            rd_erkek.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rd_1);
            groupBox2.Controls.Add(rd_4);
            groupBox2.Controls.Add(rd_3);
            groupBox2.Controls.Add(rd_2);
            groupBox2.Location = new Point(301, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(402, 177);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Eğitim düzeyi";
            // 
            // rd_1
            // 
            rd_1.AutoSize = true;
            rd_1.Location = new Point(18, 59);
            rd_1.Name = "rd_1";
            rd_1.Size = new Size(114, 29);
            rd_1.TabIndex = 3;
            rd_1.TabStop = true;
            rd_1.Text = "Eğitim yok";
            rd_1.UseVisualStyleBackColor = true;
            // 
            // rd_4
            // 
            rd_4.AutoSize = true;
            rd_4.Location = new Point(187, 111);
            rd_4.Name = "rd_4";
            rd_4.Size = new Size(107, 29);
            rd_4.TabIndex = 2;
            rd_4.TabStop = true;
            rd_4.Text = "Üniversite";
            rd_4.UseVisualStyleBackColor = true;
            // 
            // rd_3
            // 
            rd_3.AutoSize = true;
            rd_3.Location = new Point(187, 59);
            rd_3.Name = "rd_3";
            rd_3.Size = new Size(59, 29);
            rd_3.TabIndex = 1;
            rd_3.TabStop = true;
            rd_3.Text = "Lise";
            rd_3.UseVisualStyleBackColor = true;
            // 
            // rd_2
            // 
            rd_2.AutoSize = true;
            rd_2.Location = new Point(18, 111);
            rd_2.Name = "rd_2";
            rd_2.Size = new Size(87, 29);
            rd_2.TabIndex = 0;
            rd_2.TabStop = true;
            rd_2.Text = "İlk okul";
            rd_2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(91, 302);
            button1.Name = "button1";
            button1.Size = new Size(223, 45);
            button1.TabIndex = 3;
            button1.Text = "anketi gönder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(365, 307);
            label1.Name = "label1";
            label1.Size = new Size(0, 30);
            label1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 487);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 13F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rd_kadin;
        private RadioButton rd_erkek;
        private GroupBox groupBox2;
        private RadioButton rd_1;
        private RadioButton rd_4;
        private RadioButton rd_3;
        private RadioButton rd_2;
        private Button button1;
        private Label label1;
    }
}

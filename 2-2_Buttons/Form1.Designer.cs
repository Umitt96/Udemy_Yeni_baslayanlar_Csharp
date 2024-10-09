namespace _2_2_Buttons
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
            kln_adi = new TextBox();
            button1 = new Button();
            kln_sifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // kln_adi
            // 
            kln_adi.Location = new Point(140, 106);
            kln_adi.Name = "kln_adi";
            kln_adi.Size = new Size(249, 29);
            kln_adi.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(197, 301);
            button1.Name = "button1";
            button1.Size = new Size(164, 46);
            button1.TabIndex = 1;
            button1.Text = "Giriş yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // kln_sifre
            // 
            kln_sifre.Location = new Point(140, 220);
            kln_sifre.Name = "kln_sifre";
            kln_sifre.Size = new Size(249, 29);
            kln_sifre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 73);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 186);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 4;
            label2.Text = "Şifre";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 437);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(kln_sifre);
            Controls.Add(button1);
            Controls.Add(kln_adi);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox kln_adi;
        private Button button1;
        private TextBox kln_sifre;
        private Label label1;
        private Label label2;
    }
}

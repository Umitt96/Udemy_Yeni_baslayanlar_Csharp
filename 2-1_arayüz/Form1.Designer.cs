﻿namespace _2_1_arayüz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(450, 153);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(220, 28);
            label1.TabIndex = 2;
            label1.Text = "BU BİR LABEL ÖGESİDİR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(466, 221);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(187, 28);
            label2.TabIndex = 3;
            label2.Text = "MERHABA c# FORM";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1197, 726);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.PanNW;
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 15F, FontStyle.Italic | FontStyle.Underline);
            ForeColor = SystemColors.Control;
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İlk form uygulamam";
            WindowState = FormWindowState.Minimized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
    }
}

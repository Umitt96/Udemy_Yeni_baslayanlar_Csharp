namespace _2_5_listbox
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
            listbox = new ListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            input = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // listbox
            // 
            listbox.Font = new Font("Segoe UI", 16F);
            listbox.FormattingEnabled = true;
            listbox.ItemHeight = 30;
            listbox.Items.AddRange(new object[] { "dsfkjdskfjn", "sjdfnsjkdf" });
            listbox.Location = new Point(57, 47);
            listbox.Name = "listbox";
            listbox.Size = new Size(201, 214);
            listbox.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(input);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Location = new Point(297, 47);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(187, 229);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // input
            // 
            input.Location = new Point(3, 3);
            input.Name = "input";
            input.Size = new Size(184, 31);
            input.TabIndex = 2;
            input.KeyDown += input_KeyDown;
            // 
            // button1
            // 
            button1.Location = new Point(3, 40);
            button1.Name = "button1";
            button1.Size = new Size(184, 39);
            button1.TabIndex = 0;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(3, 85);
            button2.Name = "button2";
            button2.Size = new Size(184, 39);
            button2.TabIndex = 1;
            button2.Text = "Hepsini sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(3, 130);
            button3.Name = "button3";
            button3.Size = new Size(184, 39);
            button3.TabIndex = 2;
            button3.Text = "Seçileni sil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(3, 175);
            button4.Name = "button4";
            button4.Size = new Size(184, 39);
            button4.TabIndex = 3;
            button4.Text = "Sırala";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 312);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(listbox);
            Font = new Font("Segoe UI", 13F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listbox;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox input;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}

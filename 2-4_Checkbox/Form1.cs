namespace _2_4_Checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mesaj = "Seçimleriniz:";

            if (checkBox1.Checked)
            {
                mesaj += "\n1. seçenek iþaretlendi";
            }
            if (checkBox2.Checked)
            {
                mesaj += "\n2. seçenek iþaretlendi";
            }
            if (checkBox3.Checked)
            {
                mesaj += "\n3. seçenek iþaretlendi";
            }
            if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
            {
                mesaj += "\nHiçbir seçenek iþaretlenmedi";
            }

            label1.Text = mesaj;
        }
    }
}

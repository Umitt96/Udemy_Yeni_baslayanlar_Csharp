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
            string mesaj = "Se�imleriniz:";

            if (checkBox1.Checked)
            {
                mesaj += "\n1. se�enek i�aretlendi";
            }
            if (checkBox2.Checked)
            {
                mesaj += "\n2. se�enek i�aretlendi";
            }
            if (checkBox3.Checked)
            {
                mesaj += "\n3. se�enek i�aretlendi";
            }
            if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
            {
                mesaj += "\nHi�bir se�enek i�aretlenmedi";
            }

            label1.Text = mesaj;
        }
    }
}

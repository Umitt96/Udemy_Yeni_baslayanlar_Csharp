namespace _2_2_Buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //kln_adi
            //kln_sifre

            string isim = "admin";
            string sifre = "ruhi123";

            if (isim == kln_adi.Text && sifre == kln_sifre.Text)
            {
                MessageBox.Show("Hoþgeldin", "Baþarýlý giriþ");
            }
            else if (kln_adi.Text == "" || kln_sifre.Text == "")
            {
                MessageBox.Show("Kullanýcý adý veya þifre boþ olamaz", "Hata");
            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya þifre hatalý", "Hata");
            }
        }
    }
}

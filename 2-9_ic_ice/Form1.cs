namespace _2_9_ic_ice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.IsMdiContainer = true; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.Text = "Bu bir alt form nesnesidir";

            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}

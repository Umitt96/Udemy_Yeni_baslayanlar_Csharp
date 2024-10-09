namespace _2_5_listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (input.Text != "")
            {
                listbox.Items.Add(input.Text);
                input.Text = "";
                input.Focus();
            }

            else
            {
                MessageBox.Show("Input'un içi boþ olamaz!", "HATA");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listbox.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listbox.Items.Remove(listbox.SelectedItem);
        }

        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && input.Text != "")
            {
                listbox.Items.Add(input.Text);
                input.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listbox.Sorted = true;
        }
    }
}

namespace _2_6_listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Columns.Add("id", 50);
            listView1.Columns.Add("�r�n", 100);
            listView1.Columns.Add("Fiyat", 60);

            listView1.Items.Add(new ListViewItem(new[] { "583", "Karpuz", "40" }));
            listView1.Items.Add(new ListViewItem(new[] { "355", "Elma", "10" }));
            listView1.Items.Add(new ListViewItem(new[] { "733", "Kesme tahtas�", "250" }));
            listView1.Items.Add(new ListViewItem(new[] { "212", "So�uk �ay", "100" }));

            listView1.View = View.Details;
        }
    }
}

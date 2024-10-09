namespace _2_8_Treeview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeView agac_gorunum = new TreeView();
            agac_gorunum.Nodes.Add("Hayvanlar");
            agac_gorunum.Nodes[0].Nodes.Add("Fil");
            agac_gorunum.Nodes[0].Nodes.Add("Sincap");
            agac_gorunum.Nodes[0].Nodes.Add("Ayý");
            agac_gorunum.Nodes[0].Nodes.Add("Bal porsuðu");

            agac_gorunum.Nodes[0].Nodes.Add("Kedigiller");
            agac_gorunum.Nodes[0].Nodes[4].Nodes.Add("Kedi");
            agac_gorunum.Nodes[0].Nodes[4].Nodes.Add("Çita");


            agac_gorunum.Nodes.Add("Bitkiler");
            agac_gorunum.Nodes[1].Nodes.Add("Aloe vera");
            agac_gorunum.Nodes[1].Nodes.Add("Lavanta");
            agac_gorunum.Nodes[1].Nodes.Add("Kakao bitkisi");

            agac_gorunum.Size = new Size(400, 400);
            this.Controls.Add(agac_gorunum);
        }
    }
}

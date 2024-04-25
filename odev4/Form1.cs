namespace odev4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var t = DateTime.Now;
            label1.Text = t.ToString();
        }

        private void yeniKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void ogrenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Okayit o = new Okayit();
            o.Show();
        }

        private void darsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dkayit d = new Dkayit();
            d.Show();
        }



        private void ogrencilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Oliste o = new Oliste();
            o.Show();
        }

        private void darslarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dliste dliste = new Dliste();
            dliste.Show();
        }



        private void grafikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new grafik().Show();
        }



        private void hakkindaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muhammed Barakat made the program." +
                               "Fu computer engineering");
        }



        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new Okayit().Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            new Dkayit().Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            new Oliste().Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            new Dliste().Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muhammed Barakat made the program\n." +
                               "Fu computer engineering");

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            new grafik() .Show();
        }
    }
}
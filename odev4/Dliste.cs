using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev4
{
    public partial class Dliste : Form
    {
        public Dliste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("silmek istiyor mu?", "Sil", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    new YazFile().sil("dars", textBox1.Text);
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        if (listView1.Items[i].SubItems[0].Text == textBox1.Text)
                        {
                            listView1.Items[i].Remove();
                            MessageBox.Show("Silindi.......");
                            break;
                        }
                    }
                    break;
                case DialogResult.No:
                    break;

            }

        }

        private void Dliste_Load(object sender, EventArgs e)
        {
            OkuFile oku = new OkuFile("dars");
            for (int i = 0; i < oku.Dars1.Count; i++)
            {
                string[] bilgi = { oku.Dars1[i], oku.Sinif1[i], oku.Max_sayi1[i] };
                var it = new ListViewItem(bilgi);
                listView1.Items.Add(it);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text; }
            catch { }

        }
    }
}

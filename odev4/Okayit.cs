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
    public partial class Okayit : Form
    {
        public Okayit()
        {
            InitializeComponent();
        }

        private void Kaydit1_Click(object sender, EventArgs e)
        {
            if (Sinif1.Text != "" && Adi1.Text != "" && Soyad1.Text != "" && Not1.Text != "")
            {
                YazFile yaz = new YazFile();
                yaz.ogrenciler(Numara1.Text, Adi1.Text, Soyad1.Text, Sinif1.Text, Dars1.Text, Not1.Text);
                Numara1.Text = "";
                Adi1.Text = "";
                Soyad1.Text = "";
                Not1.Text = "";
                MessageBox.Show("Basarli kaydet");
            }
            else
            {
                MessageBox.Show("Girisler Bos birakmayan");
            }

        }
        OkuFile oku;
        private void Okayit_Load(object sender, EventArgs e)
        {
            oku = new OkuFile("dars");
            Dars1.Items.Clear();
            for (int i = 0; i < oku.Dars1.Count; i++)
            {
                if (i == 0)
                {
                    Dars1.Items.Add(oku.Dars1[i]);
                }

                else if (oku.Dars1[i] != oku.Dars1[i - 1])
                {
                    Dars1.Items.Add(oku.Dars1[i]);
                }
            }
            try { Dars1.SelectedIndex = 0; }
            catch { }


        }

        private void Dars1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sinif1.Enabled = true;
            Sinif1.Items.Clear();
            for (int i = 0; i < oku.Dars1.Count; i++)
            {
                if (Dars1.Text == oku.Dars1[i])
                {
                    Sinif1.Items.Add(oku.Sinif1[i]);
                }

            }
            try { Sinif1.SelectedIndex = 0; }
            catch { }

        }
    }
}

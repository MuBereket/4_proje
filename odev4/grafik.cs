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
    public partial class grafik : Form
    {
        OkuFile oku;
        public grafik()
        {
            oku = new OkuFile("ogrenci");
            InitializeComponent();
        }

        private void grafik_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < oku.Dars1.Count; i++)
            {
                if (i == 0)
                {
                    comboBox1.Items.Add(oku.No1[i]);
                }

                else if (oku.No1[i] != oku.No1[i - 1])
                {
                    comboBox1.Items.Add(oku.No1[i]);
                }
            }
            try { comboBox1.SelectedIndex = 0; }
            catch { }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.Visible = true;
            int index = oku.No1.IndexOf(comboBox1.Text);
            label2.Text = oku.Adi1[index] + " " + oku.Soyadi1[index];

            int x = 20;
            int y = 20;

            for (int i = 0; i < oku.No1.Count; i++)
            {


                if (oku.No1[i] == comboBox1.Text)
                {
                    string dersAdi = oku.Dars1[i];
                    int notu = Convert.ToInt32(oku.Not1[i]);

                    Graphics g = panel1.CreateGraphics();
                    g.DrawString(dersAdi, Font, Brushes.Black, x, y);
                    g.DrawString(notu.ToString(), Font, Brushes.Magenta, 240, y);

                    int Uzunlugu = notu;

                    g.FillRectangle(Brushes.DarkRed, x + 100, y, Uzunlugu, 20);

                    y += 30;
                }

            }

        }
    }
}

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
    public partial class Dkayit : Form
    {
        public Dkayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                YazFile yaz = new YazFile();
                yaz.darslar(textBox1.Text, textBox2.Text, textBox3.Text);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                MessageBox.Show("Basarli kaydet");
            }
            else {
                MessageBox.Show("Girisler Bos birakmayan");
            }
        }
    }
}

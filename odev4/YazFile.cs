using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev4
{
    internal class YazFile
    {
        public YazFile()
        {

        }

        public void darslar(string dars, string sinif, string max_sayi)
        {
            FileStream f = new FileStream("darslar.txt", FileMode.OpenOrCreate);
            f.Close();
            StreamWriter sw = new StreamWriter("darslar.txt", true);
            sw.WriteLine("{0} {1} {2}", dars, sinif, max_sayi);
            sw.Close();

        }
        public void ogrenciler(string no, string adi, string soyadi, string sinif, string dars, string not)
        {
            FileStream f = new FileStream("ogrenciler.txt", FileMode.OpenOrCreate);
            f.Close();
            StreamWriter sw = new StreamWriter("ogrenciler.txt", true);
            sw.WriteLine("{0} {1} {2} {3} {4} {5}", no, adi, soyadi, sinif, dars, not);
            sw.Close();
        }
        public void sil(string tur, string silinecek)
        {
            OkuFile o = new OkuFile(tur);
            switch (tur)
            {
                case "ogrenci":
                    int index = o.No1.IndexOf(silinecek);
                    if (index != -1)
                    {
                        o.No1.RemoveAt(index);
                        o.Adi1.RemoveAt(index);
                        o.Soyadi1.RemoveAt(index);
                        o.Sinif1.RemoveAt(index);
                        o.Dars1.RemoveAt(index);
                        o.Not1.RemoveAt(index);

                        StreamWriter sw = new StreamWriter("ogrenciler.txt");
                        for (int i = 0; i < o.No1.Count; i++)
                        {
                            sw.WriteLine("{0} {1} {2} {3} {4} {5}", o.No1[i], o.Adi1[i], o.Soyadi1[i]
                                , o.Sinif1[i], o.Dars1[i], o.Not1[i]);
                        }
                        sw.Close();
                    }
                    else { MessageBox.Show("Kaldırmak istediğiniz şey mevcut değil"); }
                    break;

                case "dars":
                    int index1 = o.Dars1.IndexOf(silinecek);
                    if (index1 != -1)
                    {
                        o.Dars1.RemoveAt(index1);
                        o.Sinif1.RemoveAt(index1);
                        o.Max_sayi1.RemoveAt(index1);
                      
                        StreamWriter sw2 = new StreamWriter("darslar.txt");
                        for (int i = 0; i < o.Dars1.Count; i++)
                            sw2.WriteLine("{0} {1} {2}", o.Dars1[i], o.Sinif1[i], o.Max_sayi1[i]);
                        sw2.Close();
                    }
                    else { MessageBox.Show("Kaldırmak istediğiniz şey mevcut değil"); }

                    break;
                default: break;


            }
        }
    }
}

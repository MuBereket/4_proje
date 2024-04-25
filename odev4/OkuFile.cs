using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev4
{
    internal class OkuFile
    {
        List<string> Adi=new List<string>();
        List<string> Soyadi = new List<string>();
        List<string> No = new List<string>();
        List<string> Dars = new List<string>();
        List<string> Sinif = new List<string>();
        List<string> Not = new List<string>();
        List<string> Max_sayi = new List<string>();

        public OkuFile(string fileadi)
        {
            switch (fileadi)
            {
                case "dars":
                    darslar(); break;
                case "ogrenci":
                    ogrenciler(); break;
                default:
                    MessageBox.Show("hata"); break;

            }

        }

        public void darslar()
        {
            FileStream f = new FileStream("darslar.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(f);
            ArrayList arr = new ArrayList();
            while (!sr.EndOfStream)
            {               
                arr.Add(sr.ReadLine());
            }
            arr.Sort();
            foreach (string s in arr)
            {
                var grub = s.Split(' ');
                Dars1.Add(grub[0]);
                Sinif1.Add(grub[1]);
                Max_sayi1.Add(grub[2]);
            }
            f.Close();
        }
        public void ogrenciler() {
            FileStream f = new FileStream("ogrenciler.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(f);
            ArrayList arr = new ArrayList();
            while (!sr.EndOfStream)
            {
                arr.Add(sr.ReadLine());
            }
            arr.Sort();
            foreach(string s in arr)
            {

                var grub = s.Split(' ');
                No.Add(grub[0]);
                Adi.Add(grub[1]);
                Soyadi.Add(grub[2]);
                Sinif.Add(grub[3]);
                Dars.Add(grub[4]);
                Not.Add(grub[5]);
            }
            f.Close() ;
        }



        public List<string> Adi1 { get => Adi; set => Adi = value; }
        public List<string> Soyadi1 { get => Soyadi; set => Soyadi = value; }
        public List<string> No1 { get => No; set => No = value; }
        public List<string> Dars1 { get => Dars; set => Dars = value; }
        public List<string> Not1 { get => Not; set => Not = value; }
        
        public List<string> Max_sayi1 { get => Max_sayi; set => Max_sayi = value; }
        public List<string> Sinif1 { get => Sinif; set => Sinif = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertyKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogr = new ogrenci();
            ogr.Set_Ad("Şuayip");
            Console.WriteLine(ogr.Get_Ad());

            personel per = new personel();
            per.isim = ogr.Get_Ad(); //stackOverFlow Exception
            Console.WriteLine(per.isim);
        }
    }
    class ogrenci
    {
        private string Ad;
        private string Soyad;

        public void Set_Ad(string ad)
        {
            Ad = ad;
        }
        public string Get_Ad()
        {
            return Ad;
        }
    }
    class personel
    {
        public string isim
        {
            get { return isim;}
            set { isim = value; }
        }

    }
    class Hoca
    {
        public string Isim { get; set; }
    }
}

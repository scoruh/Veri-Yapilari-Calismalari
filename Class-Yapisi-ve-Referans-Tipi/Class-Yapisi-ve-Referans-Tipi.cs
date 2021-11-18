using System;
using System.Collections.Generic;

namespace veriYapilari.SalihCoruh
{

    public class OgretimElemani
    {
        public int SicilNo { get; set; } //property - özellik
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public bool Cinsiyet { get; set; }


        public OgretimElemani(int sicilno, string adi, string soyadi, bool cinsiyet)
        {
            SicilNo = sicilno;
            Adi = adi;
            SoyAdi = soyadi;
            Cinsiyet = cinsiyet;
        }

        public override string ToString()
        {
            return $"{SicilNo,-5}" +
                   $"{Adi,-7}" +
                   $"{SoyAdi,-14}" +
                   String.Format("{0, -8}", Cinsiyet == true ? "Erkek" : "Kadın");

        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            // tanımlama - atama
            var liste1 = new List<OgretimElemani>()
            {
                new OgretimElemani(125, "Ferhat", "Bozkurt", true),
                new OgretimElemani(126, "Tolga", "Aydın", true),
                new OgretimElemani(127, "Mete", "Yağanoğlu", true),
                new OgretimElemani(128, "Ebru", "Erdem", false),
                new OgretimElemani(129, "Köksal", "Erentürk", true),
                new OgretimElemani(130, "Semra", "Yurttançıkmaz", false)

            };

            Console.WriteLine("Liste 1");
            liste1.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();

            var liste2 = liste1;

            Console.WriteLine("Liste 2");
            liste1.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();

            liste2.Add(new OgretimElemani(131, "Bilal", "Usanmaz", true)); // herhangi bir değişiklik iki listede de uygulanıyor
            liste1.RemoveAt(0);                                            // çünkü stack bölümünde iki stack ayrı yerde olsa da
                                                                           // iki listenin de adresi aynı HEAP bölgesine bakıyor
            Console.ReadKey();                                             // bu yüzden hangi listeye işlem yaparsak aynı işlem diğerinde de gerçekleşecek
            

            Console.WriteLine("Liste 1");
            liste1.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();

            Console.WriteLine("Liste 2");
            liste1.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();



            Console.ReadKey();
        }
    }
}
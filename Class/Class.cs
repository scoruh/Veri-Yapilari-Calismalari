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
                   $"{SoyAdi,-10}" +
                   String.Format("{0, -8}", Cinsiyet == true ? "Erkek" : "Kadın");
                  
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            // tanımlama
            OgretimElemani ogrGor = new OgretimElemani(125, "Ferhat", "Bozkurt", true); // atama
            
                    
            Console.WriteLine(ogrGor);
            Console.ReadKey();
        }
    }
}


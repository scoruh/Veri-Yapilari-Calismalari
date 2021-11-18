using System;
using System.Collections;
using System.Collections.Generic;

namespace veriYapilari.SalihCoruh
{
    
    
    public class Personel
    {
        public Personel(string adi, string soyAdi, decimal maas)
        {
            Adi = adi;
            SoyAdi = soyAdi;
            Maas = maas;
        }

        public int SicilNo { get; set; }
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public decimal Maas { get; set; }

        public override string ToString()
        {
            return $"{Adi} {SoyAdi} {Maas}";
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            // dictionary uygulaması
            var personelListesi = new Dictionary<int, Personel>()
            {
                // alternatif tanımlama
                {110, new Personel("Ferhat","Bozkurt", 7500) },
                {120, new Personel("Tolga","Aydın", 9000) },

            };

            // tanımlama
            personelListesi.Add(100, new Personel("Salih", "Coruh", 5000));

            foreach (var p in personelListesi)
            {
                Console.WriteLine(p);
            }


            Console.ReadLine();
        }
    }
}
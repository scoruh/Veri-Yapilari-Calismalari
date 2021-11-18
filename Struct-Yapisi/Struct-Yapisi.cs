using System;
using System.Collections.Generic;

namespace veriYapilari.SalihCoruh
{
    // tanımlama
    public struct Ogrenci
    {
        // yapılandırıcı metot - constructor
        public Ogrenci(int numara, string adi, string soyAdi, string cinsiyet, string okul)
        {
            Numara = numara;
            Adi = adi;
            SoyAdi = soyAdi;
            Cinsiyet = cinsiyet;
            Okul = okul;
        }


        public string Adi { get; set; } // property - özellik
        public string SoyAdi { get; set; }
        public int Numara { get; set; }
        public string Okul { get; set; }
        public string Cinsiyet { get; set; }

        // geçersiz kılmak - override

        public override string ToString()    // BU METOT İLE SADECE Console.Writeline(ogr) komutunu kullanarak  
        {                                    // override içerisindeki bilgileri yazdırabiliriz.
            return $"{Numara} {Adi}";
        }




    }

    public class Program
    {
        static void Main(string[] args)
        {
            // Kullanım 1
            Ogrenci ogr = new Ogrenci();
            ogr.Numara = 170707048;
            ogr.Adi = "Salih";
            ogr.SoyAdi = "Coruh";
            ogr.Cinsiyet = "Erkek";
            ogr.Okul = "Atatürk Üniversitesi";

            // Kullanım 2
            var ogr2 = new Ogrenci()
            {
                Adi = "Salih",
                SoyAdi = "Coruh",
                Numara = 170707048,
                Okul = "Atatürk Üniversitesi",
                Cinsiyet = "Erkek"
            };

            // Kullanım 3
            var ogr3 = new Ogrenci(170707048, "Salih", "Coruh", "Erkek", "Atatürk Üniversitesi");


            // Kullanım 4
            var ogrenciListesi = new List<Ogrenci>()
            {
                new Ogrenci(170707048, "Salih", "Coruh", "Erkek", "Atatürk Üniversitesi")

            };



            Console.WriteLine($"{ogr.Adi} {ogr.SoyAdi} " + $"{ogr.Numara} " + $"{ogr.Okul} " + $"{ogr.Cinsiyet}");        // Kullanım 1
            Console.WriteLine($"{ogr2.Adi} {ogr2.SoyAdi} " + $"{ogr2.Numara} " + $"{ogr2.Okul} " + $"{ogr2.Cinsiyet}");   // Kullanım 2
            Console.WriteLine($"{ogr3.Adi} {ogr3.SoyAdi} " + $"{ogr3.Numara} " + $"{ogr3.Okul} " + $"{ogr3.Cinsiyet}");   // Kullanım 3


            Console.WriteLine(ogr); // override kısmının Console.Writeline komutu

            foreach (Ogrenci og in ogrenciListesi)
            {
                Console.WriteLine(og); // Kullanım 4
                                       // override kısmında sadece numarayı ve adını yazdırmamızı istediğimiz için burada da
                                       // sadece ad ve numara yazacak
            }

            Console.ReadKey();
        }
    }

}
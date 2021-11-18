using System;
using System.Collections;
using System.Collections.Generic;

namespace veriYapilari.SalihCoruh
{
    public class Sehir : IComparable<Sehir> // interface
    {

        public int PlakaNo { get; set; }
        public string SehirAdi { get; set; }

        public Sehir(int plakaNo, string sehirAdi)
        {
            PlakaNo = plakaNo;
            SehirAdi = sehirAdi;
        }

        public override string ToString()                    // şehirleri yazdırabilmemiz için gerekli override ToString metotu
        {
            return $"{PlakaNo,- 5} {SehirAdi,-15}";
        }

        public int CompareTo(Sehir? other)                   // interfacenin çalışması için gerekn metot
        {                                                    // ve bu metot şehirlere karşılaştırma özelliği kazandırır
            if (this.PlakaNo < other.PlakaNo)                // şehirleri yalın bir "sehirler.Sort()" metotu ile sıralayamayız
            {
                return -1;
            }
            else if (this.PlakaNo == other.PlakaNo)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // list
            // tanımlama - ekleme
            var sayilar = new List<int>() { 25, 53, 18, 34, 45, 75, 63 };
            sayilar.Sort();
            sayilar.ForEach(s => Console.WriteLine(s));
            Console.WriteLine();

            // şehir listesi
            var sehirler = new List<Sehir>()
            {
                new Sehir(25, "Erzurum"),
                new Sehir(53, "Rize"),
                new Sehir(34, "İstanbul"),
                new Sehir(6, "Ankara"),
                new Sehir(55, "Samsun"),
                new Sehir(38, "Kayseri"),
            };
            sehirler.Add(new Sehir(1, "Adana")); // listenin sonuna ekliyoruz ama sıralama bu satırdan sonra gerçekleştiği için sıralamaya dahil oluyor
            sehirler.Sort(); // interface tanımlanmadan bu metot ile sıralama yapılamaz
            sehirler.ForEach(s => Console.WriteLine(s));




            Console.ReadKey();
        }
    }
}
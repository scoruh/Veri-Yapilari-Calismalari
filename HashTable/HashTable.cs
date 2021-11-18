using System;
using System.Collections;
using System.Collections.Generic;

namespace veriYapilari.SalihCoruh
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // hashTable
            // tanımlama
            var sehirler = new Hashtable();

            // ekleme
            sehirler.Add(6, "Ankara");
            sehirler.Add(34, "İstanbul");
            sehirler.Add(25, "Erzurum");
            sehirler.Add(53, "Rize");

            // dolaşma
            foreach (DictionaryEntry item in sehirler)
            {
                Console.WriteLine($"{item.Key,-5} - {item.Value, -20}");
            }
            Console.WriteLine();

            // anahtarları yazdırma
            Console.WriteLine("Anahtarlar (Keys)");
            var anahtarlar = sehirler.Keys;
            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //değerleri yazdırma
            Console.WriteLine("Değerler (Values)");
            ICollection degerler = sehirler.Values;
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // elemana erişme
            Console.WriteLine("Elemana Erişme");
            Console.WriteLine(sehirler[25]);
            Console.WriteLine();

            // eleman çıkarma
            Console.WriteLine("Eleman Silme");
            sehirler.Remove(34);
            
            foreach (DictionaryEntry item in sehirler)
            {
                Console.WriteLine($"{item.Key,-5} - {item.Value,-20}");
            }
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
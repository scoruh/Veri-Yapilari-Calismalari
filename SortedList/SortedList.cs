using System;
using System.Collections;
using System.Collections.Generic;

namespace veriYapilari.SalihCoruh
{

    public class Program
    {
        public static void Main(string[] args)
        {
            // sorted list
            // tanımlama
            var list = new SortedList()
            {
                {1, "Bir" },
                {5, "Beş" },
                {4, "Dört" },
                {7, "Yedi" },
                {9, "Dokuz" },
                {6, "Altı " },
            };

            list.Add(3, "Üç"); // alternatif ekleme

            // dolaşma
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.WriteLine();

            Console.WriteLine("Listedeki eleman sayısı: {0}", list.Count);
            Console.WriteLine("Listenin kapasitesi: {0}", list.Capacity);

            list.TrimToSize(); // listedeki eleman sayısına bağlı olarak kapasiteyi set ettik
            Console.WriteLine("Listenin kapasitesi: {0}\n", list.Capacity);
           

            // elemana erişme
            // key
            Console.WriteLine("Eleman: {0}", list[4]);
            Console.WriteLine();

            // index
            Console.WriteLine("Index: {0}", list.GetByIndex(0));
            Console.WriteLine();

            // getKey
            Console.WriteLine("Key: {0}", list.GetKey(0));
            Console.WriteLine();

            // liste sonundaki elemanın değeri
            Console.WriteLine("Liste sonundaki eleman: {0}", list.GetByIndex(list.Count-1));

            // anahtar alma
            var anahtarlar = list.Keys;
            Console.WriteLine("\nAnahtarlar:");
            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }

            // değerleri alma
            var degerler  = list.Values;
            Console.WriteLine("\nDeğerler:");
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // listedeki bir elemanı güncelleme
            Console.WriteLine("Güncelleme:");
            if (list.ContainsKey(1))
            {
                list[1] = "One"; // güncellenen eleman
            }

            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
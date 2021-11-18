using System;
using System.Collections;
using System.Collections.Generic;

namespace veriYapilari.SalihCoruh
{

    public class Program
    {
        public static void Main(string[] args)
        {
            // sortedlist uygulaması
            // tanımlama
            var kitapIcerigi = new SortedList();
            // ekleme
            kitapIcerigi.Add(1, "Önsöz");
            kitapIcerigi.Add(30, "Class");
            kitapIcerigi.Add(80, "Queue");
            kitapIcerigi.Add(40, "Diziler");
            kitapIcerigi.Add(10, "Veri Türleri");
            kitapIcerigi.Add(70, "Stack");
            kitapIcerigi.Add(50, "HashTable");
            kitapIcerigi.Add(60, "SortedList");
            kitapIcerigi.Add(20, "Struct");


            Console.WriteLine($"{"İÇİNDEKİLER",25}");
            Console.WriteLine(new string('-', 41));

            Console.WriteLine($"{"Konular",-33} {"Sayfalar",8}");

            // dolaşma
            foreach (DictionaryEntry item in kitapIcerigi)
            {
                Console.WriteLine($"{item.Value,-33} {item.Key,8}");
            }


            Console.ReadKey();
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;

namespace veriYapilari.SalihCoruh
{


    public class SortedSet
    {
        public static void Main(string[] args)
        {
            // sortedSet uygulaması
            var sayilar = new List<int>();
            var r = new Random();

            for (int i = 0; i < 100; i++)
            {
                sayilar.Add(r.Next(0,50));
                Console.Write($"{sayilar[i],-3}");
            }
            Console.WriteLine();

            // listedeki benzersiz elemanları bulma
            var benzersizSayi = new SortedSet<int>(sayilar);

            Console.WriteLine();
            Console.WriteLine("\nBenzersiz sayıların listesi\n");
            
            foreach (int s in benzersizSayi)
            {
                Console.Write($"{s,-3}");
            }
            
            Console.WriteLine();
            Console.WriteLine("Benzersiz {0} sayı var. ", benzersizSayi.Count);


            Console.ReadLine();
        }
    }
}
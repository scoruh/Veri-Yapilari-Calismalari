using System;
using System.Collections;
using System.Collections.Generic;

namespace veriYapilari.SalihCoruh
{


    public class Program
    {
        public static void Main(string[] args)
        {
            // sorted dictionary
            // tanımlama
            var kitapIndex = new SortedDictionary<string, List<int>>()
            {
                // alternatif ekleme
                {"HTML" ,new List<int> {8,10,12} },
                {"ASP.NET" ,new List<int> {50,60} },
                {"CSS" ,new List<int> {70,80,90} },
                {"SQL" ,new List<int> {100,110} }
            };

            // ekleme
            kitapIndex.Add("FTP" ,new List<int>() { 3, 5, 7 });
            kitapIndex.Add("Jquery" ,new List<int>() { 20, 30, 40 });

            foreach (var kavram in kitapIndex)
            {
                Console.WriteLine($"Konu: {kavram.Key}");
                foreach (int s in kavram.Value)
                {
                    Console.WriteLine($"\t   Sayfalar: {s}");
                }
            }

            Console.ReadLine();
        }
    }
}
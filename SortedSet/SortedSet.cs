using System;
using System.Collections;
using System.Collections.Generic;

namespace veriYapilari.SalihCoruh
{


    public class SortedSet
    {
        public static void Main(string[] args)
        {
            // sortedSet
            // tanımlama
            var isimListesi = new SortedSet<string>();

            //ekleme
            if (isimListesi.Add("Salih"))
            {
                Console.WriteLine("Salih eklendi.");
            }
            else
            {
                Console.WriteLine("Ekleme başarısız.");
            }
            Console.WriteLine("{0}", isimListesi.Add("Ferhat") == true ? "Ferhat eklendi" : "Ekleme başarısız.");

            isimListesi.Add("Mehmet");
            isimListesi.Add("Ayşe");
            isimListesi.Add("Zeynep");
            isimListesi.Add("Halil");
            isimListesi.Add("Dilara");

            // çıkarma
            isimListesi.Remove("Halil");
            isimListesi.RemoveWhere(deger => deger.Contains("y")); // içinde y olan isimleri silme
            Console.WriteLine("Halil listeden çıkarıldı!");
            
            
            Console.WriteLine("\nİsimler Listesi\n");
            
            //dolaşma
            foreach (string i in isimListesi)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Eleman sayısı: {0}", isimListesi.Count);


            Console.ReadLine();
        }
    }
}
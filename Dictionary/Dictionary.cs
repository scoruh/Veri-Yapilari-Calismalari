using System;
using System.Collections;
using System.Collections.Generic;

namespace veriYapilari.SalihCoruh
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // dictionary
            var telefonKodlari = new Dictionary<int, string>();

            // ekleme
            telefonKodlari.Add(464, "Rize");
            telefonKodlari.Add(442, "Erzurum");
            telefonKodlari.Add(212, "İstanbul");
            telefonKodlari.Add(424, "Elazığ");
            telefonKodlari.Add(332, "Konya");

            // erişme
            telefonKodlari[466] = "Artvin";

            // ContainKey
            if (!telefonKodlari.ContainsKey(312))
            {
                Console.WriteLine("\aAnkara'nın telefon kodu tanımlı değil!"); // \a -> alert sesi vermeye yarar.
                telefonKodlari.Add(312, "Ankara");
                Console.WriteLine("Yeni kod eklendi!");
            }
            Console.WriteLine();

            // ContainsValue
            if (!telefonKodlari.ContainsValue("Malatya"))
            {
                Console.WriteLine("\aMalatya'nın telefon kodu tanımlı değil!");
                telefonKodlari.Add(422, "Ankara");
                Console.WriteLine("Yeni kod eklendi!");
            }
            Console.WriteLine();

            // çıkarma
            telefonKodlari.Remove(332);
            Console.WriteLine("Konya'nın telefon kodu silindi!\n");




            foreach (var s in telefonKodlari)
            {
                Console.WriteLine(s);
            }



            Console.ReadLine();
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;

namespace veriYapilari.SalihCoruh
{

    public class Program
    {
        public static void Main(string[] args)
        {
            // hashtable uygulaması

            // başlığı okuma
            Console.WriteLine("Başlığı giriniz: ");
            string baslik = Console.ReadLine();

            // küçültme işlemi
            baslik = baslik.ToLower();

            // hashtable tanımlama
            var karakterSeti = new Hashtable()
            {
                {'ç', 'c'},
                {'ı', 'i'},
                {'ö', 'o'},
                {'ü', 'u'},
                {'ğ', 'g'},
                {'ş', 's'},
                {' ', '-'},
                {'\'', '-'},
                {'.', '-'},

            };

            foreach (DictionaryEntry item in karakterSeti)
            {
                baslik = baslik.Replace((char)item.Key, (char)item.Value);
            }

            // yeni başlığı ekrana yazdırma
            Console.WriteLine(baslik);

            Console.ReadKey();
        }
    }
}
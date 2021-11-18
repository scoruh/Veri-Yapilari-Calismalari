using System;
using System.Collections;
using System.Collections.Generic;

namespace veriYapilari.SalihCoruh
{


    public class Program
    {
        public static void Main(string[] args)
        {
            // hashSet uygulaması
            // tanımlama
            var sesliHarf = new HashSet<char>()
            {
                'e','ı','i','o','ö','u','ü'  // alternatif ekleme
            };

            Yazdir(sesliHarf);
            
            //ekleme
            sesliHarf.Add('a');  // veri yapısının sıralı çalışmadığını görmek için a harfini sonradan tanımladık
            Console.WriteLine();
            Yazdir(sesliHarf);

            // çıkarma
            sesliHarf.Remove('u');
            Yazdir(sesliHarf);

            var alfabe = new List<char>();
            for (int i = 97; i < 123; i++)
                 alfabe.Add((char)i);
            Console.WriteLine();
            Yazdir(alfabe);

            // Türkçe'de kullanılan sesli harfler
            sesliHarf.ExceptWith(alfabe);
            Yazdir(sesliHarf);

            // alfabe ile türkçe sesli harflerin birleşimi
            sesliHarf.UnionWith(alfabe);
            Yazdir(sesliHarf);




            Console.ReadKey();
        }
        
        static void Yazdir(IEnumerable list)
        {
            int i = 0;
            foreach (char h in list)
            {
                Console.Write($"{h,3}");
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("Eleman sayisi : {0}", i);
            Console.WriteLine();
        }
    }
}
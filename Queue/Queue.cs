using System;
using System.Collections;
using System.Collections.Generic;

namespace veriYapilari.SalihCoruh
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var sesliHarfler = new List<char>()
            {
                'a','e','ı','i','o','ö','u','ü'
            };

            ConsoleKeyInfo secim;
            var kuyruk = new Queue<char>();

            foreach (char k in sesliHarfler)
            {
                Console.WriteLine($"{k} kuruğa eklensin mi? [e/h] ");
                secim = Console.ReadKey();
                Console.WriteLine();
                if (secim.Key==ConsoleKey.E)
                {
                    kuyruk.Enqueue(k);
                    Console.WriteLine($"\n{k} kuyruğa eklendi.");
                    Console.WriteLine($"Kuyruktaki eleman sayısı: {kuyruk.Count}");
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Kuruktan elemanların kaldırılması için Esc tuşuna basınız.");
            secim = Console.ReadKey();
          
            if (secim.Key == ConsoleKey.Escape)
            {
                Console.WriteLine();

                while (kuyruk.Count > 0)
                {
                    Console.Write($"{kuyruk.Peek(),5} kuyruktan çıkartılıyor.");
                    Console.Write($"{kuyruk.Dequeue(),5} kuyruktan çıakrtıldı.");
                    Console.WriteLine($"Kuyruktaki eleman sayısı: {kuyruk.Count}");
                }

                Console.WriteLine("\nKuyruktan çıkarma işlemi tamamlandı!");
            }

            Console.WriteLine("Program bitti.");
            Console.ReadKey();
        }

        private static void QueueTemelOrnekler()
        {
            // queue - kuyruk tanımlama
            var karakterKuyrugu = new Queue<char>();

            // ekleme
            karakterKuyrugu.Enqueue('a');
            karakterKuyrugu.Enqueue('e');
            karakterKuyrugu.Enqueue('ı');
            karakterKuyrugu.Enqueue('i');
            karakterKuyrugu.Enqueue('o');
            karakterKuyrugu.Enqueue('ö');
            karakterKuyrugu.Enqueue('u');
            karakterKuyrugu.Enqueue('ü');

            Console.WriteLine($"Eleman sayısı: {karakterKuyrugu.Count}");
            Console.WriteLine();

            // diziye atama
            var dizi = karakterKuyrugu.ToArray();

            // çıkarma
            Console.WriteLine($"Kuyruğun başındaki eleman: {karakterKuyrugu.Peek()}");
            Console.WriteLine($"{karakterKuyrugu.Dequeue()} kuyruktan çıkartıldı."); // çıkarmalar listenin başından gerçekleşir. ("ilk giren ilk çıkar!")
            Console.WriteLine($"Eleman sayısı: {karakterKuyrugu.Count}");
            Console.WriteLine($"Kuyruğun başındaki eleman: {karakterKuyrugu.Peek()}");




            Console.ReadKey();
        }
    }
}
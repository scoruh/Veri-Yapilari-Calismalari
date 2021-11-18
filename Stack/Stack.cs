using System;
using System.Collections;
using System.Collections.Generic;

namespace veriYapilari.SalihCoruh
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            var sayiYigini = new Stack<int>();

            while (sayi > 0)
            {
                int k = sayi % 10;
                sayiYigini.Push(k);
                sayi = sayi / 10;
            }

            int i = 0;
            int n = sayiYigini.Count - 1;

            foreach (var s in sayiYigini)
            {
                Console.WriteLine($"{s} x {Math.Pow(10, n - i)} = {s * Math.Pow(10, n - i)}");
                i++;
            }
            



            Console.ReadKey();
        }

        private static void KarakterYiginiOrnegi()
        {
            var karakterYigini = new Stack<char>();
            for (int i = 65; i <= 90; i++)
            {
                karakterYigini.Push((char)i);
                Console.WriteLine($"{karakterYigini.Peek()} yığına eklendi.");
                Console.WriteLine($"Yığındaki eleman sayısı: {karakterYigini.Count()}");
            }
            Console.WriteLine();
            Console.WriteLine("Yığından çıkartma işlemi için bir tuşa basın!");
            Console.ReadKey();

            while (karakterYigini.Count > 0)
            {
                Console.WriteLine($"{karakterYigini.Pop()} yığından çıkartıldı.");
                Console.WriteLine($"Yığındaki eleman sayısı: {karakterYigini.Count()}");
            }





            Console.ReadKey();
        }

        private static void StackOrnegi()
        {
            // stack - yığın tanımlama
            var karakterYigini = new Stack<char>();

            // ekleme
            karakterYigini.Push('A');
            Console.WriteLine(karakterYigini.Peek());
            karakterYigini.Push('B');
            Console.WriteLine(karakterYigini.Peek());
            karakterYigini.Push('C');
            Console.WriteLine(karakterYigini.Peek());
            Console.WriteLine();

            // çıkarma
            Console.WriteLine(karakterYigini.Pop() + " Yığından çıkartıldı.");
            Console.WriteLine(karakterYigini.Pop() + " Yığından çıkartıldı.");
            Console.WriteLine(karakterYigini.Pop() + " Yığından çıkartıldı.");

            Console.ReadKey();
        }
    }
}
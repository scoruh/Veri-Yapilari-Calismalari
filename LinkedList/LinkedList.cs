using System;
using System.Collections;
using System.Collections.Generic;

namespace veriYapilari.SalihCoruh
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // linkedlist tanımlama
            var sehirler = new LinkedList<string>();

            // ekleme
            sehirler.AddFirst("Trabzon");
            sehirler.AddFirst("Rize");     // iki kere ilk eleman tanımlarsak en son tanımladığımız eleman ilk sıraya geçer
            sehirler.AddLast("İstanbul");

            sehirler.AddAfter(sehirler.Find("Trabzon"), "Samsun"); // daha önce eklediğimiz bir elemanın sonrasına eleman ekleme
            sehirler.AddBefore(sehirler.First.Next.Next, "Giresun"); // ilk elemanın iki sıra sonrasına eleman ekleme
            sehirler.AddAfter(sehirler.Last.Previous, "Sinop"); // son elemandan bir önceki sıraya eleman ekleme
            sehirler.AddAfter(sehirler.Find("Sinop"), "Zonguldak"); // bulduğumuz bir elemanın sonrasına eleman ekleme

            Console.WriteLine("Gidiş Güzergahı\n");

            var eleman = sehirler.First;

            while (eleman != null)
            {
                Console.WriteLine(eleman.Value);
                eleman = eleman.Next;
            }


            Console.WriteLine("\nDönüş Güzergahı\n");

            var gecici = sehirler.Last;

            while (gecici != null)
            {
                Console.WriteLine(gecici.Value);
                gecici = gecici.Previous;
            }


            Console.ReadLine();
        }
    }
}
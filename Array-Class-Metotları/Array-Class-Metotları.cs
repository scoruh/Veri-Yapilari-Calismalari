using System;
using System.Collections;
using System.Collections.Generic;

namespace veriYapilari.SalihCoruh
{
    public class Program
    {
        static void Main(string[] args)
        {
            // array - dizi - tanımlama
            int[] sayilar = new int[] { 5, 3, 8, 10, 2, 15, 19, 26, 35 };

            var arr = new ArrayList(sayilar); //alternatif dizi oluşturma

            var numbers = Array.CreateInstance(typeof(int), sayilar.Length); //alternatif dizi oluşturma
            

            sayilar.CopyTo(numbers ,0); // başka bir dizideki elemanları numbers dizisine kopyalama
            
            
            Array.Sort(numbers);  //
            Array.Sort(sayilar);  // dizilerin sıralama metotları
            arr.Sort();           //

            var x = Array.IndexOf(sayilar, 19); // 19'un değerini (sırasını) yazdıran metot
            


            Array.Clear(numbers, 2, 3); // numbers dizisinde 2. sıradan başlayıp 3 eleman silen metot



            // dolaşma
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"sayilar[{0}] = {sayilar[i],3} - numbers[{0}] = {numbers.GetValue(i),3} - arr[{i}] = {arr[i],3}");
            }
            
            Console.WriteLine();
            Console.WriteLine($"19'un değeri: {x}"); // 19'un değerini yazdıram komut

            Console.ReadKey();
        }


    }
}
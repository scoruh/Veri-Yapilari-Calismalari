using System;
using System.Collections.Generic;

namespace veriYapilari.SalihCoruh
{
    public class Program
    {
        static void Main(string[] args)
        {
            // array - dizi - tanımlama
            int[] sayilar = new int[] {5,3,8,10,2};            
            
            var numbers = Array.CreateInstance(typeof(int), 5); //alternatif dizi oluşturma
            numbers.SetValue(6, 0);
            numbers.SetValue(7, 1);
            numbers.SetValue(4, 2);
            numbers.SetValue(9, 3);
            numbers.SetValue(1, 4);

            
            // dolaşma
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"sayilar[{0}] = {sayilar[i],3} - numbers[{0}] = {numbers.GetValue(i),3}");
            }

            Console.ReadKey();
        }

        
    }
}
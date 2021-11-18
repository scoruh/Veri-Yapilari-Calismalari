using System;
using System.Collections;
using System.Collections.Generic;

namespace veriYapilari.SalihCoruh
{


    public class SortedSet
    {
        public static void Main(string[] args)
        {
            // sortedSet küme uygulaması 
            
            var A = new SortedSet<int>(RastgeleSayiUret(100));
            var B = new SortedSet<int>(RastgeleSayiUret(100));

            #region yazdirma
            Console.WriteLine();
            Console.WriteLine("A kümesi");
            foreach (int s in A)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine("B kümesi");
            foreach (int s in B)
            {
                Console.Write($"{s,5}");
            }
            #endregion

            // Union

            // A.UnionWith(B);               --> İki kümenin birleşimi
            A.IntersectWith(B);           // --> İki kümenin kesişimi
            // A.ExceptWith(B);              --> Sadece A kümesinde olan elemanlar
            // A.SymmetricExceptWith(B);     --> Sadece B kümesinde olan elemanlar

            Console.WriteLine();
            Console.WriteLine("\n\n Kümelerin kesişimi:");
            
            foreach (var s in A)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine();

            Console.WriteLine("\nToplam sayi : {0}", A.Count);

            Console.WriteLine();
        }
        public static List<int> RastgeleSayiUret(int n)
        {
            var list = new List<int>();
            var r = new Random();
            for (int i = 0; i < n; i++)
                list.Add(r.Next(0, 1000));
            return list;
        }
    }
}
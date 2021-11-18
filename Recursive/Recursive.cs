using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Recursive
    {
        static void Main(string[] args)
        {
            // Recursive - Özyinelemeli
            Console.WriteLine("Faktoriyelini almak istediğiniz sayıyı girin: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int sayac = 0; sayac <= n; sayac++)
            {
                Console.WriteLine("{0}! = {1}", sayac, FaktoriyelHesapla(sayac));
            }

            Console.ReadLine();
        }
        //Faktöriyel hesaplama metodu.
        public static int FaktoriyelHesapla(int sayi)
        {
            if (sayi <= 1)
            {
                return 1;
            }

            else
            {
                return sayi * FaktoriyelHesapla(sayi - 1);
            }
        }
    }
}
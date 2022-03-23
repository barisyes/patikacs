using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eleman sayisi giriniz: ");
            int elemanSayisi = Convert.ToInt32(Console.ReadLine());

            string[] dizi = new string[elemanSayisi];

            for (int i = 0; i < elemanSayisi; i++)
            {
                Console.Write("{0}. elemani giriniz: ", i+1);
                dizi[i] = Console.ReadLine();
            }

            for (int i = elemanSayisi-1; i >= 0; i--)
            {
                Console.Write(dizi[i] + " ");
            }

            Console.ReadLine();
        }
    }
}

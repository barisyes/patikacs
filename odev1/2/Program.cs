using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eleman sayisi giriniz: ");
            int elemanSayisi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Referans sayiyi giriniz: ");
            int refSayi = Convert.ToInt32(Console.ReadLine());

            int[] dizi = new int[elemanSayisi];

            for (int i = 0; i < elemanSayisi; i++)
            {
                Console.Write("{0}. elemani giriniz.", i+1);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < elemanSayisi; i++)
            {
                if (dizi[i]%refSayi==0)
                    Console.Write(dizi[i] + " ");
            }

            Console.ReadLine();
        }
    }
}

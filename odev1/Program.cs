using System;

namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eleman sayisi giriniz: ");
            int elemanSayisi = Convert.ToInt32(Console.ReadLine());

            int[] dizi = new int[elemanSayisi];

            for (int i = 0; i < elemanSayisi; i++)
            {
                Console.Write("{0}. elemani giriniz: ", i+1);                
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < elemanSayisi; i++)
            {
                if(dizi[i]%2==0)
                    Console.Write(dizi[i] + " ");
            }

            Console.ReadLine();
        }
    }
}

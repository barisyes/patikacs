using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cumle giriniz: ");
            string cumle = Console.ReadLine();
            string[] dizi = cumle.Split(" ");
            int kelimeSayisi = dizi.Length;
            Console.WriteLine("Kelime sayisi: {0}", kelimeSayisi);

            int harfSayisi=0;

            for (int i = 0; i < kelimeSayisi; i++)
            {
                harfSayisi += dizi[i].Length;
            }

            Console.WriteLine("Harf sayisi: {0}", harfSayisi);

            Console.ReadLine();
        }
    }
}

using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
            Console.Write("Bir sayi giriniz:");
            int length = int.Parse(Console.ReadLine());
            for (int i = 1; i <= length; i++)
            {
                if(i%2!=0)
                    Console.WriteLine(i);
            }

            //1-1000 arası tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır.
                int tekToplam=0;
                int ciftToplam=0;
            for (int i = 1; i <= 1000; i++)
            {
                if(i%2!=0)
                    tekToplam+=i;
                else
                    ciftToplam+=i;
            }

            Console.WriteLine(tekToplam);
            Console.WriteLine(ciftToplam);

            //break continue
            for (int i = 1; i < 10; i++)
            {
                if (i==4)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if (i==4)
                    continue;
                Console.WriteLine(i);
            }


        }
    }
}

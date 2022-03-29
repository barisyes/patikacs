using System;
using System.Collections;

namespace koleksiyonlar_soru1
{
    class Program
    {
        static void Main(string[] args)
        {
        //Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın.
        // (ArrayList sınıfını kullanara yazınız.)

        // Negatif ve numeric olmayan girişleri engelleyin.
        // Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
        // Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

        int[] dizi = new int[20];

        for (int i = 0; i < 20; i++)
        {   bas:
            Console.WriteLine("{0}. sayiyi giriniz: ", i+1);
            int sayi=Convert.ToInt32(Console.ReadLine());
            if(sayi<0)
            {
                Console.WriteLine("Pozitif sayi giriniz.");
                goto bas;
            }
            else
                dizi[i] = sayi;
        }

        ArrayList prime = new ArrayList();
        ArrayList notprime = new ArrayList();

        foreach (var item in dizi)
        {
            if(item==1)
                notprime.Add(item);
            else if(item==2)
                prime.Add(item);
            else
            {
                int no = 0;
                for (int i = 2; i < item; i++)
                {
                    if(item%i==0)
                        no++;
                }
                if(no==0)
                    prime.Add(item);
                else
                    notprime.Add(item);
            }
        }  //Asal ve asal olmayanlar ayrildi.

        prime.Sort();
        notprime.Sort();

        Console.Write("Asal sayilar: ");
        foreach (var item in prime)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("");

        Console.Write("Asal olmayan sayilar: ");
        foreach (var item in notprime)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("");
        Console.WriteLine("Asal sayilarin adedi:{0}", prime.Count);
        Console.WriteLine("Asal olmayan sayilarin adedi:{0}", notprime.Count);

        
        int topprime = 0;
        foreach(var item in prime)
            topprime += (int)item;
        decimal ortprime = (decimal)topprime/(decimal)prime.Count;

        int topnotprime = 0;
        foreach(var item in notprime)
            topnotprime += (int)item;
        decimal ortnotprime = (decimal)topnotprime/(decimal)notprime.Count;

        Console.WriteLine("Asal olanlarin ortalamsi: {0}", ortprime);
        Console.WriteLine("Asal olmayanlarin ortalamsi: {0}", ortnotprime);

            Console.ReadLine();
        }
    }
}

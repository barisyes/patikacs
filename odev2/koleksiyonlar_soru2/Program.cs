using System;

namespace koleksiyonlar_soru2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
            // her iki grubun kendi içerisinde ortalamalarını alan
            // ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız.
            //(Array sınıfını kullanarak yazınız.)


            int[] dizi = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0}. sayiyi giriniz: ", i+1);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(dizi);

            int[] mindizi = new int[3];
            int[] maxdizi = new int[3];

            for (int i = 0; i < 3; i++)
                mindizi[i] = dizi[i];

            int k = 0;
            for (int i = 19; i > 16; i--)
                maxdizi[k++] = dizi[i];

            foreach (var item in maxdizi)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine(" ");

            foreach (var item in mindizi)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine(" ");
            
            decimal ortmin = Ort(mindizi);
            decimal ortmax = Ort(maxdizi);
            Console.WriteLine(" En kucuk sayilarin ortlamasi: {0}", ortmin);
            Console.WriteLine(" En buyuk sayilarin ortlamasi: {0}", ortmax);

            Console.WriteLine(" Ortalama toplamlari: {0}", ortmin+ortmax);


            Console.ReadLine();
        }
        static decimal Ort(int[] arr)
        {
            decimal top = 0;
            for (int i = 0; i < arr.Length; i++)
                top += arr[i];
            decimal ort = top/(decimal)arr.Length;
            return ort;
            
        }
    }
}

using System;
using System.Collections.Generic;

namespace koleksiyonlar_soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan
            // ve dizinin elemanlarını sıralayan programı yazınız.
            Console.WriteLine("Bir cumle giriniz: ");
            string str = Console.ReadLine();

            string sesli = "AEIOUaeiou";

            List<int> depo = new List<int>();

            
            for(int i=0; i<str.Length; i++)
            {
                for(int k=0; k < sesli.Length; k++)
                if(str[i] == sesli[k])
                {
                    depo.Add(i);
                }
            }

            for (int i = 0; i < depo.Count; i++)
            {
                Console.Write(str[depo[i]]);
            }


            Console.ReadLine();
        }
    }
}

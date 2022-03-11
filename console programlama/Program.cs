using System;

namespace console_programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("isminizi giriniz: ");
            string isim = Console.ReadLine();

            Console.Write("soy isminizi giriniz: ");
            string soyisim = Console.ReadLine();

            Console.WriteLine("merhaba " + isim + " " + soyisim);
            Console.ReadLine();

        }
    }
}

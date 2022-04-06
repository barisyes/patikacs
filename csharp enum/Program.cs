using System;

namespace csharp_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik = 32;

            if(sicaklik<=(int)HavaDurumu.Soguk)
                Console.WriteLine("Hava cok soguk.");
            else if(sicaklik <= (int)HavaDurumu.Normal && sicaklik>(int)HavaDurumu.Soguk)
                Console.WriteLine("Disariya cikmak icin havanin biraz daha isinmasini bekleyelim.");
            else if(sicaklik > (int)HavaDurumu.Normal && sicaklik<=(int)HavaDurumu.Sicak)
                Console.WriteLine("Hadi disari cikalim.");
            else if(sicaklik>=(int)HavaDurumu.Sicak && sicaklik<(int)HavaDurumu.CokSicak)
                Console.WriteLine("Disariya cikmak icin cok sicak.");
            else if(sicaklik>=(int)HavaDurumu.CokSicak)
                Console.WriteLine("Hava cok sicak.");


            Console.ReadLine();
        }
    }
    enum Gunler
    {
        Pazartesi=1,
        Sali,
        Carsamba,
        Persembe,
        Cuma=23,
        Cumartesi,
        Pazar
    }
    enum HavaDurumu
    {
        Soguk=5,
        Normal=20,
        Sicak=25,
        CokSicak=30
    }
}

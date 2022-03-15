using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if(time>=6 && time<11)
                Console.WriteLine("Günaydin");
            if (time<=18)
                Console.WriteLine("İyi gunler");
            else
                Console.WriteLine("İyi geceler");

            string sonuc = time<=18 ? "iyi gunler" : "iyi geceler" ;
            sonuc = time>=6 && time<11 ? "Gunaydin" : time <= 18 ? "iyi günler" : "iyi geceler";
            Console.WriteLine(sonuc);
        }
    }
}

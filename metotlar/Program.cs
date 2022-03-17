using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //erisim_belirteci geri_donustipi metot_adi(parametreListesi/arguman)
            //{
            ////komutlar
            //return;
            //}

            int a=2;
            int b=3;

            Console.WriteLine(a+b);

            int sonuc = Topla(a,b);

            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));


            int sonuc2 = ornek.ArttirVeTopla(ref a, ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a+b));


            Console.ReadLine();
        }
        static int Topla(int deger1, int deger2)
        {
            return deger1+deger2;
        }
    }
    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirVeTopla(ref int d1, ref int d2)
        {
            return (++d1) + (++d2);
        }
    }
}

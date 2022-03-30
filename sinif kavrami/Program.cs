using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            // class SinifAdi
            // {
            //     [Erisim Belirleyici] [Veri Tipi] OzellikAdi;
            //     [Erisim Belirleyici] [Geri Dönüs Tipi] MetodAdi(Parametre Listesi);
            //     {
            //         Metot Komutlari
            //     }
            // }

            //Erisim Belirleyiciler
            //*Public
            //*Private
            //*Internal
            //*Protected

            Calisan calisan1 = new Calisan();
            calisan1.Ad="Ayse";
            calisan1.SoyAd="Kara";
            calisan1.No=23415634;
            calisan1.Departman="Insan Kaynaklari";

            calisan1.CalisanBilgileri();

            Console.WriteLine("********************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad="Deniz";
            calisan2.SoyAd="Arda";
            calisan2.No=25646789;
            calisan2.Departman="Satin Alma";

            calisan2.CalisanBilgileri();


            Console.ReadLine();
        }
    }

    class Calisan
    {
        public string Ad;
        public string SoyAd;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Calisan adi: {0}", Ad);
            Console.WriteLine("Calisan soyadi: {0}", SoyAd);
            Console.WriteLine("Calisan no: {0}", No);
            Console.WriteLine("Calisan departmani: {0}", Departman);
        }

    }
}

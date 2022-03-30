using System;

namespace kurucu_metotlar
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

            Console.WriteLine("*****Calisan1*****");
            Calisan calisan1 = new Calisan("Ayse","Kara",23425634,"Insan Kaynaklari");

            calisan1.CalisanBilgileri();


            Console.WriteLine("*****Calisan2*****");
            Calisan calisan2 = new Calisan("Deniz","Arda",25646789,"Satin Alma");

            calisan2.CalisanBilgileri();

            Console.WriteLine("*****Calisan3*****");
            Calisan calisan3 = new Calisan("Baris","Yesilkaya");
            calisan3.CalisanBilgileri();



            Console.ReadLine();
        }
    }
    class Calisan
    {
        public string Ad,SoyAd,Departman;
       // public string SoyAd;
        public int No;
        //public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.SoyAd = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.SoyAd = soyad;
        }

        public Calisan(){}

        public void CalisanBilgileri()
        {
            Console.WriteLine("Calisan adi: {0}", Ad);
            Console.WriteLine("Calisan soyadi: {0}", SoyAd);
            Console.WriteLine("Calisan no: {0}", No);
            Console.WriteLine("Calisan departmani: {0}", Departman);
        }

    }
}

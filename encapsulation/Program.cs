using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Isim = "Ayse";
            ogrenci1.Soyisim = "Ayse";
            ogrenci1.OgrenciNo = 293;
            ogrenci1.Sinif = 3;
            ogrenci1.OgrenciBilgileriGetir();

            ogrenci1.SinifAtlat();
            ogrenci1.OgrenciBilgileriGetir();

            Ogrenci ogrenci2 = new Ogrenci("Deniz","Arda",256,1);
            ogrenci2.OgrenciBilgileriGetir();
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriGetir();

            Console.ReadLine();
        }
    }
    class Ogrenci
    {
        private string isim, soyisim;
        private int ogrenciNo, sinif;

        public string Isim
        {
            get { return isim; }
            set { isim=value; } 
        }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif
        {
            get => sinif;
            set 
            {
                if(value < 1)
                {
                    Console.WriteLine("Sinif en az 1 olabilir.!");
                    sinif=1;
                }
                else
                    sinif=value;
            } 
        }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci(){}
        public void OgrenciBilgileriGetir()
        {
            Console.WriteLine("*****Ogrenci Bilgileri*****");
            Console.WriteLine("Ogrenci adi: {0}", this.Isim);
            Console.WriteLine("Ogrenci soyadi: {0}", this.Soyisim);
            Console.WriteLine("Ogrenci no: {0}", this.OgrenciNo);
            Console.WriteLine("Ogrenci sinifi: {0}", this.Sinif);
        }
        public void SinifAtlat()
        {
            this.Sinif +=1;
        }
        public void SinifDusur()
        {
            this.Sinif -=1;
        }
    }
}

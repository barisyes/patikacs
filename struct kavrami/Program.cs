using System;

namespace struct_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Diktortgen yenidikdortgen = new Diktortgen();
            // yenidikdortgen.KisaKenar = 3;
            // yenidikdortgen.UzunKenar = 4;
            Console.WriteLine("Class alan hesabi: {0}", yenidikdortgen.AlanHesapla());

            Dikdortgen_Struct dikdortgenStruct = new Dikdortgen_Struct(3,4);
            Console.WriteLine("Struct alan hesabi: {0}", dikdortgenStruct.AlanHesapla());

            Console.ReadLine();
        }
    }
    class Diktortgen
    {
        public int KisaKenar;
        public int UzunKenar;
        public Diktortgen()
        {
            KisaKenar=3;
            UzunKenar=4;
        }
        public long AlanHesapla()
        {
            return KisaKenar*UzunKenar;
        }
    }

    struct Dikdortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;
        public Dikdortgen_Struct(int kisaKenar, int uzunKenar)
        {
            KisaKenar = kisaKenar;
            UzunKenar = uzunKenar;
        }
        public long AlanHesapla()
        {
            return this.KisaKenar*this.UzunKenar;
        }
    }
}

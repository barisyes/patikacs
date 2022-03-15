﻿using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Sayi gir: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sayi= " + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("hata: " +ex.Message.ToString());
            }
            /*finally
            {
                Console.WriteLine("islem tamamlandi.");
            }*/
            
            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-2000000000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş deger girdiniz.");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun degil.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("deger uygun aralikta degil.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("islem basari ile tamamlandi.");
            }



            Console.ReadLine();
        }
    }
}

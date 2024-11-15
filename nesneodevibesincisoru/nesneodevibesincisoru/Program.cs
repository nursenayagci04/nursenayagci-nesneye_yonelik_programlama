// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int dogruSayi = 53;
        int kullaniciTahmini;
        Console.WriteLine("Bir sayı tahmin edin (0 ile 200 arasında):");

        while (true)
        {
            kullaniciTahmini = Convert.ToInt32(Console.ReadLine());
            if (kullaniciTahmini == dogruSayi)
            {
                Console.WriteLine("Tebrikler, doğru tahmin ettin, en büyük Rizeli sensin!");
                break;
            }
            else
            {
                Console.WriteLine("Iyi düşün! Tekrar dene:");
            }
        }
    }
}


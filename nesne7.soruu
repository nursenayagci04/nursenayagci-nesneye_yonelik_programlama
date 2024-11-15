// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> sayilar = new List<int>(); // Kullanıcıdan alınan sayıları saklamak için bir liste

        int sayi;
        int toplam = 0;
        Console.WriteLine("Pozitif tam sayıları giriniz . Girişi sonlandırmak için '0' giriniz:");

        while (true)
        {
            Console.Write("sayıyı girin: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi == 0)
            {
                break;
            }
            else if (sayi > 0)
            {
                sayilar.Add(sayi);
                toplam += sayi; 
            }
            else
            {
                Console.WriteLine("Lütfen sadece pozitif tam sayılar girin.");
            }
        }

        Console.WriteLine("\nGirilen pozitif sayıların toplamı: " + toplam);
        Console.WriteLine("\nGirilen pozitif sayılar:");
        for (int i = 0; i < sayilar.Count; i++)
        {
            Console.WriteLine(sayilar[i]);
        }
    }
}

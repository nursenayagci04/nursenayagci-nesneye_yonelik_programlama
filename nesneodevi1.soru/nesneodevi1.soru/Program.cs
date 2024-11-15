// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList sayilar = new ArrayList();
        sayilar.Add(10);
        sayilar.Add(20);
        sayilar.Add(30);
        sayilar.Add(40);
        sayilar.Add(50);

        
        int toplam = 0;
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
            toplam += sayi;         
        }
        Console.WriteLine("Sayıların Toplamı: " + toplam);
    }
}

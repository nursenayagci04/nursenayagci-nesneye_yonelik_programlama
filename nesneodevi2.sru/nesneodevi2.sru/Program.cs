// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
     
        Console.WriteLine("Bir cümle girin:");
        string cumle = Console.ReadLine();
        string[] kelimeler = cumle.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Cümledeki kelime sayısı: " + kelimeler.Length);
    }
}


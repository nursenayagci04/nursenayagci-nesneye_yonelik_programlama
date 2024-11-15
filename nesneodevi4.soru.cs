// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.Write("Kaç Fibonacci sayısı olsun? ");
        int n = int.Parse(Console.ReadLine());
        long a = 0, b = 1;

        Console.WriteLine("Fibonacci Serisi:");
        if (n >= 1) Console.Write(a + " ");
        if (n >= 2) Console.Write(b + " ");
        for (int i = 3; i <= n; i++)
        {
            long c = a + b;
            Console.Write(c + " ");
            a = b;
            b = c;
        }
    }
}


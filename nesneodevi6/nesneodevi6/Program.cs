// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        string islem;
        double sayi1, sayi2, sonuc;

        do
        {
            Console.WriteLine("Bir işlem seçin (+, -, *, /) ya da çıkmak için 'çıkış' yazın:");
            islem = Console.ReadLine();
            if (islem.ToLower() == "çıkış")
            {
                break;
            }

            Console.Write("Birinci sayıyı girin: ");
            sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İkinci sayıyı girin: ");
            sayi2 =Convert.ToDouble(Console.ReadLine());
            switch (islem)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine($"Sonuç: {sonuc}");
                    break;

                case "-":
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine($"Sonuç: {sonuc}");
                    break;

                case "*":
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine($"Sonuç: {sonuc}");
                    break;

                case "/":
                    if (sayi2 == 0)
                    {
                        Console.WriteLine("Hata Var!!: Bir sayıyı sıfıra bölemezsiniz!");
                    }
                    else
                    {
                        sonuc = sayi1 / sayi2;
                        Console.WriteLine($"Sonuç: {sonuc}");
                    }
                    break;

                default:
                    Console.WriteLine("Geçersiz işlem! Lütfen geçerli bir işlem türü girin (+, -, *, /).");
                    break;
            }

        } while (true);

        Console.WriteLine("Program sonlandırılıyor.");
    }
}


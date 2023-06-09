﻿namespace loops_for_loop;

class Program
{
    static void Main(string[] args)
    {
        int n =6;
        for (int i = 1; i <= n; i++) {
            var spaces = new String(' ', n - i);
            var hashes = new String('#', i);
            Console.WriteLine(spaces + hashes);
        }

        // Ekranda girilen sayıya kadar olan tek sayıları ekrana yazdırır.
        Console.WriteLine("Lütfen bir sayı giriniz:");
        int sayac = int.Parse(Console.ReadLine());
        for (int i = 1; i <= sayac; i++) {
            if(i % 2 == 1)
                Console.WriteLine(i);
        }

        // 1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdırır.
        int tekToplam = 0;
        int ciftToplam = 0;
        for (int i = 1; i <= 1000; i++) {
            if(i % 2 == 1)
                tekToplam += i;
            else
                ciftToplam += i;
        }

        Console.WriteLine("Tek Toplam: " + tekToplam);
        Console.WriteLine("Çift Toplam: " + ciftToplam);

        // break, contune
        for (int i = 1; i < 10; i++)
        {
            if(i == 4)
                break;
            Console.WriteLine(i);
        }
        for (int i = 1; i < 10; i++)
        {
            if(i == 4)
                continue;
            Console.WriteLine(i);
        }

    }
}

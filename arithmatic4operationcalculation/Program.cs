using System;

namespace arithmatic4operationcalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, toplam, fark, carpim, bolum;
            Console.Write("Sayı 1:");
            sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sayı 2:");
            sayi2 = Convert.ToInt16(Console.ReadLine());
            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            carpim = sayi1 * sayi2;
            bolum = sayi1 / sayi2;
            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine("Fark: " + fark);
            Console.WriteLine("Çarpım: " + carpim);
            Console.WriteLine("Bölüm: " + bolum);
        }
    }
}

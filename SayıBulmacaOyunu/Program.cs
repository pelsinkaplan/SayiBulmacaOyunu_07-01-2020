using System;

namespace SayıBulmacaOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tekrarOynayalımMı = true;

            while (tekrarOynayalımMı)
            {
                Random rastgeleSayiUretici = new Random();
                int uretilenSayi = rastgeleSayiUretici.Next(0, 100);
                bool sayiBulunduMu = false;


                while (!sayiBulunduMu)
                {
                    Console.WriteLine("Tahmin alalım :) ");
                    int tahminEdiIenSayi = Convert.ToInt32(Console.ReadLine());

                    if (uretilenSayi > tahminEdiIenSayi)
                    {
                        Console.WriteLine("Yukari!");
                    }
                    else if (uretilenSayi < tahminEdiIenSayi)
                    {
                        Console.WriteLine("Aşağı!");
                    }
                    else
                    {
                        Console.WriteLine("Eureka!");
                        sayiBulunduMu = true;
                    }
                }
                Console.WriteLine("Tekrar oynayalım mı? (0/1)");
                int tekrarOynayalım = Convert.ToInt32(Console.ReadLine());
                bool tekrarSor = true;
                while (tekrarSor)
                {
                    if (tekrarOynayalım == 1)
                    {
                        tekrarOynayalımMı = true;
                        tekrarSor = false;
                    }
                    else if (tekrarOynayalım == 0)
                    {
                        Console.WriteLine("Özletme kendini yine gel :)");
                        tekrarSor = false;
                        tekrarOynayalımMı = false;
                    }
                    else
                    {
                        Console.WriteLine("0 : Tamam / 1 : Devam");
                        tekrarOynayalım = Convert.ToInt32(Console.ReadLine());
                        tekrarSor = true;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}

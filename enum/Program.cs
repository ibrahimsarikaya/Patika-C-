using System;

namespace enums
{
    class Program
    {
        static void Main(string[] args)
        {
            //enum : enumeration demektir. Yani Sıralama.
            Console.WriteLine(Gunler.Pazar); // Çıktısı : Pazar
            Console.WriteLine((int)Gunler.Cumartesi); // Çıktısı : 24

            int sicaklik=32;
            if(sicaklik <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim");
            }
            else if(sicaklik >= (int)HavaDurumu.Sicak)
            {
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
            }
            else if (sicaklik >= (int)HavaDurumu.Normal && sicaklik<(int)HavaDurumu.CokSicak)
            {
                Console.WriteLine("Hadi Dışarıya çıkalım");
            }

            //Çıktı : Dışarıya çıkmak için çok sıcak bir gün
        }
    }
    enum Gunler
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma=23,
        Cumartesi,
        Pazar
    }
    enum HavaDurumu
    {
        Soguk=5,
        Normal = 20,
        Sicak=25,
        CokSicak=30
    }
    
}
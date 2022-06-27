using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //                  Canlılar
            //      Bitkiler                   Hayvanlar
            //  |              |           |               |
            //Tohumlu       Tohumsuz   Surungenler       Kuslar

            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            Console.WriteLine("***********1*********");
            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("***********2*********");

            Kuslar martı = new Kuslar(); // Çıktısı : Hayvanlar Adaptasyon Kurabilir. - Canlılar Beslenir. - Canlılar Boşaltım Yapar. - Canlılar Solunum Yapar.
            //hayvanlar.cs de base ile yazdığımızdan dolayı burada otomatik olarak yazdırdı.
            /* : Kalıtım kurma işlemidir. İki nokta üst üstenin sağ tarafı miras almaya çalıştığımız sınıftır. */ 
            Console.WriteLine("***********3*********");
            martı.Ucar();


        }
    }
}
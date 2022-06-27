using System;

namespace datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); // Çıktısı : 8.06.2022 00:20:55 -- tarih ve saat veriyor saniye dahil.
            Console.WriteLine(DateTime.Now.Date); // Çıktısı : 8.06.2022 -- Sadece tarihi verir.
            Console.WriteLine(DateTime.Now.Day); // Çıktısı : 8 -- günü verir.
            Console.WriteLine(DateTime.Now.Month); // Çıktısı : 6 -- ayı verir.
            Console.WriteLine(DateTime.Now.Year); // Çıktısı : 2022 -- yılı verir.
            Console.WriteLine(DateTime.Now.Hour); // Çıktısı : 0 -- Saati verir.
            Console.WriteLine(DateTime.Now.Minute); // Çıktısı : 23 -- Dakikayı verir.
            Console.WriteLine(DateTime.Now.Second); // Çıktısı : 1 -- Saniyeyi verir.

            Console.WriteLine(DateTime.Now.DayOfWeek); // Çıktısı : Wednesday -- Haftanın gününü verir.
            Console.WriteLine(DateTime.Now.DayOfYear); // Çıktısı : 159 -- Yılın gününü verir.

            Console.WriteLine(DateTime.Now.ToLongDateString()); // Çıktısı : 8 Haziran 2022 Çarşamba -- Gün/Ay/Yıl - haftanın gününü verir.
            Console.WriteLine(DateTime.Now.ToShortDateString()); // Çıktısı : 8.06.2022 -- Gün/Ay/Yıl verir.
            Console.WriteLine(DateTime.Now.ToLongTimeString()); // Çıktısı : 00:57:41 -- Saat/Dakika/Saniye verir.
            Console.WriteLine(DateTime.Now.ToShortTimeString()); // Çıktısı : 00:58 -- Saat/Dakika verir.

            Console.WriteLine(DateTime.Now.AddDays(2)); // Çıktısı : 10.06.2022 00:59:36 -- 2 gün sonrasının tarihi ve şuan ki saat dakika saniye yazıldı.
            Console.WriteLine(DateTime.Now.AddHours(3)); // Çıktısı : 8.06.2022 04:01:25 -- 3 saat sonrasını gösterdi tarihle beraber.
            Console.WriteLine(DateTime.Now.AddSeconds(30));  // Çıktısı : 8.06.2022 01:03:46 -- Saniyeye 30 ekledi.
            Console.WriteLine(DateTime.Now.AddMonths(5)); // Çıktısı : 8.11.2022 01:03:16 -- 5 ay sonrasını verdi.
            Console.WriteLine(DateTime.Now.AddYears(10)); // Çıktısı : 8.06.2032 01:03:16 -- 10 sene sonrasını verdi.
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));  // Çıktısı : 8.06.2022 01:03:17 -- 50 milisaniye sonrasını verdi.

            //DateTime Format

            Console.WriteLine(DateTime.Now.ToString("dd")); // Çıktısı : 08
            Console.WriteLine(DateTime.Now.ToString("ddd")); // Çıktısı : Çar
            Console.WriteLine(DateTime.Now.ToString("dddd")); // Çıktısı : Çarşamba

            Console.WriteLine(DateTime.Now.ToString("MM")); // Çıktısı : 06
            Console.WriteLine(DateTime.Now.ToString("MMM")); // Çıktısı : Haz
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // Çıktısı : Haziran

            Console.WriteLine(DateTime.Now.ToString("yy")); // Çıktısı : 22 
            Console.WriteLine(DateTime.Now.ToString("yyy")); // Çıktısı : 2022

            //Math Kütüphanesi

            Console.WriteLine(Math.Abs(-25)); // Çıktısı : 25
            Console.WriteLine(Math.Sin(10)); // Çıktısı : -0,54402111108893698
            Console.WriteLine(Math.Cos(10)); // Çıktısı : -0,8390715290764524
            Console.WriteLine(Math.Tan(10)); // Çıktısı : 0,6483608274590866

            Console.WriteLine(Math.Ceiling(22.3)); // Çıktısı : 23 -- 22.3 ten büyük en küçük tam sayıyı getirir.
            Console.WriteLine(Math.Round(22.3)); // Çıktısı : 22 -- Hangi tarafa daha yakınsa onu getirir.
            Console.WriteLine(Math.Floor(22.7)); // Çıktısı : 22 -- 22.7 den küçük ama en büyük sayıyı getirir.

            Console.WriteLine(Math.Max(2,6)); // Çıktısı : 6 -- En büyüğü verir.
            Console.WriteLine(Math.Min(2,6)); // Çıktısı : 2 -- En küçüğü verir.

            Console.WriteLine(Math.Pow(3,4)); // Çıktısı : 81 -- 3 üzeri 4 demektir. 
            Console.WriteLine(Math.Sqrt(9)); // Çıktısı : 3 -- 9 un karekökü demektir.
            Console.WriteLine(Math.Log(9)); // Çıktısı : 2,1972245773362196 -- 9 un e tabanındaki logaritmik karşılığını verir.
            Console.WriteLine(Math.Exp(3)); // Çıktısı : 20,085536923187668 -- e üzeri 3 ü verir.
            Console.WriteLine(Math.Log10(10)); // Çıktısı : 10 sayısının logaritma 10 tabanındaki karşılığını verir.
            








        }
    }
}
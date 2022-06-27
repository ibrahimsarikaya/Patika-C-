using System;
using System.Collections.Generic;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //system.colletion.generic
            Dictionary<int,string> kullanıcılar = new Dictionary<int, string>();
            kullanıcılar.Add(10,"Ayşe Yılmaz"); // 10 yazılan yer keydir. İndexi olarakta düşünebiliriz. Ayşe Yılmaz yazan yer ise value dir. üst tarafta int,string tanımladığımız için böyle oldu.
            kullanıcılar.Add(12,"Ahmet Yılmaz");
            kullanıcılar.Add(18,"Deniz Arda");
            kullanıcılar.Add(20,"Özcan Coşar");
            //Not: Aynı key ve value değerlerini ikinci defa kullanamayız. Hata verir.

            //Dizinin elemanlarına erişim
            Console.WriteLine("**** Elemanlara Erişim ****");
            Console.WriteLine(kullanıcılar[12]); // Çıktısı : Ahmet Yılmaz
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item); // Çıktısı : alt alta [10,Ayşe Yılmaz] [12,Ahmet Yılmaz] [18,Deniz Arda] [20,Özcan Coşar] 
            }

            //Count
            Console.WriteLine("**** Count ****");
            Console.WriteLine(kullanıcılar.Count); // Çıktısı : 4

            //Contains
            Console.WriteLine("**** Contains ****");
            Console.WriteLine(kullanıcılar.ContainsKey(12)); // Key'i 12 olan eleman var mı demek. Çıktısı : True 
            Console.WriteLine(kullanıcılar.ContainsValue("İbrahim Sarıkaya")); // Value olarak İbrahim Sarıkaya olan eleman var mı demek. Çıktısı : False

            //Remove
            Console.WriteLine("**** Remove ****");
            kullanıcılar.Remove(12); // Key'i 12 olan eleman silindi.
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item); // Çıktısı : alt alta [10,Ayşe Yılmaz] [18,Deniz Arda] [20,Özcan Coşar] 
            }

            //Keys 
            Console.WriteLine("**** Keys ****");
            foreach (var item in kullanıcılar.Keys)
            {
                Console.WriteLine(item); //Üst tarafta kullanıcılar.keys dediğimiz için sadece keys kısmını aldı. Çıktısı: 10 18 20
            }
            //Values
            Console.WriteLine("**** Values ****");
            foreach (var item in kullanıcılar.Values)
            {
                Console.WriteLine(item);//Üst tarafta kullanıcılar.values dediğimiz için sadece values kısmını aldı. Çıktısı: Ayşe Yılmaz - Deniz Arda - Özcan Coşar
            }


        }
    }
}
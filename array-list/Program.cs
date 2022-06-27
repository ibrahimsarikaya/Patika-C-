using System;
using System.Collections;
using System.Collections.Generic;

namespace Array_List 
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            //liste.Add("Ayşe");
            //liste.Add(2);
            //liste.Add(true);
            //liste.Add('A');

            //içerisindeki verilere erişim
            //Console.WriteLine(liste[1]); // Çıktısı : 2 -> 1. indexteki elemanı yazdırdı.
            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item); // Çıktısı : Ayşe 2 True A -> Listenin elemanlarını yazdı.
            //}

            //AddRange 
            Console.WriteLine("**** Add Range****");
            //string[] renkler ={"Kırmızı","Sarı","Yeşil"};
            List<int> sayılar= new List<int>(){1,8,3,7,9,92,6}; // Yeni bir list oluşturduk.
            //liste.AddRange(renkler);
            liste.AddRange(sayılar); // Bu oluşan listeyi ArrayListe ekledik.

            foreach (var item in liste)
            {
                Console.WriteLine(item); // Çıktısı : 1,8,3,7,9,92,6
            }

            //Sort
            Console.WriteLine("**** Sort ****");
            liste.Sort(); // Küçükten büyüğe sıraladı.

            foreach (var item in liste)
            {
                Console.WriteLine(item); // Çıktısı :1,3,6,7,8,9,92
            }

            // Binary Search
            Console.WriteLine("**** Binary Search ****");
            Console.WriteLine(liste.BinarySearch(9)); // Çıktısı :5 -> 9 un index numarasını verir.

            //Reverse 
            Console.WriteLine("**** Reverse ****");
            liste.Reverse(); // listeyi tersten sıraladık.
            
            foreach (var item in liste)
            {
                Console.WriteLine(item); // Çıktısı : 92,9,8,7,6,3,1
            }

            //Clear 
            Console.WriteLine("**** Clear ****");
            liste.Clear(); // Listeyi temizledik.
            foreach (var item in liste)
            {
                Console.WriteLine(item); // Çıktısı : yok çünkü liste temizlendi.
            }



        }
    }
}
using System;

namespace array_sinifi_methodlar_ // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
           //Sort
           int[] sayiDizisi={21,4,5,33,66,3,11,17};
           Console.WriteLine("**** Sırasız Dizi ****");

           foreach (var sayi in sayiDizisi)
           {
               Console.WriteLine(sayi);
           }
           Console.WriteLine("**** Sıralı Dizi ****");
           Array.Sort(sayiDizisi);
           foreach (var sayi in sayiDizisi)
           {
               Console.WriteLine(sayi);
           }
           //Clear
           Console.WriteLine("**** Array Clear ****");
           Array.Clear(sayiDizisi,2,3); // 2. index dahil olmak üzere 2 elemanı sıfırlar.
           foreach (var sayi in sayiDizisi)
           {
               Console.WriteLine(sayi);
           }
           //Reverse
           Console.WriteLine("**** Array Reverse ****");
           Array.Reverse(sayiDizisi);
           foreach (var sayi in sayiDizisi)
           {
               Console.WriteLine(sayi);
           }
           //indexof
           Console.WriteLine("**** Array İndexOf ****");
           Console.WriteLine(Array.IndexOf(sayiDizisi,3));

           //Resize 
           Console.WriteLine("**** Array Resize ****");
           Array.Resize<int>(ref sayiDizisi, 9); // sayidizisinin boyutunu 9 yapar.
           sayiDizisi[8]=99;
           foreach (var sayi in sayiDizisi)
           {
               Console.WriteLine(sayi);
           }

        }
    }
}
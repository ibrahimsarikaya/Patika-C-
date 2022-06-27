﻿using System;

namespace encapsulation 
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encapsulation > Bir özeliği başka sınıflardan saklamak ya da korumaktır.
            //ÖNEMLİ: Örneğin siz bir propery yani özellik tanımı yaptınız ve diğer sınıflar içerisinden erişilsin ama sadece okumak için erişilsin değeri dışarıdan değiştirilemesin istiyorsunuz. Bunu kapsülleme yaparak sağlayabilirsiniz. Kapsülleme işlemini ise property leri kullanarak yapabilirsiniz.
            //Kapsülleme sayesinden nesneler bilinçsiz olarak kullanımdan korunmuş olur. Fakat bazı durumlarda private field'lara erişmemiz ve özelliklerini değiştirmemiz gerekebilir. Bu durumda Property Kavramı devreye girer. Property bir field'ın değerini geri döndürmeye(Get) ve yeni bir değer(Set) atamaya olanak sağlar.

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşe";
            ogrenci.Soyisim = "Yılmaz";
            ogrenci.OgrenciNo=293;
            ogrenci.Sinif=3;

            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat(); // Sınıfı 4 yaptı.
            ogrenci.OgrenciBilgileriniGetir();
            
            Ogrenci ogrenci1 = new Ogrenci("Deniz","Arda",256,1);
            ogrenci1.SinifDusur(); // Sınıfı 1 düşürdü ama value 1 den küçük olduğu için "Sınıf En Az 1 Olabilir" hatası verdi.
            ogrenci1.SinifDusur();// Sınıfı 1 düşürdü ama value 1 den küçük olduğu için "Sınıf En Az 1 Olabilir" hatası verdi.
            ogrenci1.OgrenciBilgileriniGetir(); //Üstteki hatalar neticesinde sınıf=1 oldu ve ilk atadığımız değerler yazıldı.


        }
    }
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim
        {
            get { return isim; }// alttaki kullanım ile aynı
            set { isim = value; } 
        }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        { 
            get => sinif; 
            set 
            {
                if(value < 1)
                {
                    Console.WriteLine("Sınıf En Az 1 Olabilir.");
                    sinif=1;
                }
                else
                sinif = value;
            } 
        }

        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci(){}

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("***** Öğrenci Bilgileri ****");
            Console.WriteLine("Öğrenci Adı     :{0}",this.Isim);
            Console.WriteLine("Öğrenci Soyadı  :{0}",this.Soyisim);
            Console.WriteLine("Öğrenci No      :{0}",this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı  :{0}",this.Sinif);
            
        }
        public void SinifAtlat()
        {
            this.Sinif = this.Sinif +1;
        }
        public void SinifDusur()
        {
            this.Sinif = this.Sinif -1;
        }
    }
}
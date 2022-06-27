using System;

namespace inheritance
{
    public class Bitkiler:Canlılar
    {
        protected void FotosentezYapmak()
        {
            Console.WriteLine("Bitkiler fotosentez Yapar.");
        }
    }
    public class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler(){
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu Bitkiler Tohumla Çoğalır.");
        }
    }
    public class TohumsuzBitkiler:Bitkiler
    {
        public TohumsuzBitkiler(){
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz Bitkiler Sporla Çoğalır.");
        }
    }
}
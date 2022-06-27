using System;

namespace abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************INTERFACE**************");
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus.StandartRengiNe().ToString());
            Console.WriteLine(focus.KacTekerlekOlusur().ToString());
            Console.WriteLine("******************************");
            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkaninAraci().ToString());
            Console.WriteLine(civic.StandartRengiNe().ToString());
            Console.WriteLine(civic.KacTekerlekOlusur().ToString());
            Console.WriteLine("**************ABSTRACT****************");
            NewFocus focus1 = new NewFocus();
            Console.WriteLine(focus1.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus1.StandartRengiNe().ToString());
            Console.WriteLine(focus1.KacTekerlekOlusur().ToString());
            Console.WriteLine("******************************");
            NewCivic civic1 = new NewCivic();
            Console.WriteLine(civic1.HangiMarkaninAraci().ToString());
            Console.WriteLine(civic1.StandartRengiNe().ToString());
            Console.WriteLine(civic1.KacTekerlekOlusur().ToString());



        }
    }
}
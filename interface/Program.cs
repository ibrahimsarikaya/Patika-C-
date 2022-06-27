using System;

namespace arayuzler
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus.StandartRengiNe().ToString());
            Console.WriteLine(focus.KacTekerlekOlusur().ToString());

            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkaninAraci().ToString());
            Console.WriteLine(civic.StandartRengiNe().ToString());
            Console.WriteLine(civic.KacTekerlekOlusur().ToString());


        }
    }
}
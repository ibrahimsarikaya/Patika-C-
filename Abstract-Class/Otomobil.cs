namespace abstract_class
{
    public abstract class Otomobil
    {
        public int KacTekerlekOlusur()
        {
            return 4;
        }

        public virtual Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }

        public abstract Marka HangiMarkaninAraci();
        
    }
}
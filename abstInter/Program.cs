namespace abstInter;

class Program
{
    static void Main(string[] args)
    {
        Mensch mensch = new Mensch();
        mensch.Bewegen();
        Fisch fisch = new Fisch();
        fisch.Bewegen();
        fisch.Schwimmen();
    }
}
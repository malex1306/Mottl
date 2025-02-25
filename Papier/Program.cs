namespace Papier;

class Program
{
    static void Main(string[] args)
    {
        Papier meinPapier = new Papier(10,10);
        Papier meinPapier2 = new Papier(20,20);
        Papier meinPapier3 = new Papier(30.3,30.3);
        meinPapier.FlaechenBerechnung();
        meinPapier2.FlaechenBerechnung();
        meinPapier3.FlaechenBerechnung();
    }
}
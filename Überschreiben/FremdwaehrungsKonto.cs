namespace Überschreiben;

public class FremdwaehrungsKonto : Bankkonto
{
    public FremdwaehrungsKonto(double kontostand) : base(kontostand)
    {
    }
    //Verdecken: Schlüsselwort "new"
    public override void KontostandZeigen()
    {
        Console.WriteLine($"Der Kontostad beträgt: {Kontostand * 1.07689} USD");
    }
}
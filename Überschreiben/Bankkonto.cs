namespace Überschreiben;

public class Bankkonto
{
    public double Kontostand { get; set; }

    public Bankkonto(double kontostand)
    {
        Kontostand = kontostand;
    }

    
    //Freigabe zum Überschreiben mit Schlüsselwort "virtual
    public virtual void KontostandZeigen()
    {
        Console.WriteLine($"Der Kontostand beträgt: {Kontostand} Euro");
    }
}
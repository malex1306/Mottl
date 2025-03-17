namespace Verdecken_überschreiben;

public class Bankkonto
{
    public double Kontostand { get; set; }

    public Bankkonto(double kontostand)
    {
        Kontostand = kontostand;
    }

    public void KontostandZeigen()
    {
        Console.WriteLine($"Der Kontostand beträgt: {Kontostand} Euro");
    }
}
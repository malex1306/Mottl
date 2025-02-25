namespace Papier;

public class Papier
{
   public double Laenge { get; set; }
    public double Breite { get; set; }

    public Papier(double laenge, double breite)
    {
        Laenge = laenge;
        Breite = breite;
    }

    public double FlaecheBerechnung()
    {
        return Laenge * Breite;
    }

    public void FlaechenBerechnung()
    {
        Console.WriteLine($"Das Papier mit der Länge {Laenge} cm und Breite von {Breite} cm hat eine Fläche von {FlaecheBerechnung()} cm\u00b2");
    }
}
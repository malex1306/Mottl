namespace Simpsons;

public class Bart : Characteristics
{
    private int skateCounter;
    public Bart() : base("Bart", "Simpson", "Gelb", "Evergreen Terrace 742, Springfield")
    {
        Console.WriteLine($"Vorname: {Vorname}, Nachname: {Nachname}, Hautfarbe: {Hautfarbe}, Wohnort: {Wohnort}");
    }

    public void Skate()
    {
        skateCounter++;
        Console.WriteLine($"Bart ist {skateCounter} mal Skateboard gefahren!");
    }
}
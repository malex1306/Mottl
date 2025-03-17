namespace Simpsons;

public class Marge : Characteristics

{
    private int frisoerCounter = 0;
    public Marge() : base("Marge", "Simpson", "Gelb", "Evergreen Terrace 742, Springfield")
    {
        Console.WriteLine($"Vorname: {Vorname}, Nachname: {Nachname}, Hautfarbe: {Hautfarbe}, Wohnort: {Wohnort}");
    }

    public void Frisoer()
    {
        frisoerCounter++;
        Console.WriteLine($"Marge hat {frisoerCounter} mal den Frisör besucht!");
    }
}
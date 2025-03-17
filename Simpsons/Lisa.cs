namespace Simpsons;

public class Lisa : Characteristics
{
    private int saxophonCounter;
    public Lisa() : base("Lisa", "Simpsons", "Gelb", "Evergreen Terrace 742, Springfield")
    {
        Console.WriteLine($"Vorname: {Vorname}, Nachname: {Nachname}, Hautfarbe: {Hautfarbe}, Wohnort: {Wohnort}");
    }

    public void Saxophon()
    {
        saxophonCounter++;
        Console.WriteLine($"Lisa hat {saxophonCounter} mal Saxophon gespielt!");
    }
}
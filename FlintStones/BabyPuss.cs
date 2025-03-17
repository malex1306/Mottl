namespace FlintStones;

public class BabyPuss : Haustier
{
    public BabyPuss()
    {
        Wohnort = "Steintal";
        Geburtstag = new DateTime(0001, 01, 01); // Unbekanntes Geburtsdatum
        Namen = "Baby Puss";
    }

    public void SetzeBesitzer(Mann besitzer)
    {
        Besitzer = besitzer;
    }

    public Mann Besitzer { get; set; }

    public void FredRauswerfen()
    {
        Console.WriteLine("Baby Puss wirft Fred aus dem Haus!");
    }
    public void ZeigeInfo()
    {
        Console.WriteLine($"Name: {Namen}");
        Console.WriteLine($"Wohnort: {Wohnort}");
        Console.WriteLine($"Geburtstag: {Geburtstag:dd.MM.yyyy}");
        Console.WriteLine($"Besitzer: {Besitzer}");
    }
}
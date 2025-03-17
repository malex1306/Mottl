namespace FlintStones;

public class Barney : Mann
{
    public Barney()
    {
        Vorname = "Barney";
        Nachname = "Rubble";
        Wohnort = "Steintal";
        Geburtstag = new DateTime(1994, 12, 19);
    }

    public void SetzeFamilie(Betty ehefrau, BammBamm kind)
    {
        Ehefrau = ehefrau;
        kinder = kind;
    }

    public void Kichern()
    {
        Console.WriteLine("Hehehe, hihihi!");
    }
    
    
    public void ZeigeInfo()
    {
        Console.WriteLine($"Name: {Vorname} {Nachname}");
        Console.WriteLine($"Wohnort: {Wohnort}");
        Console.WriteLine($"Geburtstag: {Geburtstag:dd.MM.yyyy}");
        Console.WriteLine($"Ehefrau: {Ehefrau}");
        Console.WriteLine($"Kind: {kinder}");
       
    }
}
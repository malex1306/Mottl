namespace FlintStones;

public class Fred : Mann
{
    public Fred()
    {
        Vorname = "Fred";
        Nachname = "Flintstone";
        Wohnort = "Steintal";
        Geburtstag = new DateTime(1994, 12, 19);
    }

    public void SetzeFamilie(Wilma ehefrau, Pebbles kind)
    {
        Ehefrau = ehefrau;
        kinder = kind;
    }

    public void YabbaDabbaDoo()
    {
        Console.WriteLine("Yabba Dabba Doo!");
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
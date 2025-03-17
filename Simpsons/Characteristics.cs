namespace Simpsons;

public class Characteristics
{
    public string Vorname { get; protected set; }
    public string Nachname { get; protected set; }
    public string Hautfarbe { get; protected set; }
    public string Wohnort { get; protected set; }

    public Characteristics(string vorname, string nachname, string hautfarbe, string wohnort = "Springfield")
    {
        Vorname = vorname;
        Nachname = nachname;
        Hautfarbe = hautfarbe;
        Wohnort = wohnort;
    }
}
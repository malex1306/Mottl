namespace Geheimgesellschaft;

public class Maskierter
{
    public string Deckname { get; set; }
    public string WahreIdentität { get; set; }

    public Maskierter(string deckname, string wahreIdentität)
    {
        Deckname = deckname;
        WahreIdentität = wahreIdentität;
    }

    public virtual void Vorstellen()
    {
        Console.WriteLine($"Ich bin {Deckname}.");
    }

    public virtual void GeheimeMission()
    {
        Console.WriteLine("Die Mission ist streng geheim!");
    }

    public virtual void EntarneDich()
    {
        Console.WriteLine($"Meine wahre Identität: Ich bin {WahreIdentität}.");
    }

    public virtual int StimmeAb()
    {
        Console.WriteLine("Meine Stimme zählt einfach.");
        return 1;
    }
}
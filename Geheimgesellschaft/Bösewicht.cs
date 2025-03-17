namespace Geheimgesellschaft;

public class Bösewicht : Maskierter
{
    public Bösewicht(string deckname, string wahreIdentität) : base(deckname, wahreIdentität)
    {}

    public override void Vorstellen()
    {
        Console.WriteLine($"Ich bin {Deckname}, der dunkle Herrscher.");
    }

    public override void GeheimeMission()
    {
        Console.WriteLine("Ich plane einen großen Coup und werde die Welt beherrschen!");
    }

    public override int StimmeAb()
    {
        Console.WriteLine("Meine Stimme zählt dreifach, weil ich alle kontrolliere!");
        return 3;
    }
}
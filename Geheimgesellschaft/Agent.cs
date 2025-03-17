namespace Geheimgesellschaft;

public class Agent : Maskierter
{
    public Agent(string deckname, string wahreIdentität) : base(deckname, wahreIdentität)
    {
    }

    public override void Vorstellen()
    {
        Console.WriteLine($"Ich bin {Deckname}, ein geheimer Agent!");
    }

    public override void GeheimeMission()
    {
        Console.WriteLine("Ich beschaffe geheime Informationen aus dem Untergrund.");
    }

    public override int StimmeAb()
    {
        Console.WriteLine("Meine Stimme zählt doppelt, da ich geheime Informationen habe!");
        return 2;
    }
}
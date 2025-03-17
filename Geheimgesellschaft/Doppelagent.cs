namespace Geheimgesellschaft;

public class Doppelagent : Agent
{
    public Doppelagent(string deckname, string wahreIdentität) : base(deckname, wahreIdentität)
    {}

    public override void Vorstellen()
    {
        Console.WriteLine($"Ich bin {Deckname}, aber für wen arbeite ich wirklich?");
    }

    public override void GeheimeMission()
    {
        Console.WriteLine("Ich spiele ein doppeltes Spiel – niemand kennt meine wahre Loyalität!");
    }

    public override int StimmeAb()
    {
        Random rnd = new Random();
        bool alsAgent = rnd.Next(2) == 0;

        if (alsAgent)
        {
            Console.WriteLine("Ich stimme für die Gerechtigkeit!");
            return 2;
        }
        else
        {
            Console.WriteLine("Ich stimme für die Macht!");
            return 3;
        }
    }
}
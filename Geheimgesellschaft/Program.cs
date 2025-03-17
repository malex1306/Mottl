namespace Geheimgesellschaft;

class Program
{
    static void Main(string[] args)
    {
        List<Maskierter> teilnehmer = new List<Maskierter>
        {
            new Maskierter("Unbekannte", "Marcel"),
            new Agent("Schattenläufer", "Vasco"),
            new Bösewicht("Dunkelfürst", "Claire"),
            new Doppelagent("Phantom", "Marcel")
        };

        Console.WriteLine("Wir haben uns heute getroffen, um die Abstimmung für den wahren Anführer durchzuführen.\n");

        foreach (var person in teilnehmer)
        {
            person.Vorstellen();
            person.GeheimeMission();
            person.EntarneDich();
            Console.WriteLine();
        }

        Console.WriteLine("Wie viele Stimmen hat jeder?");
        Console.WriteLine("--------------------------------------");

        FühreAbstimmungDurch(teilnehmer);
    }

    static void FühreAbstimmungDurch(List<Maskierter> teilnehmer)
    {
        Dictionary<string, int> stimmenZähler = new Dictionary<string, int>();

        foreach (var teilnehmerObj in teilnehmer)
        {
            Console.Write($"{teilnehmerObj.Deckname}: ");
            int stimmenGewicht = teilnehmerObj.StimmeAb();

            if (stimmenZähler.ContainsKey(teilnehmerObj.Deckname))
                stimmenZähler[teilnehmerObj.Deckname] += stimmenGewicht;
            else
                stimmenZähler[teilnehmerObj.Deckname] = stimmenGewicht;
        }

        var gewinner = stimmenZähler.OrderByDescending(x => x.Value).First();
        Console.WriteLine($"\nDie Abstimmung ist beendet. Gewinner: {gewinner.Key} mit {gewinner.Value} Stimmen!");
        
        
    }
}
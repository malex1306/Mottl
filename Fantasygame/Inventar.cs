namespace Inventar;

public class Inventar
{
    public void Inventory(int charakterWahl)
    {
        Console.WriteLine("\nInventar wird angepasst...");

        switch (charakterWahl)
        {
            case 1:
                Console.WriteLine("Du hast ein Schwert und ein Schild ins Inventar bekommen!");
                break;
            case 2:
                Console.WriteLine("Du hast einen Zauberstab ins Inventar bekommen!");
                break;
            case 3:
                Console.WriteLine("Du hast einen Bogen und Pfeile ins Inventar bekommen!");
                break;
            default:
                Console.WriteLine("Keine Items hinzugefügt.");
                break;
        }
    }
}
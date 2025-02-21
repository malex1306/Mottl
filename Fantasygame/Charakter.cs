namespace Charakter;
using Inventar;
using Points;

public class Charakter
{
    public int CharakterChoose { get; private set; } 

    public void CreateCharakter()
    {
        Console.Write("Geben Sie einen Charakternamen ein: ");
        string playerName = Console.ReadLine();
        Console.Write($"Hallo {playerName}! ");
        Console.WriteLine("Du hast die Möglichkeit, dich zwischen 3 Klassen zu entscheiden!");
        Console.WriteLine("(1) Kämpfer - Schwert und Schild");
        Console.WriteLine("(2) Magier - Zauberstab und Elementarmagie (Feuer/Eis/Luft/Erde)");
        Console.WriteLine("(3) Bogenschütze - Pfeil, Bogen und Armbrust");
        Console.WriteLine("(4) Spiel beenden");
        Console.Write("Welche Klasse möchten Sie spielen? (1, 2 oder 3): ");

        CharakterChoose = Convert.ToInt32(Console.ReadLine());

        Inventar meinInventar = new Inventar();
        meinInventar.Inventory(CharakterChoose); 

        switch (CharakterChoose)
        {
            case 1:
                Console.WriteLine("Du hast dich für den Kämpfer entschieden, großartig!");
                break;
            case 2:
                Console.WriteLine("Du hast dich für den Magier entschieden, großartig!");
                break;
            case 3:
                Console.WriteLine("Du hast dich für den Bogenschützen entschieden, großartig!");
                break;
            case 4:
                Console.WriteLine("Spiel wird beendet...");
                return;
            default:
                Console.WriteLine("Ungültige Eingabe, bitte erneut versuchen.");
                CreateCharakter(); 
                break;
        }
        
        
        CharakterPoints meinePoints = new CharakterPoints();
        meinePoints.PlayerPoints();
    }
}
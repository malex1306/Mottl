namespace Charakter;
//using Inventar;
using Points;
using Fantasygame;

public class Charakter
{
    public int CharakterChoose { get; private set; } 
    public Weapon EquippedWeapon { get; private set; }
    public Defense EquippedDefense { get; private set; }

    public void CreateCharakter()
    {
        Console.Write("Geben Sie einen Charakternamen ein: ");
        string playerName = Console.ReadLine();
        Console.WriteLine();
        Console.Write($"Hallo {playerName}! ");
        Console.WriteLine("Du hast die Möglichkeit, dich zwischen 3 Klassen zu entscheiden!\n");
        Console.WriteLine("(1) Kämpfer - Schwert und Schild");
        Console.WriteLine("(2) Magier - Zauberstab und Elementarmagie (Feuer/Eis/Luft/Erde)");
        Console.WriteLine("(3) Bogenschütze - Pfeil, Bogen und Armbrust");
        Console.WriteLine("(4) Spiel beenden");
        Console.Write("Welche Klasse möchten Sie spielen? (1, 2 oder 3): ");
        

        CharakterChoose = Convert.ToInt32(Console.ReadLine());

        if (CharakterChoose == 4)
        {
            Console.Write("Spiel wird beendet...");
            return;
        }
        
        //Waffen Manager erstellen
        WeaponManager weaponManager = new WeaponManager();
        EquippedWeapon = weaponManager.GetWeaponForClass(CharakterChoose);
        EquippedDefense = weaponManager.GetDefenseForClass(CharakterChoose);
        
        switch (CharakterChoose)
        {
            case 1:
                Console.WriteLine("Du hast dich für den Kämpfer entschieden, großartig!\n");
                break;
            case 2:
                Console.WriteLine("Du hast dich für den Magier entschieden, großartig!\n");
                break;
            case 3:
                Console.WriteLine("Du hast dich für den Bogenschützen entschieden, großartig!\n");
                break;
            default:
                Console.WriteLine("Ungültige Eingabe, bitte erneut versuchen.");
                CreateCharakter(); 
                break;
        }
        
        //Inventar meinInventar = new Inventar();
        //meinInventar.Inventory(CharakterChoose); 
        Console.WriteLine($"Du hast die Waffe {EquippedWeapon.Name} erhalten! (Schaden: {EquippedWeapon.Damage})");
        Console.WriteLine($"Du hast zur Verteidung {EquippedDefense.Name} erhalten! Verteidigung: {EquippedDefense.DefensePoints}");
        
        CharakterPoints meinePoints = new CharakterPoints();
        meinePoints.PlayerPoints();
        
        
    }
}
using System.Net.Security;

namespace Spielkader;

public class Spieler
{
    public string Name { get; set; }
    public double Transfergebuehr { get; set; }
    public double AktMarktwert { get; private set; }
    private static Random random = new Random();

    public Spieler(string name, double transfergebuehr)
    {
        Name = name;
        Transfergebuehr = transfergebuehr;
        AktMarktwert = random.Next(2000, 100001); // Zufälliger Marktwert zwischen 2000 und 100000
    }

    public void MarktwertAnpassen()
    {
        double aenderung = random.NextDouble() * 0.5 - 0.25; // Wertänderung zwischen -25% und +25%
        AktMarktwert += AktMarktwert * aenderung;
        Console.WriteLine($"Neuer Marktwert von {Name}: {AktMarktwert:F2}");
    }
}

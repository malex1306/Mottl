namespace Spielkader;

class Program
{
    static void Main(string[] args)
    {
        Kader kader = new Kader();

        Console.WriteLine("Wie viele Spieler möchten Sie hinzufügen?");
        int anzahl = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < anzahl; i++)
        {
            kader.SpielerHinzufuegen();
        }

        Console.WriteLine($"Gesamtmarktwert: {kader.GesamtMarktwert():F2}");
        Console.WriteLine($"Möglicher Gewinn: {kader.GesamtGewinn():F2}");
    }
}
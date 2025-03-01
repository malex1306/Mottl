namespace Spielkader;

public class Kader
{
    private List<Spieler> spielerListe = new List<Spieler>();

    public void SpielerHinzufuegen()
    {
        Console.Write("Geben Sie den Namen des Spielers ein: ");
        string name = Console.ReadLine();
        Console.Write("Geben Sie die Transfergebühr ein: ");
        double transfergebuehr = Convert.ToDouble(Console.ReadLine());
        Spieler spieler = new Spieler(name, transfergebuehr);
        spielerListe.Add(spieler);
        Console.WriteLine($"Spieler {name} mit Marktwert {spieler.AktMarktwert:F2} hinzugefügt.");
    }

    public double GesamtMarktwert()
    {
        double summe = 0;
        foreach (var spieler in spielerListe)
        {
            summe += spieler.AktMarktwert;
        }
        return summe;
    }

    public double GesamtGewinn()
    {
        double summe = 0;
        foreach (var spieler in spielerListe)
        {
            summe += spieler.AktMarktwert - spieler.Transfergebuehr;
        }
        return summe;
    }
}
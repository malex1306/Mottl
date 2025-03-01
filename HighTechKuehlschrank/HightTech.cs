namespace HighTechKuehlschrank;

public class HighTech
{
    public string Marke { get; set; }
    public int Kapazitaet { get; set; }
    public int Energieverbrauch { get; set; }
    private Dictionary<string, int> LebensmittelListe = new Dictionary<string, int>();

    
    public HighTech() { }

    
    public void InitialisiereKuehlschrank()
    {
        Console.WriteLine("Geben Sie die Marke des Kühlschranks ein:");
        Marke = Console.ReadLine();

        int kapazitaetTemp;
        Console.WriteLine("Geben Sie die maximale Kapazität des Kühlschranks ein:");
        while (!int.TryParse(Console.ReadLine(), out kapazitaetTemp) || kapazitaetTemp <= 0)
        {
            Console.WriteLine("Bitte eine gültige Zahl für die Kapazität eingeben.");
        }
        Kapazitaet = kapazitaetTemp; 

        int energieverbrauchTemp;
        Console.WriteLine("Geben Sie den Energieverbrauch in kWh ein:");
        while (!int.TryParse(Console.ReadLine(), out energieverbrauchTemp) || energieverbrauchTemp <= 0)
        {
            Console.WriteLine("Bitte eine gültige Zahl für den Energieverbrauch eingeben.");
        }
        Energieverbrauch = energieverbrauchTemp; 

        Console.WriteLine($"\nKühlschrank '{Marke}' wurde mit einer Kapazität von {Kapazitaet} und einem Energieverbrauch von {Energieverbrauch} kWh initialisiert.\n");
    }

    public void LebensmittelHinzufuegen()
    {
        Console.WriteLine("Welche Lebensmittel wollen Sie hinzufügen?");
        string lebensmittel = Console.ReadLine();
        Console.WriteLine("Wie viele?");
        int menge;
        while (!int.TryParse(Console.ReadLine(), out menge) || menge <= 0)
        {
            Console.WriteLine("Bitte eine gültige Anzahl eingeben.");
        }

        if (LebensmittelListe.Values.Sum() + menge > Kapazitaet)
        {
            Console.WriteLine("Nicht genug Platz im Kühlschrank!");
            return;
        }

        if (LebensmittelListe.ContainsKey(lebensmittel))
        {
            LebensmittelListe[lebensmittel] += menge;
        }
        else
        {
            LebensmittelListe[lebensmittel] = menge;
        }

        Console.WriteLine($"{menge}x {lebensmittel} wurde hinzugefügt.");
    }

    public void LebensmittelEntnehmen()
    {
        Console.WriteLine("Welches Lebensmittel möchten Sie entnehmen?");
        string lebensmittel = Console.ReadLine();

        if (!LebensmittelListe.ContainsKey(lebensmittel))
        {
            Console.WriteLine("Lebensmittel nicht gefunden!");
            return;
        }

        Console.WriteLine($"Wie viele {lebensmittel} möchten Sie entnehmen?");
        int menge;
        while (!int.TryParse(Console.ReadLine(), out menge) || menge <= 0)
        {
            Console.WriteLine("Bitte eine gültige Anzahl eingeben.");
        }

        if (LebensmittelListe[lebensmittel] < menge)
        {
            Console.WriteLine("Nicht genug im Kühlschrank!");
            return;
        }

        LebensmittelListe[lebensmittel] -= menge;
        if (LebensmittelListe[lebensmittel] == 0)
        {
            LebensmittelListe.Remove(lebensmittel);
        }

        Console.WriteLine($"{menge}x {lebensmittel} wurde entnommen.");
    }

    public void CheckBestand()
    {
        Console.WriteLine("\nAktueller Kühlschrankinhalt:");
        foreach (var item in LebensmittelListe)
        {
            Console.WriteLine($"{item.Key}: {item.Value} Einheiten");
        }

        if (LebensmittelListe.Count == 0)
        {
            Console.WriteLine("Der Kühlschrank ist leer.");
        }
    }
}

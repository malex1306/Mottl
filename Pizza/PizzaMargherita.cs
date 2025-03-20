namespace Pizza;

class PizzaMargherita : IPizza
{
    public List<string> Zutaten { get; } = new List<string> { "Tomatensauce", "Mozzarella", "Basilikum" };
    public string Groesse { get; }
    private Dictionary<string, decimal> PreisListe = new Dictionary<string, decimal>
    {
        { "klein", 6.50m },
        { "mittel", 8.50m },
        { "groß", 10.50m }
    };

    public PizzaMargherita(string groesse)
    {
        if (!PreisListe.ContainsKey(groesse))
            throw new ArgumentException("Ungültige Größe");
        Groesse = groesse;
    }
    
    public string GetBeschreibung()
    {
        return $"Pizza Margherita ({Groesse})";
    }

    public List<string> GetZutaten() => Zutaten;
    public decimal GetPreis() => PreisListe[Groesse];
    public string GetGroesse() => Groesse;
}

    
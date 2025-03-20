namespace Pizza;

public class PizzaQuattroStagione : IPizza
{
    public List<string> Zutaten { get; } = new List<string> { "Tomatensauce", "Mozzarella", "Pilze", "Schinken" };
    private decimal Preis = 8.50m;
    
    public List<string> GetZutaten() => Zutaten;
    public decimal GetPreis() => Preis;
    
    public string GetBeschreibung()
    {
        return "Pizza QuattroStagione";
    }
}
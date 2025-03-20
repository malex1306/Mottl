namespace Pizza;

class Program
{
    static void Main(string[] args)
    {
        List<IPizza> bestellungen = new List<IPizza>
        {
            new PizzaMargherita("klein"),
            new PizzaMargherita("groß"),
            new PizzaNapolitana(),
            new PizzaMargherita("mittel"),
            new PizzaQuattroStagione()
        };
        
        Console.WriteLine("Bestellte Pizzen:");
        foreach (var pizza in bestellungen)
        {
            Console.WriteLine($"- {pizza.GetBeschreibung()} für {pizza.GetPreis():C}");
        }
        
        decimal gesamtpreis = bestellungen.Sum(pizza => pizza.GetPreis());
        Console.WriteLine($"\nDer Gesamtpreis der Bestellung liegt bei: {gesamtpreis:C}");
    }
}

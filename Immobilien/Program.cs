namespace Immobilien;

class Program
{
    static void Main(string[] args)
    {
        Immobilie haus = new Immobilie(60, "bsp");
        haus.SetMiete(300);
        Console.WriteLine($"Die Miete für diese Immobilie beträgt {haus.GetMiete()} Euro in der {haus.GetMiete()} Euro in der {haus.adresse}");
        Console.WriteLine();
        Immobilie haus2 = new Wohnung(40, "bsp1", 4);
        haus2.SetMiete(450);
        Console.WriteLine($"Die Miete für diese Immobilie beträgt {haus2.GetMiete()} Euro in der {haus2.adresse}");
        Immobilie haus3 = new Geschaeftsraume(100, "bsp2", 4);
        Console.WriteLine();
        haus3.SetMiete(750);
        Console.WriteLine($"Die Miete für diese Immobilie beträgt {haus3.GetMiete()} Euro in der {haus3.adresse}");
    }
}
namespace Interfaces;

public class Elektroauto : IFahrzeug, IElktroauto
{
    public string Modell { get; set; }

    public Elektroauto(string modell)
    {
        Modell = modell;
    }
    public void Starten()
    {
        Console.WriteLine($"Das Elektroauto {Modell} startet geräuschlos");
    }

    public void Laden()
    {
        Console.WriteLine($"Das Elektroauto {Modell} lädt...");
    }

    void IFahrzeug.ZeigeMaterial()
    {
        Console.WriteLine("Material: Blech");
    }

    void IElktroauto.ZeigeMaterial()
    {
        Console.WriteLine("Material: Alu");
    }
}
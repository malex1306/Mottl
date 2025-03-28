namespace Kappselung;

public class Bankkonto
{
    public int kontonummer { get; private set; }

    private decimal kontostand;
    
    public int Kontonummer{get => kontonummer; set{kontonummer=value;} }

    public Bankkonto(int kontonummer, decimal kontostand)
    {
        this.kontonummer = kontonummer;
        this.kontostand = kontostand;
    }

    public decimal GetKontostand()
    {
        return kontostand;
    }

    public void Einzahlen(decimal betrag)
    {
        if (betrag > 0)
        {
            kontostand += betrag;
            Console.WriteLine($"Einzahlung von Betrag {betrag} war erfolgreich. Neuer Kontostand: {kontostand}");
        }
        else
        {
            Console.WriteLine("Betrag muss positiv sein");
        }
    }

    public void Abheben(decimal betrag)
    {
        if (betrag > 0 && betrag <= kontonummer)
        {
            kontostand -= betrag;
            Console.WriteLine($"Abhebung von {betrag} erfolgreich. Neuer Kontostand: {kontostand}");
        }
        else
        {
            Console.WriteLine("Ungültiger Betrag oder unzureichende Kontostand.");
        }
    }
    
}
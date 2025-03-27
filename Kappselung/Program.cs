namespace Kappselung;

class Program
{
    static void Main(string[] args)
    {
        Bankkonto meinKonto = new Bankkonto(12345678, 1000m);
        Console.WriteLine($"Kontostand: {meinKonto.GetKontostand()}");
        meinKonto.Abheben(500);
        meinKonto.Einzahlen(1000);
        Console.WriteLine($"Endgültiger Kontostand: {meinKonto.GetKontostand()}");
        
    }
}
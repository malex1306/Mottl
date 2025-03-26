namespace Vererbung;

class Program
{
    static void Main(string[] args)
    {
        Hund h = new Hund();
        h.machGerausch();
    }
}

// Erstelle eine Basisklasse Tier mit einer Methode MacheGeräusch(), die "Unbekanntes Geräusch" ausgibt.
// Erstelle eine abgeleitete Klasse Hund, die MacheGeräusch() überschreibt und "Wuff" ausgibt.
// Erstelle ein Hund-Objekt und rufe MacheGeräusch() auf.
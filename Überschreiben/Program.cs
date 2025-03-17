namespace Überschreiben;

class Program
{
    static void Main(string[] args)
    {
        Bankkonto euro = new Bankkonto(1000.0);
        euro.KontostandZeigen();
        //Erwartete ausgabe: 1000.00 Euro
        
        Console.WriteLine();
        
        Bankkonto dollar = new FremdwaehrungsKonto(1000.0);
        dollar.KontostandZeigen();
        //Erwartete ausgabe : 1076,89
    }
}
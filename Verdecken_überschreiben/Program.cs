namespace Verdecken_überschreiben;

class Program
{
    static void Main(string[] args)
    {
        Bankkonto euro = new Bankkonto(1000.0);
        euro.KontostandZeigen();
        //Erwartete ausgabe: 1000.00 Euro
        
        Console.WriteLine();
        
        FremdwaehrungsKonto doller = new FremdwaehrungsKonto(1000.0);
        doller.KontostandZeigen();
        //Erwartete ausgabe : 1076, 89 USD
        Console.WriteLine();
        
        Bankkonto k1 = new Bankkonto(1000.0);
        k1.KontostandZeigen();
        //Erwartete ausgabe : 1000,00
    }
}
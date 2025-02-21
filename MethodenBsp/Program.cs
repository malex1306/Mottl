namespace MethodenBsp;

class Program
{
    
    static void Main(string[] args)
    { 
        double Konto = 0;
        bool online = true;

        while (online)
        {

            Console.WriteLine("Ihr Bankkonto");
            Console.WriteLine("Was möchten Sie tun");
            Console.WriteLine("(1)Geld einzahlen");
            Console.WriteLine("(2)Geld abheben");
            Console.WriteLine("(3)Kontostand abfragen");
            Console.WriteLine("(4)Programm beenden");

            string auswahl = Console.ReadLine();

            switch (auswahl)
            {
                case "1":
                    //Methode Geld einzahlen
                    Console.WriteLine("Wieviel Geld möchten sie einzahlen? ");
                    double einzahlung = Convert.ToDouble(Console.ReadLine());
                    Konto = GeldEinzahlen(einzahlung, Konto);
                    break;
                case "2":
                    //Methode geld abheben
                    Console.WriteLine("Wieviel Geld möchten sie abheben? ");
                    double abheben = Convert.ToDouble(Console.ReadLine());
                    Konto = GeldAbheben(abheben, Konto);
                    break;
                case "3":
                    //Methode abfragen
                    KontostandAbfragen(Konto);
                    break;
                case "4":
                    //Programm beenden
                    online = false;
                    break;
                default: 
                    Console.WriteLine("Falsche angabe");
                    break;
            }
        }
    }

    static double GeldEinzahlen(double betrag, double konto)
    {
        return konto + betrag;
    }

    static void KontostandAbfragen(double konto)
    {
        Console.WriteLine($"Ihr Kontostand lautet {konto}");
    }

    static double GeldAbheben(double betrag, double konto)
    {
        if (konto > betrag)
        {
            return konto - betrag;
        }
        else
        {
            Console.WriteLine($"Es ist nicht genügend Geld zur Verfügung aktueller aktueller Kontosatnd");
            return konto;
        }
    }
}
namespace HighTechKuehlschrank;


class Program
{
    static void Main()
    {
        HighTech kuehlschrank = new HighTech();
        kuehlschrank.InitialisiereKuehlschrank();

        // Beispiel-Menü zur Interaktion
        while (true)
        {
            Console.WriteLine("\nWas möchten Sie tun?");
            Console.WriteLine("1 - Lebensmittel hinzufügen");
            Console.WriteLine("2 - Lebensmittel entnehmen");
            Console.WriteLine("3 - Bestand prüfen");
            Console.WriteLine("4 - Beenden");

            string eingabe = Console.ReadLine();

            switch (eingabe)
            {
                case "1":
                    kuehlschrank.LebensmittelHinzufuegen();
                    break;
                case "2":
                    kuehlschrank.LebensmittelEntnehmen();
                    break;
                case "3":
                    kuehlschrank.CheckBestand();
                    break;
                case "4":
                    Console.WriteLine("Programm beendet.");
                    return;
                default:
                    Console.WriteLine("Ungültige Eingabe, bitte erneut versuchen.");
                    break;
            }
        }
    }
}
namespace DigitaleSpardose
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Willkommen zur digitalen Spardose!");
            
            
            Spardose dose1 = new Spardose(20);  
            Spardose dose2 = new Spardose(5);   

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nWähle eine Option:");
                Console.WriteLine("1 - 1 Cent hinzufügen (Dose 1)");
                Console.WriteLine("2 - 10 Cent hinzufügen (Dose 1)");
                Console.WriteLine("3 - 1 Euro hinzufügen (Dose 1)");
                Console.WriteLine("4 - 1 Euro hinzufügen (Dose 2)");
                Console.WriteLine("5 - 2 Euro hinzufügen (Dose 1)");
                Console.WriteLine("6 - 2 Euro hinzufügen (Dose 2)");
                Console.WriteLine("7 - Dose 1 aufbrechen");
                Console.WriteLine("8 - Dose 2 aufbrechen");
                Console.WriteLine("9 - Gesamtbetrag aller Spardosen anzeigen");
                Console.WriteLine("0 - Beenden");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        dose1.AddCents1();
                        Console.WriteLine("1 Cent in Dose 1 hinzugefügt.");
                        break;
                    case "2":
                        dose1.AddCents10();
                        Console.WriteLine("10 Cent in Dose 1 hinzugefügt.");
                        break;
                    case "3":
                        dose1.AddEuros1();
                        Console.WriteLine("1 Euro in Dose 1 hinzugefügt.");
                        break;
                    case "4":
                        dose1.AddEuros1();
                        Console.WriteLine("1 Euro in Dose 1 hinzugefügt.");
                        break;
                    case "5":
                        dose1.AddEuros2();
                        Console.WriteLine("1 Euro in Dose 1 hinzugefügt.");
                        break;
                    case "6":
                        dose2.AddEuros2();
                        Console.WriteLine("1 Euro in Dose 2 hinzugefügt.");
                        break;
                    case "7":
                        dose1.DoseAufbrechen();
                        break;
                    case "8":
                        dose2.DoseAufbrechen();
                        break;
                    case "9":
                        Spardose.AlleSpardosenGesamtbetrag();
                        break;
                    case "0":
                        running = false;
                        Console.WriteLine("Programm beendet.");
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe. Bitte erneut versuchen.");
                        break;
                }
            }
        }
    }
}

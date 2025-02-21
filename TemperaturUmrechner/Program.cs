namespace TemperaturUmrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            float t;

            Console.WriteLine("Bedienungsanleitung: Wählen Sie die Temperatur-Einheit aus.");
            
            do
            {
                Console.Write("\nModus wählen: (1) Celsius, (2) Fahrenheit, (3) Kelvin, (4) Beenden: ");
                string input = Console.ReadLine();

                if (input == "4") break;

                Console.Write("Temperatur eingeben: ");
                if (!float.TryParse(Console.ReadLine(), out t))
                {
                    Console.WriteLine("Ungültige Eingabe!");
                    continue;
                }

                Console.Write("In welche Einheit soll umgerechnet werden? (1) Celsius, (2) Fahrenheit, (3) Kelvin: ");
                string zielEinheit = Console.ReadLine();
                double celsius = 0;

                switch (input)
                {
                    case "1": // Celsius
                        celsius = t;
                        break;
                    case "2": // Fahrenheit -> Celsius
                        celsius = FnachC(t);
                        break;
                    case "3": // Kelvin -> Celsius
                        celsius = KnachC(t);
                        break;
                    default:
                        Console.WriteLine("Unbekannte Einheit!");
                        continue;
                }

                Console.WriteLine($"\nAlle Temperaturen:");
                Console.WriteLine($"Celsius: {celsius:F2}°C");
                Console.WriteLine($"Fahrenheit: {CnachF(celsius):F2}°F");
                Console.WriteLine($"Kelvin: {CnachK(celsius):F2} K");
                Console.WriteLine($"Fahrenheit nach Kelvin: {FnachK(t):F2} K");
                Console.WriteLine($"Kelvin nach Fahrenheit: {KnachF(t):F2}°F");

            } while (true);
        }

        static double CnachF(double C)
        {
            return (C * 9 / 5) + 32;
        }

        static double CnachK(double C)
        {
            return C + 273.15;
        }

        static double FnachC(double F)
        {
            return (F - 32) * 5 / 9;
        }

        static double KnachC(double K)
        {
            return K - 273.15;
        }

        static double FnachK(double F)
        {
            return (F - 32) * 5 / 9 + 273.15;
        }

        static double KnachF(double K)
        {
            return (K - 273.15) * 9 / 5 + 32;
        }
    }
}

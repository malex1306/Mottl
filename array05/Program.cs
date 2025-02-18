class Program
{
    static void Main()
    {
        while (true) 
        {
            Console.Write("Gib eine Zahl ein: ");
            if (int.TryParse(Console.ReadLine(), out int zahl))
            {
                while (true) 
                {
                    Console.WriteLine("\nWähle eine Option:");
                    Console.WriteLine("1: Binärzahl");
                    Console.WriteLine("2: Oktalzahl");
                    Console.WriteLine("3: Hexadezimalzahl");
                    Console.WriteLine("4: Programm Beenden");

                    string? option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":
                            Console.WriteLine($"Binär: {Convert.ToString(zahl, 2)}");
                            break;
                        case "2":
                            Console.WriteLine($"Oktal: {Convert.ToString(zahl, 8)}");
                            break;
                        case "3":
                            Console.WriteLine($"Hexadezimal: {Convert.ToString(zahl, 16).ToUpper()}");
                            break;
                        case "4":
                            Console.WriteLine("Programm wird beendet...");
                            return; 
                        default:
                            Console.WriteLine("Ungültige Eingabe. Bitte eine gültige Option wählen.");
                            continue;
                    }
                    break; 
                }
            }
            else
            {
                Console.WriteLine("Ungültige Zahl. Bitte eine gültige Zahl eingeben.");
            }
        }
    }
}
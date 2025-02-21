namespace DerZskRechner
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Willkommen zum ZSK-Rechner!");
                Console.WriteLine("1. Euro in Tiere umrechnen");
                Console.WriteLine("2. Tiere in Euro umrechnen");
                Console.WriteLine("3. Beenden");
                Console.Write("Bitte eine Option wählen: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        EuroZuTiere();
                        break;
                    case "2":
                        TiereZuEuro();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Ungültige Eingabe. Bitte erneut versuchen.");
                        break;
                }
            }
        }

        static void EuroZuTiere()
        {
            Console.Write("Wieviel Euro möchten Sie wechseln? ");
            int euro = Convert.ToInt32(Console.ReadLine());

            int kühe = euro / 2800;  
            euro %= 2800;

            int schafe = euro / 650; 
            euro %= 650;

            int ziegen = euro / 500; 
            euro %= 500;

            int kleineZiegen = euro / 50; 
            euro %= 50;

            Console.WriteLine("\nSie erhalten:");
            Console.WriteLine($" {kühe} Kuh/Kühe");
            Console.WriteLine($" {schafe} Schaf/Schafe");
            Console.WriteLine($" {ziegen} Ziege/Ziegen");
            Console.WriteLine($" {kleineZiegen} Kleine Ziege(n)");
            Console.WriteLine($" Übrig: {euro}€\n");

            Console.WriteLine("Drücke eine Taste, um fortzufahren...");
            Console.ReadKey();
        }

        static void TiereZuEuro()
        {
            Console.Write("Wie viele Kühe haben Sie? ");
            int kühe = Convert.ToInt32(Console.ReadLine());

            Console.Write("Wie viele Schafe haben Sie? ");
            int schafe = Convert.ToInt32(Console.ReadLine());

            Console.Write("Wie viele Ziegen haben Sie? ");
            int ziegen = Convert.ToInt32(Console.ReadLine());

            Console.Write("Wie viele kleine Ziegen haben Sie? ");
            int kleineZiegen = Convert.ToInt32(Console.ReadLine());

            int gesamtEuro = (kühe * 2900) + (schafe * 650) + (ziegen * 500) + (kleineZiegen * 50);

            Console.WriteLine($"\nGesamtwert in Euro:  {gesamtEuro}€\n");
            Console.WriteLine("Drücke eine Taste, um fortzufahren...");
            Console.ReadKey();
        }
    }
}

namespace Fantasygame;

public class Story
{
    private InventarManager inventarManager = new InventarManager(); 

    public void CreateStory()
    {
        Console.WriteLine("Du erwachst in einer zerfallenen Hütte am Rand von Celmora, einer Stadt, die einst voller Leben war, nun aber von Dunkelheit verschlungen wird." +
                          "\n Seit Tagen hörst du Gerüchte über das Herz der Ewigkeit, ein mächtiges Artefakt,\n das das Schicksal von Celdoria bestimmen könnte.\n\n");
        Console.WriteLine("Kapitel 1\n");
        Console.WriteLine("Nachdem du dich umgeschaut hast, entdeckst du eine sehr gut erhaltene Kiste!");
        Console.WriteLine("Möchtest du den Inhalt anschauen? J/N");

        string kisteEntscheidung = Console.ReadLine()?.ToUpper();

        if (kisteEntscheidung == "J")
        {
            Console.WriteLine("Du erhältst eine abgenutzte, aber lesbare Umgebungskarte.");
            inventarManager.AddItemToInventar("Map of Celmora", "Karte", "\n~~~~~~~~~~~~~~~~~~~~~~~~~\n~         ~~~           ~\n~  ~~~    ~~~    ~~~    ~\n~  ~@~    ~~~    ~D~    ~\n~  ~~~         ~~~~~~   ~\n~         ~~~    ~F~    ~\n~  ~~~    ~~~    ~~~    ~\n~  ~T~    ~~~           ~\n~  ~~~         ~~~~~~   ~\n~         ~~~    ~G~    ~\n~~~~~~~~~~~~~~~~~~~~~~~~~");
        }

        StoryLoop(); 
    }

    public void StoryLoop()
    {
        while (true)
        {
            Console.WriteLine("\n[Drücke 'I', um das Inventar zu öffnen oder Enter, um fortzufahren...]");
            string input = Console.ReadLine()?.ToUpper();

            if (input == "I")
            {
                Menu();
            }
            else
            {
                Console.WriteLine("Du reist weiter...");
                break;
            }
        }
    }

    public void Menu()
    {
        while (true)
        {
            Console.WriteLine("\n--- Menü ---");
            Console.WriteLine("1. Inventar anzeigen");
            Console.WriteLine("2. Zurück zur Story");
            Console.WriteLine("3. Spiel beenden");
            Console.Write("Wähle eine Option: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    inventarManager.ShowInventar(); 
                    break;
                case "2":
                    return; 
                case "3":
                    Console.WriteLine("Spiel wird beendet...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe, versuche es erneut.");
                    break;
            }
        }
    }
}

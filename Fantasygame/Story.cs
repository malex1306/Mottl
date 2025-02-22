namespace Fantasygame;


public class Story
{
    public void CreateStory()
    {
        InventarManager inventarManager = new InventarManager();
        
        Console.WriteLine("Du erwachst in einer zerfallenen Hütte am Rand von Celmora, einer Stadt, die einst voller Leben war, nun aber von Dunkelheit verschlungen wird." +
                          "\n Seit Tagen hörst du Gerüchte über das Herz der Ewigkeit, ein mächtiges Artefakt,\n das das Schicksal von Celdoria bestimmen könnte.\n\n");
        Console.WriteLine("Kapitel 1\n");
        Console.WriteLine("Nachdem du dich umgeschaut hast endeckst du eine sehr gut erhalten Kiste!");
        Console.WriteLine("Möchtest du dir den Inhalt der Konsole anschauen? J/N");
        string KisteEntscheidung = Console.ReadLine();

        if (KisteEntscheidung == "J")
        {
            Console.WriteLine("Du erhälst eine abgenutzte denoch Lesbare Umgebungskarte");

            inventarManager.AddItemToInventar("Map of Celmora", "Karte");
        }
        
        
    }
}
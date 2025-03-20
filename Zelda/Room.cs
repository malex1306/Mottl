namespace Zelda;

public class Room
{
    public List<int> Doors { get; set; }
    public List<Enemy> Enemies { get; set; }
    public List<Item> Items { get; set; }

    public Room(List<int> doors)
    {
        Doors = doors;
        Enemies = new List<Enemy>();
        Items = new List<Item>();
    }

    public void EnterRoom(Player player)
    {
        if (Enemies.Count == 0 && Doors.Count == 0)
        {
            Console.WriteLine("Alle Gegener wurden besiegt");
        }
        else
        {
            Console.WriteLine($"Es gibt noch {Enemies.Count} Gegner oder {Doors.Count} verschlossene Türen!"); 
        }
        
    }
}
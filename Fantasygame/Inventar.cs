namespace Fantasygame;

public class Inventar
{
    public string ItemName { get; set; }
    public string ItemType { get; set; }

    public Inventar(string Itemname, string Itemtype)
    {
        ItemName = Itemname;
        ItemType = Itemtype;
        
    }

    public void ItemDisplay()
    {
        Console.WriteLine(ItemName);
    }
}
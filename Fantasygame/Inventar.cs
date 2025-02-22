namespace Fantasygame;

public class Inventar
{
    public string ItemName { get; set; }
    public string ItemType { get; set; }
    public string ItemPic { get; set; }

    public Inventar(string Itemname, string Itemtype, string Itempic)
    {
        ItemName = Itemname;
        ItemType = Itemtype;
        ItemPic = Itempic;
        
    }

    public void ItemDisplay()
    {
        Console.WriteLine(ItemName, ItemType, ItemPic);
    }
}
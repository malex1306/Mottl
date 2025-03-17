namespace Warenkorb;

public class ShoppingCart
{
    private List<Article> items = new List<Article>();

    public void AddItem(Article item)
    {
        items.Add(item);
    }

    public void PrintReceipt()
    {
        decimal total = 0;
        Console.WriteLine("Warenkorb:");
        foreach (var item in items)
        {
            Console.WriteLine($"Artikelnummer: {item.ArticleNumber}, Preis: {item.GetPrice():C}");
            total += item.GetPrice();
        }
        Console.WriteLine($"Gesamtpreis: {total:C}");
    }
}
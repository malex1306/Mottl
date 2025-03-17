namespace Warenkorb;

public class Books : Article
{
    public string Author { get; }
    public string Title { get; }
    public int Year { get; }
    private const decimal TaxRate = 0.07m;

    public Books(int articleNumber, decimal netPrice, string author, string title, int year)
        : base(articleNumber, netPrice)
    {
        Author = author;
        Title = title;
        Year = year;
    }

    public override decimal GetPrice()
    {
        return NetPrice * (1 + TaxRate);
    }
}
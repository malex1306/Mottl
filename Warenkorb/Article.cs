namespace Warenkorb;

public class Article
{
    public int ArticleNumber { get; }
    public decimal NetPrice { get; }

    public Article(int articleNumber, decimal netPrice)
    {
        ArticleNumber = articleNumber;
        NetPrice = netPrice;
    }

    public virtual decimal GetPrice()
    {
        return NetPrice;
    }
}
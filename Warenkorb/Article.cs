namespace Warenkorb;

public class Article
{
    public int ArticleNumber { get; }
    protected decimal NetPrice { get; }

    protected Article(int articleNumber, decimal netPrice)
    {
        ArticleNumber = articleNumber;
        NetPrice = netPrice;
    }

    public virtual decimal GetPrice()
    {
        return NetPrice;
    }
}
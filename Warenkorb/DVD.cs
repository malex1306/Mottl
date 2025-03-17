namespace Warenkorb;

public class DVD : Article
{
    public string MovieTitle { get; }
    public int Duration { get; }
    public int RegionCode { get; }
    private const decimal TaxRate = 0.19m;

    public DVD(int articleNumber, decimal netPrice, string movieTitle, int duration, int regionCode)
        : base(articleNumber, netPrice)
    {
        MovieTitle = movieTitle;
        Duration = duration;
        RegionCode = regionCode;
    }

    public override decimal GetPrice()
    {
        return NetPrice * (1 + TaxRate);
    }
}
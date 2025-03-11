namespace ZooBesucher;

public class Kind : Besucher
{
    public int AnzahlKinder { get; set; }

    public Kind(int anzahlKinder) : base(0) 
    {
        AnzahlKinder = anzahlKinder;
    }
}
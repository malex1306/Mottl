namespace Zelda;

public class Boss : Enemy
{
    public int Groesse { get; set; }

    public Boss() : base(30, 20, "Wurm Moldorm", 2, 1)
    {
        Groesse = 3;
    }

    public override string Beschreibung()
    {
        return "ToDO";
    }
}
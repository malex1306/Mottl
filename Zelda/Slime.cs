namespace Zelda;

public class Slime : Enemy
{
    public int Groesse { get; set; }

    public Slime() : base(10, 5, "Slime", 1, 0 )
    {
        Groesse = 1;
    }

    public override string Beschreibung()
    {
        return "Der Slime springt herum und greift dich an!";
    }
}
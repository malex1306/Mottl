namespace Zelda;

public class Goblin : Enemy
{
    public int Groesse { get; set; }

    public Goblin() : base(20,10, "Goblin", 4, 6)
    {
        Groesse = 2;
    }

    public override string Beschreibung()
    {
        return "Der Goblin Läuft vor die her und endeckt dich im letzen moment doch noch und greift dich an!";
    }
}
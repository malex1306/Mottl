namespace Zelda;

public class Enemy : GameObject
{
    public int Health { get; set; }
    public int AttackPower  { get; set; }
 

    public Enemy(int health, int attackPower, string name, int positionX, int positionY)
    {
        Health = health;
        AttackPower = attackPower;
        Name = name;
        PositionX = positionX;
        PositionY = positionY;
    }

    public override void Interact()
    {
        Console.WriteLine($"{Name} greift dich an!");
    }

    public virtual string Beschreibung()
    {
        return "Ein unbekannter gegener greift an";
    }
}
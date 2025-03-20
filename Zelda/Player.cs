namespace Zelda;

public class Player : GameObject, Interface.IAttackable
{
    public int Health { get; set; }
    public List<string> GetItems { get; set; }
    public string MoveUp { get; set; }
    public string MoveDown { get; set; }
    public string MoveLeft { get; set; }    
    public string MoveRight { get; set; }

    public void Attack()
    {
        
    }

    public void PickUp()
    {
        
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        
        Console.WriteLine($"Der spieler hat {damage} Schaden erlitten. Verbleibene Gesundheit {Health}");

        if (Health <= 0)
        {
            Console.WriteLine($"Der Spieler {Name} ist besiegt!");
        }
    }

    public override void Interact()
    {
        throw new NotImplementedException();
    }

    public void TakeDamage()
    {
        throw new NotImplementedException();
    }
}
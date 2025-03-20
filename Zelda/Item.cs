namespace Zelda;

public class Item : GameObject
{
    public Item() { }

    public override void Interact()
    {
        Console.WriteLine("Du hast ein Item aufgenommen!");
    }
}

public class Sword : Item
{
    public Sword() { }
}

public class Key : Item
{
    public Key() { }
}

public class Heart : Item
{
    public Heart() { }
}
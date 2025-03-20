namespace Zelda;

public abstract class GameObject
{
    public string Name { get; set; }
    public int PositionX { get; set; }
    public int PositionY { get; set; }

    public abstract void Interact();
}
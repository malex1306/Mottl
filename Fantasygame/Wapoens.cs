namespace Fantasygame;

public class Weapon
{
   public string Name { get; set; }
   public int Damage { get; set; }
   public string Type { get; set; }

   public Weapon(string name, int damage, string type)
   {
      Name = name;
      Damage = damage;
      Type = type;
   }

   public void Display()
   {
      Console.WriteLine($"{Name} - Type: {Type}, Schaden: {Damage}");
   }
}

public class Defense
{
   public string Name { get; set; }
   public int DefensePoints{get;set;}

   public Defense(string name, int defensePoints)
   {
      Name = name;
      DefensePoints = defensePoints;
   }

   public void DisplayDefense()
   {
      Console.WriteLine($"{Name} - Defense: {DefensePoints}");
   }
}
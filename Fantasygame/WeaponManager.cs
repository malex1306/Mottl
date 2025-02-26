namespace Fantasygame;

public class WeaponManager
{
    private List<Weapon> weapons = new List<Weapon>();
    private List<Defense> defenses = new List<Defense>();

    public WeaponManager()
    {
        //Start weapons
        weapons.Add(new Weapon("Schwert", 4, "Nahkampf"));
        weapons.Add(new Weapon("Zauberstab", 5, "Magie"));
        weapons.Add(new Weapon("Bogen", 5, "Fernkampf"));
        
        //Start defense
        defenses.Add(new Defense("Schild", 5));
        defenses.Add(new Defense("Magische Feuer Barriere", 5));
        defenses.Add(new Defense("kleines SChild", 5));
    }

    public Weapon GetWeaponForClass(int classChoice)
    {
        return classChoice switch
        {
            1 => weapons.First(w => w.Name == "Schwert"),
            2 => weapons.First(w => w.Name == "Zauberstab"),
            3 => weapons.First(w => w.Name == "Bogen"),
            _ => throw new ArgumentException("Ungültige Klassenauswahl")
        };
    }

    public Defense GetDefenseForClass(int classChoice)
    {
        return classChoice switch
        {
            1 => defenses.First(w => w.Name == "Schild"),
            2 => defenses.First(w => w.Name == "Magische Feuer Barriere"),
            3 => defenses.First(w => w.Name == "kleines SChild"),
            _ => throw new ArgumentException("Ungültige Klassenauswahl")
        };
    }
}
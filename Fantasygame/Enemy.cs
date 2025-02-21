namespace MyEnemys;

public class Enemy
{
    public int staerke = 0;
    public int gesundheit = 0;
    public int glueck = 0;
    
    public void CreateEnemyOrk()
    {
        Random rnd = new Random();
        
        int gesamtPunkte = 15;
        
        staerke = rnd.Next(1, gesamtPunkte -1);
        gesamtPunkte -= staerke;
        
        gesundheit = rnd.Next(1, gesamtPunkte);
        gesamtPunkte -= gesundheit;
        
        glueck = gesamtPunkte;

        ShowEnemyStats();
    }
    
    public void CreateEnemyMage()
    {
        Random rnd = new Random();
        
        int gesamtPunkte = 15;
        
        staerke = rnd.Next(1, gesamtPunkte -1);
        gesamtPunkte -= staerke;
        
        gesundheit = rnd.Next(1, gesamtPunkte);
        gesamtPunkte -= gesundheit;
        
        glueck = gesamtPunkte;

        ShowEnemyStats();
    }

    public void ShowEnemyStats()
    {
        Console.WriteLine("🛡️ Ein neuer Gegner ist erschienen!");
        Console.WriteLine($"💪 Stärke: {staerke}");
        Console.WriteLine($"❤️ Gesundheit: {gesundheit}");
        Console.WriteLine($"🍀 Glück: {glueck}");
        Console.WriteLine($"🎯 Gesamtsumme: {staerke + gesundheit + glueck} (Maximal 15!)");
    }
}

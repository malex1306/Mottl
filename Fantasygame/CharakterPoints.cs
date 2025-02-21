namespace Points;

public class CharakterPoints
{
    public void PlayerPoints()
    {
        Console.WriteLine("Nun kannst du Insgesamt 15 Punkte in Stärke, Gesundheit und Glück verteilen");
        Console.WriteLine("Achte auf die Punkteverteilung wird sie überschritten werden jedem Attribut automatisch 5 zugewiesen");

        int staerke, gesundheit, glueck = 0;
        int maxPunkte = 15;

        while (true)
        { 
            Console.WriteLine("Stärke eingeben");
            staerke = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Gesundheit eingeben");
            gesundheit = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Glück eingeben");
            glueck = Convert.ToInt32(Console.ReadLine());
            
            int summe = staerke + gesundheit + glueck;

            if (summe <= maxPunkte)
            {
                break;
            }
            else
            {
                Console.WriteLine($"Die Gesamtpunkte sind {summe} und überschreiten die erlaubten {maxPunkte}");
                Console.WriteLine($"Bitte verteile die Maximalen Punkte von{maxPunkte} neu");
            }
        }
        Console.WriteLine("\n Punkte erfolgreich verteilt");
        Console.WriteLine($"Du hast Stärke: {staerke}, Gesundheit: {gesundheit}, Glück: {glueck} gegeben!");
    }
}
namespace FlintStones
{
    public class Dino : Haustier
    {
        public Dino()
        {
            Wohnort = "Steintal";
            Geburtstag = new DateTime(1994, 12, 19);
            besitzer = new Menschen();  
            Namen = "Dino";  
        }

        public void GesichtAblecken()
        {
            Console.WriteLine("Dino leckt das Gesicht!");
        }

        public void ZeigeInfo()
        {
            Console.WriteLine($"Name: {Namen}");
            Console.WriteLine($"Geburtstag: {Geburtstag:dd.MM.yyyy}");
            Console.WriteLine($"Wohnort: {Wohnort}");
            Console.WriteLine($"Besitzer: {besitzer.GetType().Name}"); // Ausgabe des Besitzertyps (kann angepasst werden)
        }
    }
}
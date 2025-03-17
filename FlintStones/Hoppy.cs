namespace FlintStones
{
    public class Hoppy : Haustier
    {
        public Hoppy()
        {
            Wohnort = "Steintal";
            Geburtstag = new DateTime(1994, 12, 19);
            Besitzer = new Barney();  
            Namen = "Hoppy";  
        }

        public Barney Besitzer { get; set; }  
        
        public void SetzeBesitzer(Barney besitzer)
        {
            Besitzer = besitzer; 
        }

        public void Rumhoppsen()
        {
            Console.WriteLine("Hoppy hoppst fröhlich herum!");
        }

        public void ZeigeInfo()
        {
            Console.WriteLine($"Name: {Namen}");
            Console.WriteLine($"Geburtstag: {Geburtstag:dd.MM.yyyy}");
            Console.WriteLine($"Wohnort: {Wohnort}");
            Console.WriteLine($"Besitzer: {Besitzer}");  
        }
    }
}
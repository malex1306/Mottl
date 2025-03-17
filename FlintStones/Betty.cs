namespace FlintStones
{
    public class Betty : Frau
    {
        public Betty()
        {
            Vorname = "Betty";
            Nachname = "Rubble";
            Wohnort = "Steintal";
            Geburtstag = new DateTime(1994, 12, 19);
            Ehemann = new Barney();  
            kinder = new BammBamm();  
        }

        public void Shoppen()
        {
            Console.WriteLine("Betty geht shoppen!");
        }

        public void ZeigeInfo()
        {
            Console.WriteLine($"Name: {Vorname} {Nachname}");
            Console.WriteLine($"Geburtstag: {Geburtstag:dd.MM.yyyy}");
            Console.WriteLine($"Wohnort: {Wohnort}");
            Console.WriteLine($"Ehemann: {Ehemann} {Ehemann}");
            Console.WriteLine($"Kinder: {kinder} {kinder}");
        }
    }
}
namespace FlintStones
{
    public class Wilma : Frau
    {
        public Wilma()
        {
            Vorname = "Wilma";
            Nachname = "Flintstone";
            Wohnort = "Steintal";
            Geburtstag = new DateTime(1994, 12, 19);
            Ehemann = new Fred();  
            kinder = new Pebbles(); 
        }

        public void Kochen()
        {
            Console.WriteLine("Wilma kocht ein leckeres Essen!");
        }

        public void ZeigeInfo()
        {
            Console.WriteLine($"Name: {Vorname} {Nachname}");
            Console.WriteLine($"Geburtstag: {Geburtstag:dd.MM.yyyy}");
            Console.WriteLine($"Wohnort: {Wohnort}");
            Console.WriteLine($"Ehemann: {Ehemann} ");
            Console.WriteLine($"Kinder: {kinder} ");
        }
    }
}
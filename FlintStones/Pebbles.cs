namespace FlintStones
{
    public class Pebbles : Kinder
    {
        public Pebbles()
        {
            Vorname = "Pebbles";
            Nachname = "Flintstone";
            Wohnort = "Steintal";
            Geburtstag = new DateTime(1994, 12, 19);
        }

        // Setze die Eltern (Fred und Wilma)
        public void SetzeEltern(Fred vater, Wilma mutter)
        {
            this.vater = vater;
            this.mutter = mutter;
        }

        public void Krabbeln()
        {
            Console.WriteLine("Pebbles krabbelt fröhlich herum!");
        }

        public void ZeigeInfo()
        {
            Console.WriteLine($"Name: {Vorname} {Nachname}");
            Console.WriteLine($"Wohnort: {Wohnort}");
            Console.WriteLine($"Geburtstag: {Geburtstag:dd.MM.yyyy}");
            Console.WriteLine($"Vater: {vater} {vater}");
            Console.WriteLine($"Mutter: {mutter} {mutter}");
        }
    }
}
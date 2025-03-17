namespace FlintStones
{
    public class BammBamm : Kinder
    {
        private Fred vater;
        private Wilma mutter;

        public BammBamm()
        {
            Vorname = "Bamm";
            Nachname = "Flintstone";
            Wohnort = "Steintal";
            Geburtstag = new DateTime(1994, 12, 19);
        }

      
        public void SetzeEltern(Fred vater, Wilma mutter)
        {
            this.vater = vater; 
            this.mutter = mutter; 
        }

        public void KaputtSchlagen()
        {
            Console.WriteLine("BammBamm schlägt alles kaputt!");
        }

       
        public void ZeigeInfo()
        {
            Console.WriteLine($"Name: {Vorname} {Nachname}");
            Console.WriteLine($"Wohnort: {Wohnort}");
            Console.WriteLine($"Geburtstag: {Geburtstag:dd.MM.yyyy}");

            // Korrekte Ausgabe der Eltern
            Console.WriteLine($"Vater: {vater}");
            Console.WriteLine($"Mutter: {mutter} ");
        }
    }
}
namespace WiederholungBeziehung;

class Program
{
    static void Main(string[] args)
    {
        //Assoziation
        // Lehrer lehrer = new Lehrer("Mustermann");
        // Schueler schueler = new Schueler();
        // Schueler schueler2 = new Schueler();
        // Schueler schueler3 = new Schueler();
        //
        // lehrer.AddSchueler(schueler);
        // lehrer.AddSchueler(schueler2);
        // lehrer.AddSchueler(schueler3);
        
        // Aggregation
        // Schueler schueler = new Schueler();
        // Schueler schueler2 = new Schueler();
        // Schueler schueler3 = new Schueler();
        // List<Schueler> schuelerListe = new List<Schueler>(){ schueler, schueler2, schueler3 };
        //
        // Lehrer l1 = new Lehrer(schuelerListe);
        
        // Komposition
        Lehrer l1 = new Lehrer();
    }
}
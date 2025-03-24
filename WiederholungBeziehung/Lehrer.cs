namespace WiederholungBeziehung;

public class Lehrer
{
    public string name { get; set; }
    public List<Schueler> schuelerliste { get; set; }

    // Assoziation
    // public Lehrer(string _name)
    // {
    //     name = _name;
    //     schuelerliste = new List<Schueler>();
    // }

    // Aggregation

    // public Lehrer(List<Schueler> schuelerliste)
    // {
    //     this.schuelerliste = schuelerliste;
    // }
    
    // Kompostion
    public Lehrer()
    {
        Schueler s1 = new Schueler();
        Schueler s2 = new Schueler();
        Schueler s3 = new Schueler();
        
        schuelerliste = new List<Schueler>() { s1, s2, s3 };
    }
    
    public void AddSchueler(Schueler schueler)
    {
        schuelerliste.Add(schueler);
    }
}
namespace Immobilien;

public class Wohnung : Immobilie
{
    public int Zimmer { get; set; }

    public Wohnung(int flaeche, string adresse, int zimmer) 
        : base(flaeche, adresse) 
    {
        Zimmer = zimmer;
    }

    public override void SetMiete(int miete)
    {
        this.miete = flaeche * 10;
    }

    public override int GetMiete()
    {
        return miete; 
    }
}
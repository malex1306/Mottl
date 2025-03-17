namespace Immobilien;

public class Immobilie
{
    public int flaeche;
    public int miete;
    public string adresse;

    public Immobilie(int flaeche, string adresse)
    {
        this.flaeche = flaeche;
        this.adresse = adresse;
       
    }
    
    public virtual void SetMiete(int miete)
    {
        this.miete = miete;
    }

    public virtual int GetMiete()
    {
        return miete;
    }
    
}
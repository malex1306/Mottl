namespace Immobilien;

public class Geschaeftsraume : Immobilie
{
    public int geschaeftsräume { get; set; }
    
    public Geschaeftsraume(int flaeche, string adresse,int geschaeftsräume) 
        : base(flaeche, adresse) 
    {
        this.geschaeftsräume = geschaeftsräume;
    }
    
    public override void SetMiete(int miete)
    {
        this.miete = (flaeche * 20) + (geschaeftsräume * 30);
    }

    public override int GetMiete()
    {
        return this.miete; 
    }
    
}
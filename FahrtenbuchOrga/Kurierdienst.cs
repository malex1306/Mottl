namespace FahrtenbuchOrga;

public class Kurierdienst 
{
    private List<Fahrtenbuch> fahrtenbuecher = new List<Fahrtenbuch>();

    public void AddFahrtenbuch(Fahrtenbuch buch)
    {
        fahrtenbuecher.Add(buch);
    }
    
    public double BerechneUmsatzProTag(DateTime datum)
    {
        return fahrtenbuecher.Sum(buch => buch.BerechneUmsatzProTag(datum));
    }

    public double BerechneUmsatzProFahrer(string name)
    {
        return fahrtenbuecher.Where(b => b.Name == name).Sum(b => b.BerechneUmsatz());
    }

    public double BerechneGesamtumsatz()
    {
        return fahrtenbuecher.Sum(buch => buch.BerechneUmsatz());
    }
}
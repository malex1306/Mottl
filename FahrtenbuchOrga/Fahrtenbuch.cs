namespace FahrtenbuchOrga;

public class Fahrtenbuch
{
    public string Name { get; set; }
    
    private List<Fahrt> fahrten = new List<Fahrt>();

    public Fahrtenbuch(string name)
    {
        Name = name;
    }

    public void AddFahrt(Fahrt fahrt)
    {
        fahrten.Add(fahrt);
    }

    public double BerechneUmsatz()
    {
        return fahrten.Sum(f => f.BerechnePreis());

    }

    public double BerechneUmsatzProTag(DateTime date)
    {
        return fahrten.Where(f => f.Datum.Date == date.Date).Sum(f => f.BerechnePreis());
    }
}
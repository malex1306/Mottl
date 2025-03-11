namespace ZooBesucher;

public class Entrance
{
    private List<Besucher> BesucherListe = new List<Besucher>();

    public void AddVisitor(Besucher besucher)
    {
        BesucherListe.Add(besucher);
    }

    public int GetTurnover()
    {
        return BesucherListe.Sum(besucher => besucher.Eintrittspreis);
    }

    public int GetBesucher()
    {
        return BesucherListe.Sum(besucher =>
        {
            if (besucher is Gruppe gruppe)
                return gruppe.Gruppengröße; 
            if (besucher is Erwachsene erwachsene)
                return erwachsene.AnzahlErwachsene; 
            if (besucher is Kind kind)
                return kind.AnzahlKinder;
            return 1;
        });
    }
}







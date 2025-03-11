namespace ZooBesucher;

public class Erwachsene : Besucher
{
        public int AnzahlErwachsene { get; set; }

        public Erwachsene(int anzahlErwachsene) : base(anzahlErwachsene * 15) 
        {
                AnzahlErwachsene = anzahlErwachsene;
        }
}


namespace DigitaleSpardose;

public class Spardose
{
    public double Cent { get; private set; }
    public double Euro { get; private set; }
    public double MaxAnzahl { get; private set; }
    public bool DoseAufgebrochen { get; private set; }
    
    private static double GesamtSparbetrag = 0; 

    public Spardose(double maxAnzahl)
    {
        Cent = 0;
        Euro = 0;
        MaxAnzahl = maxAnzahl;
        DoseAufgebrochen = false;
    }

    private double Gesamtbetrag()
    {
        return Euro + (Cent / 100);
    }

    private bool IstVoll()
    {
        return Gesamtbetrag() >= MaxAnzahl;
    }

    private void Hinzufügen(double cent, double euro)
    {
        if (DoseAufgebrochen)
        {
            Console.WriteLine("Die Spardose wurde aufgebrochen. Kein weiteres Sparen möglich.");
            return;
        }

        if (IstVoll())
        {
            Console.WriteLine("Die Spardose ist voll!");
            return;
        }

        Cent += cent;
        Euro += euro;

        
        while (Cent >= 100)
        {
            Cent -= 100;
            Euro += 1;
        }

        GesamtSparbetrag += (euro + cent / 100);
    }

    public void AddCents1() => Hinzufügen(1, 0);
    public void AddCents2() => Hinzufügen(2, 0);
    public void AddCents5() => Hinzufügen(5, 0);
    public void AddCents10() => Hinzufügen(10, 0);
    public void AddCents20() => Hinzufügen(20, 0);
    public void AddCents50() => Hinzufügen(50, 0);
    public void AddEuros1() => Hinzufügen(0, 1);
    public void AddEuros2() => Hinzufügen(0, 2);

    public void DoseAufbrechen()
    {
        DoseAufgebrochen = true;
        Console.WriteLine($"Spardose aufgebrochen! Inhalt: {Gesamtbetrag()} Euro");
    }

    public static void AlleSpardosenGesamtbetrag()
    {
        Console.WriteLine($"Gesamter Sparbetrag aller Spardosen: {GesamtSparbetrag} Euro");
    }
}
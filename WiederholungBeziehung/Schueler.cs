namespace WiederholungBeziehung;

public class Schueler
{
    public string name { get; set; }

    // Abhängikeit
    public void BuchLesen(Buch b)
    {
        Console.WriteLine($"Der schüler {name} ließt das Buch {b.Title}");
    }
}
namespace ZooBesucher;

public class Gruppe : Besucher
{
    public int Gruppengröße { get; set; }

    public Gruppe(int gruppengroeße) : base(50)
    {
        if (gruppengroeße < 5)
            throw new ArgumentException("Eine Gruppe muss mindestens 5 Personen haben.");

        Gruppengröße = gruppengroeße;
    }
}

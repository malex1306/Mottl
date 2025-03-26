namespace Interface;

public class Fahrrad : IFahrzeug
{
    public void Fahren()
    {
        Console.WriteLine("Das Fahrrad fährt");
    }
}
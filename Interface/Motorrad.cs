namespace Interface;

public class Motorrad : IFahrzeug
{
    public void Fahren()
    {
        Console.WriteLine("Das Motorrad fährt");
    }
}
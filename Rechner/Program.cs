namespace Rechner;

class Program
{
    static void Main(string[] args)
    {
        int ergebnis = Rechner.Addieren(5, 8);
        Console.WriteLine($"Das Ergebnis ist: {ergebnis}");
    }
}

class Rechner
{
    public static int Addieren(int a, int b)
    {
        return a + b;
    }
    
}
namespace Math;

class Program
{
    static void Main(string[] args)
    {
        MatheHelfer.Quadrat(5);
        int fakultatErgebnis = MatheHelfer.Fakultat(12);
        Console.WriteLine($"Die Fakultat ist: {fakultatErgebnis}");
    }
}

class MatheHelfer
{
    public static void Quadrat(int zahl)
    {
        Console.WriteLine($"Die Quadratzahl von {zahl} ist {zahl * zahl}");
    }

    public static int Fakultat(int zahl)
    {
        int result = 1;
        for (int i = 1; i <= zahl; i++)
        {
            result *= i;
        }
        return result;
    }
}
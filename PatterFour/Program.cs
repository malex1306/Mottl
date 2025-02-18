namespace PatterFour
{
    class Program
    {
        static void Main()
        {
                Console.Write("Gib die Höhe des Dreiecks ein: ");
                if (int.TryParse(Console.ReadLine(), out int hoehe) && hoehe > 0)
                { 
                    for (int i = 1; i <= hoehe; i++)
                    { 
                        Console.Write(new string(' ', hoehe - i));
                     
                        Console.WriteLine(new string('*', 2 * i - 1));
                    }
                }
                else
                {
                    Console.WriteLine("Bitte eine gültige positive Zahl eingeben.");
                }
        }
    }
}
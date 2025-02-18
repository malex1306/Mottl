namespace ArraySimple;

class Program
{
    static void Main(string[] args)
    {
        string[] TeilnehmerDo7 = new string[6];

        for (int i = 0; i < TeilnehmerDo7.Length; i++)
        {
            Console.WriteLine($"Geben Sie {i + 1} Namen ein: ");
            string name = Console.ReadLine();
            TeilnehmerDo7[i] = name;
        }

        foreach (string teilnehmer in TeilnehmerDo7)
        {
            Console.WriteLine(teilnehmer);
        }
    }
}
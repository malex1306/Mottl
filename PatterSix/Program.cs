namespace PatterSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie die Reihen an: ");
            int reihen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geben Sie die Spalten an: ");
            int spalten = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < reihen; i++)
            {
                for (int j = 0; j < spalten; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        if (j%2 != 0 && i % 2 == 0)
                        {
                            Console.Write("|");
                        }
                        else if (i % 2 != 0 && j % 2 == 0)
                        {
                            Console.Write("-");
                        }
                        else
                        {
                            Console.Write("+");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
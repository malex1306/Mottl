namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // xxxxxxx
            // xxxxxxx
            // xxxxxxx
            // xxxxxxx
            // xxxxxxx
            // xxxxxxx

            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= 6; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write("x");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
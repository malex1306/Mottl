namespace PatternFour
{
    class Program
    {
        static void Main()
        {
            int rows = 4;
            
            for (int i = 0; i < rows ; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write(" ");

                Console.Write("X");

                for (int j = 0; j < 2 * (rows - i -1 ); j++)
                    Console.Write(" ");

                Console.WriteLine("X");
            }
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                    Console.Write(" ");

                for (int j = 0; j < 2 * i + 2; j++)
                    Console.Write("X");

                Console.WriteLine();
            }
        }
    }
}
namespace PatterThree
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write((i < 4) == (j < 4) ? '.' : '=');
                }
                Console.WriteLine();
            }
        }
    }
}
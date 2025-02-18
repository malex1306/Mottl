namespace PatterOne;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if ((i + j) % 2 == 0)
                {
                    Console.Write("0 ");
                }
                else
                {
                    Console.Write("X ");
                }
            }

            Console.WriteLine();
        }
    }
}
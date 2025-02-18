
class Program
{
    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 4 - i; j++)
            
                Console.Write(" ");
            
            
            for (int j = 0; j < 5; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
namespace _2dArr;

class Program
{
    static void Main(string[] args)
    {
        int[,] array2D = { { 1, 2, 3, 4, 5, 6, 7 }, { 1, 2, 3, 4, 5, 6, 7 } };

        // for (int i = 0; i < array2D.GetLength(0); i++)
        // {
        //     for (int j = 0; j < array2D.GetLength(1); j++)
        //     {
        //         Console.Write((array2D[i, j] + " ").PadLeft(5));
        //     }
        //     Console.WriteLine();
        // }
        
        // mit foreach
        
        int counter = 0;
        foreach (int a in array2D)
        {
            
            Console.Write((a + " ").PadLeft(10));
            counter++;
            if (counter == array2D.GetLength(1))
            {
                Console.WriteLine();
                counter = 0;
            }
        }
    }
}
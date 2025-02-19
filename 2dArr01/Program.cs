namespace _2dArr01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[3, 3];

            // Eingabe des 2D-Arrays
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.WriteLine("Geben Sie eine Zahl zwischen 1 - 9 an:");
                    array2D[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Ausgabe des 2D-Arrays
            Console.WriteLine("\nAusgabe des 2D-Arrays:");
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write(array2D[i, j].ToString().PadLeft(5));
                }
                Console.WriteLine(); // Neue Zeile nach jeder Zeile des Arrays
            }
        }
    }
}
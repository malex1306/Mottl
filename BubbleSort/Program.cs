class Program
{
    static void Main()
    {
        int[] zahlen = RandomZahlen(10); 
        Console.WriteLine("Unsortiert: " + string.Join(", ", zahlen));

        BubbleSort(zahlen);
        Console.WriteLine("Sortiert:   " + string.Join(", ", zahlen));
    }

    static int[] RandomZahlen(int length)
    {
        Random rand = new Random();
        int[] zahlen = new int[length];

        for (int i = 0; i < length; i++)
        {
            zahlen[i] = rand.Next(1, 10); 
        }
        return zahlen;
    }

    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        bool swapped;

        do
        {
            swapped = false;
            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] > array[i + 1]) 
                {
                    (array[i], array[i + 1]) = (array[i + 1], array[i]); 
                    swapped = true;
                }
            }
        } while (swapped);
    }
}
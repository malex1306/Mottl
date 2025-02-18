namespace array03;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Geben sie dinge zum einkauf ein :");
        // string [] arr = Console.ReadLine().Split(" ");
        //
        // HashSet<string> einzigartigeItems = new HashSet<string>(arr);
        //
        // Console.WriteLine("Eindeutige einkaufsliste: ");
        // foreach (string item in einzigartigeItems)
        // {
        //     Console.WriteLine(item);
        // }
        Console.WriteLine("Geben Sie Dinge zum Einkauf ein:");
        string[] arr = Console.ReadLine().Split(" ");

        List<string> einzigartigeItems = new List<string>();

        foreach (string item in arr)
        {
            bool istEinzigartig = true;

           
            for (int i = 0; i < einzigartigeItems.Count; i++)
            {
                if (einzigartigeItems[i] == item)
                {
                    istEinzigartig = false;
                    break;
                }
            }

            
            if (istEinzigartig)
            {
                einzigartigeItems.Add(item);
            }
        }
        Console.WriteLine("Eindeutige Einkaufsliste:");
        foreach (string item in einzigartigeItems)
        {
            Console.WriteLine(item);
        }
    }
}
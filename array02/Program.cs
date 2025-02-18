namespace array02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Geben Sie Buchstaben getrennt mit Leerzeichen ein:");
        string[] array = Console.ReadLine().Split(' ');

        string[] uniqueItems = array.Distinct().ToArray(); 
        int[] counts = new int[uniqueItems.Length]; 

        for (int i = 0; i < uniqueItems.Length; i++)
        {
            foreach (string item in array)
            {
                if (item == uniqueItems[i])
                {
                    counts[i]++;
                }
            }
        }

        Console.WriteLine("Häufigkeit der Buchstaben:");
        for (int i = 0; i < uniqueItems.Length; i++)
        {
            Console.WriteLine($"{uniqueItems[i]}: {counts[i]}");
        }
    }
    
}
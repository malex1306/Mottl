namespace Komprimierung;

class Program
{
    static string[] ErstelleKomprimierung(string[] unkomprimiert)
    {
        List<string> komprimiert = new List<string>();
        int zaehler = 1;

        for (int i = 0; i < unkomprimiert.Length - 1; i++)
        {
            if (unkomprimiert[i] == unkomprimiert[i + 1])
            {
                zaehler++;
            }
            else
            {
                if (zaehler > 4)
                {
                    komprimiert.Add("%");
                    komprimiert.Add(zaehler.ToString());
                    komprimiert.Add(unkomprimiert[i]);
                }
                else
                {
                    for (int j = 0; j < zaehler; j++)
                    {
                        komprimiert.Add(unkomprimiert[i]);
                    }
                }
                zaehler = 1;
            }
        }

      
        if (zaehler > 4)
        {
            komprimiert.Add("%");
            komprimiert.Add(zaehler.ToString());
            komprimiert.Add(unkomprimiert[^1]);
        }
        else
        {
            for (int j = 0; j < zaehler; j++)
            {
                komprimiert.Add(unkomprimiert[^1]);
            }
        }

        return komprimiert.ToArray();
    }

    static void Main()
    {
        string[] input = { "a", "a", "a", "a", "a", "b", "b", "b", "c", "c", "c", "c", "c", "c" };
        string[] result = ErstelleKomprimierung(input);
        Console.WriteLine(string.Join(", ", result));
    }
}

namespace _2dArr02;

class Program
{
    static void Main(string[] args)
    {
        Program p = new Program();
        p.Room();
        p.Temperature();
    }

    int[,] arrRooms = new int[2, 2]; 
    int[,] arrTemp = new int[2, 2];  

    public void Room()
    {
        for (int i = 0; i < arrRooms.GetLength(0); i++)
        {
            for (int j = 0; j < arrRooms.GetLength(1); j++)
            {
                Console.Write("Geben Sie die Raumnummer (1 - 4) ein: ");
                arrRooms[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Raumnummern gespeichert.\n");
    }

    public void Temperature()
    {
        for (int i = 0; i < arrTemp.GetLength(0); i++)
        {
            for (int j = 0; j < arrTemp.GetLength(1); j++)
            {
                Console.Write($"Geben Sie die Temperatur für Raum {arrRooms[i, j]} ein: ");
                arrTemp[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nRaum Temperaturen aufgenommen.\n");

    
        int maxTemp = GetMaxTemperature();
        double avgTemp = GetAverageTemperature();

        Console.WriteLine($"Maximale Temperatur: {maxTemp}°C");
        Console.WriteLine($"Durchschnittstemperatur: {avgTemp:F2}°C");
    }

    private int GetMaxTemperature()
    {
        int max = arrTemp[0, 0];

        foreach (int temp in arrTemp)
        {
            if (temp > max)
                max = temp;
        }

        return max;
    }

    private double GetAverageTemperature()
    {
        int sum = 0;
        int count = arrTemp.GetLength(0) * arrTemp.GetLength(1);

        foreach (int temp in arrTemp)
        {
            sum += temp;
        }

        return (double)sum / count;
    }
}
namespace classLearn;

public class Auto
{
    private string marke;
    private bool gestartet;
    private double speed; 
    private double way;   
    private double time;
    private double minutes;
    private double Kilometerstand;
  

    public bool IstAn()
    {
        return gestartet;
    }

    public void Starten()
    {
        if (!gestartet)
        {
            gestartet = true;
        }
        else
        {
            Console.WriteLine($"Das Auto mit der Marke {marke} ist bereits an!");
        }
    }

    public string GetMarke()
    {
        return marke;
    }

    public void SetMarke(string m)
    {
        marke = m;
    }

    public double GetSpeed()
    {
        return speed;
    }

    public void SetSpeed(double speed)
    {
        this.speed = speed;
    }
    
    public double GetTime()
    {
        return time;
    }

    public void SetTime(double m)
    {
        minutes = m;
    }

    public double GetKilometerstand()
    {
        return Kilometerstand;
    }

    public void GefahreneKm()
    {
        if (gestartet)
        {
            way = (speed/60) * minutes;
            Kilometerstand += way;
            
            Console.WriteLine($"Das Auto hat in {minutes} Minuten eine Strecke von {way:f2} km zurückgelegt.");
        }
        else
        {
            Console.WriteLine("Das Auto ist nicht gestartet. Strecke kann nicht berechnet werden.");
            Console.WriteLine("Möchten sie das Auto starten? (j/n)");
            string answer = Console.ReadLine();

            switch (answer.ToLower())
            {
                case "j":
                    Starten();
                    GefahreneKm();
                    break;
                case "n":
                    Console.WriteLine("Das Auto ist nicht gestartet.");
                    break;
                default:
                    Console.WriteLine("Ungültige angabe.");
                    break;
            }
        }
    }
}
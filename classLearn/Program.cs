namespace classLearn;

class Program
{
    static void Main(string[] args)
    {
        Auto meinAuto = new Auto();
        meinAuto.SetMarke("Honda"); 
        meinAuto.SetSpeed(100); 
        meinAuto.SetTime(134);    

        Console.WriteLine($"Folgende Marke wurde gesetzt: {meinAuto.GetMarke()}");
        Console.WriteLine($"Maximale Geschwindigkeit für {meinAuto.GetMarke()} liegt bei {meinAuto.GetSpeed()} km/h.");
        
        Console.WriteLine($"Auto gestartet? {meinAuto.IstAn()}");

        //einAuto.Starten();
        
        meinAuto.GefahreneKm(); 
    }
}
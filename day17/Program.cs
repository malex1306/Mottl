namespace day17;

class Program
{
    static void Main(string[] args)
    {
        Auto a1 = new Auto("blue", "Audi");
        Auto a2 = new Auto("blue", "Audi");
        Motorrad m1 = new Motorrad("BMW", true);
        
        Console.WriteLine(Fahrzeug.GetAnzahlFahrzeuge());
        Console.WriteLine(Auto.GetAnzahlFahrzeuge());

        Fahrzeug f1 = new Motorrad("BMW",true);
        f1.getMarke();

        if (f1 is Motorrad)
        {
            Motorrad m2 = (Motorrad)f1;
        }
        
        Motorrad m3 = f1 as Motorrad;
        if (m3 == null)
        {
           Console.WriteLine("Kein Motorrad vorhanden"); 
        }
        
    }
}
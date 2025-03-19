namespace FahrtenbuchOrga;

class Program
{
    static void Main(string[] args)
    {
        Kurierdienst dienst = new Kurierdienst();

        Fahrtenbuch buch1 = new Fahrtenbuch("Max");
        Fahrtenbuch buch2 = new Fahrtenbuch("Lisa");

        buch1.AddFahrt(new Fahrt(DateTime.Today, 10, false, new Pkws())); 
        buch1.AddFahrt(new Fahrt(DateTime.Today, 5, true, new Motorroller())); 

        buch2.AddFahrt(new Fahrt(DateTime.Today, 20, false, new Kleintransporter())); 
        buch2.AddFahrt(new Fahrt(DateTime.Today, 8, true, new Lastenfahraeder())); 

        dienst.AddFahrtenbuch(buch1);
        dienst.AddFahrtenbuch(buch2);

        Console.WriteLine($"Gesamtumsatz: {dienst.BerechneGesamtumsatz()} €");
        Console.WriteLine($"Umsatz heute: {dienst.BerechneUmsatzProTag(DateTime.Today)} €");
        Console.WriteLine($"Umsatz von Max: {dienst.BerechneUmsatzProFahrer("Max")} €");  
    }
}
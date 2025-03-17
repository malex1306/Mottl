namespace Simpsons;

public class Homer : Characteristics
{
    private int donutCounter = 0; 

    public Homer() : base("Homer", "Simpson", "Gelb", "Evergreen Terrace 742, Springfield")
    {
        Console.WriteLine($"Vorname: {Vorname}, Nachname: {Nachname}, Hautfarbe: {Hautfarbe}, Wohnort: {Wohnort}");
    }

    public void Donuts()
    {
        donutCounter++; 
        Console.WriteLine($"Homer hat {donutCounter} Donut(s) gegessen!");
    }
}
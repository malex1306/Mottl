namespace Interfaces;

class Program
{
    static void Main(string[] args)
    {
        Elektroauto Ford = new Elektroauto("Modell Mustung");
        Ford.Starten();
        Ford.Laden();

        IFahrzeug t1 = Ford;
        t1.ZeigeMaterial();
        IElktroauto t2 = Ford;
        t2.ZeigeMaterial();
    }
}
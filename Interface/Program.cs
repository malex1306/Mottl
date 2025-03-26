namespace Interface;

class Program
{
    static void Main(string[] args)
    {
        Auto auto = new Auto();
        auto.Fahren();
        Fahrrad fahrrad = new Fahrrad();
        fahrrad.Fahren();
    }
}
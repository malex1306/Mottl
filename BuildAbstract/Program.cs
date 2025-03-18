namespace BuildAbstract;

class Program
{
    static void Main(string[] args)
    {
        Hund hund = new Hund();
        hund.MachGeraeusch();
        
        Katze katze = new Katze();
        katze.MachGeraeusch();
    }
}
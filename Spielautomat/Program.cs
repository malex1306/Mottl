namespace Spielautomat;

class Program
{
    static void Main(string[] args)
    {
        Spielautomat spielautomat = new Spielautomat();
        spielautomat.StartSpiel();
        spielautomat.ZeigeHighscore();
    }
}
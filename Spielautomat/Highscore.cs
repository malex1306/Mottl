namespace Spielautomat;

public class Spielautomat
{
    public int Highscore { get; set; }
    public string HighscoreSpieler { get; set; }
    private Random random = new Random();

    public void StartSpiel()
    {
        Console.WriteLine("Gib deinen Namen ein");
        string spielerName = Console.ReadLine();
        int aktuelleZahl = random.Next(1, 100);
        int score = 0;
        
        Console.WriteLine($"Startzahl: {aktuelleZahl}");
        while (true)
        {
            Console.WriteLine("Möchtest du weitermachen? (j/n)");
            string eingabe = Console.ReadLine().ToLower();
            if (eingabe != "j")
            {
                BeendeSpiel(spielerName, score);
                return;
            }
            int neueZahl = random.Next(1, 100);
            Console.WriteLine($"Neue Zahl: {neueZahl}");
            
            if (neueZahl < aktuelleZahl && neueZahl % 2 != 0)
            {
                Console.WriteLine("Du hast verloren!");
            }

            aktuelleZahl = neueZahl;
            score++;
        }
    }

    private void BeendeSpiel(string spielerName, int score)
    {
        Console.WriteLine($"Spiel beendet, Dein Score: {score}");
        if (score > Highscore)
        {
            Highscore = score;
            HighscoreSpieler = spielerName;
            Console.WriteLine($"Neuer Highscore");
        }
    }

    public void ZeigeHighscore()
    {
        if (string.IsNullOrEmpty(HighscoreSpieler))
        {
            Console.WriteLine("Es gibt noch keinen Highscore");
        }
        else
        {
            Console.WriteLine($"Highscore: {Highscore} von {HighscoreSpieler}");
        }
    }
}
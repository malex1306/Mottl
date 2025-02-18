namespace array04
{
    class Program
    {
        static void Main(string[] args)
        {
            bool spielen = true;

            while (spielen)
            {
                string[] arrWords = { "Auto", "Baum", "Haus", "Luftballon" };
                Random zufall = new Random();
                int index = zufall.Next(0, arrWords.Length);
                string randomWord = arrWords[index];

                char[] wordArray = randomWord.ToCharArray();
                char[] rateArray = new char[wordArray.Length];

                for (int i = 0; i < wordArray.Length; i++)
                {
                    rateArray[i] = '_';
                }

                int maxFails = 8;
                int fails = 0;
                bool gewonnen = false;

                while (fails < maxFails && !gewonnen)
                {
                    Console.Clear();
                    Console.WriteLine("Hangman - Versuche das Wort zu erraten!");
                    Console.WriteLine("Fehlversuche übrig: " + (maxFails - fails));
                    Console.WriteLine("Wort: " + new string(rateArray));
                    Console.WriteLine("Bereits getippte Buchstaben: ");

                    Console.WriteLine("Buchstabe eingeben: ");
                    char buchstabe = Char.ToLower(Console.ReadKey().KeyChar); // Umwandlung in Kleinbuchstaben
                    Console.WriteLine();

                    bool buchstabeFind = false;
                    for (int i = 0; i < wordArray.Length; i++)
                    {
                        // Hier wird der Buchstabe ebenfalls in Kleinbuchstaben umgewandelt
                        if (Char.ToLower(wordArray[i]) == buchstabe)
                        {
                            rateArray[i] = wordArray[i]; // Setze den gefundenen Buchstaben im rateArray
                            buchstabeFind = true;
                        }
                    }

                    if (!buchstabeFind)
                    {
                        fails++;
                    }

                    gewonnen = true;
                    for (int i = 0; i < rateArray.Length; i++)
                    {
                        if (rateArray[i] == '_')
                        {
                            gewonnen = false;
                            break;
                        }
                    }
                }

                Console.Clear();
                if (gewonnen)
                {
                    Console.WriteLine("Herzlichen Glückwunsch, du hast das Wort erraten: " + randomWord);
                }
                else
                {
                    Console.WriteLine("Du hast verloren! Das Wort war: " + randomWord);
                }

                Console.WriteLine("Möchtest du noch einmal spielen? (j/n)");
                char antwort = Console.ReadKey().KeyChar;
                if (antwort != 'j')
                {
                    spielen = false;
                }
            }
        }
    }
}

namespace Buecherverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            Bibliothek meineBibliothek = new Bibliothek();

            while (true)
            {
                Console.WriteLine("\nBuchverwaltung - Wählen Sie eine Option:");
                Console.WriteLine("1 - Buch hinzufügen");
                Console.WriteLine("2 - Buch entfernen");
                Console.WriteLine("3 - Alle Bücher anzeigen");
                Console.WriteLine("4 - Beenden");
                Console.Write("Ihre Auswahl: ");

                string eingabe = Console.ReadLine();

                switch (eingabe)
                {
                    case "1":
                        BuchHinzufuegen(meineBibliothek);
                        break;
                    case "2":
                        BuchEntfernen(meineBibliothek);
                        break;
                    case "3":
                        meineBibliothek.AlleBuecherAnzeigen();
                        break;
                    case "4":
                        Console.WriteLine("Programm wird beendet...");
                        return;
                    default:
                        Console.WriteLine("Ungültige Eingabe. Bitte wählen Sie eine Zahl zwischen 1 und 4.");
                        break;
                }
            }
        }

        static void BuchHinzufuegen(Bibliothek bibliothek)
        {
            Console.Write("\nGeben Sie den Autor des Buches ein: ");
            string author = Console.ReadLine();

            Console.Write("Geben Sie den Buchnamen ein: ");
            string buchname = Console.ReadLine();

            Console.Write("Geben Sie das Erscheinungsjahr ein: ");
            if (!int.TryParse(Console.ReadLine(), out int erscheinung))
            {
                Console.WriteLine("Ungültige Eingabe! Bitte geben Sie eine Zahl für das Erscheinungsjahr ein.");
                return;
            }

            Buecher neuesBuch = new Buecher(buchname, author, erscheinung);
            bibliothek.BuecherHinzufuegen(neuesBuch);
        }

        static void BuchEntfernen(Bibliothek bibliothek)
        {
            Console.Write("\nGeben Sie den Namen des Buches ein, das entfernt werden soll: ");
            string buchname = Console.ReadLine();

            if (bibliothek.BuecherEntfernen(buchname))
            {
                Console.WriteLine($"Das Buch \"{buchname}\" wurde entfernt.");
            }
            else
            {
                Console.WriteLine($"Buch \"{buchname}\" wurde nicht gefunden.");
            }
        }
    }

    class Buecher
    {
        public string Buchname { get; set; }
        public string Author { get; set; }
        public int Erscheinung { get; set; }

        public Buecher(string buchname, string author, int erscheinung)
        {
            Buchname = buchname;
            Author = author;
            Erscheinung = erscheinung;
        }
    }

    class Bibliothek
    {
        private List<Buecher> buchListe = new List<Buecher>();

        public void BuecherHinzufuegen(Buecher neuesBuch)
        {
            buchListe.Add(neuesBuch);
            
        }

        public bool BuecherEntfernen(string buchname)
        {
            var buch = buchListe.FirstOrDefault(b => b.Buchname.Equals(buchname, StringComparison.OrdinalIgnoreCase));
            if (buch != null)
            {
                buchListe.Remove(buch);
                return true;
            }
            return false;
        }

        public void AlleBuecherAnzeigen()
        {
            
            if (buchListe.Count == 0)
            {
                Console.WriteLine("\nEs sind keine Bücher in der Bibliothek.");
            }
            else
            {
                Console.WriteLine("\nFolgende Bücher sind in der Bibliothek enthalten:");
                foreach (var bu in buchListe)
                {
                    Console.WriteLine($" {bu.Buchname} |  {bu.Author} | {bu.Erscheinung}");
                }
            }
        }
    }
}

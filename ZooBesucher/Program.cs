namespace ZooBesucher;

    class Program
    {
        static void Main()
        {
            Entrance entrance = new Entrance();

            entrance.AddVisitor(new Erwachsene(5)); // 15 €
            entrance.AddVisitor(new Kind(3)); // 0 €
            entrance.AddVisitor(new Gruppe(5)); // 50 €

            Console.WriteLine($"Anzahl Besucher: {entrance.GetBesucher()}");
            Console.WriteLine($"Tagesumsatz: {entrance.GetTurnover()} €");
        }
    }


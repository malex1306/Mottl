namespace FlintStones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erstelle die Instanzen der Charaktere und Haustiere
            Fred fred = new Fred();
            Wilma wilma = new Wilma();
            Pebbles pebbles = new Pebbles();
            Barney barney = new Barney();
            Betty betty = new Betty();
            BammBamm bammBamm = new BammBamm();
            BabyPuss babyPuss = new BabyPuss();
            Hoppy hoppy = new Hoppy();
            Dino dino = new Dino();
            
            // Setze die Familie von Fred und rufe seine Infos auf
            fred.SetzeFamilie(wilma, pebbles);
            fred.ZeigeInfo();
            fred.YabbaDabbaDoo();
            Console.WriteLine();

            // Setze die Familie von Barney und rufe seine Infos auf
            barney.SetzeFamilie(betty, bammBamm);
            barney.ZeigeInfo();
            barney.Kichern();
            Console.WriteLine();

            // Setze den Besitzer für BabyPuss und rufe seine Infos auf
            babyPuss.SetzeBesitzer(fred);
            babyPuss.ZeigeInfo();
            babyPuss.FredRauswerfen();
            Console.WriteLine();

            // Setze die Eltern von BammBamm und rufe seine Infos auf
            bammBamm.SetzeEltern(fred, wilma);
            bammBamm.ZeigeInfo();
            bammBamm.KaputtSchlagen();
            Console.WriteLine();

            // Setze die Eltern von Pebbles und rufe ihre Infos auf
            pebbles.SetzeEltern(fred, wilma);
            pebbles.ZeigeInfo();
            pebbles.Krabbeln();
            Console.WriteLine();

            // Hoppy: Zeige Info und ruft die Methode Rumhoppsen auf
            hoppy.ZeigeInfo();
            hoppy.Rumhoppsen();
            Console.WriteLine();

            // Dino: Zeige Info und ruft die Methode GesichtAblecken auf
            dino.ZeigeInfo();
            dino.GesichtAblecken();
            Console.WriteLine();

            // Wilma: Zeige Info und ruft die Methode Kochen auf
            wilma.ZeigeInfo();
            wilma.Kochen();
            Console.WriteLine();

            // Betty: Zeige Info und ruft die Methode Shoppen auf
            betty.ZeigeInfo();
            betty.Shoppen();
            Console.WriteLine();
        }
    }
}

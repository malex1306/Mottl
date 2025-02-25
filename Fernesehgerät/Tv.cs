namespace Fernesehgerät
{
    public class Tv
    {
        public bool SwitchOn { get; set; }
        public int Volume { get; set; }
        public int CurrentChannel { get; private set; }
        private Dictionary<int, string> Channels { get; set; }

        public Tv(bool switchOn, int volume)
        {
            SwitchOn = switchOn;
            Volume = volume;
            CurrentChannel = 1;
            Channels = new Dictionary<int, string>
            {
                { 1, "ARD" },
                { 2, "ZDF" },
                { 3, "WDR" },
                { 4, "RTL" },
                { 5, "Sat1" },
                { 6, "VOX" },
                { 7, "PRO7" },
                { 8, "RTL2" },
                { 9, "SUPER RTL" },
                { 10, "KABEL 1" },
                
            };
        }

        public void RaiseVolume()
        {
            if (Volume >= 0 && Volume <= 99)
            {
                Volume++;
                Console.WriteLine($" Lautstärke erhöht: {Volume}");
            }
            else
            {
                Console.WriteLine(" Lautstärke ist auf Maximum (100).");
            }
        }

        public void LowerVolume()
        {
            if (Volume <= 0 && Volume >= 99)
            {
                Volume--;
                Console.WriteLine($" Lautstärke gesenkt: {Volume}");
            }
            else
            {
                Console.WriteLine(" Lautstärke ist auf Minimum (0).");
            }
        }

        public void TurnOn()
        {
            SwitchOn = true;
            Console.WriteLine(" Fernseher eingeschaltet!");
            Console.WriteLine($" **Fernseher An** | Letzter Kanal: {Channels[CurrentChannel]} |  Letzte Lautstärke: {Volume}");
        }

        public void TurnOff()
        {
            SwitchOn = false;
            Console.WriteLine(" Fernseher ausgeschaltet!");
        }

        public void ChangeChannel(int number)
        {
            if (Channels.ContainsKey(number))
            {
                CurrentChannel = number;
                Console.WriteLine($" Kanal gewechselt zu: {Channels[number]}");
            }
            else
            {
                Console.WriteLine(" Ungültiger Sender!");
            }
        }

        public void GetInfo()
        {
            if (SwitchOn)
            {
                Console.WriteLine($" **Fernseher AN** | Kanal: {Channels[CurrentChannel]} |  Lautstärke: {Volume}");
            }
            else
            {
                Console.WriteLine($" **Fernseher Aus** | Letzter Kanal: {Channels[CurrentChannel]} |  Letzte Lautstärke: {Volume}");
                Console.Write("Möchten Sie ihn einschalten? (j/n) ");
                string input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "j":
                        TurnOn();
                        break;
                    case "n":
                        Console.WriteLine("Fernsehr bleibt ausgeschlatet");
                        Environment.Exit(0);
                        break;
                    default: Console.WriteLine("Falsche eingabe");
                        break;
                }
            }
        }

        public void Menu()
        {
            while (true)
            {
                Console.Clear();
                GetInfo();

                Console.WriteLine("\nWas möchten Sie tun?");
                Console.WriteLine("[1] Lauter ");
                Console.WriteLine("[2] Leiser ");
                Console.WriteLine("[3] Sender wechseln ");
                Console.WriteLine("[4] Fernseher aus ");
                Console.Write("Eingabe: ");
                
                char input = Console.ReadKey().KeyChar;
                Console.Clear();

                switch (input)
                {
                    case '1':
                        RaiseVolume();
                        break;
                    case '2':
                        LowerVolume();
                        break;
                    case '3':
                        Console.Write("Verfügbare Sender: ");
                        foreach (var channel in Channels)
                        {
                            Console.Write($"[{channel.Key}] {channel.Value}  ");
                        }
                        Console.Write("\nGeben Sie eine Sendernummer ein: ");

                        if (int.TryParse(Console.ReadLine(), out int channelNumber))
                        {
                            ChangeChannel(channelNumber);
                        }
                        else
                        {
                            Console.WriteLine(" Ungültige Eingabe.");
                        }
                        break;
                    case '4':
                        TurnOff();
                        return; 
                    default:
                        Console.WriteLine(" Ungültige Auswahl.");
                        break;
                }
                
                Console.ReadKey();
            }
        }
    }
}

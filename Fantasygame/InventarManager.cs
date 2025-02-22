namespace Fantasygame;

    

    public class InventarManager
    {
        private List<Inventar> items = new List<Inventar>();

        public void AddItemToInventar(string name, string beschreibung)
        {
            Console.WriteLine($"Du hast das Item: '{name}' zu deinem Inventar hinzugefügt.");
            items.Add(new Inventar(name, beschreibung));
        }

        public void ShowInventar()
        {
            Console.WriteLine("\nDein Inventar:");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.ItemName} - {item.ItemType}");
            }
        }
    }

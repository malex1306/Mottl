namespace Warenkorb;

class Program
{
    static void Main(string[] args)
    {
        ShoppingCart cart = new ShoppingCart();
        cart.AddItem(new Books(1, 10.00m, "Autor A", "Buch 1", 2022));
        cart.AddItem(new DVD(2, 15.00m, "Film B", 120, 1));
        cart.PrintReceipt();
    }
}
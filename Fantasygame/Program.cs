namespace Fantasygame;
using Charakter;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Willkommen zu CEl MONSTER HUNTER");
        Charakter meinCharakter = new Charakter();
        meinCharakter.CreateCharakter();
    }
}

namespace Fantasygame;
using Charakter;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Willkommen zu CEl MONSTER HUNTER");
        Console.WriteLine();
        
        
        Charakter meinCharakter = new Charakter();
        meinCharakter.CreateCharakter();
        
        Story meinStory = new Story();
        meinStory.CreateStory();
        
    }
}

namespace Simpsons;

class Program
{
    static void Main(string[] args)
    {
        Homer homer = new Homer();
        homer.Donuts();
        homer.Donuts();
        Marge marge = new Marge();
        marge.Frisoer();
        Bart bart = new Bart();
        bart.Skate();
        bart.Skate();
        Lisa lisa = new Lisa();
        lisa.Saxophon();
        Maggie maggie = new Maggie();
        maggie.Nuckeln();
    }
}
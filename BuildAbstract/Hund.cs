namespace BuildAbstract;

//Subklasse erbt von abstrakter Basisklasse
public class Hund : Tier
{
    //Abstrakte BasisMethode muss überschrieben werden
    public override void MachGeraeusch()
    {
        Console.WriteLine("Der Hund bellt. Wuff, Wuff");
    }
}
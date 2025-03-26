namespace abstInter;

public class Fisch : Lebewesen, ISchwimmer
{
  public override void Bewegen()
  {
    Console.WriteLine("Ich schwimme!");
  }

  public void Schwimmen()
  {
    Console.WriteLine("Schwimmen!");
  }
}
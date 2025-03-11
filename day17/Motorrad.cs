namespace day17;

public class Motorrad : Fahrzeug
{
  public bool Staender {get; set;}

  public Motorrad(string marke, bool staender)
  {
    Staender = staender;
    this.marke = marke;
    anzahlFahrzeuge++;
  }
  
}
namespace day17;

public class Auto : Fahrzeug
{
 public string LenkradFarbe { get; set; }

 public Auto(string lenkradFarbe, string marke)
 {
  LenkradFarbe = lenkradFarbe;
  this.marke = marke;
  anzahlFahrzeuge++;
 }

 // public string Marke
 // {
 //  get => marke;
 // }
}
namespace FahrtenbuchOrga;

public class Fahrt
{
  public DateTime Datum { get; set; }
  public double Kilometer { get; set; }
  public bool Express { get; set; }
  public Fahrzeug Fahrzeug { get; set; }

  public Fahrt(DateTime datum, double kilometer, bool express, Fahrzeug fahrzeug)
  {
    Datum = datum;
    Kilometer = kilometer;
    Express = express;
    Fahrzeug = fahrzeug;
  }

  public double BerechnePreis()
  {
    double preis = Kilometer * Fahrzeug.KostenProKm;
    if (Express) preis += Kilometer * 3;
    return preis;
  }
}
namespace Simpsons;

public class Maggie : Characteristics
{
   private int nuckelnCounter;
   public Maggie() : base("Maggie", "Simpson", "Gelb", "Evergreen Terrace 742, Springfield")
   {
      Console.WriteLine($"Vorname: {Vorname}, Nachname: {Nachname}, Hautfarbe: {Hautfarbe}, Wohnort: {Wohnort}");
   }

   public void Nuckeln()
   {
      nuckelnCounter++;
      Console.WriteLine($"Maggie hat {nuckelnCounter} mal am Schnuler genuckelt!");
   }
}
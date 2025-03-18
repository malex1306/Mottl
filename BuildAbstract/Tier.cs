namespace BuildAbstract;

//Klasse als abstract kennzeichnen
public abstract class Tier
{
   public void schlafen()
   {
      //normale Methode gilt für jedes Tier gleich
      Console.WriteLine("Das Tier schläft...*schnarch*");
   }
   
   // Abstrakte Methode ( nur Methodensignatur -- ohne Methodenkörper)
   public abstract void MachGeraeusch();
}
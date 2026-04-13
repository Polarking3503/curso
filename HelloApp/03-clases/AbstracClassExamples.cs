partial class Program
{
  static void AbstracClassExamples()
  {
    HomeAppliance myWasher = new WashingMachine { Brand = "LG" };
    HomeAppliance myMicrowave = new Microwave { Brand = "Breville" };
    myWasher.ShowBrand();
    myWasher.TurnOn();
    myMicrowave.ShowBrand();
    myMicrowave.TurnOn();
  }
}
abstract class HomeAppliance
{
  public string? Brand { get; set; }

  public abstract void TurnOn();

  public void ShowBrand()
  {
    WriteLine($"La marca del electrodoméstico: {Brand}");
  }
}
class WashingMachine : HomeAppliance
{
  public override void TurnOn()
  {
    WriteLine("🌀 La lavadora a inicializado el ciclo de lavado");
  }
}

class Microwave : HomeAppliance
{
  public override void TurnOn()
  {
    WriteLine("🔥 El microondas esta calentando la comida.");
  }
}
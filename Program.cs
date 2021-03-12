using System;

namespace GarysGarage
{
  class Program
  {
    static void Main(string[] args)
    {
      Zero fxs = new Zero()
      {
        MainColor = "Black",
        MaximumOccupancy = "2",
        BatteryKWh = 15,
      };
      Tesla modelS = new Tesla()
      {
        MainColor = "White",
        MaximumOccupancy = "4",
        BatteryKWh = 60,
      };
      Cessna mx410 = new Cessna()
      {
        MainColor = "Yellow",
        MaximumOccupancy = "4",
        FuelCapacity = 55,
      };
      Ram Classic = new Ram()
      {
        MainColor = "Space Gray",
        MaximumOccupancy = "8",
        FuelCapacity = 26,
      };

      fxs.Drive();
      fxs.Turn("right");
      fxs.Stop();
      Console.WriteLine("");

      modelS.Drive();
      modelS.Turn("right");
      modelS.Stop();
      Console.WriteLine("");

      mx410.Drive();
      mx410.Turn("left");
      mx410.Stop();
      Console.WriteLine("");

      Classic.Drive();
      Classic.Turn("left");
      Classic.Stop();
      Console.WriteLine("");
    }
  }
}

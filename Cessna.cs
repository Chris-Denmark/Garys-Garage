using System;

namespace GaryGarage
{
  public class Cessna : Vehicle, IGasVehicles // Propellor light aircraft
  {
    public double FuelCapacity { get; set; }
    public double CurrentTankPercentage { get; set; }

    public void RefuelTank()
    {
      CurrentTankPercentage = 100;
    }

    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} Cessna flies past. Zoooooom!");
    }

    public override void Turn(string direction)
    {
      Console.WriteLine($"The plane quickly swerves {direction}.");
    }

    public override void Stop()
    {
      Console.WriteLine($"The {this.MainColor} plane quickly squeals to a stop!");
    }
  }
}
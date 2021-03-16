using System;

namespace GaryGarage
{
  public class Ram : Vehicle, IGasVehicles // Gas powered truck
  {
    public double FuelCapacity { get; set; }
    public double CurrentTankPercentage { get; set; }

    public void RefuelTank()
    {
      CurrentTankPercentage = 100;
    }

    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} Ram drives past. Rrrrrrruuummmmmbbblleeeee!");
    }

    public override void Turn(string direction)
    {
      Console.WriteLine($"The truck quickly swerves {direction}.");
    }

    public override void Stop()
    {
      Console.WriteLine($"The {this.MainColor} Ram quickly squeals to a stop!");
    }
  }
}
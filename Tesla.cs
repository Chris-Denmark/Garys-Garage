using System;

namespace GaryGarage
{
  public class Tesla : Vehicle, IElectricVehicles
  {
    public double BatteryKWh { get; set; }
    public double CurrentChargePercentage { get; set; }

    public void ChargeBattery()
    {
      CurrentChargePercentage = 100;
    }

    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} Tesla drives past. Fwoooosh!");
    }

    public override void Turn(string direction)
    {
      Console.WriteLine($"The car quickly swerves {direction}.");
    }

    public override void Stop()
    {
      Console.WriteLine($"The {this.MainColor} Tesla quickly squeals to a stop!");
    }
  }
}
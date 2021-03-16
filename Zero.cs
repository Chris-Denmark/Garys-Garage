using System;

namespace GaryGarage
{
  public class Zero : Vehicle, IElectricVehicles // Electric motorcycle
  {
    public double BatteryKWh { get; set; }
    public double CurrentChargePercentage { get; set; }

    public void ChargeBattery()
    {
      CurrentChargePercentage = 100;
    }

    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} Zero zips past. Whooooosh!");
    }

    public override void Turn(string direction)
    {
      Console.WriteLine($"The bike quickly swerves {direction}.");
    }

    public override void Stop()
    {
      Console.WriteLine($"The {this.MainColor} bike quickly squeals to a stop!");
    }
  }
}
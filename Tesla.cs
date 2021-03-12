using System;
public class Tesla : Vehicle
{
  public double BatteryKWh { get; set; }

  public void ChargeBattery()
  {
    // method definition omitted
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
using System;
public class Zero : Vehicle // Electric motorcycle
{
  public double BatteryKWh { get; set; }

  public void ChargeBattery()
  {
    // method definition omitted
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
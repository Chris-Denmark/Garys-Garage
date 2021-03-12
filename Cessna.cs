using System;
public class Cessna : Vehicle // Propellor light aircraft
{
  public double FuelCapacity { get; set; }

  public void RefuelTank()
  {
    // method definition omitted
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
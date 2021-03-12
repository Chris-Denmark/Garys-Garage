using System;
public class Ram : Vehicle // Gas powered truck
{
  public double FuelCapacity { get; set; }

  public void RefuelTank()
  {
    // method definition omitted
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
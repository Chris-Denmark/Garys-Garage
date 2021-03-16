namespace GaryGarage
{
  public interface IElectricVehicles
  {
    double BatteryKWh { get; set; }
    double CurrentChargePercentage { get; set; }
    void ChargeBattery();
  }
}
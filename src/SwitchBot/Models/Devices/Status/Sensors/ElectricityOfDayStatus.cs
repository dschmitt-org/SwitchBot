namespace SwitchBot.Models;

public class ElectricityOfDayStatus : BaseDeviceStatus, IElectricityOfDayStatus
{
    public int ElectricityOfDay { get; init; }
}
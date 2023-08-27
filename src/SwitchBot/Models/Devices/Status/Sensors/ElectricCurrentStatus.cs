namespace SwitchBot.Models;

public class ElectricCurrentStatus : BaseDeviceStatus, IElectricCurrentStatus
{
    public float ElectricCurrent { get; init; }
}
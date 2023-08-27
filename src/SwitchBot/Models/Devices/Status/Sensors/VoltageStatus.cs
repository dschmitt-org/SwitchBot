namespace SwitchBot.Models;

public class VoltageStatus : BaseDeviceStatus, IVoltageStatus
{
    public float Voltage { get; init; }
}
namespace SwitchBot.Models;

public class BatteryStatus : BaseDeviceStatus, IBatteryStatus
{
    public byte Battery { get; init; }
}
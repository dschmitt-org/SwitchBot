namespace SwitchBot.Models;

public class TemperatureStatus : BaseDeviceStatus, ITemperatureStatus
{
    public float Temperature { get; init; }
}
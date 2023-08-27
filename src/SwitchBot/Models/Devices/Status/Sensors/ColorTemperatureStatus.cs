namespace SwitchBot.Models;

public class ColorTemperatureStatus : BaseDeviceStatus, IColorTemperatureStatus
{
    public int ColorTemperature { get; init; }
}
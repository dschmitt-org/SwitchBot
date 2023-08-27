namespace SwitchBot.Models;

public class TemperatureHumidityBatteryStatus : BaseDeviceStatus, ITemperatureStatus, IHumidityStatus, IBatteryStatus
{
    public float Temperature { get; init; }

    public byte Humidity { get; init; }

    public byte Battery { get; init; }
}
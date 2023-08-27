namespace SwitchBot.Models;

public class TemperatureHumidityStatus : BaseDeviceStatus, ITemperatureStatus, IHumidityStatus
{
    public float Temperature { get; init; }

    public byte Humidity { get; init; }
}
namespace SwitchBot.Models;

public class HumidityStatus : BaseDeviceStatus, IHumidityStatus
{
    public byte Humidity { get; init; }
}
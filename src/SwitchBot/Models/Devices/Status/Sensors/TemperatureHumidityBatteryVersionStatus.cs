namespace SwitchBot.Models;

public class TemperatureHumidityBatteryVersionStatus : TemperatureHumidityBatteryStatus, IVersionStatus
{
    public string Version { get; init; }
}
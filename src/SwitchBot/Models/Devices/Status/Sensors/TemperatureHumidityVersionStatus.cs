namespace SwitchBot.Models;

public class TemperatureHumidityVersionStatus : TemperatureHumidityStatus, IVersionStatus
{
    public string Version { get; init; }
}
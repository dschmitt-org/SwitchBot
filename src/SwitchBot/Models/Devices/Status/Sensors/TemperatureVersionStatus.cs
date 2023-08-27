namespace SwitchBot.Models;

public class TemperatureVersionStatus : TemperatureStatus, IVersionStatus
{
    public string Version { get; init; }
}
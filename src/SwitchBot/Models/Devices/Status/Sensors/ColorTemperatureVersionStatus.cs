namespace SwitchBot.Models;

public class ColorTemperatureVersionStatus : ColorTemperatureStatus, IVersionStatus
{
    public string Version { get; init; }
}
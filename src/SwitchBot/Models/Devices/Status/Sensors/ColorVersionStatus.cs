namespace SwitchBot.Models;

public class ColorVersionStatus : BaseDeviceStatus, IColorStatus, IVersionStatus
{
    public string Color { get; init; }
    public string Version { get; init; }
}
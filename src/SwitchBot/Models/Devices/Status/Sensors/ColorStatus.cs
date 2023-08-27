namespace SwitchBot.Models;

public class ColorStatus : BaseDeviceStatus, IColorStatus
{
    public string Color { get; init; }
}
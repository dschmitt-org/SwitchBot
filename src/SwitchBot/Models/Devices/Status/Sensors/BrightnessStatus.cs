namespace SwitchBot.Models;

public class BrightnessStatus : BaseDeviceStatus, IBrightnessStatus
{
    public byte Brightness { get; init; }
}
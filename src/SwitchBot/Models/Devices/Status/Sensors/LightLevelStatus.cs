namespace SwitchBot.Models;

public class LightLevelStatus : BaseDeviceStatus, ILightLevelStatus
{
    public int LightLevel { get; init; }
}
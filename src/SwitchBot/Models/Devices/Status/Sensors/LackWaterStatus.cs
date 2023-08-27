namespace SwitchBot.Models;

public class LackWaterStatus : BaseDeviceStatus, ILackWaterStatus
{
    public bool LackWater { get; init; }
}
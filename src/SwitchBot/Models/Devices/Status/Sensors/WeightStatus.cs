namespace SwitchBot.Models;

public class WeightStatus : BaseDeviceStatus, IWeightStatus
{
    public float Weight { get; init; }
}
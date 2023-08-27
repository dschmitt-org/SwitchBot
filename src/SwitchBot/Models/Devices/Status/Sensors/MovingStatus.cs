namespace SwitchBot.Models;

public class MovingStatus : BaseDeviceStatus, IMovingStatus
{
    public bool Moving { get; init; }
}
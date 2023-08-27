namespace SwitchBot.Models;

public class DirectionStatus : BaseDeviceStatus, IDirectionStatus
{
    public string Direction { get; init; }
}
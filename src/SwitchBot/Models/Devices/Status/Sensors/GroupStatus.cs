namespace SwitchBot.Models;

public class GroupStatus : BaseDeviceStatus, IGroupStatus
{
    public bool Group { get; init; }
}
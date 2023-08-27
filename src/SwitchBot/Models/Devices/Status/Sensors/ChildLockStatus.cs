namespace SwitchBot.Models;

public class ChildLockStatus : BaseDeviceStatus, IChildLockStatus
{
    public bool ChildLock { get; init; }
}
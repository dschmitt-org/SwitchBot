namespace SwitchBot.Models;

public class LockStateStatus : BaseDeviceStatus, ILockStateStatus
{
    public string LockState { get; init; }
}
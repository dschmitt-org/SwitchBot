namespace SwitchBot.Models;

public class LockStateVersionStatus : LockStateStatus, IVersionStatus
{
    public string Version { get; init; }
}
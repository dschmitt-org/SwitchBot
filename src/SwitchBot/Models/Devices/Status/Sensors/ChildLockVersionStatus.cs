namespace SwitchBot.Models;

public class ChildLockVersionStatus : ChildLockStatus, IVersionStatus
{
    public string Version { get; init; }
}
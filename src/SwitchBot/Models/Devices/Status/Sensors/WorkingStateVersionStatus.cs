namespace SwitchBot.Models;

public class WorkingStateVersionStatus : WorkingStateStatus, IVersionStatus
{
    public string Version { get; init; }
}
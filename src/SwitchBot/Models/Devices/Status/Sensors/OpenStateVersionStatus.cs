namespace SwitchBot.Models;

public class OpenStateVersionStatus : OpenStateStatus, IVersionStatus
{
    public string Version { get; init; }
}
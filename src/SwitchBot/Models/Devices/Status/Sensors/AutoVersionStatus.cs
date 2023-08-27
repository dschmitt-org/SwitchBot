namespace SwitchBot.Models;

public class AutoVersionStatus : AutoStatus, IVersionStatus
{
    public string Version { get; init; }
}
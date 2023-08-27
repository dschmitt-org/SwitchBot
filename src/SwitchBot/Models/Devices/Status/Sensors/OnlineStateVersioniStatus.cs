namespace SwitchBot.Models;

public class OnlineStateVersioniStatus : OnlineStateStatus, IVersionStatus
{
    public string Version { get; init; }
}
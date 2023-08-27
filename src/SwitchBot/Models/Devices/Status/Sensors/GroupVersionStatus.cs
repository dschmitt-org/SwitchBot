namespace SwitchBot.Models;

public class GroupVersionStatus : GroupStatus, IVersionStatus
{
    public string Version { get; init; }
}
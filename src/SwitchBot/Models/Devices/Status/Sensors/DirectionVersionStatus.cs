namespace SwitchBot.Models;

public class DirectionVersionStatus : DirectionStatus, IVersionStatus
{
    public string Version { get; init; }
}
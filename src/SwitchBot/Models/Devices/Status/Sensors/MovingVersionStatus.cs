namespace SwitchBot.Models;

public class MovingVersionStatus : MovingStatus, IVersionStatus
{
    public string Version { get; init; }
}
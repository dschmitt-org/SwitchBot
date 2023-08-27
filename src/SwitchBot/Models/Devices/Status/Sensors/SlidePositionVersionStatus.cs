namespace SwitchBot.Models;

public class SlidePositionVersionStatus : SlidePositionStatus, IVersionStatus
{
    public string Version { get; init; }
}
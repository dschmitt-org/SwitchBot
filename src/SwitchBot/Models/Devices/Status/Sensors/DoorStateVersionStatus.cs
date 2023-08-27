namespace SwitchBot.Models;

public class DoorStateVersionStatus : DoorStateStatus, IVersionStatus
{
    public string Version { get; init; }
}
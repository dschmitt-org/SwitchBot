namespace SwitchBot.Models;

public class MoveDetectedVersionStatus : MoveDetectedStatus, IVersionStatus
{
    public string Version { get; init; }
}
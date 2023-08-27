namespace SwitchBot.Models;

public class VoltageVersionStatus : VoltageStatus, IVersionStatus
{
    public string Version { get; init; }
}
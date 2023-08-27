namespace SwitchBot.Models;

public class ElectricCurrentVersionStatus : ElectricCurrentStatus, IVersionStatus
{
    public string Version { get; init; }
}
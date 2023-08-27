namespace SwitchBot.Models;

public class BatteryVersionStatus : BatteryStatus, IVersionStatus
{
    public string Version { get; init; }
}
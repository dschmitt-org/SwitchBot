namespace SwitchBot.Models;

public class DeviceModeVersionStatus : DeviceModeStatus, IVersionStatus
{
    public string Version { get; init; }
}
namespace SwitchBot.Models;

public class CalibrateVersionStatus : CalibrateStatus, IVersionStatus
{
    public string Version { get; init; }
}
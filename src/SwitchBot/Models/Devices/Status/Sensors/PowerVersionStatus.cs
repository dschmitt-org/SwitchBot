namespace SwitchBot.Models;

public class PowerVersionStatus : PowerStatus, IVersionStatus
{
    public string Version { get; init; }
}
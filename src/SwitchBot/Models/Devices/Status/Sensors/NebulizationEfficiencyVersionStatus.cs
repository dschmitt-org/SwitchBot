namespace SwitchBot.Models;

public class NebulizationEfficiencyVersionStatus : NebulizationEfficiencyStatus, IVersionStatus
{
    public string Version { get; init; }

}
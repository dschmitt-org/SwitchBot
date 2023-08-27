namespace SwitchBot.Models;

public class NebulizationEfficiencyStatus : BaseDeviceStatus, INebulizationEfficiencyStatus
{
    public int NebulizationEfficiency { get; init; }
}
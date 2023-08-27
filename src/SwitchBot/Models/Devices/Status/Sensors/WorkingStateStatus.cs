namespace SwitchBot.Models;

public class WorkingStateStatus : BaseDeviceStatus, IWorkingStateStatus
{
    public WorkingState WorkingState { get; init; }
}
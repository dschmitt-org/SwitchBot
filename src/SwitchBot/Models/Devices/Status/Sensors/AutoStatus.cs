namespace SwitchBot.Models;

public class AutoStatus : BaseDeviceStatus, IAutoStatus
{
    public bool Auto { get; init; }
}
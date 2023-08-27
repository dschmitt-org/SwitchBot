namespace SwitchBot.Models;

public class DoorStateStatus : BaseDeviceStatus, IDoorStateStatus
{
    public string DoorState { get; init; }
}
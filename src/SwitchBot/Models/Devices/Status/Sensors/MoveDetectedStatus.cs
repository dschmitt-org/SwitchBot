namespace SwitchBot.Models;

public class MoveDetectedStatus : BaseDeviceStatus, IMoveDetectedStatus
{
    public bool MoveDetected { get; init; }
}
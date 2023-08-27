namespace SwitchBot.Models;

public class CalibrateStatus : BaseDeviceStatus, ICalibrateStatus
{
    public bool Calibrate { get; init; }
}
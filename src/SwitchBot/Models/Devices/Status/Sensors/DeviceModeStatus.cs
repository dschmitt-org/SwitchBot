namespace SwitchBot.Models;

public class DeviceModeStatus : BaseDeviceStatus, IDeviceModeStatus
{
    public DeviceMode DeviceMode { get; init; }
}
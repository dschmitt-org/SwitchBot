namespace SwitchBot.Models;

public class PowerStatus : BaseDeviceStatus, IPowerStatus
{
    public PowerState Power { get; init; }
}
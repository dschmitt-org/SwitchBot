namespace SwitchBot.Models;

public class OpenStateStatus : BaseDeviceStatus, IOpenStateStatus
{
    public OpenState OpenState { get; init; }
}
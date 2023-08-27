namespace SwitchBot.Models;

public class OnlineStateStatus : BaseDeviceStatus, IOnlineStateStatus
{
    public OnlineState OnlineState { get; init; }
}
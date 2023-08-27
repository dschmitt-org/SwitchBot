namespace SwitchBot.Models;

public class SlidePositionStatus : BaseDeviceStatus, ISlidePositionStatus
{
    public byte SlidePosition { get; init; }
}
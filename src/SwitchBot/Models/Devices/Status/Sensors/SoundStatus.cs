namespace SwitchBot.Models;

public class SoundStatus : BaseDeviceStatus, ISoundStatus
{
    public bool Sound { get; init; }
}
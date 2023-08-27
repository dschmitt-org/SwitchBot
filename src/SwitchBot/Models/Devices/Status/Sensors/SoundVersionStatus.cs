namespace SwitchBot.Models;

public class SoundVersionStatus : SoundStatus, IVersionStatus
{
    public string Version { get; init; }
}
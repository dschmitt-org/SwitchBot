namespace SwitchBot.Models;

public class BrightnessVersionStatus : BrightnessStatus, IVersionStatus
{
    public string Version { get; init; }
}
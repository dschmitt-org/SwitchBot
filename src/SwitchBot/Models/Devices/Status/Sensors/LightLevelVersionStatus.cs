namespace SwitchBot.Models;

public class LightLevelVersionStatus : LightLevelStatus, IVersionStatus
{
    public string Version { get; init; }
}
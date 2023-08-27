namespace SwitchBot.Models;

public class HumidityVersionStatus : HumidityStatus, IVersionStatus
{
    public string Version { get; init; }
}
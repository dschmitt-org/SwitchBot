namespace SwitchBot.Models;

public class LackWaterVersionStatus : LackWaterStatus, IVersionStatus
{
    public string Version { get; init; }
}
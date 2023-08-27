namespace SwitchBot.Models;

public class WeightVersionStatus : WeightStatus, IVersionStatus
{
    public string Version { get; init; }
}
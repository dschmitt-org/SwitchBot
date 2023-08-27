namespace SwitchBot.Models;

public class ElectricityOfDayVersionStatus : ElectricityOfDayStatus, IVersionStatus
{
    public string Version { get; init; }
}
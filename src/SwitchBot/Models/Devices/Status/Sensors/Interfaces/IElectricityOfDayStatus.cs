using Newtonsoft.Json;

namespace SwitchBot.Models;

internal interface IElectricityOfDayStatus
{
    /// <summary>
    /// The duration that the device has been used during a day, measured in minutes. 
    /// </summary>
    [JsonProperty("electricityOfDay")]
    public int ElectricityOfDay { get; init; }
}
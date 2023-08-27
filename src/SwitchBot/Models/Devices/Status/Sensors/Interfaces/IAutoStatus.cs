using Newtonsoft.Json;

namespace SwitchBot.Models;

internal interface IAutoStatus
{
    /// <summary>
    /// Determines if a Humidifier is in Auto Mode or not.
    /// </summary> 
    [JsonProperty("auto")]
    public bool Auto { get; init; }
}
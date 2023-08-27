using Newtonsoft.Json;

namespace SwitchBot.Models;

internal interface IColorTemperatureStatus
{
    /// <summary>
    /// The color temperature value, range from 2700 to 6500. 
    /// </summary>
    [JsonProperty("colorTemperature")]
    public int ColorTemperature { get; init; }
}
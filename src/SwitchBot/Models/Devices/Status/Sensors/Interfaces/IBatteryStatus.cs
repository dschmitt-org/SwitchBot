using Newtonsoft.Json;

namespace SwitchBot.Models;

internal interface IBatteryStatus
{
    /// <summary>
    /// The current battery level. 
    /// </summary>
    /// <value></value>
    [JsonProperty("battery")]
    public byte Battery { get; init; }
}
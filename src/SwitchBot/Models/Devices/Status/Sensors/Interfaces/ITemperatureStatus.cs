using Newtonsoft.Json;

namespace SwitchBot.Models;

internal interface ITemperatureStatus
{
    /// <summary>
    /// Temperature in celsius. 
    /// </summary>
    [JsonProperty("temperature")]
    public float Temperature { get; init; }
}
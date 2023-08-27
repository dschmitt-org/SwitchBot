using Newtonsoft.Json;

namespace SwitchBot.Models;

internal interface IHumidityStatus
{
    /// <summary>
    /// Humidity percentage.
    /// </summary>
    [JsonProperty("humidity")]
    public byte Humidity { get; init; }
}
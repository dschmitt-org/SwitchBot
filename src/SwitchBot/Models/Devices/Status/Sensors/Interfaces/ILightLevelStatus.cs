using Newtonsoft.Json;

namespace SwitchBot.Models;

internal interface ILightLevelStatus
{
    /// <summary>
    /// The level of illuminance of the ambience light, 1~20.
    /// </summary>
    [JsonProperty("lightLevel")]
    public int LightLevel { get; init; }
}
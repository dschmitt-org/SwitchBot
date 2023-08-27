using Newtonsoft.Json;

namespace SwitchBot.Models;

internal interface IWeightStatus
{
    /// <summary>
    /// The power consumed in a day, measured in Watts. 
    /// </summary>
    [JsonProperty("weight")]
    public float Weight { get; init; }
}
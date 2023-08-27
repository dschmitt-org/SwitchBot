using Newtonsoft.Json;

namespace SwitchBot.Models;

internal interface ILackWaterStatus
{
    /// <summary>
    /// Determines if the water tank is empty or not.
    /// </summary>
    [JsonProperty("lackWater")]
    public bool LackWater { get; init; }
}
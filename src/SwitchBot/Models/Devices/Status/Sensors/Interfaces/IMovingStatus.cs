using Newtonsoft.Json;

namespace SwitchBot.Models;

internal interface IMovingStatus
{
    /// <summary>
    /// Determines if the device is moving or not.
    /// </summary>
    [JsonProperty("moving")]
    public bool Moving { get; init; }
}
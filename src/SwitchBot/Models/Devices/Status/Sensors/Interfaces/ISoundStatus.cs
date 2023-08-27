using Newtonsoft.Json;

namespace SwitchBot.Models;

internal interface ISoundStatus
{
    /// <summary>
    /// Determines if the device is muted or not.
    /// </summary> 
    [JsonProperty("sound")]
    public bool Sound { get; init; }
}
using Newtonsoft.Json;

namespace SwitchBot.Models;

internal interface IGroupStatus
{
    /// <summary>
    /// Determines if a device is paired with or grouped with one or more devices of the same type or not.
    /// </summary>
    [JsonProperty("group")]
    public bool Group { get; init; }
}
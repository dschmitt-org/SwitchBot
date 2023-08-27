using Newtonsoft.Json;

namespace SwitchBot.Models;

internal interface IDoorStateStatus
{
    /// <summary>
    /// Determines if the door is closed or not.
    /// </summary> 
    [JsonProperty("doorState")]
    public string DoorState { get; init; }
}
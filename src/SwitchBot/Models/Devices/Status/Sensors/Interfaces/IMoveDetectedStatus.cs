using Newtonsoft.Json;
using SwitchBot.JsonConverters;

namespace SwitchBot.Models;

internal interface IMoveDetectedStatus
{
    /// <summary>
    /// Determines if motion is detected.
    /// </summary>
    [JsonProperty("moveDetected")]
    public bool MoveDetected { get; init; }
}
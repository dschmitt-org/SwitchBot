using Newtonsoft.Json;

namespace SwitchBot.Models;

internal interface ICalibrateStatus
{
    /// <summary>
    /// Determines if the open and the closed positions have been properly calibrated or not.
    /// </summary>
    [JsonProperty("calibrate")]
    public bool Calibrate { get; init; }
}
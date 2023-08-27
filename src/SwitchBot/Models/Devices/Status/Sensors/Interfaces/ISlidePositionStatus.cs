using Newtonsoft.Json;

namespace SwitchBot.Models;

internal interface ISlidePositionStatus
{
    /// <summary>
    /// The current position, 0-100.
    /// </summary>
    [JsonProperty("slidePosition")]
    public byte SlidePosition { get; init; }
}
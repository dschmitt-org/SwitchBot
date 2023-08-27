using Newtonsoft.Json;
using SwitchBot.JsonConverters;

namespace SwitchBot.Models;

internal interface IDirectionStatus
{
    /// <summary>
    ///  The opening direction of a device.
    /// </summary> 
    [JsonProperty("direction")]
    public string Direction { get; init; }
}
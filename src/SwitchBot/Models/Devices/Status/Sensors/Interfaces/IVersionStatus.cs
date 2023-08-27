using Newtonsoft.Json;

namespace SwitchBot.Models;

internal interface IVersionStatus
{
    /// <summary>
    ///  The current firmware version, e.g. V4.2. 
    /// </summary>
    [JsonProperty("version")]
    public string Version { get; init; }
}
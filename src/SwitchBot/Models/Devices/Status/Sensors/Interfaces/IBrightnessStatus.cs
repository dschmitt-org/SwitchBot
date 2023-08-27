using Newtonsoft.Json;
using SwitchBot.JsonConverters;

namespace SwitchBot.Models;

internal interface IBrightnessStatus
{
    /// <summary>
    /// The brightness value, range from 1 to 100. 
    /// </summary>
    /// <value></value>
    [JsonProperty("brightness")]
    public byte Brightness { get; init; }
}
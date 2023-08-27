using Newtonsoft.Json;

namespace SwitchBot.Models;

internal interface IColorStatus
{
    /// <summary>
    /// The color value, RGB "255:255:255". 
    /// </summary>
    [JsonProperty("color")]
    public string Color { get; init; }
}
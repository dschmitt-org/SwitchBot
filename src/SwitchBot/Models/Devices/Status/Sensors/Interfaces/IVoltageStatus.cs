using Newtonsoft.Json;

namespace SwitchBot.Models;

internal interface IVoltageStatus
{
    /// <summary>
    /// The voltage of the device, measured in Volt. 
    /// </summary>
    [JsonProperty("voltage")]
    public float Voltage { get; init; }
}
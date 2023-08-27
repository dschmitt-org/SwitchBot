using Newtonsoft.Json;
using SwitchBot.JsonConverters;

namespace SwitchBot.Models;

internal interface IPowerStatus
{
    /// <summary>
    /// ON/OFF state. 
    /// </summary>
    [JsonProperty("power")]
    [JsonConverter(typeof(EnumDescriptionJsonConverter<PowerState>))]
    public PowerState Power { get; init; }
}
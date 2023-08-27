using Newtonsoft.Json;
using SwitchBot.JsonConverters;

namespace SwitchBot.Models;

internal interface IBrightnessStateStatus
{
    /// <summary>
    /// The ambient brightness picked up by the sensor. bright or dim.
    /// </summary>
    [JsonProperty("brightness")]
    [JsonConverter(typeof(EnumDescriptionJsonConverter<BrightnessState>))]
    public BrightnessState Brightness { get; init; }
}
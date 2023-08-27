using Newtonsoft.Json;
using SwitchBot.JsonConverters;

namespace SwitchBot.Models;

internal interface IDeviceModeStatus
{
    /// <summary>
    /// PressMode, SwitchMode, or CustomizeMode.
    /// </summary> 
    [JsonProperty("deviceMode")]
    [JsonConverter(typeof(EnumDescriptionJsonConverter<DeviceMode>))]
    public DeviceMode DeviceMode { get; init; }
}
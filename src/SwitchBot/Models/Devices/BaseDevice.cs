using Newtonsoft.Json;
using SwitchBot.JsonConverters;

namespace SwitchBot.Models;

public class BaseDevice
{
    [JsonProperty("deviceId")]
    public string Id { get; init; }

    [JsonProperty("deviceType")]
    [JsonConverter(typeof(EnumDescriptionJsonConverter<DeviceType>))]
    public DeviceType Type { get; init; }

    [JsonProperty("hubDeviceId")]
    public string HubDeviceId { get; init; }
}
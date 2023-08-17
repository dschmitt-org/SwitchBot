using Newtonsoft.Json;

namespace SwitchBot.Models;

public class BaseDevice
{
    [JsonProperty("deviceId")]
    public string Id { get; init; }

    [JsonProperty("deviceName")]
    public string Name { get; init; }

    [JsonProperty("deviceType")]
    public string Type { get; init; }

    [JsonProperty("enableCloudService")]
    public bool IsCloudServiceEnabled { get; init; }

    [JsonProperty("hubDeviceId")]
    public string HubDeviceId { get; init; }
}
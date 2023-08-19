using Newtonsoft.Json;

namespace SwitchBot.Models;

public class Device : BaseDevice
{
    [JsonProperty("deviceName")]
    public string Name { get; init; }

    [JsonProperty("enableCloudService")]
    public bool IsCloudServiceEnabled { get; init; }
}
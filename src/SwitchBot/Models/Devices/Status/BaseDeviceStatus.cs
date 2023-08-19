using Newtonsoft.Json;

namespace SwitchBot.Models;

public class BaseDeviceStatus : BaseDevice
{
    [JsonProperty("version")]
    public string Version { get; init; }

    [JsonProperty("battery")]
    public byte Battery { get; init; }
}
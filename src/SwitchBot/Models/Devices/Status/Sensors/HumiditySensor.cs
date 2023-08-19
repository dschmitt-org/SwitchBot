using Newtonsoft.Json;

namespace SwitchBot.Models;

public class HumiditySensor : BaseDeviceStatus
{
    [JsonProperty("humidity")]
    public byte Humidity { get; init; }
}
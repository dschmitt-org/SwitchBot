using Newtonsoft.Json;

namespace SwitchBot.Models;

public class TemperatureAndHumiditySensor : BaseDeviceStatus
{
    [JsonProperty("temperature")]
    public float Temperature { get; init; }

    [JsonProperty("humidity")]
    public byte Humidity { get; init; }
}
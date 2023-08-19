using Newtonsoft.Json;

namespace SwitchBot.Models;

public class TemperatureSensor : BaseDeviceStatus
{
    [JsonProperty("temperature")]
    public float Temperature { get; init; }
}
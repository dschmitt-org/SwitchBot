using Newtonsoft.Json;
using SwitchBot.JsonConverters;

namespace SwitchBot.Models;

[JsonConverter(typeof(JsonPathConverter))]
public class DevicesResponse
{
    [JsonProperty("statusCode")]
    public int StatusCode { get; init; }

    [JsonProperty("message")]
    public string Message { get; init; }

    [JsonProperty("body.deviceList")]
    public List<BaseDevice> Devices { get; init; } = new List<BaseDevice>();
}
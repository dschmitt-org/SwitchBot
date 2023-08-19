using Newtonsoft.Json;
using SwitchBot.JsonConverters;

namespace SwitchBot.Models;

[JsonConverter(typeof(JsonPathConverter))]
public class DevicesResponse : BaseResponse
{
    [JsonProperty("body.deviceList")]
    public List<Device> Devices { get; init; } = new List<Device>();
}
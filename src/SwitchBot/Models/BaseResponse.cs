using Newtonsoft.Json;
using SwitchBot.JsonConverters;

namespace SwitchBot.Models;

public class BaseResponse
{
    [JsonProperty("statusCode")]
    public int StatusCode { get; init; }

    [JsonProperty("message")]
    public string Message { get; init; }
}
using Newtonsoft.Json;

namespace SwitchBot.Models;

public class DeviceStatusResponse<T> : BaseResponse
    where T : BaseDeviceStatus
{
    [JsonProperty("body")]
    public T DeviceStatus { get; init; }
}
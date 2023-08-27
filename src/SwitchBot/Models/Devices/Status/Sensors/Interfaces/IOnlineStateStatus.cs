using Newtonsoft.Json;
using SwitchBot.JsonConverters;

namespace SwitchBot.Models;

internal interface IOnlineStateStatus
{
    /// <summary>
    /// Attributes of the context object. the connection status of the device. online or offline. 
    /// </summary>
    [JsonProperty("onlineStatus")]
    [JsonConverter(typeof(EnumDescriptionJsonConverter<OnlineState>))]
    public OnlineState OnlineState { get; init; }
}
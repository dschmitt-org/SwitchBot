using Newtonsoft.Json;
using SwitchBot.JsonConverters;

namespace SwitchBot.Models;

internal interface IOpenStateStatus
{
    /// <summary>
    /// The open state of the Sensor. open, close, or timeOutNotClose. 
    /// </summary>
    /// <value></value>
    [JsonProperty("openState")]
    [JsonConverter(typeof(EnumDescriptionJsonConverter<OpenState>))]
    public OpenState OpenState { get; init; }
}
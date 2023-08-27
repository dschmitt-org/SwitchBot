using Newtonsoft.Json;
using SwitchBot.JsonConverters;
using SwitchBot.Resolvers;

namespace SwitchBot.Models;

public class BaseDevice
{
    private DeviceType type;

    /// <summary>
    /// Device ID.
    /// </summary> 
    [JsonProperty("deviceId")]
    public string Id { get; init; }

    /// <summary>
    /// Device type.
    /// </summary>
    [JsonProperty("deviceType")]
    [JsonConverter(typeof(EnumDescriptionJsonConverter<DeviceType>))]
    public DeviceType Type
    {
        get { return this.type; }
        set
        {
            this.type = value;
            this.StatusTypes = StatusTypeResolver.Resolve(value);
        }
    }

    /// <summary>
    /// List that determines the types of status.
    /// </summary>
    public List<StatusType> StatusTypes { get; private set; }

    /// <summary>
    /// Device's parent Hub ID.
    /// </summary>
    [JsonProperty("hubDeviceId")]
    public string HubDeviceId { get; init; }
}
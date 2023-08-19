using Newtonsoft.Json;
using SwitchBot.JsonConverters;
using SwitchBot.Resolvers;

namespace SwitchBot.Models;

public class BaseDevice
{
    private DeviceType type;

    [JsonProperty("deviceId")]
    public string Id { get; init; }

    [JsonProperty("deviceType")]
    [JsonConverter(typeof(EnumDescriptionJsonConverter<DeviceType>))]
    public DeviceType Type
    {
        get { return this.type; }
        set
        {
            this.type = value;
            this.SensorTypes = SensorTypeResolver.Resolve(value);
        }
    }

    public List<SensorType> SensorTypes { get; private set; }

    [JsonProperty("hubDeviceId")]
    public string HubDeviceId { get; init; }
}
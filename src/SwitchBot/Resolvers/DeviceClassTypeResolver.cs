using Newtonsoft.Json;
using SwitchBot.JsonConverters;
using SwitchBot.RestClient.Devices;

namespace SwitchBot.Models;

public static class DeviceClassTypeResolver
{
    public static Type Resolve(DeviceType deviceType)
    {
        return deviceType switch
        {
            DeviceType.Meter => typeof(Meter),
            DeviceType.MeterPlus => typeof(MeterPlus),
            DeviceType.OutdoorMeter => typeof(OutdoorMeter),
            _ => throw new NotSupportedException($"{nameof(DeviceType)} {deviceType} is not supported")
        };
    }
}
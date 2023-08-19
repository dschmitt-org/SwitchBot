using SwitchBot.Models;

namespace SwitchBot.Resolvers;

internal static class SensorTypeResolver
{
    public static List<SensorType> Resolve(DeviceType deviceType)
    {
        return deviceType switch
        {
            DeviceType.Meter => new List<SensorType> { SensorType.TemperatureSensor, SensorType.HumiditySensor },
            DeviceType.MeterPlus => new List<SensorType> { SensorType.TemperatureSensor, SensorType.HumiditySensor },
            DeviceType.OutdoorMeter => new List<SensorType> { SensorType.TemperatureSensor, SensorType.HumiditySensor },
            _ => new List<SensorType>(),
        };
    }
}
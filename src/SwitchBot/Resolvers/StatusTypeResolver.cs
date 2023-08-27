using SwitchBot.Models;

namespace SwitchBot.Resolvers;

internal static class StatusTypeResolver
{
    public static List<StatusType> Resolve(DeviceType deviceType)
    {
        return deviceType switch
        {
            DeviceType.Meter => new List<StatusType> { StatusType.Temperature, StatusType.Humidity, StatusType.Battery },
            DeviceType.MeterPlus => new List<StatusType> { StatusType.Temperature, StatusType.Humidity, StatusType.Battery },
            DeviceType.OutdoorMeter => new List<StatusType> { StatusType.Temperature, StatusType.Humidity, StatusType.Battery },
            _ => new List<StatusType>(),
        };
    }
}
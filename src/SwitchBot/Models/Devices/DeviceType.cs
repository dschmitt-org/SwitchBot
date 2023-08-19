using System.ComponentModel;
using Newtonsoft.Json;

namespace SwitchBot.Models;

public enum DeviceType
{
    [Description("Hub")]
    Hub,

    [Description("Hub Plus")]
    HubPlus,

    [Description("Hub Mini")]
    HubMini,

    [Description("Hub 2")]
    Hub2,

    [Description("Meter")]
    Meter,

    [Description("MeterPlus")]
    MeterPlus,

    [Description("WoIOSensor")]
    OutdoorMeter,
}
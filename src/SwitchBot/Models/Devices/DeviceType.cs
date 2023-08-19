using System.ComponentModel;

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

    [Description("Bot")]
    Bot,

    [Description("Plug")]
    Plug,

    [Description("Curtain")]
    Curtain,

    [Description("Motion Sensor")]
    MotionSensor,

    [Description("Contact Sensor")]
    ContactSensor,

    [Description("Color Bulb")]
    ColorBulb,

    [Description("Humidifier")]
    Humidifier,

    [Description("Smart Fan")]
    SmartFan,

    [Description("Strip Light")]
    StripLight,

    [Description("Plug Mini (US)")]
    PlugMiniUS,

    [Description("Plug Mini (JP)")]
    PlugMiniJP,

    [Description("Smart Lock")]
    Lock,

    [Description("Robot Vacuum Cleaner S1")]
    RobotVacuumCleanerS1,

    [Description("Robot Vacuum Cleaner S1 Plus")]
    RobotVacuumCleanerS1Plus,

    [Description("Keypad")]
    Keypad,

    [Description("Keypad Touch")]
    KeypadTouch,

    [Description("Ceiling Light")]
    CeilingLight,

    [Description("Ceiling Light Pro")]
    CeilingLightPro,
}
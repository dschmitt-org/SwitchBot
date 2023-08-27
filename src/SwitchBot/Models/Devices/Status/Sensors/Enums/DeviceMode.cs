using System.ComponentModel;

namespace SwitchBot.Models;

public enum DeviceMode
{
    [Description("pressMode")]
    PressMode,

    [Description("switchMode")]
    SwitchMode,

    [Description("customizeMode")]
    CustomizeMode,
}
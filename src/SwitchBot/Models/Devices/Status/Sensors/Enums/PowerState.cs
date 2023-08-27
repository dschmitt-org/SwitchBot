using System.ComponentModel;

namespace SwitchBot.Models;

public enum PowerState
{
    [Description("ON")]
    On,

    [Description("OFF")]
    Off,
}
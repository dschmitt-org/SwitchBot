using System.ComponentModel;

namespace SwitchBot.Models;

public enum OnlineState
{
    [Description("online")]
    Online,

    [Description("offline")]
    Offline,
}
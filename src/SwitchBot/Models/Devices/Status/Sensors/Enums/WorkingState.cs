using System.ComponentModel;

namespace SwitchBot.Models;

public enum WorkingState
{
    [Description("StandBy")]
    StandBy,

    [Description("Clearing")]
    Clearing,

    [Description("Paused")]
    Paused,

    [Description("GotoChargeBase")]
    GotoChargeBase,

    [Description("Charging")]
    Charging,

    [Description("ChargeDone")]
    ChargeDone,

    [Description("Dormant")]
    Dormant,

    [Description("InTrouble")]
    InTrouble,

    [Description("InRemoteControl")]
    InRemoteControl,

    [Description("InDustCollecting")]
    InDustCollecting,
}
using System.ComponentModel;

namespace SwitchBot.Models;

public enum BrightnessState
{
    [Description("bright")]
    Bright,

    [Description("dim")]
    Dim,
}
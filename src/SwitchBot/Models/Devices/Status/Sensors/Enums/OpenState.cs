using System.ComponentModel;

namespace SwitchBot.Models;

public enum OpenState
{
    [Description("open")]
    Open,

    [Description("close")]
    Close,

    [Description("timeOutNotClose")]
    TimeOutNotClose,
}
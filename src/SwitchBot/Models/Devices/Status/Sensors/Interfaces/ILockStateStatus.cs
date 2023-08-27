using Newtonsoft.Json;

namespace SwitchBot.Models;

internal interface ILockStateStatus
{
    /// <summary>
    /// Determines if the device is locked or not.
    /// </summary>
    [JsonProperty("lockState")]
    public string LockState { get; init; }
}
using Newtonsoft.Json;

namespace SwitchBot.Models;

internal interface IChildLockStatus
{
    /// <summary>
    /// Determines if the safety lock is on or not.
    /// </summary>
    [JsonProperty("childLock")]
    public bool ChildLock { get; init; }
}
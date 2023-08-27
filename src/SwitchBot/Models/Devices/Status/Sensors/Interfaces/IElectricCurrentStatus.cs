using Newtonsoft.Json;

namespace SwitchBot.Models;

internal interface IElectricCurrentStatus
{
    /// <summary>
    /// The current of the device at the moment, measured in Amp.
    /// </summary>
    [JsonProperty("electricCurrent")]
    public float ElectricCurrent { get; init; }
}
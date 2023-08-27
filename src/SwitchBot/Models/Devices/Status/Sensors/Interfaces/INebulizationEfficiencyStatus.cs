using Newtonsoft.Json;

namespace SwitchBot.Models;

internal interface INebulizationEfficiencyStatus
{
    /// <summary>
    /// Atomization efficiency percentage.
    /// </summary>
    [JsonProperty("nebulizationEfficiency")]
    public int NebulizationEfficiency { get; init; }
}
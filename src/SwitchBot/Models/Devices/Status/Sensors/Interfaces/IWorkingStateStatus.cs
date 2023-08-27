using Newtonsoft.Json;
using SwitchBot.JsonConverters;

namespace SwitchBot.Models;

internal interface IWorkingStateStatus
{
    /// <summary>
    /// The working status of the device. StandBy, Clearing, Paused, GotoChargeBase, Charging, ChargeDone, Dormant, InTrouble, InRemoteControl, or InDustCollecting.
    /// </summary> 
    [JsonProperty("workingStatus")]
    [JsonConverter(typeof(EnumDescriptionJsonConverter<WorkingState>))]
    public WorkingState WorkingState { get; init; }
}
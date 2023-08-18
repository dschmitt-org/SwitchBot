using SwitchBot.Models;

namespace SwitchBot.RestClient.Devices;
public interface ISwitchBotRestClientDevicesApi
{
    Task<DevicesResponse> GetDevicesResponse();
    Task<List<BaseDevice>> GetDevices();
}
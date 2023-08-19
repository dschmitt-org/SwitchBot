using SwitchBot.Models;

namespace SwitchBot.RestClient.Devices;
public interface ISwitchBotRestClientDevicesApi
{
    Task<DevicesResponse> GetDevicesResponse();
    Task<List<Device>> GetDevices();
    Task<DeviceStatusResponse<T>> GetDeviceStatusResponse<T>(string deviceId) where T : BaseDeviceStatus;
    Task<T> GetDeviceStatus<T>(string deviceId) where T : BaseDeviceStatus;
}
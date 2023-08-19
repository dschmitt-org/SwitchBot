using Flurl;
using Flurl.Http;
using Microsoft.Extensions.Logging;
using SwitchBot.Models;
using SwitchBot.Options;

namespace SwitchBot.RestClient.Devices;
public class SwitchBotRestClientDevicesApi : BaseSwitchBotRestClientApiV1_1, ISwitchBotRestClientDevicesApi
{
    public SwitchBotRestClientDevicesApi(ILogger logger, IFlurlClient flurlClient, SwitchBotRestOptions switchBotRestOptions)
        : base(logger, flurlClient, switchBotRestOptions)
    { }

    public async Task<DevicesResponse> GetDevicesResponse()
    {
        return await this.flurlClient.BaseUrl.AppendPathSegment(Version)
                                             .AppendPathSegment("devices")
                                             .GetJsonAsync<DevicesResponse>();
    }

    public async Task<DeviceStatusResponse<T>> GetDeviceStatusResponse<T>(string deviceId) where T : BaseDeviceStatus
    {
        return await this.flurlClient.BaseUrl.AppendPathSegment(Version)
                                             .AppendPathSegment("devices")
                                             .AppendPathSegment(deviceId)
                                             .AppendPathSegment("status")
                                             .GetJsonAsync<DeviceStatusResponse<T>>();
    }

    public async Task<List<Device>> GetDevices()
        => await GetDevicesResponse().ContinueWith(x => x.Result.Devices);

    public async Task<T> GetDeviceStatus<T>(string deviceId) where T : BaseDeviceStatus
        => await this.GetDeviceStatusResponse<T>(deviceId).ContinueWith(x => x.Result.DeviceStatus);
}
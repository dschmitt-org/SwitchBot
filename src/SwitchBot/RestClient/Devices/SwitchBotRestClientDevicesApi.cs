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

    public async Task<List<BaseDevice>> GetDevices()
    {
        return await this.flurlClient.BaseUrl.AppendPathSegment(Version)
                                             .AppendPathSegment("devices")
                                             .GetJsonAsync<DevicesResponse>()
                                             .ContinueWith(x => x.Result.Devices);
    }

    public async Task<DevicesResponse> GetDevicesResponse()
    {
        return await this.flurlClient.BaseUrl.AppendPathSegment(Version)
                                             .AppendPathSegment("devices")
                                             .GetJsonAsync<DevicesResponse>();
    }
}
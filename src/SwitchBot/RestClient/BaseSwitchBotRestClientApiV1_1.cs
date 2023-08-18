using Flurl;
using Flurl.Http;
using Microsoft.Extensions.Logging;
using SwitchBot.Models;
using SwitchBot.Options;

namespace SwitchBot.RestClient.Devices;
public class BaseSwitchBotRestClientApiV1_1
{
    protected const string Version = "v1.1";
    protected readonly ILogger logger;
    protected readonly IFlurlClient flurlClient;
    protected readonly SwitchBotRestOptions switchBotRestOptions;

    public BaseSwitchBotRestClientApiV1_1(ILogger logger, IFlurlClient flurlClient, SwitchBotRestOptions switchBotRestOptions)
    {
        this.logger = logger;
        this.flurlClient = flurlClient;
        this.switchBotRestOptions = switchBotRestOptions;
    }
}
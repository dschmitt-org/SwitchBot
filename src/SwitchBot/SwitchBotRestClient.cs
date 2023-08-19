using System.Security.Cryptography;
using System.Text;
using Flurl.Http;
using Flurl.Util;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using SwitchBot.Options;

namespace SwitchBot;

public class SwitchBotRestClient
{
    private const string Name = "SwitchBot";
    protected internal ILogger logger;
    private IFlurlClient flurlClient;
    private SwitchBotRestOptions switchBotRestOptions;

    /// <summary>
    /// Create a new instance of the SwitchBotRestClient using provided options
    /// </summary>
    /// <param name="optionsDelegate">Option configuration delegate</param>
    public SwitchBotRestClient(Action<SwitchBotRestOptions> optionsDelegate) : this(null, null, optionsDelegate)
    {
    }

    /// <summary>
    /// Create a new instance of the SwitchBotRestClient using provided options
    /// </summary>
    public SwitchBotRestClient(ILoggerFactory? loggerFactory = null, HttpClient? httpClient = null) : this(httpClient, loggerFactory, null)
    {
    }

    /// <summary>
    /// Create a new instance of the SwitchBotRestClient using provided options
    /// </summary>
    /// <param name="optionsDelegate">Option configuration delegate</param>
    /// <param name="loggerFactory">The logger factory</param>
    /// <param name="httpClient">Http client for this client</param>
    public SwitchBotRestClient(HttpClient? httpClient, ILoggerFactory? loggerFactory, Action<SwitchBotRestOptions>? optionsDelegate = null)
    {
        this.logger = loggerFactory?.CreateLogger(Name) ?? NullLoggerFactory.Instance.CreateLogger(Name);
        this.switchBotRestOptions = SwitchBotRestOptions.Default;

        if (optionsDelegate != null) optionsDelegate(this.switchBotRestOptions);

        if (httpClient == null) httpClient = new HttpClient();


        httpClient.DefaultRequestHeaders.TryAddWithoutValidation("header.Name", this.switchBotRestOptions.Token);
        foreach (var header in this.GetAuthorizationHeaders())
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation(header.Name, header.Value);

        var headers = this.GetAuthorizationHeaders();
        FlurlHttp.Configure(settings =>
        {
            settings.Timeout = switchBotRestOptions.Timeout;
            settings.OnError = this.HandleFlurlError;
            settings.OnErrorAsync = this.HandleFlurlErrorAsync;
            settings.BeforeCall = (httpCall) =>
            {
                foreach (var header in this.GetAuthorizationHeaders())
                    httpCall.Request.Headers.Add(header.Name, header.Value);
            };
            settings.BeforeCallAsync = (httpCall) =>
            {
                foreach (var header in this.GetAuthorizationHeaders())
                    httpCall.Request.Headers.Add(header.Name, header.Value);

                return Task.CompletedTask;
            };
        });

        this.flurlClient = new FlurlClient(httpClient) { BaseUrl = @"https://api.switch-bot.com/" };

        this.Devices = new SwitchBotRestClientDevicesApi(this.logger, this.flurlClient, switchBotRestOptions);
    }

    public ISwitchBotRestClientDevicesApi Devices { get; }

    private INameValueList<string> GetAuthorizationHeaders()
    {
        var time = Convert.ToInt64(DateTime.Now.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds);
        var nonce = Guid.NewGuid().ToString();
        var data = this.switchBotRestOptions.Token + time.ToString() + nonce;
        var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(this.switchBotRestOptions.Secret));
        var signature = Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(data)));

        var headers = new NameValueList<string>(new List<(string Name, string Value)>(), true)
        {
            { @"Authorization", this.switchBotRestOptions.Token },
            { @"sign", signature },
            { @"nonce", nonce },
            { @"t", time.ToString() }
        };

        return headers;
    }

    private void HandleFlurlError(FlurlCall call)
    {
        if (call.Exception is FlurlHttpTimeoutException flurlHttpTimeoutException)
        {
            logger.LogError(flurlHttpTimeoutException, "SwitchBot Rest timeout occured");
            call.ExceptionHandled = true;
        }
        else if (call.Exception is FlurlHttpException flurlHttpException)
        {
            logger.LogDebug(flurlHttpException, "SwitchBot Rest exception occured");
            call.ExceptionHandled = true;
        }
        else
        {
            logger.LogCritical("Unhandled exception in SwitchBot Rest Api occured");
        }
    }

    private Task HandleFlurlErrorAsync(FlurlCall call)
    {
        this.HandleFlurlError(call);

        return Task.CompletedTask;
    }
}

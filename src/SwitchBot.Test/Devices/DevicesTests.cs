using FluentAssertions;
using FluentAssertions.Json;
using Flurl.Http.Testing;
using Newtonsoft.Json;
using NUnit.Framework;
using SwitchBot.Models;
using SwitchBot.RestClient;

namespace SwitchBot.Test;

public class DevicesTests
{
    private HttpTest httpTest;
    private SwitchBotRestClient switchBotRestClient;

    [SetUp]
    public void Setup()
    {
        this.httpTest = new HttpTest();
        this.switchBotRestClient = new SwitchBotRestClient(options =>
        {
            options.Token = "";
            options.Secret = "";
        });
    }

    [TearDown]
    public void TearDown()
    {
        this.httpTest.Dispose();
    }

    [Test]
    public void DevicesResponseTest()
    {
        // Setup
        var devicesResponseJson = File.ReadAllText("./Devices/devices.json");
        var devicesResponseExpected = JsonConvert.DeserializeObject<DevicesResponse>(devicesResponseJson);

        httpTest.ForCallsTo(@"https://api.switch-bot.com/*/devices")
                .WithVerb(HttpMethod.Get)
                .RespondWith(devicesResponseJson);

        // execute
        var devicesResponse = this.switchBotRestClient.Devices.GetDevicesResponse().GetAwaiter().GetResult();

        // evaluate
        devicesResponse.Should().BeEquivalentTo(devicesResponseExpected);
    }

    [Test]
    public void DevicesTest()
    {
        // Setup
        var devicesResponseJson = File.ReadAllText("./Devices/devices.json");
        var devicesExpected = JsonConvert.DeserializeObject<DevicesResponse>(devicesResponseJson).Devices;

        httpTest.ForCallsTo(@"https://api.switch-bot.com/*/devices")
                .WithVerb(HttpMethod.Get)
                .RespondWith(devicesResponseJson);

        // execute
        var devices = this.switchBotRestClient.Devices.GetDevices().GetAwaiter().GetResult();

        // evaluate
        devices.Should().BeEquivalentTo(devicesExpected);
    }

    [Test]
    public void DeviceStatusResponseTest()
    {
        // Setup
        var deviceStatusResponseJson = File.ReadAllText("./Devices/deviceStatus.json");
        var deviceStatusResponseExpected = JsonConvert.DeserializeObject<DeviceStatusResponse<Meter>>(deviceStatusResponseJson);

        httpTest.ForCallsTo(@"https://api.switch-bot.com/*/devices/*/status")
                .WithVerb(HttpMethod.Get)
                .RespondWith(deviceStatusResponseJson);

        // execute
        var deviceStatusResponse = this.switchBotRestClient.Devices.GetDeviceStatusResponse<Meter>("deviceId").GetAwaiter().GetResult();

        // evaluate
        deviceStatusResponse.Should().BeEquivalentTo(deviceStatusResponseExpected);
    }

    [Test]
    public void DeviceStatusTest()
    {
        // Setup
        var deviceStatusResponseJson = File.ReadAllText("./Devices/deviceStatus.json");
        var deviceStatusExpected = JsonConvert.DeserializeObject<DeviceStatusResponse<Meter>>(deviceStatusResponseJson).DeviceStatus;

        httpTest.ForCallsTo(@"https://api.switch-bot.com/*/devices/*/status")
                .WithVerb(HttpMethod.Get)
                .RespondWith(deviceStatusResponseJson);

        // execute
        var deviceStatus = this.switchBotRestClient.Devices.GetDeviceStatus<Meter>("deviceId").GetAwaiter().GetResult();

        // evaluate
        deviceStatus.Should().BeEquivalentTo(deviceStatusExpected);
    }
}
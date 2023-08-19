using System.Xml.Schema;
using Newtonsoft.Json;
using SwitchBot.Models;
using SwitchBot.RestClient;

// Create SwitchBotRestClient
var switchBotRestClient = new SwitchBotRestClient(options =>
{
    options.Token = "0109de8f111f11bf7e3d283668c16e53ce9cfa7c8f3fce50e3e07972e68145ff5535d1e5a2992e199785100fafeb5f0e";
    options.Secret = "220fae8f4169315553814550b6791b7a";
});

// Get DevicesResponse
var devicesResponse = await switchBotRestClient.Devices.GetDevicesResponse();
Console.WriteLine(JsonConvert.SerializeObject(devicesResponse));

// Get Devices
var devices = await switchBotRestClient.Devices.GetDevices();

// Get DeviceStatusResponse
foreach (var device in devices.Where(x => x.Type == DeviceType.MeterPlus))
{
    var deviceStatusResponse = await switchBotRestClient.Devices.GetDeviceStatusResponse<MeterPlus>(device.Id);
    Console.WriteLine(JsonConvert.SerializeObject(deviceStatusResponse));

    var deviceStatus = await switchBotRestClient.Devices.GetDeviceStatus<MeterPlus>(device.Id);
}
using Newtonsoft.Json;
using SwitchBot;
using SwitchBot.Models;

// Create SwitchBotRestClient
var switchBotRestClient = new SwitchBotRestClient(options =>
{
    options.Token = "<YOUR TOKEN>";
    options.Secret = "<YOUR SECRET>";
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
}

// Get DeviceStatus
foreach (var device in devices.Where(x => x.Type == DeviceType.MeterPlus))
{
    var deviceStatus = await switchBotRestClient.Devices.GetDeviceStatus<MeterPlus>(device.Id);
}

// Get DeviceStatus by SensorType
foreach (var device in devices.Where(x => x.SensorTypes.Contains(SensorType.TemperatureSensor) && x.SensorTypes.Contains(SensorType.HumiditySensor)))
{
    var deviceStatus = await switchBotRestClient.Devices.GetDeviceStatus<TemperatureAndHumiditySensor>(device.Id);
}

foreach (var device in devices.Where(x => x.SensorTypes.Contains(SensorType.TemperatureSensor)))
{
    var deviceStatus = await switchBotRestClient.Devices.GetDeviceStatus<TemperatureSensor>(device.Id);
}
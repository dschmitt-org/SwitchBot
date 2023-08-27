using Newtonsoft.Json;
using SwitchBot;
using SwitchBot.Models;

// Create SwitchBotRestClient
var switchBotRestClient = new SwitchBotRestClient(options =>
{
    options.Token = "0109de8f111f11bf7e3d283668c16e53ce9cfa7c8f3fce50e3e07972e68145ff08a1a2bb7b594e613335c09c3764a2bd";
    options.Secret = "401c417b71cedc27ddd3b5d098ec709b";
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
foreach (var device in devices.Where(x => x.StatusTypes.Contains(StatusType.Temperature) && x.StatusTypes.Contains(StatusType.Humidity)))
{
    var deviceStatus = await switchBotRestClient.Devices.GetDeviceStatus<TemperatureHumidityStatus>(device.Id);
}

foreach (var device in devices.Where(x => x.StatusTypes.Contains(StatusType.Temperature)))
{
    var deviceStatus = await switchBotRestClient.Devices.GetDeviceStatus<TemperatureStatus>(device.Id);
}
using SwitchBot.RestClient;

// Create SwitchBotRestClient
var switchBotRestClient = new SwitchBotRestClient(options =>
{
    options.Token = "0109de8f111f11bf7e3d283668c16e53ce9cfa7c8f3fce50e3e07972e68145ff705d74f1fc0a006f7df36e0b7689471e";
    options.Secret = "6ca1e6d152d9443de57f5de4c989734b";
});

// Get DevicesResponse
var devicesResponse = await switchBotRestClient.Devices.GetDevicesResponse();
Console.WriteLine(devicesResponse.Message);

// Get Devices
var devices = await switchBotRestClient.Devices.GetDevices();
devices.ForEach(device => Console.WriteLine(device.Name));
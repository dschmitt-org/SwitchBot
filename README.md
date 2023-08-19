[![Nuget](https://img.shields.io/nuget/v/SwitchBot)](https://www.nuget.org/packages/SwitchBot)

# SwitchBot

This project uses the [SwitchBotAPI](https://github.com/OpenWonderLabs/SwitchBotAPI) to communicate with the SwitchBot environment.

## Getting Started

```csharp
using SwitchBot.RestClient;

// Create SwitchBotRestClient
var switchBotRestClient = new SwitchBotRestClient(options =>
{
    options.Token = "<YOUR TOKEN>";
    options.Secret = "<YOUR SECRET>";
});

// Get DevicesResponse
var devicesResponse = await switchBotRestClient.Devices.GetDevicesResponse();

// Get Devices
var devices = await switchBotRestClient.Devices.GetDevices();

// Get DeviceStatusResponse
foreach (var device in devices.Where(x => x.Type == DeviceType.MeterPlus))
{
    var deviceStatusResponse = await switchBotRestClient.Devices.GetDeviceStatusResponse<MeterPlus>(device.Id);
}

// Get DeviceStatusResponse by SensorType
foreach (var device in devices.Where(x => x.SensorTypes.Contains(SensorType.TemperatureSensor)))
{
    var deviceStatus = await switchBotRestClient.Devices.GetDeviceStatusResponse<TemperatureSensor>(device.Id);
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
```

## Supported devices

```
✅ Hub
✅ Hub Plus
✅ Hub Mini
❌ Hub 2 (can only be used as hub, no sensor data supported yet)
✅ Meter
✅ Meter Plus
✅ Outdoor Meter 
❌ Bot 
❌ Curtain 
❌ Plug
❌ Motion Sensor 
❌ Contact Sensor 
❌ Color Bulb
❌ Humidifier
❌ Smart Fan
❌ Strip Light
❌ Plug Mini 
❌ Lock
❌ Robot Vacuum Cleaner S1
❌ Robot Vacuum Cleaner S1 Plus
❌ Keypad 
❌ Keypad Touch 
❌ Ceiling Light
❌ Ceiling Light Pro
❌ Blind Tilt 
```

## Supported api endpoints

### Devices 
```
✅ GET https://api.switch-bot.com/v1.1/devices
✅ GET https://api.switch-bot.com/v1.1/devices/{deviceId}/status
❌ POST https://api.switch-bot.com/v1.1/devices/{deviceId}/commands
```

### Scenes
```
❌ GET https://api.switch-bot.com/v1.1/scenes
❌ POST https://api.switch-bot.com/v1.1/scenes/{sceneId}/execute
```

### Webook
```
❌ POST https://api.switch-bot.com/v1.1/webhook/setupWebhook
❌ POST https://api.switch-bot.com/v1.1/webhook/queryWebhook
❌ POST https://api.switch-bot.com/v1.1/webhook/updateWebhook
❌ POST https://api.switch-bot.com/v1.1/webhook/deleteWebhook
```

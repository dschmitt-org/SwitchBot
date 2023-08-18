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
Console.WriteLine(devicesResponse.Message);

// Get Devices
var devices = await switchBotRestClient.Devices.GetDevices();
devices.ForEach(device => Console.WriteLine(device.Name));
```

## Current supported endpoints

### Devices 
```
✅ GET https://api.switch-bot.com/v1.1/devices
❌ GET https://api.switch-bot.com/v1.1/devices/{deviceId}/status
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

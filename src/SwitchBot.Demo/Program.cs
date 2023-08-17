using System.Text;
using System.Security.Cryptography;
using SwitchBot.Models;
using Newtonsoft.Json;

HttpClient client = new HttpClient();

var response = await SendRequest(@"https://api.switch-bot.com/v1.1/devices");
var jsonString = await response.Content.ReadAsStringAsync();

Console.WriteLine(jsonString);
Console.WriteLine();

var devicesResponse = JsonConvert.DeserializeObject<DevicesResponse>(jsonString);

foreach (var device in devicesResponse.Devices)
{
    Console.WriteLine(device.Name);

    response = await SendRequest(@$"https://api.switch-bot.com/v1.1/devices/{device.Id}/status");
    jsonString = await response.Content.ReadAsStringAsync();

    Console.WriteLine(jsonString);
    Console.WriteLine();
}

async Task<HttpResponseMessage> SendRequest(string url)
{
    var token = "0109de8f111f11bf7e3d283668c16e53ce9cfa7c8f3fce50e3e07972e68145ff705d74f1fc0a006f7df36e0b7689471e";
    string secret = "6ca1e6d152d9443de57f5de4c989734b";
    DateTime dt1970 = new DateTime(1970, 1, 1);
    DateTime current = DateTime.Now;
    TimeSpan span = current - dt1970;
    var time = Convert.ToInt64(span.TotalMilliseconds);
    var nonce = Guid.NewGuid().ToString();
    string data = token + time.ToString() + nonce;
    Encoding utf8 = Encoding.UTF8;
    HMACSHA256 hmac = new HMACSHA256(utf8.GetBytes(secret));
    var signature = Convert.ToBase64String(hmac.ComputeHash(utf8.GetBytes(data)));

    var request = new HttpRequestMessage(HttpMethod.Get, url);
    request.Headers.TryAddWithoutValidation(@"Authorization", token);
    request.Headers.TryAddWithoutValidation(@"sign", signature);
    request.Headers.TryAddWithoutValidation(@"nonce", nonce);
    request.Headers.TryAddWithoutValidation(@"t", time.ToString());

    return await client.SendAsync(request); ;
}